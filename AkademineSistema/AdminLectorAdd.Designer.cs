
namespace AkademineSistema
{
    partial class AdminLectorAdd
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
            this.btnAdminLectorAddCancel = new System.Windows.Forms.Button();
            this.txtAdminLectorSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminLectorAddOk = new System.Windows.Forms.Button();
            this.txtAdminLectorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdminLectorAddCancel
            // 
            this.btnAdminLectorAddCancel.Location = new System.Drawing.Point(137, 121);
            this.btnAdminLectorAddCancel.Name = "btnAdminLectorAddCancel";
            this.btnAdminLectorAddCancel.Size = new System.Drawing.Size(81, 29);
            this.btnAdminLectorAddCancel.TabIndex = 19;
            this.btnAdminLectorAddCancel.Text = "Cancel";
            this.btnAdminLectorAddCancel.UseVisualStyleBackColor = true;
            this.btnAdminLectorAddCancel.Click += new System.EventHandler(this.btnAdminLectorAddCancel_Click);
            // 
            // txtAdminLectorSurname
            // 
            this.txtAdminLectorSurname.Location = new System.Drawing.Point(45, 93);
            this.txtAdminLectorSurname.Name = "txtAdminLectorSurname";
            this.txtAdminLectorSurname.Size = new System.Drawing.Size(173, 22);
            this.txtAdminLectorSurname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // btnAdminLectorAddOk
            // 
            this.btnAdminLectorAddOk.Location = new System.Drawing.Point(45, 121);
            this.btnAdminLectorAddOk.Name = "btnAdminLectorAddOk";
            this.btnAdminLectorAddOk.Size = new System.Drawing.Size(81, 29);
            this.btnAdminLectorAddOk.TabIndex = 15;
            this.btnAdminLectorAddOk.Text = "Ok";
            this.btnAdminLectorAddOk.UseVisualStyleBackColor = true;
            this.btnAdminLectorAddOk.Click += new System.EventHandler(this.btnAdminLectorAddOk_Click);
            // 
            // txtAdminLectorName
            // 
            this.txtAdminLectorName.Location = new System.Drawing.Point(45, 48);
            this.txtAdminLectorName.Name = "txtAdminLectorName";
            this.txtAdminLectorName.Size = new System.Drawing.Size(173, 22);
            this.txtAdminLectorName.TabIndex = 14;
            // 
            // AdminLectorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 178);
            this.Controls.Add(this.btnAdminLectorAddCancel);
            this.Controls.Add(this.txtAdminLectorSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminLectorAddOk);
            this.Controls.Add(this.txtAdminLectorName);
            this.Name = "AdminLectorAdd";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLectorAddCancel;
        private System.Windows.Forms.TextBox txtAdminLectorSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminLectorAddOk;
        private System.Windows.Forms.TextBox txtAdminLectorName;
    }
}