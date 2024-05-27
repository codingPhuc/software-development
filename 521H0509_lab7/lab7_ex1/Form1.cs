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


        public Form1()
        {
            InitializeComponent();
        }

        public void showGRD()
        {
            string sql = "select * from Khoa";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {   
            grp.Enabled = b;
            txtKhoaID.Enabled = false;
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
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
            txtKhoaID.Clear();
            txtKHoaNam.Clear();
            txtPhone_number.Clear();
            cbsupervisor.Text = "";


            txtKhoaID.Focus();
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
            txtKhoaID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtKHoaNam.Text = grd.CurrentRow.Cells[1].Value.ToString();
            cbsupervisor.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtPhone_number.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Khoa where Makhoa = '" + txtKhoaID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtKhoaID.Enabled = false;
            txtKHoaNam.Focus();
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
            //automatically generate  ID number of Khoa  
            // generate by the first letter of the name of Khoa and the first letter of each word in the name of Khoa
            
            txtKhoaID.Text = GenerateKhoaID(txtKHoaNam.Text);

            string sql = "";
            long funding;
            long.TryParse(txtPhone_number.Text, out funding);
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Khoa where Makhoa  = '" + txtKhoaID.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("project exists");
                    txtKhoaID.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Khoa values ('" + txtKhoaID.Text + "', N'" + txtKHoaNam.Text + "', N'" + cbsupervisor.Text + "', " + funding + ")";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Khoa set Tenkhoa  = N'" + txtKHoaNam.Text + "', Diadiem  = N'" + cbsupervisor.Text + "', Dienthoai  = " + funding + " where Makhoa  = '" + txtKhoaID.Text + "'";
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
