
namespace AkademineSistema
{
    partial class AdminGroupF
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
            this.btnAdminGroupDelete = new System.Windows.Forms.Button();
            this.btnAdminGroupAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminGroupSearch = new System.Windows.Forms.TextBox();
            this.btnAdminStudentSearch = new System.Windows.Forms.Button();
            this.listAdminGroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminGroupDelete
            // 
            this.btnAdminGroupDelete.Location = new System.Drawing.Point(251, 379);
            this.btnAdminGroupDelete.Name = "btnAdminGroupDelete";
            this.btnAdminGroupDelete.Size = new System.Drawing.Size(112, 34);
            this.btnAdminGroupDelete.TabIndex = 16;
            this.btnAdminGroupDelete.Text = "Delete Group";
            this.btnAdminGroupDelete.UseVisualStyleBackColor = true;
            this.btnAdminGroupDelete.Click += new System.EventHandler(this.btnAdminGroupDelete_Click);
            // 
            // btnAdminGroupAdd
            // 
            this.btnAdminGroupAdd.Location = new System.Drawing.Point(68, 379);
            this.btnAdminGroupAdd.Name = "btnAdminGroupAdd";
            this.btnAdminGroupAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdminGroupAdd.TabIndex = 15;
            this.btnAdminGroupAdd.Text = "Add Group";
            this.btnAdminGroupAdd.UseVisualStyleBackColor = true;
            this.btnAdminGroupAdd.Click += new System.EventHandler(this.btnAdminGroupAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Group Search";
            // 
            // txtAdminGroupSearch
            // 
            this.txtAdminGroupSearch.Location = new System.Drawing.Point(68, 50);
            this.txtAdminGroupSearch.Name = "txtAdminGroupSearch";
            this.txtAdminGroupSearch.Size = new System.Drawing.Size(209, 22);
            this.txtAdminGroupSearch.TabIndex = 12;
            // 
            // btnAdminStudentSearch
            // 
            this.btnAdminStudentSearch.Location = new System.Drawing.Point(283, 46);
            this.btnAdminStudentSearch.Name = "btnAdminStudentSearch";
            this.btnAdminStudentSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminStudentSearch.TabIndex = 17;
            this.btnAdminStudentSearch.Text = "Search";
            this.btnAdminStudentSearch.UseVisualStyleBackColor = true;
            this.btnAdminStudentSearch.Click += new System.EventHandler(this.btnAdminStudentSearch_Click);
            // 
            // listAdminGroups
            // 
            this.listAdminGroups.FormattingEnabled = true;
            this.listAdminGroups.ItemHeight = 16;
            this.listAdminGroups.Location = new System.Drawing.Point(68, 97);
            this.listAdminGroups.Name = "listAdminGroups";
            this.listAdminGroups.Size = new System.Drawing.Size(295, 276);
            this.listAdminGroups.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID - Group Name - AdminID";
            // 
            // AdminGroupF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAdminGroups);
            this.Controls.Add(this.btnAdminStudentSearch);
            this.Controls.Add(this.btnAdminGroupDelete);
            this.Controls.Add(this.btnAdminGroupAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminGroupSearch);
            this.Name = "AdminGroupF";
            this.Text = "AdmingGroupF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGroupDelete;
        private System.Windows.Forms.Button btnAdminGroupAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminGroupSearch;
        private System.Windows.Forms.Button btnAdminStudentSearch;
        private System.Windows.Forms.ListBox listAdminGroups;
        private System.Windows.Forms.Label label2;
    }
}