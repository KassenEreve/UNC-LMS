namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    partial class UserControl_EmergencyMaintenanceItem
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
            this.lbl_custodian = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_laboratory = new System.Windows.Forms.Label();
            this.lbl_reportedItems = new System.Windows.Forms.Label();
            this.lbl_roomID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_custodian);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.lbl_laboratory);
            this.panel1.Controls.Add(this.lbl_reportedItems);
            this.panel1.Controls.Add(this.lbl_roomID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 66);
            this.panel1.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoEllipsis = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_date.Location = new System.Drawing.Point(452, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(125, 48);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "label3";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_custodian
            // 
            this.lbl_custodian.AutoEllipsis = true;
            this.lbl_custodian.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custodian.ForeColor = System.Drawing.Color.Gray;
            this.lbl_custodian.Location = new System.Drawing.Point(320, 9);
            this.lbl_custodian.Name = "lbl_custodian";
            this.lbl_custodian.Size = new System.Drawing.Size(125, 48);
            this.lbl_custodian.TabIndex = 5;
            this.lbl_custodian.Text = "label3";
            this.lbl_custodian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.xuiButton1.Location = new System.Drawing.Point(595, 26);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(20, 20);
            this.xuiButton1.TabIndex = 4;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xuiButton1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.vIEWToolStripMenuItem.Text = "ASSIGNMENT";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // lbl_laboratory
            // 
            this.lbl_laboratory.AutoEllipsis = true;
            this.lbl_laboratory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laboratory.ForeColor = System.Drawing.Color.Gray;
            this.lbl_laboratory.Location = new System.Drawing.Point(210, 11);
            this.lbl_laboratory.Name = "lbl_laboratory";
            this.lbl_laboratory.Size = new System.Drawing.Size(122, 48);
            this.lbl_laboratory.TabIndex = 3;
            this.lbl_laboratory.Text = "label3";
            this.lbl_laboratory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reportedItems
            // 
            this.lbl_reportedItems.AutoEllipsis = true;
            this.lbl_reportedItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportedItems.ForeColor = System.Drawing.Color.Gray;
            this.lbl_reportedItems.Location = new System.Drawing.Point(50, 11);
            this.lbl_reportedItems.Name = "lbl_reportedItems";
            this.lbl_reportedItems.Size = new System.Drawing.Size(197, 48);
            this.lbl_reportedItems.TabIndex = 1;
            this.lbl_reportedItems.Text = "label2";
            this.lbl_reportedItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_roomID
            // 
            this.lbl_roomID.AutoSize = true;
            this.lbl_roomID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_roomID.Location = new System.Drawing.Point(23, 26);
            this.lbl_roomID.Name = "lbl_roomID";
            this.lbl_roomID.Size = new System.Drawing.Size(48, 20);
            this.lbl_roomID.TabIndex = 0;
            this.lbl_roomID.Text = "label1";
            this.lbl_roomID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_EmergencyMaintenanceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_EmergencyMaintenanceItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(656, 69);
            this.Load += new System.EventHandler(this.UserControl_EmergencyMaintenanceItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Label lbl_laboratory;
        private System.Windows.Forms.Label lbl_reportedItems;
        private System.Windows.Forms.Label lbl_roomID;
        private System.Windows.Forms.Label lbl_custodian;
        private System.Windows.Forms.Label lbl_date;
    }
}
