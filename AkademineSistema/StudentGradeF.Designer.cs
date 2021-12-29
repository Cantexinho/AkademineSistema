
namespace AkademineSistema
{
    partial class StudentGradeF
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
            this.cmbStudentGrane = new System.Windows.Forms.ComboBox();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.lblStudentChoose = new System.Windows.Forms.Label();
            this.listStudentGrades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStudentGrane
            // 
            this.cmbStudentGrane.FormattingEnabled = true;
            this.cmbStudentGrane.Location = new System.Drawing.Point(65, 61);
            this.cmbStudentGrane.Name = "cmbStudentGrane";
            this.cmbStudentGrane.Size = new System.Drawing.Size(209, 24);
            this.cmbStudentGrane.TabIndex = 0;
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(280, 61);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(80, 29);
            this.btnStudentSearch.TabIndex = 1;
            this.btnStudentSearch.Text = "search";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // lblStudentChoose
            // 
            this.lblStudentChoose.AutoSize = true;
            this.lblStudentChoose.Location = new System.Drawing.Point(62, 41);
            this.lblStudentChoose.Name = "lblStudentChoose";
            this.lblStudentChoose.Size = new System.Drawing.Size(105, 17);
            this.lblStudentChoose.TabIndex = 4;
            this.lblStudentChoose.Text = "Choose subject";
            // 
            // listStudentGrades
            // 
            this.listStudentGrades.FormattingEnabled = true;
            this.listStudentGrades.ItemHeight = 16;
            this.listStudentGrades.Location = new System.Drawing.Point(65, 108);
            this.listStudentGrades.Name = "listStudentGrades";
            this.listStudentGrades.Size = new System.Drawing.Size(295, 276);
            this.listStudentGrades.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID - Source - Grade - Date";
            // 
            // StudentGradeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStudentGrades);
            this.Controls.Add(this.lblStudentChoose);
            this.Controls.Add(this.btnStudentSearch);
            this.Controls.Add(this.cmbStudentGrane);
            this.Name = "StudentGradeF";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentGradeF_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentGrane;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Label lblStudentChoose;
        private System.Windows.Forms.ListBox listStudentGrades;
        private System.Windows.Forms.Label label1;
    }
}