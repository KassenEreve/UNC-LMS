namespace CapstoneProject.Controls.Technician_ctrls
{
    partial class UserControl_TechnicianComputerLogItem
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
            this.lbl_studentNum = new System.Windows.Forms.Label();
            this.lbl_roomID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_studentNum);
            this.panel1.Controls.Add(this.lbl_roomID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 66);
            this.panel1.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Gray;
            this.lbl_date.Location = new System.Drawing.Point(275, 26);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(51, 20);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "label4";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_studentNum
            // 
            this.lbl_studentNum.AutoSize = true;
            this.lbl_studentNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studentNum.ForeColor = System.Drawing.Color.Gray;
            this.lbl_studentNum.Location = new System.Drawing.Point(131, 26);
            this.lbl_studentNum.Name = "lbl_studentNum";
            this.lbl_studentNum.Size = new System.Drawing.Size(50, 20);
            this.lbl_studentNum.TabIndex = 1;
            this.lbl_studentNum.Text = "label2";
            this.lbl_studentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_roomID
            // 
            this.lbl_roomID.AutoSize = true;
            this.lbl_roomID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_roomID.Location = new System.Drawing.Point(34, 26);
            this.lbl_roomID.Name = "lbl_roomID";
            this.lbl_roomID.Size = new System.Drawing.Size(48, 20);
            this.lbl_roomID.TabIndex = 0;
            this.lbl_roomID.Text = "label1";
            this.lbl_roomID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // UserControl_TechnicianComputerLogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_TechnicianComputerLogItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(439, 69);
            this.Load += new System.EventHandler(this.UserControl_TechnicianComputerLogItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_studentNum;
        private System.Windows.Forms.Label lbl_roomID;
    }
}
