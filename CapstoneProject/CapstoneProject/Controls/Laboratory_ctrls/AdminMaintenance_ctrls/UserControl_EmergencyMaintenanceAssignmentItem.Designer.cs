namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    partial class UserControl_EmergencyMaintenanceAssignmentItem
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
            this.lbl_equipment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_pcPart = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_equipment
            // 
            this.lbl_equipment.AutoEllipsis = true;
            this.lbl_equipment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipment.ForeColor = System.Drawing.Color.Gray;
            this.lbl_equipment.Location = new System.Drawing.Point(4, 5);
            this.lbl_equipment.Name = "lbl_equipment";
            this.lbl_equipment.Size = new System.Drawing.Size(166, 46);
            this.lbl_equipment.TabIndex = 6;
            this.lbl_equipment.Text = "label3";
            this.lbl_equipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_pcPart);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.lbl_equipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 50);
            this.panel1.TabIndex = 10;
            // 
            // lbl_pcPart
            // 
            this.lbl_pcPart.AutoEllipsis = true;
            this.lbl_pcPart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcPart.ForeColor = System.Drawing.Color.Gray;
            this.lbl_pcPart.Location = new System.Drawing.Point(168, 4);
            this.lbl_pcPart.Name = "lbl_pcPart";
            this.lbl_pcPart.Size = new System.Drawing.Size(170, 46);
            this.lbl_pcPart.TabIndex = 13;
            this.lbl_pcPart.Text = "label3";
            this.lbl_pcPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoEllipsis = true;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Gray;
            this.lbl_desc.Location = new System.Drawing.Point(342, 4);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(186, 46);
            this.lbl_desc.TabIndex = 12;
            this.lbl_desc.Text = "label3";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_EmergencyMaintenanceAssignmentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_EmergencyMaintenanceAssignmentItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(664, 53);
            this.Load += new System.EventHandler(this.UserControl_EmergencyMaintenanceAssignmentItem_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_equipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_pcPart;
        private System.Windows.Forms.Label lbl_desc;
    }
}
