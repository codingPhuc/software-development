using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Ca4_Thu6
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void showHT()
        {
            cbHT.Items.Add("Nguyen Van A");
            cbHT.Items.Add("Tran Thi B");
            cbHT.Items.Add("Hoang Van E");

        }

        void showHT1()
        {
            string sql = "select distinct Hometown from student";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbHT.DataSource = tb;
            cbHT.DisplayMember = "Hometown";
            cbHT.ValueMember = "Hometown";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = testDb; data source = LAPTOP-O6E7LQLE\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
            formload();
            //showHT1();
            showHT();
        }
        void formload()
        {
            textBoxmasach.Enabled = false; 
            enable(groupBoxAddAuthor, false);

        }
        private void cbHT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from doc_gia   where ho_ten   like N'" + cbHT.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bTC_Click(object sender, EventArgs e)
        {
            string sql = "select * from sach ";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bPDF_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Project where Fee < 10000000" ;
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            groupBoxAddAuthor.Enabled = true; 


          
        }

        

        private void grd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            textBoxmasach.Text = grd.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime phieuMuonDate = dateTimephieumuon.Value;
            DateTime phieuTraDate = dateTimePhieutra.Value;

            // Format the dates as strings
            string formattedDateMuon = phieuMuonDate.ToString("yyyy-MM-dd");
            string formattedDateTra = phieuTraDate.ToString("yyyy-MM-dd");

            // Compare the dates
            if (phieuMuonDate > phieuTraDate)
            {
                // Show the text box or perform any other action
                MessageBox.Show("Phieu muon date should be less  than phieu tra date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
              
            }
            //check primary key
           
            
       
            
        }
    }
}
