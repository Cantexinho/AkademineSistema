
namespace AkademineSistema
{
    partial class AdminSubjectLector
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
            this.btnAdminSubjectLectorAddCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminSubjectLectorAddOk = new System.Windows.Forms.Button();
            this.listAdminSubjectLector = new System.Windows.Forms.ListBox();
            this.btnAdminSubjectLectorSearch = new System.Windows.Forms.Button();
            this.txtAdminSubjectLectorSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminSubjectLectorAddCancel
            // 
            this.btnAdminSubjectLectorAddCancel.Location = new System.Drawing.Point(271, 348);
            this.btnAdminSubjectLectorAddCancel.Name = "btnAdminSubjectLectorAddCancel";
            this.btnAdminSubjectLectorAddCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectLectorAddCancel.TabIndex = 20;
            this.btnAdminSubjectLectorAddCancel.Text = "Cancel";
            this.btnAdminSubjectLectorAddCancel.UseVisualStyleBackColor = true;
            this.btnAdminSubjectLectorAddCancel.Click += new System.EventHandler(this.btnAdminSubjectLectorAddCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name of lector";
            // 
            // btnAdminSubjectLectorAddOk
            // 
            this.btnAdminSubjectLectorAddOk.Location = new System.Drawing.Point(57, 348);
            this.btnAdminSubjectLectorAddOk.Name = "btnAdminSubjectLectorAddOk";
            this.btnAdminSubjectLectorAddOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectLectorAddOk.TabIndex = 17;
            this.btnAdminSubjectLectorAddOk.Text = "Ok";
            this.btnAdminSubjectLectorAddOk.UseVisualStyleBackColor = true;
            this.btnAdminSubjectLectorAddOk.Click += new System.EventHandler(this.btnAdminSubjectLectorAddOk_Click);
            // 
            // listAdminSubjectLector
            // 
            this.listAdminSubjectLector.FormattingEnabled = true;
            this.listAdminSubjectLector.ItemHeight = 16;
            this.listAdminSubjectLector.Location = new System.Drawing.Point(57, 89);
            this.listAdminSubjectLector.Name = "listAdminSubjectLector";
            this.listAdminSubjectLector.Size = new System.Drawing.Size(295, 244);
            this.listAdminSubjectLector.TabIndex = 25;
            // 
            // btnAdminSubjectLectorSearch
            // 
            this.btnAdminSubjectLectorSearch.Location = new System.Drawing.Point(272, 33);
            this.btnAdminSubjectLectorSearch.Name = "btnAdminSubjectLectorSearch";
            this.btnAdminSubjectLectorSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminSubjectLectorSearch.TabIndex = 24;
            this.btnAdminSubjectLectorSearch.Text = "Search";
            this.btnAdminSubjectLectorSearch.UseVisualStyleBackColor = true;
            this.btnAdminSubjectLectorSearch.Click += new System.EventHandler(this.btnAdminStudentSearch_Click);
            // 
            // txtAdminSubjectLectorSearch
            // 
            this.txtAdminSubjectLectorSearch.Location = new System.Drawing.Point(57, 37);
            this.txtAdminSubjectLectorSearch.Name = "txtAdminSubjectLectorSearch";
            this.txtAdminSubjectLectorSearch.Size = new System.Drawing.Size(209, 22);
            this.txtAdminSubjectLectorSearch.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID - Name - Surname - AdminID";
            // 
            // AdminSubjectLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAdminSubjectLector);
            this.Controls.Add(this.btnAdminSubjectLectorSearch);
            this.Controls.Add(this.txtAdminSubjectLectorSearch);
            this.Controls.Add(this.btnAdminSubjectLectorAddCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminSubjectLectorAddOk);
            this.Name = "AdminSubjectLector";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminSubjectLectorAddCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminSubjectLectorAddOk;
        private System.Windows.Forms.ListBox listAdminSubjectLector;
        private System.Windows.Forms.Button btnAdminSubjectLectorSearch;
        private System.Windows.Forms.TextBox txtAdminSubjectLectorSearch;
        private System.Windows.Forms.Label label1;
    }
}