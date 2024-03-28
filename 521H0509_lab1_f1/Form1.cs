using System.Globalization;

namespace Lab1_F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void initGRD()
        {
            //clear grd
            grd.Columns.Clear();
            grd.Rows.Clear();

            //grdDSUV - tạo header
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Student ID";
            grd.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Full name";
            grd.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Hometown";
            grd.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "DOB";
            grd.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "GPA";
            grd.Columns.Add(c5);

        }

        public void readFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string s;
            string[] t;
            int i = 0;
            while (true)
            {
                s = sr.ReadLine();
                if (s is null)
                {
                    break;
                }
                //
                t = s.Split('\t');

                grd.Rows.Add();
                for (int j = 0; j < t.Length; ++j)
                {
                    grd.Rows[i].Cells[j].Value = t[j];

                }
                ++i;

            }

            sr.Close();
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        public void formload()
        {
            initGRD();
            readFile("student.txt");
            enable(grp1, false);
            bSUA.Enabled = false;
            bXOA.Enabled = false;
            bLUU.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void bTHEM_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            MSSV.Clear();
            NAME.Clear();
            GPA.Clear();
            ORIGIN.Text = "";
            BIRTH.Text = "";
            MSSV.Focus();
            bLUU.Enabled = true;
        }

        private void bHUY_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void grd_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != grd.Rows[grd.Rows.Count - 1])
            {
                MSSV.Text = grd.CurrentRow.Cells[0].Value.ToString();
                NAME.Text = grd.CurrentRow.Cells[1].Value.ToString();
                ORIGIN.Text = grd.CurrentRow.Cells[2].Value.ToString();
                BIRTH.Text = General.convertDMY2YMD(grd.CurrentRow.Cells[3].Value.ToString());
                GPA.Text = grd.CurrentRow.Cells[4].Value.ToString();

                bXOA.Enabled = true;
                bSUA.Enabled = true;
            }

        }

        private void bSUA_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            MSSV.Enabled = false;

            bLUU.Enabled = true;
            NAME.Focus();
        }

        private void bXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this student?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                grd.Rows.Remove(grd.CurrentRow);
                StreamWriter sw = new StreamWriter("student.txt");
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    sw.WriteLine(grd.Rows[i].Cells[0].Value.ToString() + "\t" + grd.Rows[i].Cells[1].Value.ToString() + "\t" + grd.Rows[i].Cells[2].Value.ToString() + "\t" + grd.Rows[i].Cells[3].Value.ToString() + "\t" + grd.Rows[i].Cells[4].Value.ToString());
                }
                sw.Close();
            }
        }
        // the button will add the save data to the gird view 
        // the form will reload 
        // the save button will add the student information to the text file 
        private void bLUU_Click(object sender, EventArgs e)
        {
            string newFormat = "dd/MM/yyyy";
            string oldFormat = "dddd, MMMM d, yyyy";

            // Assuming you have TextBox controls for entering new student information
            string newMSSV = MSSV.Text;
            string newName = NAME.Text;
            string newOrigin = ORIGIN.Text;
            string newBirth = BIRTH.Text;
            string newGPA = GPA.Text;

            newBirth = DateTime
                        .ParseExact(newBirth, oldFormat, CultureInfo.InvariantCulture)
                        .ToString(newFormat);

            // Validate the input (you can add more validation as needed)
            if (string.IsNullOrEmpty(newMSSV) || string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newOrigin) || string.IsNullOrEmpty(newBirth) || string.IsNullOrEmpty(newGPA))
            {
                MessageBox.Show("Please enter all student information.");
                return;
            }

            // Check if the student with the same MSSV already exists in the DataGridView
            bool studentExists = false;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == newMSSV)
                {
                    // Update the existing student's information
                    row.SetValues(newMSSV, newName, newOrigin, newBirth, newGPA);
                    studentExists = true;
                    break;
                }
            }

            // If the student doesn't exist, add a new student
            if (!studentExists)
            {
                // Add the new student to the DataGridView
                grd.Rows.Add(newMSSV, newName, newOrigin, newBirth, newGPA);
            }

            // Update the student information in the text file
            UpdateStudentInFile(newMSSV, newName, newOrigin, newBirth, newGPA);

            // Clear the TextBox controls after adding/updating a student
            MSSV.Clear();
            NAME.Clear();
            ORIGIN.Items.Clear();
            GPA.Clear();

            MessageBox.Show("Student added/updated successfully.");
        }

        private void UpdateStudentInFile(string mssv, string name, string origin, string birth, string gpa)
        {
            string filePath = "student.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            bool studentUpdated = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] studentData = lines[i].Split('\t');

                if (studentData[0] == mssv)
                {
                    // Update the existing student's information in the file
                    lines[i] = $"{mssv}\t{name}\t{origin}\t{birth}\t{gpa}";
                    studentUpdated = true;
                    break;
                }
            }

            if (!studentUpdated)
            {
                // If the student doesn't exist in the file, add a new entry
                lines.Add($"{mssv}\t{name}\t{origin}\t{birth}\t{gpa}");
            }

            // Write the updated content back to the file
            File.WriteAllLines(filePath, lines);
        }

        private void txtHL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }
    }
}