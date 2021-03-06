namespace CapstoneProject.Controls.Laboratory_ctrls
{
    partial class UserControl_PcSpecsItem
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
            this.lbl_video = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_motherboard = new System.Windows.Forms.Label();
            this.lbl_processor = new System.Windows.Forms.Label();
            this.lbl_ctr = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.lbl_code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.lbl_video);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.lbl_motherboard);
            this.panel1.Controls.Add(this.lbl_processor);
            this.panel1.Controls.Add(this.lbl_ctr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 66);
            this.panel1.TabIndex = 1;
            // 
            // lbl_video
            // 
            this.lbl_video.AutoEllipsis = true;
            this.lbl_video.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_video.ForeColor = System.Drawing.Color.Gray;
            this.lbl_video.Location = new System.Drawing.Point(412, 12);
            this.lbl_video.Name = "lbl_video";
            this.lbl_video.Size = new System.Drawing.Size(140, 46);
            this.lbl_video.TabIndex = 5;
            this.lbl_video.Text = "label3";
            this.lbl_video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // lbl_motherboard
            // 
            this.lbl_motherboard.AutoEllipsis = true;
            this.lbl_motherboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motherboard.ForeColor = System.Drawing.Color.Gray;
            this.lbl_motherboard.Location = new System.Drawing.Point(267, 12);
            this.lbl_motherboard.Name = "lbl_motherboard";
            this.lbl_motherboard.Size = new System.Drawing.Size(126, 46);
            this.lbl_motherboard.TabIndex = 2;
            this.lbl_motherboard.Text = "label4";
            this.lbl_motherboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_processor
            // 
            this.lbl_processor.AutoEllipsis = true;
            this.lbl_processor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_processor.ForeColor = System.Drawing.Color.Gray;
            this.lbl_processor.Location = new System.Drawing.Point(127, 12);
            this.lbl_processor.Name = "lbl_processor";
            this.lbl_processor.Size = new System.Drawing.Size(123, 46);
            this.lbl_processor.TabIndex = 1;
            this.lbl_processor.Text = "label2";
            this.lbl_processor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ctr
            // 
            this.lbl_ctr.AutoSize = true;
            this.lbl_ctr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ctr.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ctr.Location = new System.Drawing.Point(20, 26);
            this.lbl_ctr.Name = "lbl_ctr";
            this.lbl_ctr.Size = new System.Drawing.Size(48, 20);
            this.lbl_ctr.TabIndex = 0;
            this.lbl_ctr.Text = "label1";
            this.lbl_ctr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.xuiButton1.Location = new System.Drawing.Point(588, 26);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(20, 20);
            this.xuiButton1.TabIndex = 4;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xuiButton1_MouseClick);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Gray;
            this.lbl_code.Location = new System.Drawing.Point(70, 27);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(48, 20);
            this.lbl_code.TabIndex = 6;
            this.lbl_code.Text = "label1";
            this.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_PcSpecsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_PcSpecsItem";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(656, 69);
            this.Load += new System.EventHandler(this.UserControl_PcSpecsItem_Load);
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
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Label lbl_motherboard;
        private System.Windows.Forms.Label lbl_processor;
        private System.Windows.Forms.Label lbl_ctr;
        private System.Windows.Forms.Label lbl_video;
        private System.Windows.Forms.Label lbl_code;
    }
}
