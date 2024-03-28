namespace Lab1_F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grd = new DataGridView();
            BIRTH = new DateTimePicker();
            ORIGIN = new ComboBox();
            NAME = new TextBox();
            label4 = new Label();
            label2 = new Label();
            MSSV = new TextBox();
            label5 = new Label();
            bLUU = new Button();
            bSUA = new Button();
            bXOA = new Button();
            bTHEM = new Button();
            label3 = new Label();
            bXEMIN = new Button();
            groupBox2 = new GroupBox();
            bHUY = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            grp1 = new GroupBox();
            GPA = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(2, 20);
            grd.Margin = new Padding(2);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 33;
            grd.Size = new Size(616, 194);
            grd.TabIndex = 0;
            grd.Click += grd_Click;
            // 
            // BIRTH
            // 
            BIRTH.Location = new Point(349, 37);
            BIRTH.Margin = new Padding(2);
            BIRTH.Name = "BIRTH";
            BIRTH.Size = new Size(274, 23);
            BIRTH.TabIndex = 3;
            // 
            // ORIGIN
            // 
            ORIGIN.FormattingEnabled = true;
            ORIGIN.Items.AddRange(new object[] { "Saigon", "Thanh Hoa", "Nghe An", "Long An", "Quang Ngai" });
            ORIGIN.Location = new Point(103, 38);
            ORIGIN.Margin = new Padding(2);
            ORIGIN.Name = "ORIGIN";
            ORIGIN.Size = new Size(162, 23);
            ORIGIN.TabIndex = 2;
            // 
            // NAME
            // 
            NAME.Location = new Point(349, 14);
            NAME.Margin = new Padding(2);
            NAME.Name = "NAME";
            NAME.Size = new Size(275, 23);
            NAME.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // MSSV
            // 
            MSSV.Location = new Point(103, 14);
            MSSV.Margin = new Padding(2);
            MSSV.Name = "MSSV";
            MSSV.Size = new Size(162, 23);
            MSSV.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 61);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 0;
            label5.Text = "Học lực";
            // 
            // bLUU
            // 
            bLUU.Location = new Point(342, 10);
            bLUU.Margin = new Padding(2);
            bLUU.Name = "bLUU";
            bLUU.Size = new Size(69, 22);
            bLUU.TabIndex = 0;
            bLUU.Text = "Lưu";
            bLUU.UseVisualStyleBackColor = true;
            bLUU.Click += bLUU_Click;
            // 
            // bSUA
            // 
            bSUA.Location = new Point(269, 10);
            bSUA.Margin = new Padding(2);
            bSUA.Name = "bSUA";
            bSUA.Size = new Size(69, 22);
            bSUA.TabIndex = 0;
            bSUA.Text = "Sửa";
            bSUA.UseVisualStyleBackColor = true;
            bSUA.Click += bSUA_Click;
            // 
            // bXOA
            // 
            bXOA.Location = new Point(195, 10);
            bXOA.Margin = new Padding(2);
            bXOA.Name = "bXOA";
            bXOA.Size = new Size(69, 22);
            bXOA.TabIndex = 0;
            bXOA.Text = "Xóa";
            bXOA.UseVisualStyleBackColor = true;
            bXOA.Click += bXOA_Click;
            // 
            // bTHEM
            // 
            bTHEM.Location = new Point(122, 9);
            bTHEM.Margin = new Padding(2);
            bTHEM.Name = "bTHEM";
            bTHEM.Size = new Size(69, 22);
            bTHEM.TabIndex = 0;
            bTHEM.Text = "Thêm";
            bTHEM.UseVisualStyleBackColor = true;
            bTHEM.Click += bTHEM_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Quê quán";
            // 
            // bXEMIN
            // 
            bXEMIN.Location = new Point(489, 10);
            bXEMIN.Margin = new Padding(2);
            bXEMIN.Name = "bXEMIN";
            bXEMIN.Size = new Size(69, 22);
            bXEMIN.TabIndex = 0;
            bXEMIN.Text = "Xem in";
            bXEMIN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bXEMIN);
            groupBox2.Controls.Add(bHUY);
            groupBox2.Controls.Add(bLUU);
            groupBox2.Controls.Add(bSUA);
            groupBox2.Controls.Add(bXOA);
            groupBox2.Controls.Add(bTHEM);
            groupBox2.Location = new Point(8, 103);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(627, 31);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bHUY
            // 
            bHUY.Location = new Point(416, 10);
            bHUY.Margin = new Padding(2);
            bHUY.Name = "bHUY";
            bHUY.Size = new Size(69, 22);
            bHUY.TabIndex = 0;
            bHUY.Text = "Hủy";
            bHUY.UseVisualStyleBackColor = true;
            bHUY.Click += bHUY_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(6, 139);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(629, 214);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sinh viên";
            // 
            // grp1
            // 
            grp1.Controls.Add(GPA);
            grp1.Controls.Add(BIRTH);
            grp1.Controls.Add(ORIGIN);
            grp1.Controls.Add(NAME);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(MSSV);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(8, 7);
            grp1.Margin = new Padding(2);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(2);
            grp1.Size = new Size(627, 86);
            grp1.TabIndex = 3;
            grp1.TabStop = false;
            grp1.Text = "Thông tin sinh viên";
            // 
            // GPA
            // 
            GPA.Location = new Point(104, 62);
            GPA.Margin = new Padding(2);
            GPA.Name = "GPA";
            GPA.Size = new Size(162, 23);
            GPA.TabIndex = 4;
            GPA.KeyPress += txtHL_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 357);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(grp1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grd;
        private DateTimePicker BIRTH;
        private ComboBox ORIGIN;
        private TextBox NAME;
        private Label label4;
        private Label label2;
        private TextBox MSSV;
        private Label label5;
        private Button bLUU;
        private Button bSUA;
        private Button bXOA;
        private Button bTHEM;
        private Label label3;
        private Button bXEMIN;
        private GroupBox groupBox2;
        private Button bHUY;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox grp1;
        private MaskedTextBox GPA;
    }
}