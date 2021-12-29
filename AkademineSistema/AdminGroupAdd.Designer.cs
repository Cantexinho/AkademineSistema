
namespace AkademineSistema
{
    partial class AdminGroupAdd
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
            this.btnAdminGroupCancel = new System.Windows.Forms.Button();
            this.txtAdminGroupAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminGroupOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGroupCancel
            // 
            this.btnAdminGroupCancel.Location = new System.Drawing.Point(145, 88);
            this.btnAdminGroupCancel.Name = "btnAdminGroupCancel";
            this.btnAdminGroupCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminGroupCancel.TabIndex = 19;
            this.btnAdminGroupCancel.Text = "Cancel";
            this.btnAdminGroupCancel.UseVisualStyleBackColor = true;
            this.btnAdminGroupCancel.Click += new System.EventHandler(this.btnAdminGroupCancel_Click);
            // 
            // txtAdminGroupAdd
            // 
            this.txtAdminGroupAdd.Location = new System.Drawing.Point(53, 60);
            this.txtAdminGroupAdd.Name = "txtAdminGroupAdd";
            this.txtAdminGroupAdd.Size = new System.Drawing.Size(173, 22);
            this.txtAdminGroupAdd.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Group name";
            // 
            // btnAdminGroupOk
            // 
            this.btnAdminGroupOk.Location = new System.Drawing.Point(53, 88);
            this.btnAdminGroupOk.Name = "btnAdminGroupOk";
            this.btnAdminGroupOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminGroupOk.TabIndex = 15;
            this.btnAdminGroupOk.Text = "Ok";
            this.btnAdminGroupOk.UseVisualStyleBackColor = true;
            this.btnAdminGroupOk.Click += new System.EventHandler(this.btnAdminGroupOk_Click);
            // 
            // AdminGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 157);
            this.Controls.Add(this.btnAdminGroupCancel);
            this.Controls.Add(this.txtAdminGroupAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdminGroupOk);
            this.Name = "AdminGroupAdd";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGroupCancel;
        private System.Windows.Forms.TextBox txtAdminGroupAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminGroupOk;
    }
}