
namespace AkademineSistema
{
    partial class AdminSubjectAdd
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
            this.btnAdminSubjectAddCancel = new System.Windows.Forms.Button();
            this.btnAdminSubjectAddOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminSubjetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdminSubjectAddCancel
            // 
            this.btnAdminSubjectAddCancel.Location = new System.Drawing.Point(127, 83);
            this.btnAdminSubjectAddCancel.Name = "btnAdminSubjectAddCancel";
            this.btnAdminSubjectAddCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectAddCancel.TabIndex = 19;
            this.btnAdminSubjectAddCancel.Text = "Cancel";
            this.btnAdminSubjectAddCancel.UseVisualStyleBackColor = true;
            this.btnAdminSubjectAddCancel.Click += new System.EventHandler(this.btnAdminSubjectAddCancel_Click);
            // 
            // btnAdminSubjectAddOk
            // 
            this.btnAdminSubjectAddOk.Location = new System.Drawing.Point(40, 83);
            this.btnAdminSubjectAddOk.Name = "btnAdminSubjectAddOk";
            this.btnAdminSubjectAddOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminSubjectAddOk.TabIndex = 15;
            this.btnAdminSubjectAddOk.Text = "Ok";
            this.btnAdminSubjectAddOk.UseVisualStyleBackColor = true;
            this.btnAdminSubjectAddOk.Click += new System.EventHandler(this.btnAdminSubjectAddOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Subject name";
            // 
            // txtAdminSubjetName
            // 
            this.txtAdminSubjetName.Location = new System.Drawing.Point(40, 55);
            this.txtAdminSubjetName.Name = "txtAdminSubjetName";
            this.txtAdminSubjetName.Size = new System.Drawing.Size(168, 22);
            this.txtAdminSubjetName.TabIndex = 22;
            // 
            // AdminSubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 147);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdminSubjetName);
            this.Controls.Add(this.btnAdminSubjectAddCancel);
            this.Controls.Add(this.btnAdminSubjectAddOk);
            this.Name = "AdminSubjectAdd";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminSubjectAddCancel;
        private System.Windows.Forms.Button btnAdminSubjectAddOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminSubjetName;
    }
}