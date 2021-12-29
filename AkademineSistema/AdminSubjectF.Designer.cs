
namespace AkademineSistema
{
    partial class AdminSubjectF
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
            this.btnAdminSubjectLector = new System.Windows.Forms.Button();
            this.btnAdminSubjectDelete = new System.Windows.Forms.Button();
            this.btnAdminSubjectAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminSubjectSearch = new System.Windows.Forms.TextBox();
            this.btnAdminSubjectGroup = new System.Windows.Forms.Button();
            this.btnAdminStudentSearch = new System.Windows.Forms.Button();
            this.listAdminSubjects = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminSubjectLector
            // 
            this.btnAdminSubjectLector.Location = new System.Drawing.Point(89, 391);
            this.btnAdminSubjectLector.Name = "btnAdminSubjectLector";
            this.btnAdminSubjectLector.Size = new System.Drawing.Size(117, 34);
            this.btnAdminSubjectLector.TabIndex = 18;
            this.btnAdminSubjectLector.Text = "Assign Lector";
            this.btnAdminSubjectLector.UseVisualStyleBackColor = true;
            this.btnAdminSubjectLector.Click += new System.EventHandler(this.btnAdminSubjectLector_Click);
            // 
            // btnAdminSubjectDelete
            // 
            this.btnAdminSubjectDelete.Location = new System.Drawing.Point(272, 351);
            this.btnAdminSubjectDelete.Name = "btnAdminSubjectDelete";
            this.btnAdminSubjectDelete.Size = new System.Drawing.Size(112, 34);
            this.btnAdminSubjectDelete.TabIndex = 17;
            this.btnAdminSubjectDelete.Text = "Delete Subject";
            this.btnAdminSubjectDelete.UseVisualStyleBackColor = true;
            this.btnAdminSubjectDelete.Click += new System.EventHandler(this.btnAdminSubjectDelete_Click);
            // 
            // btnAdminSubjectAdd
            // 
            this.btnAdminSubjectAdd.Location = new System.Drawing.Point(89, 351);
            this.btnAdminSubjectAdd.Name = "btnAdminSubjectAdd";
            this.btnAdminSubjectAdd.Size = new System.Drawing.Size(117, 34);
            this.btnAdminSubjectAdd.TabIndex = 16;
            this.btnAdminSubjectAdd.Text = "Add Subject";
            this.btnAdminSubjectAdd.UseVisualStyleBackColor = true;
            this.btnAdminSubjectAdd.Click += new System.EventHandler(this.btnAdminSubjectAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Subject Search";
            // 
            // txtAdminSubjectSearch
            // 
            this.txtAdminSubjectSearch.Location = new System.Drawing.Point(89, 38);
            this.txtAdminSubjectSearch.Name = "txtAdminSubjectSearch";
            this.txtAdminSubjectSearch.Size = new System.Drawing.Size(209, 22);
            this.txtAdminSubjectSearch.TabIndex = 13;
            // 
            // btnAdminSubjectGroup
            // 
            this.btnAdminSubjectGroup.Location = new System.Drawing.Point(89, 431);
            this.btnAdminSubjectGroup.Name = "btnAdminSubjectGroup";
            this.btnAdminSubjectGroup.Size = new System.Drawing.Size(117, 34);
            this.btnAdminSubjectGroup.TabIndex = 19;
            this.btnAdminSubjectGroup.Text = "Assign Group";
            this.btnAdminSubjectGroup.UseVisualStyleBackColor = true;
            this.btnAdminSubjectGroup.Click += new System.EventHandler(this.btnAdminSubjectGroup_Click);
            // 
            // btnAdminStudentSearch
            // 
            this.btnAdminStudentSearch.Location = new System.Drawing.Point(304, 34);
            this.btnAdminStudentSearch.Name = "btnAdminStudentSearch";
            this.btnAdminStudentSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminStudentSearch.TabIndex = 20;
            this.btnAdminStudentSearch.Text = "Search";
            this.btnAdminStudentSearch.UseVisualStyleBackColor = true;
            this.btnAdminStudentSearch.Click += new System.EventHandler(this.btnAdminStudentSearch_Click);
            // 
            // listAdminSubjects
            // 
            this.listAdminSubjects.FormattingEnabled = true;
            this.listAdminSubjects.ItemHeight = 16;
            this.listAdminSubjects.Location = new System.Drawing.Point(89, 83);
            this.listAdminSubjects.Name = "listAdminSubjects";
            this.listAdminSubjects.Size = new System.Drawing.Size(295, 260);
            this.listAdminSubjects.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID - Name - LectorID - AdminID";
            // 
            // AdminSubjectF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminSubjectGroup);
            this.Controls.Add(this.listAdminSubjects);
            this.Controls.Add(this.btnAdminStudentSearch);
            this.Controls.Add(this.btnAdminSubjectLector);
            this.Controls.Add(this.btnAdminSubjectDelete);
            this.Controls.Add(this.btnAdminSubjectAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminSubjectSearch);
            this.Name = "AdminSubjectF";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminSubjectLector;
        private System.Windows.Forms.Button btnAdminSubjectDelete;
        private System.Windows.Forms.Button btnAdminSubjectAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminSubjectSearch;
        private System.Windows.Forms.Button btnAdminSubjectGroup;
        private System.Windows.Forms.Button btnAdminStudentSearch;
        private System.Windows.Forms.ListBox listAdminSubjects;
        private System.Windows.Forms.Label label2;
    }
}