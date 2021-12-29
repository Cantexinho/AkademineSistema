
namespace AkademineSistema
{
    partial class AdminSubjectGroup
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
            this.listAdminSubjectGroup = new System.Windows.Forms.ListBox();
            this.btnAdminSubjectGroupSearch = new System.Windows.Forms.Button();
            this.txtAdminSubjectGroupSearch = new System.Windows.Forms.TextBox();
            this.btnAdminSubjectGroupAddCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminSubjectGroupAddOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAdminSubjectGroup
            // 
            this.listAdminSubjectGroup.FormattingEnabled = true;
            this.listAdminSubjectGroup.ItemHeight = 16;
            this.listAdminSubjectGroup.Location = new System.Drawing.Point(69, 93);
            this.listAdminSubjectGroup.Name = "listAdminSubjectGroup";
            this.listAdminSubjectGroup.Size = new System.Drawing.Size(295, 244);
            this.listAdminSubjectGroup.TabIndex = 31;
            // 
            // btnAdminSubjectGroupSearch
            // 
            this.btnAdminSubjectGroupSearch.Location = new System.Drawing.Point(284, 41);
            this.btnAdminSubjectGroupSearch.Name = "btnAdminSubjectGroupSearch";
            this.btnAdminSubjectGroupSearch.Size = new System.Drawing.Size(80, 31);
            this.btnAdminSubjectGroupSearch.TabIndex = 30;
            this.btnAdminSubjectGroupSearch.Text = "Search";
            this.btnAdminSubjectGroupSearch.UseVisualStyleBackColor = true;
            this.btnAdminSubjectGroupSearch.Click += new System.EventHandler(this.btnAdminSubjectGroupSearch_Click);
            // 
            // txtAdminSubjectGroupSearch
            // 
            this.txtAdminSubjectGroupSearch.Location = new System.Drawing.Point(69, 45);
            this.txtAdminSubjectGroupSearch.Name = "txtAdminSubjectGroupSearch";
            this.txtAdminSubjectGroupSearch.Size = new System.Drawing.Size(209, 22);
            this.txtAdminSubjectGroupSearch.TabIndex = 29;
            // 
            // btnAdminSubjectGroupAddCancel
            // 
            this.btnAdminSubjectGroupAddCancel.Location = new System.Drawing.Point(283, 356);
            this.btnAdminSubjectGroupAddCancel.Name = "btnAdminSubjectGroupAddCancel";
            this.btnAdminSubjectGroupAddCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectGroupAddCancel.TabIndex = 28;
            this.btnAdminSubjectGroupAddCancel.Text = "Cancel";
            this.btnAdminSubjectGroupAddCancel.UseVisualStyleBackColor = true;
            this.btnAdminSubjectGroupAddCancel.Click += new System.EventHandler(this.btnAdminSubjectGroupAddCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name of group";
            // 
            // btnAdminSubjectGroupAddOk
            // 
            this.btnAdminSubjectGroupAddOk.Location = new System.Drawing.Point(69, 356);
            this.btnAdminSubjectGroupAddOk.Name = "btnAdminSubjectGroupAddOk";
            this.btnAdminSubjectGroupAddOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectGroupAddOk.TabIndex = 26;
            this.btnAdminSubjectGroupAddOk.Text = "Ok";
            this.btnAdminSubjectGroupAddOk.UseVisualStyleBackColor = true;
            this.btnAdminSubjectGroupAddOk.Click += new System.EventHandler(this.btnAdminSubjectGroupAddOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID - Group Name - AdminID";
            // 
            // AdminSubjectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAdminSubjectGroup);
            this.Controls.Add(this.btnAdminSubjectGroupSearch);
            this.Controls.Add(this.txtAdminSubjectGroupSearch);
            this.Controls.Add(this.btnAdminSubjectGroupAddCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminSubjectGroupAddOk);
            this.Name = "AdminSubjectGroup";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAdminSubjectGroup;
        private System.Windows.Forms.Button btnAdminSubjectGroupSearch;
        private System.Windows.Forms.TextBox txtAdminSubjectGroupSearch;
        private System.Windows.Forms.Button btnAdminSubjectGroupAddCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminSubjectGroupAddOk;
        private System.Windows.Forms.Label label1;
    }
}