
namespace AkademineSistema
{
    partial class AdminStudentF
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
            this.txtAdminStudentSeacrh = new System.Windows.Forms.TextBox();
            this.btnAdminStudentSearch = new System.Windows.Forms.Button();
            this.lblAdminStudentSearch = new System.Windows.Forms.Label();
            this.btnAdminStudentAdd = new System.Windows.Forms.Button();
            this.btnAdminStudentDelete = new System.Windows.Forms.Button();
            this.btnAdminStudentGroup = new System.Windows.Forms.Button();
            this.listAdminStudent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdminStudentSeacrh
            // 
            this.txtAdminStudentSeacrh.Location = new System.Drawing.Point(89, 44);
            this.txtAdminStudentSeacrh.Name = "txtAdminStudentSeacrh";
            this.txtAdminStudentSeacrh.Size = new System.Drawing.Size(209, 22);
            this.txtAdminStudentSeacrh.TabIndex = 5;
            // 
            // btnAdminStudentSearch
            // 
            this.btnAdminStudentSearch.Location = new System.Drawing.Point(304, 40);
            this.btnAdminStudentSearch.Name = "btnAdminStudentSearch";
            this.btnAdminStudentSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminStudentSearch.TabIndex = 6;
            this.btnAdminStudentSearch.Text = "Search";
            this.btnAdminStudentSearch.UseVisualStyleBackColor = true;
            this.btnAdminStudentSearch.Click += new System.EventHandler(this.btnAdminStudentSearch_Click);
            // 
            // lblAdminStudentSearch
            // 
            this.lblAdminStudentSearch.AutoSize = true;
            this.lblAdminStudentSearch.Location = new System.Drawing.Point(86, 20);
            this.lblAdminStudentSearch.Name = "lblAdminStudentSearch";
            this.lblAdminStudentSearch.Size = new System.Drawing.Size(155, 17);
            this.lblAdminStudentSearch.TabIndex = 7;
            this.lblAdminStudentSearch.Text = "Type in student\'s name";
            // 
            // btnAdminStudentAdd
            // 
            this.btnAdminStudentAdd.Location = new System.Drawing.Point(89, 356);
            this.btnAdminStudentAdd.Name = "btnAdminStudentAdd";
            this.btnAdminStudentAdd.Size = new System.Drawing.Size(101, 43);
            this.btnAdminStudentAdd.TabIndex = 9;
            this.btnAdminStudentAdd.Text = "Add Student";
            this.btnAdminStudentAdd.UseVisualStyleBackColor = true;
            this.btnAdminStudentAdd.Click += new System.EventHandler(this.btnAdminStudentAdd_Click);
            // 
            // btnAdminStudentDelete
            // 
            this.btnAdminStudentDelete.Location = new System.Drawing.Point(272, 356);
            this.btnAdminStudentDelete.Name = "btnAdminStudentDelete";
            this.btnAdminStudentDelete.Size = new System.Drawing.Size(112, 34);
            this.btnAdminStudentDelete.TabIndex = 10;
            this.btnAdminStudentDelete.Text = "Delete Student";
            this.btnAdminStudentDelete.UseVisualStyleBackColor = true;
            this.btnAdminStudentDelete.Click += new System.EventHandler(this.btnAdminStudentDelete_Click);
            // 
            // btnAdminStudentGroup
            // 
            this.btnAdminStudentGroup.Location = new System.Drawing.Point(87, 405);
            this.btnAdminStudentGroup.Name = "btnAdminStudentGroup";
            this.btnAdminStudentGroup.Size = new System.Drawing.Size(103, 43);
            this.btnAdminStudentGroup.TabIndex = 11;
            this.btnAdminStudentGroup.Text = "Add to Group";
            this.btnAdminStudentGroup.UseVisualStyleBackColor = true;
            this.btnAdminStudentGroup.Click += new System.EventHandler(this.btnAdminStudentGroup_Click);
            // 
            // listAdminStudent
            // 
            this.listAdminStudent.FormattingEnabled = true;
            this.listAdminStudent.ItemHeight = 16;
            this.listAdminStudent.Location = new System.Drawing.Point(89, 92);
            this.listAdminStudent.Name = "listAdminStudent";
            this.listAdminStudent.Size = new System.Drawing.Size(295, 244);
            this.listAdminStudent.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID - Name - Surname - GroupID - AdminID ";
            // 
            // AdminStudentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAdminStudent);
            this.Controls.Add(this.btnAdminStudentGroup);
            this.Controls.Add(this.btnAdminStudentDelete);
            this.Controls.Add(this.btnAdminStudentAdd);
            this.Controls.Add(this.lblAdminStudentSearch);
            this.Controls.Add(this.btnAdminStudentSearch);
            this.Controls.Add(this.txtAdminStudentSeacrh);
            this.Name = "AdminStudentF";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdminStudentSeacrh;
        private System.Windows.Forms.Button btnAdminStudentSearch;
        private System.Windows.Forms.Label lblAdminStudentSearch;
        private System.Windows.Forms.Button btnAdminStudentAdd;
        private System.Windows.Forms.Button btnAdminStudentDelete;
        private System.Windows.Forms.Button btnAdminStudentGroup;
        private System.Windows.Forms.ListBox listAdminStudent;
        private System.Windows.Forms.Label label1;
    }
}