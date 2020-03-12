namespace Final_Exam_Gude__Students_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ftygh = new System.Windows.Forms.TabControl();
            this.tcNewStudent = new System.Windows.Forms.TabPage();
            this.txtIdnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.txtEmailNew = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtLnameNew = new System.Windows.Forms.TextBox();
            this.txtFnameNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcSearch = new System.Windows.Forms.TabPage();
            this.LBsearch = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLnameSearch = new System.Windows.Forms.TextBox();
            this.txtFnameSearch = new System.Windows.Forms.TextBox();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tcExport = new System.Windows.Forms.TabPage();
            this.tcAbout = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lbExport = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ftygh.SuspendLayout();
            this.tcNewStudent.SuspendLayout();
            this.tcSearch.SuspendLayout();
            this.tcExport.SuspendLayout();
            this.tcAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // ftygh
            // 
            this.ftygh.Controls.Add(this.tcNewStudent);
            this.ftygh.Controls.Add(this.tcSearch);
            this.ftygh.Controls.Add(this.tcExport);
            this.ftygh.Controls.Add(this.tcAbout);
            this.ftygh.Location = new System.Drawing.Point(2, 105);
            this.ftygh.Name = "ftygh";
            this.ftygh.SelectedIndex = 0;
            this.ftygh.Size = new System.Drawing.Size(396, 356);
            this.ftygh.TabIndex = 1;
            // 
            // tcNewStudent
            // 
            this.tcNewStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcNewStudent.Controls.Add(this.txtIdnew);
            this.tcNewStudent.Controls.Add(this.label3);
            this.tcNewStudent.Controls.Add(this.btnSaveNew);
            this.tcNewStudent.Controls.Add(this.txtEmailNew);
            this.tcNewStudent.Controls.Add(this.btnClean);
            this.tcNewStudent.Controls.Add(this.txtLnameNew);
            this.tcNewStudent.Controls.Add(this.txtFnameNew);
            this.tcNewStudent.Controls.Add(this.label5);
            this.tcNewStudent.Controls.Add(this.label2);
            this.tcNewStudent.Controls.Add(this.label1);
            this.tcNewStudent.Location = new System.Drawing.Point(4, 22);
            this.tcNewStudent.Name = "tcNewStudent";
            this.tcNewStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tcNewStudent.Size = new System.Drawing.Size(388, 330);
            this.tcNewStudent.TabIndex = 0;
            this.tcNewStudent.Text = "New Student";
            this.tcNewStudent.UseVisualStyleBackColor = true;
            this.tcNewStudent.Click += new System.EventHandler(this.tcNewStudent_Click);
            // 
            // txtIdnew
            // 
            this.txtIdnew.Location = new System.Drawing.Point(99, 98);
            this.txtIdnew.Name = "txtIdnew";
            this.txtIdnew.Size = new System.Drawing.Size(273, 20);
            this.txtIdnew.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(53, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID :";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(303, 297);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "Save";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmailNew
            // 
            this.txtEmailNew.Location = new System.Drawing.Point(99, 127);
            this.txtEmailNew.Name = "txtEmailNew";
            this.txtEmailNew.Size = new System.Drawing.Size(273, 20);
            this.txtEmailNew.TabIndex = 10;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(6, 297);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtLnameNew
            // 
            this.txtLnameNew.Location = new System.Drawing.Point(99, 72);
            this.txtLnameNew.Name = "txtLnameNew";
            this.txtLnameNew.Size = new System.Drawing.Size(273, 20);
            this.txtLnameNew.TabIndex = 7;
            // 
            // txtFnameNew
            // 
            this.txtFnameNew.Location = new System.Drawing.Point(99, 38);
            this.txtFnameNew.Name = "txtFnameNew";
            this.txtFnameNew.Size = new System.Drawing.Size(273, 20);
            this.txtFnameNew.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(39, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcSearch
            // 
            this.tcSearch.Controls.Add(this.LBsearch);
            this.tcSearch.Controls.Add(this.label10);
            this.tcSearch.Controls.Add(this.btnClear);
            this.tcSearch.Controls.Add(this.btnSearch);
            this.tcSearch.Controls.Add(this.txtLnameSearch);
            this.tcSearch.Controls.Add(this.txtFnameSearch);
            this.tcSearch.Controls.Add(this.txtIdSearch);
            this.tcSearch.Controls.Add(this.label9);
            this.tcSearch.Controls.Add(this.label8);
            this.tcSearch.Controls.Add(this.label7);
            this.tcSearch.Location = new System.Drawing.Point(4, 22);
            this.tcSearch.Name = "tcSearch";
            this.tcSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tcSearch.Size = new System.Drawing.Size(388, 330);
            this.tcSearch.TabIndex = 1;
            this.tcSearch.Text = "Search Students";
            this.tcSearch.UseVisualStyleBackColor = true;
            // 
            // LBsearch
            // 
            this.LBsearch.FormattingEnabled = true;
            this.LBsearch.Location = new System.Drawing.Point(32, 133);
            this.LBsearch.Name = "LBsearch";
            this.LBsearch.Size = new System.Drawing.Size(327, 134);
            this.LBsearch.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Search Result";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(284, 284);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLnameSearch
            // 
            this.txtLnameSearch.Location = new System.Drawing.Point(121, 79);
            this.txtLnameSearch.Name = "txtLnameSearch";
            this.txtLnameSearch.Size = new System.Drawing.Size(238, 20);
            this.txtLnameSearch.TabIndex = 5;
            // 
            // txtFnameSearch
            // 
            this.txtFnameSearch.Location = new System.Drawing.Point(121, 49);
            this.txtFnameSearch.Name = "txtFnameSearch";
            this.txtFnameSearch.Size = new System.Drawing.Size(238, 20);
            this.txtFnameSearch.TabIndex = 4;
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.Location = new System.Drawing.Point(121, 17);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(238, 20);
            this.txtIdSearch.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID :";
            // 
            // tcExport
            // 
            this.tcExport.Controls.Add(this.lbExport);
            this.tcExport.Controls.Add(this.btnExport);
            this.tcExport.Location = new System.Drawing.Point(4, 22);
            this.tcExport.Name = "tcExport";
            this.tcExport.Padding = new System.Windows.Forms.Padding(3);
            this.tcExport.Size = new System.Drawing.Size(388, 330);
            this.tcExport.TabIndex = 2;
            this.tcExport.Text = "Export Students";
            this.tcExport.UseVisualStyleBackColor = true;
            this.tcExport.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tcAbout
            // 
            this.tcAbout.Controls.Add(this.pictureBox4);
            this.tcAbout.Controls.Add(this.pictureBox3);
            this.tcAbout.Controls.Add(this.pictureBox2);
            this.tcAbout.Location = new System.Drawing.Point(4, 22);
            this.tcAbout.Name = "tcAbout";
            this.tcAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tcAbout.Size = new System.Drawing.Size(388, 330);
            this.tcAbout.TabIndex = 3;
            this.tcAbout.Text = "About";
            this.tcAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(119, 259);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(263, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(307, 291);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export Now";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbExport
            // 
            this.lbExport.FormattingEnabled = true;
            this.lbExport.Location = new System.Drawing.Point(6, 6);
            this.lbExport.Name = "lbExport";
            this.lbExport.Size = new System.Drawing.Size(376, 277);
            this.lbExport.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(403, 509);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ftygh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ftygh.ResumeLayout(false);
            this.tcNewStudent.ResumeLayout(false);
            this.tcNewStudent.PerformLayout();
            this.tcSearch.ResumeLayout(false);
            this.tcSearch.PerformLayout();
            this.tcExport.ResumeLayout(false);
            this.tcAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl ftygh;
        private System.Windows.Forms.TabPage tcNewStudent;
        private System.Windows.Forms.TabPage tcSearch;
        private System.Windows.Forms.TabPage tcExport;
        private System.Windows.Forms.TabPage tcAbout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailNew;
        private System.Windows.Forms.TextBox txtFnameNew;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ListBox LBsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLnameSearch;
        private System.Windows.Forms.TextBox txtFnameSearch;
        private System.Windows.Forms.TextBox txtIdSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtIdnew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLnameNew;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListBox lbExport;
    }
}

