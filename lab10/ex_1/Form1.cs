using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
namespace Lab2_Ca4
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

        public void showGRD()
        {
            string sql = "select * from Readers";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            txtMaDocGia.Enabled = false;
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog =Final_Exam ; data source = LAPTOP-O6E7LQLE\\SQLEXPRESS; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            string sql = "select name from Readers";
     
            SqlCommand command = new SqlCommand(sql, cn);
            SqlDataReader reader = command.ExecuteReader();

            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["name"].ToString());
            }
            reader.Close();
            
            formload();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            dpNgaySinhDocGia.Value = DateTime.Now;


            txtMaDocGia.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtTenDocGia.Text = grd.CurrentRow.Cells[1].Value.ToString();
            dpNgaySinhDocGia.Text = grd.CurrentRow.Cells[2].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from Readers where reader_id = '" + txtMaDocGia.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key violation
                {
                    MessageBox.Show("This reader is currently lending a book and cannot be deleted.");
                }
                else
                {
                    throw; // Re-throw the exception if it's not a foreign key violation
                }
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMaDocGia.Enabled = false;
            txtTenDocGia.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime dob;
            DateTime.TryParse(dpNgaySinhDocGia.Text, out dob);
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Readers where reader_id = '" + txtMaDocGia.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Reader exists");
                    txtMaDocGia.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Readers (name, dob) values (N'" + txtTenDocGia.Text + "', '" + dob.ToString("yyyy-MM-dd") + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Readers set name = N'" + txtTenDocGia.Text + "', dob = '" + dob.ToString("yyyy-MM-dd") + "' where reader_id = '" + txtMaDocGia.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void bPRINT_Click(object sender, EventArgs e)
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
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Readers where name like N'" + comboBox1.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
    }
}
