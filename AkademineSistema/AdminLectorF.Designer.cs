
namespace AkademineSistema
{
    partial class AdminLectorF
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
            this.btnAdminLectorDelete = new System.Windows.Forms.Button();
            this.btnAdminLectorAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminLectorSearch = new System.Windows.Forms.TextBox();
            this.btnAdminStudentSearch = new System.Windows.Forms.Button();
            this.listAdminLectors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminLectorDelete
            // 
            this.btnAdminLectorDelete.Location = new System.Drawing.Point(272, 365);
            this.btnAdminLectorDelete.Name = "btnAdminLectorDelete";
            this.btnAdminLectorDelete.Size = new System.Drawing.Size(112, 34);
            this.btnAdminLectorDelete.TabIndex = 17;
            this.btnAdminLectorDelete.Text = "Delete Lector";
            this.btnAdminLectorDelete.UseVisualStyleBackColor = true;
            this.btnAdminLectorDelete.Click += new System.EventHandler(this.btnAdminLectorDelete_Click);
            // 
            // btnAdminLectorAdd
            // 
            this.btnAdminLectorAdd.Location = new System.Drawing.Point(89, 365);
            this.btnAdminLectorAdd.Name = "btnAdminLectorAdd";
            this.btnAdminLectorAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdminLectorAdd.TabIndex = 16;
            this.btnAdminLectorAdd.Text = "Add Lector";
            this.btnAdminLectorAdd.UseVisualStyleBackColor = true;
            this.btnAdminLectorAdd.Click += new System.EventHandler(this.btnAdminLectorAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lector Search";
            // 
            // txtAdminLectorSearch
            // 
            this.txtAdminLectorSearch.Location = new System.Drawing.Point(89, 49);
            this.txtAdminLectorSearch.Name = "txtAdminLectorSearch";
            this.txtAdminLectorSearch.Size = new System.Drawing.Size(209, 22);
            this.txtAdminLectorSearch.TabIndex = 13;
            // 
            // btnAdminStudentSearch
            // 
            this.btnAdminStudentSearch.Location = new System.Drawing.Point(304, 45);
            this.btnAdminStudentSearch.Name = "btnAdminStudentSearch";
            this.btnAdminStudentSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminStudentSearch.TabIndex = 18;
            this.btnAdminStudentSearch.Text = "Search";
            this.btnAdminStudentSearch.UseVisualStyleBackColor = true;
            this.btnAdminStudentSearch.Click += new System.EventHandler(this.btnAdminStudentSearch_Click);
            // 
            // listAdminLectors
            // 
            this.listAdminLectors.FormattingEnabled = true;
            this.listAdminLectors.ItemHeight = 16;
            this.listAdminLectors.Location = new System.Drawing.Point(89, 94);
            this.listAdminLectors.Name = "listAdminLectors";
            this.listAdminLectors.Size = new System.Drawing.Size(295, 260);
            this.listAdminLectors.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID - Name - Surname - AdminID";
            // 
            // AdminLectorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAdminLectors);
            this.Controls.Add(this.btnAdminStudentSearch);
            this.Controls.Add(this.btnAdminLectorDelete);
            this.Controls.Add(this.btnAdminLectorAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminLectorSearch);
            this.Name = "AdminLectorF";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdminLectorDelete;
        private System.Windows.Forms.Button btnAdminLectorAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminLectorSearch;
        private System.Windows.Forms.Button btnAdminStudentSearch;
        private System.Windows.Forms.ListBox listAdminLectors;
        private System.Windows.Forms.Label label2;
    }
}