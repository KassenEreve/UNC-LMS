namespace CapstoneProject.Controls.Teacher_ctrls
{
    partial class UserControl_TeacherAttendanceItem
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
            this.lbl_comp = new System.Windows.Forms.Label();
            this.lbl_student = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_student);
            this.panel1.Controls.Add(this.lbl_comp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 101);
            this.panel1.TabIndex = 6;
            // 
            // lbl_comp
            // 
            this.lbl_comp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_comp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_comp.Location = new System.Drawing.Point(0, 0);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(106, 33);
            this.lbl_comp.TabIndex = 0;
            this.lbl_comp.Text = "label1";
            this.lbl_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_student
            // 
            this.lbl_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_student.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_student.Location = new System.Drawing.Point(0, 33);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(106, 33);
            this.lbl_student.TabIndex = 1;
            this.lbl_student.Text = "label1";
            this.lbl_student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_time.Location = new System.Drawing.Point(0, 66);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(106, 33);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "label1";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_TeacherAttendanceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_TeacherAttendanceItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(116, 111);
            this.Load += new System.EventHandler(this.UserControl_TeacherAttendanceItem_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_comp;
    }
}
