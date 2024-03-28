namespace Lab2_Ca4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grd = new DataGridView();
            cbsupervisor = new ComboBox();
            txtprojectName = new TextBox();
            txtFund = new TextBox();
            txtprojectID = new TextBox();
            label2 = new Label();
            label5 = new Label();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            label3 = new Label();
            bPRINT = new Button();
            grp2 = new GroupBox();
            bCANCEL = new Button();
            label1 = new Label();
            grp3 = new GroupBox();
            grp1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(8, 20);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(514, 218);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            grd.Click += grd_Click;
            // 
            // cbsupervisor
            // 
            cbsupervisor.FormattingEnabled = true;
            cbsupervisor.Items.AddRange(new object[] { "Hà Nội", "Sài Gòn" });
            cbsupervisor.Location = new Point(89, 45);
            cbsupervisor.Name = "cbsupervisor";
            cbsupervisor.Size = new Size(156, 23);
            cbsupervisor.TabIndex = 2;
            // 
            // txtprojectName
            // 
            txtprojectName.Location = new Point(360, 16);
            txtprojectName.Name = "txtprojectName";
            txtprojectName.Size = new Size(156, 23);
            txtprojectName.TabIndex = 1;
            // 
            // txtFund
            // 
            txtFund.Location = new Point(360, 49);
            txtFund.Name = "txtFund";
            txtFund.Size = new Size(156, 23);
            txtFund.TabIndex = 4;
            txtFund.TextChanged += txtGPA_TextChanged;
            txtFund.KeyPress += txtGPA_KeyPress;
            // 
            // txtprojectID
            // 
            txtprojectID.AcceptsReturn = true;
            txtprojectID.Location = new Point(89, 16);
            txtprojectID.Name = "txtprojectID";
            txtprojectID.Size = new Size(156, 23);
            txtprojectID.TabIndex = 0;
            txtprojectID.TextChanged += txtprojectID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 20);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Ten de tai ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 49);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 0;
            label5.Text = "Kinh Phi";
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(268, 16);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(68, 30);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            bSAVE.Click += bSAVE_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(194, 16);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(68, 30);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(120, 16);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(68, 30);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // bADD
            // 
            bADD.Location = new Point(46, 16);
            bADD.Name = "bADD";
            bADD.Size = new Size(68, 30);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 49);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "chu nhiem de tai ";
            // 
            // bPRINT
            // 
            bPRINT.Location = new Point(416, 16);
            bPRINT.Name = "bPRINT";
            bPRINT.Size = new Size(68, 30);
            bPRINT.TabIndex = 5;
            bPRINT.Text = "Print";
            bPRINT.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            grp2.Controls.Add(bPRINT);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(17, 120);
            grp2.Name = "grp2";
            grp2.Size = new Size(529, 57);
            grp2.TabIndex = 4;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(342, 16);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(68, 30);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            bCANCEL.Click += bCANCEL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Ma So de tai ";
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(14, 185);
            grp3.Name = "grp3";
            grp3.Size = new Size(531, 247);
            grp3.TabIndex = 5;
            grp3.TabStop = false;
            grp3.Text = "Project List";
            // 
            // grp1
            // 
            grp1.Controls.Add(cbsupervisor);
            grp1.Controls.Add(txtprojectName);
            grp1.Controls.Add(txtFund);
            grp1.Controls.Add(txtprojectID);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(17, 8);
            grp1.Name = "grp1";
            grp1.Size = new Size(527, 108);
            grp1.TabIndex = 3;
            grp1.TabStop = false;
            grp1.Text = "Student information";
            grp1.Enter += grp1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 447);
            Controls.Add(grp2);
            Controls.Add(grp3);
            Controls.Add(grp1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp2.ResumeLayout(false);
            grp3.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grd;
        private DateTimePicker dpDOB;
        private ComboBox cbsupervisor;
        private TextBox txtprojectName;
        private TextBox txtFund;
        private TextBox txtprojectID;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private Label label3;
        private Button bPRINT;
        private GroupBox grp2;
        private Button bCANCEL;
        private Label label1;
        private GroupBox grp3;
        private GroupBox grp1;
    }
}