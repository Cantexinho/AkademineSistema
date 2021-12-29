
namespace AkademineSistema
{
    partial class AdminMainF
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
            this.lblAdminChoose = new System.Windows.Forms.Label();
            this.btnAdminStudents = new System.Windows.Forms.Button();
            this.btnAdminLectors = new System.Windows.Forms.Button();
            this.btnAdminSubjects = new System.Windows.Forms.Button();
            this.btnAdminGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminChoose
            // 
            this.lblAdminChoose.AutoSize = true;
            this.lblAdminChoose.Location = new System.Drawing.Point(77, 56);
            this.lblAdminChoose.Name = "lblAdminChoose";
            this.lblAdminChoose.Size = new System.Drawing.Size(136, 17);
            this.lblAdminChoose.TabIndex = 8;
            this.lblAdminChoose.Text = "Choose What To Do";
            // 
            // btnAdminStudents
            // 
            this.btnAdminStudents.Location = new System.Drawing.Point(80, 76);
            this.btnAdminStudents.Name = "btnAdminStudents";
            this.btnAdminStudents.Size = new System.Drawing.Size(110, 47);
            this.btnAdminStudents.TabIndex = 6;
            this.btnAdminStudents.Text = "Lookup Students";
            this.btnAdminStudents.UseVisualStyleBackColor = true;
            this.btnAdminStudents.Click += new System.EventHandler(this.btnAdminStudents_Click);
            // 
            // btnAdminLectors
            // 
            this.btnAdminLectors.Location = new System.Drawing.Point(196, 76);
            this.btnAdminLectors.Name = "btnAdminLectors";
            this.btnAdminLectors.Size = new System.Drawing.Size(110, 47);
            this.btnAdminLectors.TabIndex = 9;
            this.btnAdminLectors.Text = "Lookup Lectors";
            this.btnAdminLectors.UseVisualStyleBackColor = true;
            this.btnAdminLectors.Click += new System.EventHandler(this.btnAdminLectors_Click);
            // 
            // btnAdminSubjects
            // 
            this.btnAdminSubjects.Location = new System.Drawing.Point(196, 129);
            this.btnAdminSubjects.Name = "btnAdminSubjects";
            this.btnAdminSubjects.Size = new System.Drawing.Size(110, 47);
            this.btnAdminSubjects.TabIndex = 10;
            this.btnAdminSubjects.Text = "Lookup Subjects";
            this.btnAdminSubjects.UseVisualStyleBackColor = true;
            this.btnAdminSubjects.Click += new System.EventHandler(this.btnAdminSubjects_Click);
            // 
            // btnAdminGroups
            // 
            this.btnAdminGroups.Location = new System.Drawing.Point(80, 129);
            this.btnAdminGroups.Name = "btnAdminGroups";
            this.btnAdminGroups.Size = new System.Drawing.Size(110, 47);
            this.btnAdminGroups.TabIndex = 11;
            this.btnAdminGroups.Text = "Lookup Groups";
            this.btnAdminGroups.UseVisualStyleBackColor = true;
            this.btnAdminGroups.Click += new System.EventHandler(this.btnAdminGroups_Click);
            // 
            // AdminMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 232);
            this.Controls.Add(this.btnAdminGroups);
            this.Controls.Add(this.btnAdminSubjects);
            this.Controls.Add(this.btnAdminLectors);
            this.Controls.Add(this.lblAdminChoose);
            this.Controls.Add(this.btnAdminStudents);
            this.Name = "AdminMainF";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainF_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminChoose;
        private System.Windows.Forms.Button btnAdminStudents;
        private System.Windows.Forms.Button btnAdminLectors;
        private System.Windows.Forms.Button btnAdminSubjects;
        private System.Windows.Forms.Button btnAdminGroups;
    }
}