
namespace AkademineSistema
{
    partial class AdminStudentAddGroup
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminStudentGroupAssignOk = new System.Windows.Forms.Button();
            this.btnAdminStudentAssignGroupCancel = new System.Windows.Forms.Button();
            this.listAdminStudentGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID - Group Name - AdminID";
            // 
            // btnAdminStudentGroupAssignOk
            // 
            this.btnAdminStudentGroupAssignOk.Location = new System.Drawing.Point(58, 339);
            this.btnAdminStudentGroupAssignOk.Name = "btnAdminStudentGroupAssignOk";
            this.btnAdminStudentGroupAssignOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminStudentGroupAssignOk.TabIndex = 13;
            this.btnAdminStudentGroupAssignOk.Text = "Ok";
            this.btnAdminStudentGroupAssignOk.UseVisualStyleBackColor = true;
            this.btnAdminStudentGroupAssignOk.Click += new System.EventHandler(this.btnAdminStudentGroupAssignOk_Click);
            // 
            // btnAdminStudentAssignGroupCancel
            // 
            this.btnAdminStudentAssignGroupCancel.Location = new System.Drawing.Point(272, 339);
            this.btnAdminStudentAssignGroupCancel.Name = "btnAdminStudentAssignGroupCancel";
            this.btnAdminStudentAssignGroupCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminStudentAssignGroupCancel.TabIndex = 16;
            this.btnAdminStudentAssignGroupCancel.Text = "Cancel";
            this.btnAdminStudentAssignGroupCancel.UseVisualStyleBackColor = true;
            this.btnAdminStudentAssignGroupCancel.Click += new System.EventHandler(this.btnAdminStudentAssignGroupCancel_Click);
            // 
            // listAdminStudentGroups
            // 
            this.listAdminStudentGroups.FormattingEnabled = true;
            this.listAdminStudentGroups.ItemHeight = 16;
            this.listAdminStudentGroups.Location = new System.Drawing.Point(58, 57);
            this.listAdminStudentGroups.Name = "listAdminStudentGroups";
            this.listAdminStudentGroups.Size = new System.Drawing.Size(295, 276);
            this.listAdminStudentGroups.TabIndex = 20;
            // 
            // AdminStudentAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.listAdminStudentGroups);
            this.Controls.Add(this.btnAdminStudentAssignGroupCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminStudentGroupAssignOk);
            this.Name = "AdminStudentAddGroup";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminStudentGroupAssignOk;
        private System.Windows.Forms.Button btnAdminStudentAssignGroupCancel;
        private System.Windows.Forms.ListBox listAdminStudentGroups;
    }
}