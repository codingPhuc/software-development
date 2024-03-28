using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            string sql = "select * from project";
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
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog =SchoolDB ; data source = LAPTOP-O6E7LQLE\\SQLEXPRESS; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtprojectID.Clear();
            txtprojectName.Clear();
            txtFund.Clear();
            cbsupervisor.Text = "";


            txtprojectID.Focus();
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
            txtprojectID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtprojectName.Text = grd.CurrentRow.Cells[1].Value.ToString();
            cbsupervisor.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtFund.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from project where projectID = '" + txtprojectID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtprojectID.Enabled = false;
            txtprojectName.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {   
            string sql = "";
            long funding;
            long.TryParse(txtFund.Text, out funding);
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from project where projectID = '" + txtprojectID.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("project exists");
                    txtprojectID.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Project values ('" + txtprojectID.Text + "', N'" + txtprojectName.Text + "', N'" + cbsupervisor.Text + "', " + funding + ")";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Project set projectName = N'" + txtprojectName.Text + "', supervisor = N'" + cbsupervisor.Text + "', funding = " + funding + " where projectID = '" + txtprojectID.Text + "'";
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

            if (!Char.IsDigit(ch) )
            {
                e.Handled = true;
            }
        }
    }
}
