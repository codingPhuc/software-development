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
            this.label4 = new System.Windows.Forms.Label();
            this.masoTextbox = new System.Windows.Forms.TextBox();
            this.dateTimeAuthor = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.bPDF = new System.Windows.Forms.Button();
            this.bTC = new System.Windows.Forms.Button();
            this.cbHT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAddAuthor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddAuthor
            // 
            this.groupBoxAddAuthor.Controls.Add(this.label4);
            this.groupBoxAddAuthor.Controls.Add(this.masoTextbox);
            this.groupBoxAddAuthor.Controls.Add(this.dateTimeAuthor);
            this.groupBoxAddAuthor.Controls.Add(this.label3);
            this.groupBoxAddAuthor.Controls.Add(this.label2);
            this.groupBoxAddAuthor.Controls.Add(this.hoTenTextBox);
            this.groupBoxAddAuthor.Location = new System.Drawing.Point(17, 9);
            this.groupBoxAddAuthor.Name = "groupBoxAddAuthor";
            this.groupBoxAddAuthor.Size = new System.Drawing.Size(338, 147);
            this.groupBoxAddAuthor.TabIndex = 2;
            this.groupBoxAddAuthor.TabStop = false;
            this.groupBoxAddAuthor.Text = "Them doc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(11, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ma so doc gia";
            // 
            // masoTextbox
            // 
            this.masoTextbox.Location = new System.Drawing.Point(95, 24);
            this.masoTextbox.Name = "masoTextbox";
            this.masoTextbox.Size = new System.Drawing.Size(210, 20);
            this.masoTextbox.TabIndex = 8;
            // 
            // dateTimeAuthor
            // 
            this.dateTimeAuthor.Location = new System.Drawing.Point(95, 104);
            this.dateTimeAuthor.Name = "dateTimeAuthor";
            this.dateTimeAuthor.Size = new System.Drawing.Size(210, 20);
            this.dateTimeAuthor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ngay sinh  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ho ten doc gia ";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Location = new System.Drawing.Point(95, 61);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(210, 20);
            this.hoTenTextBox.TabIndex = 3;
            // 
            // bPDF
            // 
            this.bPDF.Location = new System.Drawing.Point(373, 25);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(96, 21);
            this.bPDF.TabIndex = 2;
            this.bPDF.Text = "To PDF";
            this.bPDF.UseVisualStyleBackColor = true;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // bTC
            // 
            this.bTC.Location = new System.Drawing.Point(373, 73);
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
            this.cbHT.Location = new System.Drawing.Point(373, 135);
            this.cbHT.Name = "cbHT";
            this.cbHT.Size = new System.Drawing.Size(210, 21);
            this.cbHT.TabIndex = 1;
            this.cbHT.SelectedIndexChanged += new System.EventHandler(this.cbHT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(370, 113);
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(21, 179);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 21);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(144, 179);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(96, 21);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(259, 179);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(96, 21);
            this.buttonedit.TabIndex = 7;
            this.buttonedit.Text = "Edit";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(373, 179);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 21);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 642);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonDel);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox masoTextbox;
        private System.Windows.Forms.DateTimePicker dateTimeAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttonSave;
    }
}

