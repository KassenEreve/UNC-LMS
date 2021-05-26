namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    partial class UserControl_AddMaintenanceStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.lbl_room = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_indicator = new XanderUI.XUIButton();
            this.xuiColorPane1 = new XanderUI.XUIColorPane();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD MAINTENANCE STATUS";
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "BACK";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(654, 389);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(151, 52);
            this.xuiButton2.TabIndex = 15;
            this.xuiButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "SAVE";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(486, 389);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(151, 52);
            this.xuiButton1.TabIndex = 14;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(221, 84);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(403, 34);
            this.textBox_name.TabIndex = 8;
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.ForeColor = System.Drawing.Color.Gray;
            this.lbl_room.Location = new System.Drawing.Point(85, 84);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(73, 28);
            this.lbl_room.TabIndex = 9;
            this.lbl_room.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.xuiColorPane1);
            this.panel1.Controls.Add(this.btn_indicator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_desc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.lbl_room);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 366);
            this.panel1.TabIndex = 16;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(221, 153);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(403, 102);
            this.textBox_desc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(85, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(85, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Indicator :";
            // 
            // btn_indicator
            // 
            this.btn_indicator.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_indicator.ButtonImage = null;
            this.btn_indicator.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_indicator.ButtonText = "";
            this.btn_indicator.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_indicator.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.CornerRadius = 12;
            this.btn_indicator.Enabled = false;
            this.btn_indicator.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_indicator.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_indicator.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_indicator.Location = new System.Drawing.Point(217, 303);
            this.btn_indicator.Name = "btn_indicator";
            this.btn_indicator.Size = new System.Drawing.Size(30, 27);
            this.btn_indicator.TabIndex = 13;
            this.btn_indicator.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_indicator.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiColorPane1
            // 
            this.xuiColorPane1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.xuiColorPane1.Color10 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiColorPane1.Color11 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.xuiColorPane1.Color12 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.xuiColorPane1.Color13 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(54)))));
            this.xuiColorPane1.Color14 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(120)))));
            this.xuiColorPane1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.xuiColorPane1.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(11)))), ((int)(((byte)(56)))));
            this.xuiColorPane1.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.xuiColorPane1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiColorPane1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.xuiColorPane1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiColorPane1.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiColorPane1.Color9 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiColorPane1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiColorPane1.GridColor = System.Drawing.Color.White;
            this.xuiColorPane1.Location = new System.Drawing.Point(322, 289);
            this.xuiColorPane1.Name = "xuiColorPane1";
            this.xuiColorPane1.SelectedColor = System.Drawing.Color.Empty;
            this.xuiColorPane1.ShowGrid = true;
            this.xuiColorPane1.Size = new System.Drawing.Size(175, 50);
            this.xuiColorPane1.TabIndex = 14;
            this.xuiColorPane1.Text = "xuiColorPane1";
            this.xuiColorPane1.Click += new System.EventHandler(this.xuiColorPane1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(204, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Selected";
            // 
            // UserControl_AddMaintenanceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_AddMaintenanceStatus";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(835, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btn_indicator;
        private XanderUI.XUIColorPane xuiColorPane1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
    }
}
