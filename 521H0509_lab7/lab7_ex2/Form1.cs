using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


// create a form to automatically generate  ID number of Khoa 
/*create table Khoa  in database create database CourseRegis 

(

Makhoa varchar(10),

Tenkhoa nvarchar(30),

Diadiem nvarchar(30),

Dienthoai varchar(20)

)*/


namespace Lab2_Ca4
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;
        String gender = "";


        public Form1()
        {
            InitializeComponent();
        }

        public void showGRD()
        {
            string sql = "select * from Sinhvien";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {   

            grp.Enabled = b;
            txtMSSV.Enabled = false;
 
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            string sql = "SELECT Makhoa  FROM khoa";
            cm = new SqlCommand(sql, cn);
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                cbMASkhoa.Items.Add(reader.GetString(0));
            }
            reader.Close();
            dk = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "data source = LAPTOP-O6E7LQLE\\SQLEXPRESS; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
           /* txtKhoaID.Clear();*/
            txtMSSV.Clear();    
            
            txtSVNam.Clear();
            
            txt_GioiTinh.Clear();
            cbdiadiem.Text = "";


          /*  txtKhoaID.Focus();*/
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
        // all of combox and textbox name list them out
        // cbdiadiem, txtSVNam, txtKhoaID , txtGPA , txtKhoaID , 
      
        private void grd_Click(object sender, EventArgs e)
        {   
            
           /* txtKhoaID.Text = grd.CurrentRow.Cells[0].Value.ToString();*/
           txtMSSV.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtSVNam.Text = grd.CurrentRow.Cells[1].Value.ToString();
            dpNgaySinh.Text = grd.CurrentRow.Cells[2].Value.ToString();
            cbQueQuan.Text = grd.CurrentRow.Cells[3].Value.ToString(); 
            txt_GioiTinh.Text = grd.CurrentRow.Cells[4].Value.ToString();
            cbdiadiem.Text = grd.CurrentRow.Cells[5].Value.ToString();
            cbMASkhoa.Text = grd.CurrentRow.Cells[6].Value.ToString();
            


            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Sinhvien where Masv = '" + txtMSSV.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            /*txtKhoaID.Enabled = false;*/
            txtSVNam.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }
        private string GenerateKhoaID(string khoaName)
        {
            string khoaID = "";
            string[] words = khoaName.Split(' ');

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    khoaID += word[0];
                }
            }

            return khoaID.ToUpper();
        }
        private void bSAVE_Click(object sender, EventArgs e)
        {


            string sql = "";
            gender = rdbnam.Checked ? "Nam" : "Nữ"; 
            if (dk == 1)//Add
            {
                Random random = new Random();
                string idNumber = cbMASkhoa.Text + random.Next(1000, 9999).ToString();
                txtMSSV.Text = idNumber;
                sql = "select * from Sinhvien where Masv = '" + txtMSSV.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Student already exists");
                    txtMSSV.Focus();
                    return;
                }

                // Insert into
                sql = "insert into Sinhvien values ('" + txtMSSV.Text + "', N'" + txtSVNam.Text + "', '" + dpNgaySinh.Value.ToString("yyyy-MM-dd") + "', N'" + cbQueQuan.Text + "', N'" + txt_GioiTinh.Text + "', N'" + cbdiadiem.Text + "', '" + cbMASkhoa.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
              
            }

            if (dk == 2) //Edit
            {
                // Update
                sql = "UPDATE Sinhvien SET Ten = N'" + txtSVNam.Text + "', NS = '" + dpNgaySinh.Value.ToString("yyyy-MM-dd") + "', QQ = N'" + cbQueQuan.Text + "', Gioitinh = N'" + txt_GioiTinh.Text + "', DC = N'" + cbdiadiem.Text + "', Makhoa = '" + cbMASkhoa.Text + "' WHERE Masv = '" + txtMSSV.Text + "'";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
