namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    partial class UserControl_ViewMaintenanceHistoryItem
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
            this.btn_indicator = new XanderUI.XUIButton();
            this.lbl_technician = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_ctr = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_description);
            this.panel1.Controls.Add(this.btn_indicator);
            this.panel1.Controls.Add(this.lbl_technician);
            this.panel1.Controls.Add(this.lbl_level);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_ctr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 66);
            this.panel1.TabIndex = 5;
            // 
            // btn_indicator
            // 
            this.btn_indicator.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_indicator.ButtonImage = null;
            this.btn_indicator.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_indicator.ButtonText = "";
            this.btn_indicator.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_indicator.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.CornerRadius = 8;
            this.btn_indicator.Enabled = false;
            this.btn_indicator.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_indicator.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_indicator.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_indicator.Location = new System.Drawing.Point(96, 30);
            this.btn_indicator.Name = "btn_indicator";
            this.btn_indicator.Size = new System.Drawing.Size(17, 14);
            this.btn_indicator.TabIndex = 8;
            this.btn_indicator.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_technician
            // 
            this.lbl_technician.AutoEllipsis = true;
            this.lbl_technician.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_technician.ForeColor = System.Drawing.Color.Gray;
            this.lbl_technician.Location = new System.Drawing.Point(235, 12);
            this.lbl_technician.Name = "lbl_technician";
            this.lbl_technician.Size = new System.Drawing.Size(102, 46);
            this.lbl_technician.TabIndex = 5;
            this.lbl_technician.Text = "label3";
            this.lbl_technician.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoEllipsis = true;
            this.lbl_level.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ForeColor = System.Drawing.Color.Gray;
            this.lbl_level.Location = new System.Drawing.Point(120, 12);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(114, 46);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "label4";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoEllipsis = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_date.Location = new System.Drawing.Point(362, 12);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(117, 46);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "label2";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ctr
            // 
            this.lbl_ctr.AutoSize = true;
            this.lbl_ctr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ctr.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ctr.Location = new System.Drawing.Point(30, 26);
            this.lbl_ctr.Name = "lbl_ctr";
            this.lbl_ctr.Size = new System.Drawing.Size(48, 20);
            this.lbl_ctr.TabIndex = 0;
            this.lbl_ctr.Text = "label1";
            this.lbl_ctr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoEllipsis = true;
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Gray;
            this.lbl_description.Location = new System.Drawing.Point(494, 13);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(132, 46);
            this.lbl_description.TabIndex = 9;
            this.lbl_description.Text = "label2";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_ViewMaintenanceHistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_ViewMaintenanceHistoryItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(656, 69);
            this.Load += new System.EventHandler(this.UserControl_ViewMaintenanceHistoryItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btn_indicator;
        private System.Windows.Forms.Label lbl_technician;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_ctr;
        private System.Windows.Forms.Label lbl_description;
    }
}
