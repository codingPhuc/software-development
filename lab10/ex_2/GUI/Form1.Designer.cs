namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bALLProject = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBook);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dpNgayMuon);
            this.groupBox1.Controls.Add(this.dpNgayTra);
            this.groupBox1.Controls.Add(this.cbReader);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngay muon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngay Tra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dpNgayMuon
            // 
            this.dpNgayMuon.Location = new System.Drawing.Point(330, 20);
            this.dpNgayMuon.Name = "dpNgayMuon";
            this.dpNgayMuon.Size = new System.Drawing.Size(200, 20);
            this.dpNgayMuon.TabIndex = 3;
            // 
            // dpNgayTra
            // 
            this.dpNgayTra.Location = new System.Drawing.Point(330, 49);
            this.dpNgayTra.Name = "dpNgayTra";
            this.dpNgayTra.Size = new System.Drawing.Size(200, 20);
            this.dpNgayTra.TabIndex = 2;
            // 
            // cbReader
            // 
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(71, 17);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(121, 21);
            this.cbReader.TabIndex = 1;
            this.cbReader.SelectedIndexChanged += new System.EventHandler(this.cbbSinhvien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bPrint);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.bALLProject);
            this.groupBox2.Location = new System.Drawing.Point(16, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(200, 16);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(77, 26);
            this.bPrint.TabIndex = 0;
            this.bPrint.Text = "Print Preview";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(104, 16);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(77, 26);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bALLProject
            // 
            this.bALLProject.Location = new System.Drawing.Point(21, 16);
            this.bALLProject.Name = "bALLProject";
            this.bALLProject.Size = new System.Drawing.Size(77, 26);
            this.bALLProject.TabIndex = 0;
            this.bALLProject.Text = "Get Project";
            this.bALLProject.UseVisualStyleBackColor = true;
            this.bALLProject.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(18, 154);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(549, 249);
            this.grd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "book";
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(71, 49);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(121, 21);
            this.cbBook.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 414);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bALLProject;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpNgayMuon;
        private System.Windows.Forms.DateTimePicker dpNgayTra;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label4;
    }
}

