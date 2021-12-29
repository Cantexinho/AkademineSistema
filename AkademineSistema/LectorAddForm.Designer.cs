
namespace AkademineSistema
{
    partial class LectorAddForm
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
            this.btnLectorGradeCancel = new System.Windows.Forms.Button();
            this.btnLectorGradeAdd = new System.Windows.Forms.Button();
            this.lblLectorAddDate = new System.Windows.Forms.Label();
            this.dateLectorAddDate = new System.Windows.Forms.DateTimePicker();
            this.lblLectorAddGrade = new System.Windows.Forms.Label();
            this.txtLectorAddGrade = new System.Windows.Forms.TextBox();
            this.lblLectorAddSource = new System.Windows.Forms.Label();
            this.txtLectorAddSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLectorGradeCancel
            // 
            this.btnLectorGradeCancel.Location = new System.Drawing.Point(198, 135);
            this.btnLectorGradeCancel.Name = "btnLectorGradeCancel";
            this.btnLectorGradeCancel.Size = new System.Drawing.Size(83, 35);
            this.btnLectorGradeCancel.TabIndex = 20;
            this.btnLectorGradeCancel.Text = "Cancel";
            this.btnLectorGradeCancel.UseVisualStyleBackColor = true;
            this.btnLectorGradeCancel.Click += new System.EventHandler(this.btnLectorGradeCancel_Click);
            // 
            // btnLectorGradeAdd
            // 
            this.btnLectorGradeAdd.Location = new System.Drawing.Point(112, 135);
            this.btnLectorGradeAdd.Name = "btnLectorGradeAdd";
            this.btnLectorGradeAdd.Size = new System.Drawing.Size(80, 35);
            this.btnLectorGradeAdd.TabIndex = 19;
            this.btnLectorGradeAdd.Text = "Add";
            this.btnLectorGradeAdd.UseVisualStyleBackColor = true;
            this.btnLectorGradeAdd.Click += new System.EventHandler(this.btnLectorGradeAdd_Click);
            // 
            // lblLectorAddDate
            // 
            this.lblLectorAddDate.AutoSize = true;
            this.lblLectorAddDate.Location = new System.Drawing.Point(34, 69);
            this.lblLectorAddDate.Name = "lblLectorAddDate";
            this.lblLectorAddDate.Size = new System.Drawing.Size(98, 17);
            this.lblLectorAddDate.TabIndex = 18;
            this.lblLectorAddDate.Text = "Date of Grade";
            // 
            // dateLectorAddDate
            // 
            this.dateLectorAddDate.Location = new System.Drawing.Point(138, 64);
            this.dateLectorAddDate.Name = "dateLectorAddDate";
            this.dateLectorAddDate.Size = new System.Drawing.Size(209, 22);
            this.dateLectorAddDate.TabIndex = 17;
            // 
            // lblLectorAddGrade
            // 
            this.lblLectorAddGrade.AutoSize = true;
            this.lblLectorAddGrade.Location = new System.Drawing.Point(84, 95);
            this.lblLectorAddGrade.Name = "lblLectorAddGrade";
            this.lblLectorAddGrade.Size = new System.Drawing.Size(48, 17);
            this.lblLectorAddGrade.TabIndex = 16;
            this.lblLectorAddGrade.Text = "Grade";
            // 
            // txtLectorAddGrade
            // 
            this.txtLectorAddGrade.Location = new System.Drawing.Point(138, 92);
            this.txtLectorAddGrade.Name = "txtLectorAddGrade";
            this.txtLectorAddGrade.Size = new System.Drawing.Size(54, 22);
            this.txtLectorAddGrade.TabIndex = 15;
            // 
            // lblLectorAddSource
            // 
            this.lblLectorAddSource.AutoSize = true;
            this.lblLectorAddSource.Location = new System.Drawing.Point(19, 39);
            this.lblLectorAddSource.Name = "lblLectorAddSource";
            this.lblLectorAddSource.Size = new System.Drawing.Size(113, 17);
            this.lblLectorAddSource.TabIndex = 14;
            this.lblLectorAddSource.Text = "Source of Grade";
            // 
            // txtLectorAddSource
            // 
            this.txtLectorAddSource.Location = new System.Drawing.Point(138, 36);
            this.txtLectorAddSource.Name = "txtLectorAddSource";
            this.txtLectorAddSource.Size = new System.Drawing.Size(209, 22);
            this.txtLectorAddSource.TabIndex = 13;
            // 
            // LectorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 195);
            this.Controls.Add(this.btnLectorGradeCancel);
            this.Controls.Add(this.btnLectorGradeAdd);
            this.Controls.Add(this.lblLectorAddDate);
            this.Controls.Add(this.dateLectorAddDate);
            this.Controls.Add(this.lblLectorAddGrade);
            this.Controls.Add(this.txtLectorAddGrade);
            this.Controls.Add(this.lblLectorAddSource);
            this.Controls.Add(this.txtLectorAddSource);
            this.Name = "LectorAddForm";
            this.Text = "Lector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLectorGradeCancel;
        private System.Windows.Forms.Button btnLectorGradeAdd;
        private System.Windows.Forms.Label lblLectorAddDate;
        private System.Windows.Forms.DateTimePicker dateLectorAddDate;
        private System.Windows.Forms.Label lblLectorAddGrade;
        private System.Windows.Forms.TextBox txtLectorAddGrade;
        private System.Windows.Forms.Label lblLectorAddSource;
        private System.Windows.Forms.TextBox txtLectorAddSource;
    }
}