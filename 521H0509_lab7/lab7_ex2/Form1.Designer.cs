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
            cbdiadiem = new ComboBox();
            txtSVNam = new TextBox();
            label2 = new Label();
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
            cbMASkhoa = new ComboBox();
            label8 = new Label();
            txtMSSV = new TextBox();
            label7 = new Label();
            dpNgaySinh = new DateTimePicker();
            label6 = new Label();
            cbQueQuan = new ComboBox();
            label5 = new Label();
            txt_GioiTinh = new TextBox();
            rdbnu = new RadioButton();
            rdbnam = new RadioButton();
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
            // cbdiadiem
            // 
            cbdiadiem.FormattingEnabled = true;
            cbdiadiem.Items.AddRange(new object[] { "Hà Nội", "Sai Gon" });
            cbdiadiem.Location = new Point(89, 45);
            cbdiadiem.Name = "cbdiadiem";
            cbdiadiem.Size = new Size(156, 23);
            cbdiadiem.TabIndex = 2;
            // 
            // txtSVNam
            // 
            txtSVNam.Location = new Point(360, 16);
            txtSVNam.Name = "txtSVNam";
            txtSVNam.Size = new Size(156, 23);
            txtSVNam.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 20);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Ten Sinh Vien";
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
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "dia diem";
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
            grp2.Location = new Point(17, 218);
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
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Ma  so khoa";
            label1.Click += label1_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(14, 301);
            grp3.Name = "grp3";
            grp3.Size = new Size(531, 237);
            grp3.TabIndex = 5;
            grp3.TabStop = false;
            grp3.Text = "Project List";
            // 
            // grp1
            // 
            grp1.Controls.Add(rdbnam);
            grp1.Controls.Add(rdbnu);
            grp1.Controls.Add(cbMASkhoa);
            grp1.Controls.Add(label8);
            grp1.Controls.Add(txtMSSV);
            grp1.Controls.Add(label7);
            grp1.Controls.Add(dpNgaySinh);
            grp1.Controls.Add(label6);
            grp1.Controls.Add(cbQueQuan);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(txt_GioiTinh);
            grp1.Controls.Add(cbdiadiem);
            grp1.Controls.Add(txtSVNam);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(17, 8);
            grp1.Name = "grp1";
            grp1.Size = new Size(527, 204);
            grp1.TabIndex = 3;
            grp1.TabStop = false;
            grp1.Text = "Student information";
            // 
            // cbMASkhoa
            // 
            cbMASkhoa.FormattingEnabled = true;
            cbMASkhoa.Location = new Point(89, 16);
            cbMASkhoa.Name = "cbMASkhoa";
            cbMASkhoa.Size = new Size(156, 23);
            cbMASkhoa.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 123);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 10;
            label8.Text = "Ma  so sinh vien";
            // 
            // txtMSSV
            // 
            txtMSSV.AcceptsReturn = true;
            txtMSSV.Location = new Point(89, 115);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(156, 23);
            txtMSSV.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 82);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 8;
            label7.Text = "Ngay Sinh";
            // 
            // dpNgaySinh
            // 
            dpNgaySinh.Location = new Point(360, 79);
            dpNgaySinh.Name = "dpNgaySinh";
            dpNgaySinh.Size = new Size(156, 23);
            dpNgaySinh.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 82);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 6;
            label6.Text = "Que Quan";
            // 
            // cbQueQuan
            // 
            cbQueQuan.FormattingEnabled = true;
            cbQueQuan.Items.AddRange(new object[] { "Hà Nội", "Sài Gòn" });
            cbQueQuan.Location = new Point(89, 79);
            cbQueQuan.Name = "cbQueQuan";
            cbQueQuan.Size = new Size(156, 23);
            cbQueQuan.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 53);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Gioi tinh";
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.AcceptsReturn = true;
            txt_GioiTinh.Location = new Point(360, 49);
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.Size = new Size(156, 23);
            txt_GioiTinh.TabIndex = 3;
            // 
            // rdbnu
            // 
            rdbnu.AutoSize = true;
            rdbnu.Location = new Point(360, 123);
            rdbnu.Name = "rdbnu";
            rdbnu.Size = new Size(41, 19);
            rdbnu.TabIndex = 12;
            rdbnu.TabStop = true;
            rdbnu.Text = "Nu";
            rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            rdbnam.AutoSize = true;
            rdbnam.Location = new Point(448, 123);
            rdbnam.Name = "rdbnam";
            rdbnam.Size = new Size(51, 19);
            rdbnam.TabIndex = 13;
            rdbnam.TabStop = true;
            rdbnam.Text = "Nam";
            rdbnam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 550);
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
        private ComboBox cbdiadiem;
        private TextBox txtSVNam;
        private Label label2;
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
        private Label label8;
        private TextBox txtMSSV;
        private Label label7;
        private DateTimePicker dpNgaySinh;
        private Label label6;
        private ComboBox cbQueQuan;
        private Label label5;
        private TextBox txt_GioiTinh;
        private ComboBox cbMASkhoa;
        private RadioButton rdbnam;
        private RadioButton rdbnu;
    }
}