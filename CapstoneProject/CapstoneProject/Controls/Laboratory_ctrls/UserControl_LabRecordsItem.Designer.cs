namespace CapstoneProject.Controls.Laboratory_ctrls
{
    partial class UserControl_LabRecordsItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_computer = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_student = new System.Windows.Forms.Label();
            this.lbl_ctr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_computer);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_student);
            this.panel1.Controls.Add(this.lbl_ctr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 55);
            this.panel1.TabIndex = 2;
            // 
            // lbl_computer
            // 
            this.lbl_computer.AutoEllipsis = true;
            this.lbl_computer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computer.ForeColor = System.Drawing.Color.Gray;
            this.lbl_computer.Location = new System.Drawing.Point(401, 7);
            this.lbl_computer.Name = "lbl_computer";
            this.lbl_computer.Size = new System.Drawing.Size(140, 46);
            this.lbl_computer.TabIndex = 5;
            this.lbl_computer.Text = "label3";
            this.lbl_computer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoEllipsis = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_date.Location = new System.Drawing.Point(237, 7);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(126, 46);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "label4";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_student
            // 
            this.lbl_student.AutoEllipsis = true;
            this.lbl_student.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.ForeColor = System.Drawing.Color.Gray;
            this.lbl_student.Location = new System.Drawing.Point(82, 7);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(123, 46);
            this.lbl_student.TabIndex = 1;
            this.lbl_student.Text = "label2";
            this.lbl_student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ctr
            // 
            this.lbl_ctr.AutoSize = true;
            this.lbl_ctr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ctr.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ctr.Location = new System.Drawing.Point(33, 21);
            this.lbl_ctr.Name = "lbl_ctr";
            this.lbl_ctr.Size = new System.Drawing.Size(48, 20);
            this.lbl_ctr.TabIndex = 0;
            this.lbl_ctr.Text = "label1";
            this.lbl_ctr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_LabRecordsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_LabRecordsItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(656, 58);
            this.Load += new System.EventHandler(this.UserControl_LabRecordsItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_computer;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_ctr;
    }
}
