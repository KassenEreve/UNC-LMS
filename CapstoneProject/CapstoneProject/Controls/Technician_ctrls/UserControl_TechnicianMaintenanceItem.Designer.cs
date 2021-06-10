namespace CapstoneProject.Controls.Technician_ctrls
{
    partial class UserControl_TechnicianMaintenanceItem
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_items = new System.Windows.Forms.Label();
            this.lbl_ctr = new System.Windows.Forms.Label();
            this.lbl_lab = new System.Windows.Forms.Label();
            this.btn_indicator = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_indicator);
            this.panel1.Controls.Add(this.lbl_lab);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.lbl_level);
            this.panel1.Controls.Add(this.lbl_items);
            this.panel1.Controls.Add(this.lbl_ctr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 66);
            this.panel1.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoEllipsis = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_date.Location = new System.Drawing.Point(442, 12);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(136, 46);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "label3";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = global::CapstoneProject.Properties.Resources.Untitled_1;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.xuiButton1.Location = new System.Drawing.Point(596, 26);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(20, 20);
            this.xuiButton1.TabIndex = 4;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoEllipsis = true;
            this.lbl_level.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ForeColor = System.Drawing.Color.Gray;
            this.lbl_level.Location = new System.Drawing.Point(345, 12);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(114, 46);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "label4";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_items
            // 
            this.lbl_items.AutoEllipsis = true;
            this.lbl_items.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items.ForeColor = System.Drawing.Color.Gray;
            this.lbl_items.Location = new System.Drawing.Point(91, 12);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(123, 46);
            this.lbl_items.TabIndex = 1;
            this.lbl_items.Text = "label2";
            this.lbl_items.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ctr
            // 
            this.lbl_ctr.AutoSize = true;
            this.lbl_ctr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ctr.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ctr.Location = new System.Drawing.Point(36, 26);
            this.lbl_ctr.Name = "lbl_ctr";
            this.lbl_ctr.Size = new System.Drawing.Size(48, 20);
            this.lbl_ctr.TabIndex = 0;
            this.lbl_ctr.Text = "label1";
            this.lbl_ctr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lab
            // 
            this.lbl_lab.AutoEllipsis = true;
            this.lbl_lab.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lab.ForeColor = System.Drawing.Color.Gray;
            this.lbl_lab.Location = new System.Drawing.Point(220, 12);
            this.lbl_lab.Name = "lbl_lab";
            this.lbl_lab.Size = new System.Drawing.Size(73, 46);
            this.lbl_lab.TabIndex = 6;
            this.lbl_lab.Text = "label2";
            this.lbl_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_indicator.Location = new System.Drawing.Point(320, 30);
            this.btn_indicator.Name = "btn_indicator";
            this.btn_indicator.Size = new System.Drawing.Size(17, 14);
            this.btn_indicator.TabIndex = 8;
            this.btn_indicator.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // UserControl_TechnicianMaintenanceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_TechnicianMaintenanceItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(656, 69);
            this.Load += new System.EventHandler(this.UserControl_TechnicianMaintenanceItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Label lbl_ctr;
        private System.Windows.Forms.Label lbl_lab;
        private XanderUI.XUIButton btn_indicator;
    }
}
