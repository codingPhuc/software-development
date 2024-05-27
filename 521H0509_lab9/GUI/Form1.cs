using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace GUI
{
    public partial class Form1 : Form
    {
        BUS_SinhVien l;
        int dk = 0;

        public Form1()
        {   
            InitializeComponent();
            BUS_SinhVien l = new BUS_SinhVien("", "", "", DateTime.Parse("2000-01-01"), "");
            cbbSinhvien.DataSource = l.selectStudentNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BUS_Detai l = new BUS_Detai("DT001", "Phat trien ung dung di dong", "Tran Van D", 100);
            grd.DataSource = l.selectQuery();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            BUS_Detai l = new BUS_Detai("DT001", "Phat trien ung dung di dong", "Tran Van D", 100);
            grd.DataSource = l.selectQuery();

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            dk = 2;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string s = "";
            if (dk == 1)
            {
              /*  l = new BUS_SinhVien (txtPID.Text, txtName.Text, txtSup.Text, int.Parse( txtFun.Text));*/
                l.addQuery();
            }
            else if (dk == 2)
            {

            }
            grd.DataSource = l.selectQuery();
        }

        private void cbbSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_Detai l = new BUS_Detai("DT001", "Phat trien ung dung di dong", "Tran Van D", 100);
            string  studentNumber = cbbSinhvien.SelectedItem.ToString();
            grd.DataSource = l.GetDeTaiBySinhVien(studentNumber); 

        }

        private void bPrint_Click(object sender, EventArgs e)
        {

            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }
    }
}
