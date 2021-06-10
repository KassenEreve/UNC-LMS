namespace CapstoneProject.Controls
{
    partial class UserControl_LoginPage
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_studentNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_studentLog = new System.Windows.Forms.Panel();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.lbl_lab = new System.Windows.Forms.Label();
            this.lbl_studentNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_studentLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(392, 214);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(262, 34);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(392, 275);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(262, 34);
            this.textBox_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "LOG IN";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(454, 376);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 5;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 36);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_studentNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(213, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 125);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_studentNum
            // 
            this.textBox_studentNum.Location = new System.Drawing.Point(197, 48);
            this.textBox_studentNum.Name = "textBox_studentNum";
            this.textBox_studentNum.Size = new System.Drawing.Size(242, 34);
            this.textBox_studentNum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Number :";
            // 
            // panel_studentLog
            // 
            this.panel_studentLog.Controls.Add(this.lbl_dateTime);
            this.panel_studentLog.Controls.Add(this.lbl_comp);
            this.panel_studentLog.Controls.Add(this.lbl_lab);
            this.panel_studentLog.Controls.Add(this.lbl_studentNum);
            this.panel_studentLog.Controls.Add(this.label4);
            this.panel_studentLog.Controls.Add(this.xuiButton2);
            this.panel_studentLog.Location = new System.Drawing.Point(172, 176);
            this.panel_studentLog.Name = "panel_studentLog";
            this.panel_studentLog.Size = new System.Drawing.Size(716, 269);
            this.panel_studentLog.TabIndex = 8;
            this.panel_studentLog.Visible = false;
            this.panel_studentLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_studentLog_Paint);
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_dateTime.Location = new System.Drawing.Point(62, 91);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(118, 28);
            this.lbl_dateTime.TabIndex = 14;
            this.lbl_dateTime.Text = "DATE/TIME :";
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_comp.Location = new System.Drawing.Point(432, 134);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(122, 28);
            this.lbl_comp.TabIndex = 13;
            this.lbl_comp.Text = "COMPUTER :";
            // 
            // lbl_lab
            // 
            this.lbl_lab.AutoSize = true;
            this.lbl_lab.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_lab.Location = new System.Drawing.Point(62, 142);
            this.lbl_lab.Name = "lbl_lab";
            this.lbl_lab.Size = new System.Drawing.Size(141, 28);
            this.lbl_lab.TabIndex = 12;
            this.lbl_lab.Text = "LABORATORY :";
            // 
            // lbl_studentNum
            // 
            this.lbl_studentNum.AutoSize = true;
            this.lbl_studentNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_studentNum.Location = new System.Drawing.Point(432, 89);
            this.lbl_studentNum.Name = "lbl_studentNum";
            this.lbl_studentNum.Size = new System.Drawing.Size(190, 28);
            this.lbl_studentNum.TabIndex = 11;
            this.lbl_studentNum.Text = "STUDENT NUMBER :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(242, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "LOGGED SUCCESSFULLY";
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "EXIT";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(249, 198);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(200, 50);
            this.xuiButton2.TabIndex = 9;
            this.xuiButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapstoneProject.Properties.Resources._90635670_814557849056726_693252045636894720_n1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(424, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 150);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_studentLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_LoginPage";
            this.Size = new System.Drawing.Size(1039, 483);
            this.Load += new System.EventHandler(this.UserControl_LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_studentLog.ResumeLayout(false);
            this.panel_studentLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_studentNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_studentLog;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.Label lbl_studentNum;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.Label lbl_lab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
