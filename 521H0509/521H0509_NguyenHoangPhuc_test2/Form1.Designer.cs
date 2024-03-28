namespace Lab3_Ca4_Thu6
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
            this.groupBoxAddAuthor = new System.Windows.Forms.GroupBox();
            this.dateTimephieumuon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bPDF = new System.Windows.Forms.Button();
            this.bTC = new System.Windows.Forms.Button();
            this.cbHT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.dateTimePhieutra = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ma_phieu_muon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmasach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAddAuthor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddAuthor
            // 
            this.groupBoxAddAuthor.Controls.Add(this.label4);
            this.groupBoxAddAuthor.Controls.Add(this.textBoxmasach);
            this.groupBoxAddAuthor.Controls.Add(this.label5);
            this.groupBoxAddAuthor.Controls.Add(this.dateTimePhieutra);
            this.groupBoxAddAuthor.Controls.Add(this.dateTimephieumuon);
            this.groupBoxAddAuthor.Controls.Add(this.label3);
            this.groupBoxAddAuthor.Controls.Add(this.label2);
            this.groupBoxAddAuthor.Controls.Add(this.ma_phieu_muon);
            this.groupBoxAddAuthor.Location = new System.Drawing.Point(17, 9);
            this.groupBoxAddAuthor.Name = "groupBoxAddAuthor";
            this.groupBoxAddAuthor.Size = new System.Drawing.Size(452, 164);
            this.groupBoxAddAuthor.TabIndex = 2;
            this.groupBoxAddAuthor.TabStop = false;
            this.groupBoxAddAuthor.Text = "Them doc gia";
            // 
            // dateTimephieumuon
            // 
            this.dateTimephieumuon.Location = new System.Drawing.Point(77, 101);
            this.dateTimephieumuon.Name = "dateTimephieumuon";
            this.dateTimephieumuon.Size = new System.Drawing.Size(210, 20);
            this.dateTimephieumuon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ngay muon ";
            // 
            // bPDF
            // 
            this.bPDF.Location = new System.Drawing.Point(601, 50);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(96, 21);
            this.bPDF.TabIndex = 2;
            this.bPDF.Text = "To PDF";
            this.bPDF.UseVisualStyleBackColor = true;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // bTC
            // 
            this.bTC.Location = new System.Drawing.Point(601, 77);
            this.bTC.Name = "bTC";
            this.bTC.Size = new System.Drawing.Size(96, 21);
            this.bTC.TabIndex = 2;
            this.bTC.Text = "Tất cả";
            this.bTC.UseVisualStyleBackColor = true;
            this.bTC.Click += new System.EventHandler(this.bTC_Click);
            // 
            // cbHT
            // 
            this.cbHT.FormattingEnabled = true;
            this.cbHT.Location = new System.Drawing.Point(487, 135);
            this.cbHT.Name = "cbHT";
            this.cbHT.Size = new System.Drawing.Size(210, 21);
            this.cbHT.TabIndex = 1;
            this.cbHT.SelectedIndexChanged += new System.EventHandler(this.cbHT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(484, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tim doc gia ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd);
            this.groupBox2.Location = new System.Drawing.Point(15, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 412);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách doc gia";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(6, 37);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.Size = new System.Drawing.Size(670, 350);
            this.grd.TabIndex = 0;
            this.grd.Click += new System.EventHandler(this.grd_Click);
            this.grd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grd_MouseClick);
            // 
            // dateTimePhieutra
            // 
            this.dateTimePhieutra.Location = new System.Drawing.Point(77, 138);
            this.dateTimePhieutra.Name = "dateTimePhieutra";
            this.dateTimePhieutra.Size = new System.Drawing.Size(210, 20);
            this.dateTimePhieutra.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(21, 179);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 21);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Muon";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ma_phieu_muon";
            // 
            // ma_phieu_muon
            // 
            this.ma_phieu_muon.Location = new System.Drawing.Point(102, 61);
            this.ma_phieu_muon.Name = "ma_phieu_muon";
            this.ma_phieu_muon.Size = new System.Drawing.Size(210, 20);
            this.ma_phieu_muon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ngay tra";
            // 
            // textBoxmasach
            // 
            this.textBoxmasach.Location = new System.Drawing.Point(102, 35);
            this.textBoxmasach.Name = "textBoxmasach";
            this.textBoxmasach.Size = new System.Drawing.Size(210, 20);
            this.textBoxmasach.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ma_sach";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxAddAuthor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bTC);
            this.Controls.Add(this.cbHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPDF);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAddAuthor.ResumeLayout(false);
            this.groupBoxAddAuthor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddAuthor;
        private System.Windows.Forms.Button bPDF;
        private System.Windows.Forms.Button bTC;
        private System.Windows.Forms.ComboBox cbHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DateTimePicker dateTimephieumuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePhieutra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ma_phieu_muon;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmasach;
        private System.Windows.Forms.Button button1;
    }
}

