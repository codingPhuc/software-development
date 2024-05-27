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
            this.cbbSinhvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bALLProject = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSinhvien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Information";
            // 
            // cbbSinhvien
            // 
            this.cbbSinhvien.FormattingEnabled = true;
            this.cbbSinhvien.Location = new System.Drawing.Point(71, 17);
            this.cbbSinhvien.Name = "cbbSinhvien";
            this.cbbSinhvien.Size = new System.Drawing.Size(121, 21);
            this.cbbSinhvien.TabIndex = 1;
            this.cbbSinhvien.SelectedIndexChanged += new System.EventHandler(this.cbbSinhvien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh Vien";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCancel);
            this.groupBox2.Controls.Add(this.bPrint);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.bEdit);
            this.groupBox2.Controls.Add(this.bDel);
            this.groupBox2.Controls.Add(this.bALLProject);
            this.groupBox2.Location = new System.Drawing.Point(16, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(353, 16);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(77, 26);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(436, 16);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(77, 26);
            this.bPrint.TabIndex = 0;
            this.bPrint.Text = "Print Preview";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(270, 16);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(77, 26);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(187, 16);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(77, 26);
            this.bEdit.TabIndex = 0;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(104, 16);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(77, 26);
            this.bDel.TabIndex = 0;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bALLProject;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox cbbSinhvien;
    }
}

