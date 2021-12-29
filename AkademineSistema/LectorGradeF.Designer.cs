
namespace AkademineSistema
{
    partial class LectorGradeF
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
            this.btnLectorBack = new System.Windows.Forms.Button();
            this.btnLectorAdd = new System.Windows.Forms.Button();
            this.listLectorStudentGrade = new System.Windows.Forms.ListBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLectorDeleteGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLectorBack
            // 
            this.btnLectorBack.Location = new System.Drawing.Point(269, 370);
            this.btnLectorBack.Name = "btnLectorBack";
            this.btnLectorBack.Size = new System.Drawing.Size(88, 33);
            this.btnLectorBack.TabIndex = 6;
            this.btnLectorBack.Text = "Back";
            this.btnLectorBack.UseVisualStyleBackColor = true;
            this.btnLectorBack.Click += new System.EventHandler(this.btnLectorBack_Click);
            // 
            // btnLectorAdd
            // 
            this.btnLectorAdd.Location = new System.Drawing.Point(62, 331);
            this.btnLectorAdd.Name = "btnLectorAdd";
            this.btnLectorAdd.Size = new System.Drawing.Size(88, 33);
            this.btnLectorAdd.TabIndex = 7;
            this.btnLectorAdd.Text = "Add Grade";
            this.btnLectorAdd.UseVisualStyleBackColor = true;
            this.btnLectorAdd.Click += new System.EventHandler(this.btnLectorAdd_Click);
            // 
            // listLectorStudentGrade
            // 
            this.listLectorStudentGrade.FormattingEnabled = true;
            this.listLectorStudentGrade.ItemHeight = 16;
            this.listLectorStudentGrade.Location = new System.Drawing.Point(62, 81);
            this.listLectorStudentGrade.Name = "listLectorStudentGrade";
            this.listLectorStudentGrade.Size = new System.Drawing.Size(295, 244);
            this.listLectorStudentGrade.TabIndex = 9;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(58, 37);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(60, 24);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID - Source - Grade - Date";
            // 
            // btnLectorDeleteGrade
            // 
            this.btnLectorDeleteGrade.Location = new System.Drawing.Point(269, 331);
            this.btnLectorDeleteGrade.Name = "btnLectorDeleteGrade";
            this.btnLectorDeleteGrade.Size = new System.Drawing.Size(88, 33);
            this.btnLectorDeleteGrade.TabIndex = 35;
            this.btnLectorDeleteGrade.Text = "Delete";
            this.btnLectorDeleteGrade.UseVisualStyleBackColor = true;
            this.btnLectorDeleteGrade.Click += new System.EventHandler(this.btnLectorDeleteGrade_Click);
            // 
            // LectorGradeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 412);
            this.Controls.Add(this.btnLectorDeleteGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.listLectorStudentGrade);
            this.Controls.Add(this.btnLectorAdd);
            this.Controls.Add(this.btnLectorBack);
            this.Name = "LectorGradeF";
            this.Text = "Lector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLectorBack;
        private System.Windows.Forms.Button btnLectorAdd;
        private System.Windows.Forms.ListBox listLectorStudentGrade;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLectorDeleteGrade;
    }
}