
namespace AkademineSistema
{
    partial class LectorMainF
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
            this.cmbLectorGroup = new System.Windows.Forms.ComboBox();
            this.btnLectorGroupSelect = new System.Windows.Forms.Button();
            this.listLectorStudent = new System.Windows.Forms.ListBox();
            this.lblLectorChoose = new System.Windows.Forms.Label();
            this.btnLectorSelectStudent = new System.Windows.Forms.Button();
            this.lblLectorChooseSubject = new System.Windows.Forms.Label();
            this.btnLectorSubjectSelect = new System.Windows.Forms.Button();
            this.cmbLectorSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLectorGroup
            // 
            this.cmbLectorGroup.FormattingEnabled = true;
            this.cmbLectorGroup.Location = new System.Drawing.Point(62, 95);
            this.cmbLectorGroup.Name = "cmbLectorGroup";
            this.cmbLectorGroup.Size = new System.Drawing.Size(209, 24);
            this.cmbLectorGroup.TabIndex = 0;
            // 
            // btnLectorGroupSelect
            // 
            this.btnLectorGroupSelect.Location = new System.Drawing.Point(278, 95);
            this.btnLectorGroupSelect.Name = "btnLectorGroupSelect";
            this.btnLectorGroupSelect.Size = new System.Drawing.Size(80, 24);
            this.btnLectorGroupSelect.TabIndex = 1;
            this.btnLectorGroupSelect.Text = "Select";
            this.btnLectorGroupSelect.UseVisualStyleBackColor = true;
            this.btnLectorGroupSelect.Click += new System.EventHandler(this.btnLectorGroupSelect_Click);
            // 
            // listLectorStudent
            // 
            this.listLectorStudent.FormattingEnabled = true;
            this.listLectorStudent.ItemHeight = 16;
            this.listLectorStudent.Location = new System.Drawing.Point(62, 142);
            this.listLectorStudent.Name = "listLectorStudent";
            this.listLectorStudent.Size = new System.Drawing.Size(296, 244);
            this.listLectorStudent.TabIndex = 2;
            // 
            // lblLectorChoose
            // 
            this.lblLectorChoose.AutoSize = true;
            this.lblLectorChoose.Location = new System.Drawing.Point(59, 75);
            this.lblLectorChoose.Name = "lblLectorChoose";
            this.lblLectorChoose.Size = new System.Drawing.Size(100, 17);
            this.lblLectorChoose.TabIndex = 3;
            this.lblLectorChoose.Text = "Choose Group";
            // 
            // btnLectorSelectStudent
            // 
            this.btnLectorSelectStudent.Location = new System.Drawing.Point(167, 392);
            this.btnLectorSelectStudent.Name = "btnLectorSelectStudent";
            this.btnLectorSelectStudent.Size = new System.Drawing.Size(108, 31);
            this.btnLectorSelectStudent.TabIndex = 4;
            this.btnLectorSelectStudent.Text = "Select Student";
            this.btnLectorSelectStudent.UseVisualStyleBackColor = true;
            this.btnLectorSelectStudent.Click += new System.EventHandler(this.btnLectorSelectStudent_Click);
            // 
            // lblLectorChooseSubject
            // 
            this.lblLectorChooseSubject.AutoSize = true;
            this.lblLectorChooseSubject.Location = new System.Drawing.Point(59, 28);
            this.lblLectorChooseSubject.Name = "lblLectorChooseSubject";
            this.lblLectorChooseSubject.Size = new System.Drawing.Size(107, 17);
            this.lblLectorChooseSubject.TabIndex = 8;
            this.lblLectorChooseSubject.Text = "Choose Subject";
            // 
            // btnLectorSubjectSelect
            // 
            this.btnLectorSubjectSelect.Location = new System.Drawing.Point(278, 48);
            this.btnLectorSubjectSelect.Name = "btnLectorSubjectSelect";
            this.btnLectorSubjectSelect.Size = new System.Drawing.Size(80, 24);
            this.btnLectorSubjectSelect.TabIndex = 7;
            this.btnLectorSubjectSelect.Text = "Select";
            this.btnLectorSubjectSelect.UseVisualStyleBackColor = true;
            this.btnLectorSubjectSelect.Click += new System.EventHandler(this.btnLectorSubjectSelect_Click);
            // 
            // cmbLectorSubject
            // 
            this.cmbLectorSubject.FormattingEnabled = true;
            this.cmbLectorSubject.Location = new System.Drawing.Point(62, 48);
            this.cmbLectorSubject.Name = "cmbLectorSubject";
            this.cmbLectorSubject.Size = new System.Drawing.Size(209, 24);
            this.cmbLectorSubject.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID - Name - Surname - GroupID - AdminID ";
            // 
            // LectorMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLectorChooseSubject);
            this.Controls.Add(this.btnLectorSubjectSelect);
            this.Controls.Add(this.cmbLectorSubject);
            this.Controls.Add(this.btnLectorSelectStudent);
            this.Controls.Add(this.lblLectorChoose);
            this.Controls.Add(this.listLectorStudent);
            this.Controls.Add(this.btnLectorGroupSelect);
            this.Controls.Add(this.cmbLectorGroup);
            this.Name = "LectorMainF";
            this.Text = "Lector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LectorMainF_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLectorGroup;
        private System.Windows.Forms.Button btnLectorGroupSelect;
        private System.Windows.Forms.ListBox listLectorStudent;
        private System.Windows.Forms.Label lblLectorChoose;
        private System.Windows.Forms.Button btnLectorSelectStudent;
        private System.Windows.Forms.Label lblLectorChooseSubject;
        private System.Windows.Forms.Button btnLectorSubjectSelect;
        private System.Windows.Forms.ComboBox cmbLectorSubject;
        private System.Windows.Forms.Label label1;
    }
}