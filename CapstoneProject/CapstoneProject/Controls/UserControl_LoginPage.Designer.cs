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
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = true;
            this.xuiCustomPictureBox1.Image = null;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(392, 34);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(222, 150);
            this.xuiCustomPictureBox1.TabIndex = 1;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 34);
            this.textBox2.TabIndex = 4;
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
            // 
            // UserControl_LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xuiCustomPictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_LoginPage";
            this.Size = new System.Drawing.Size(1039, 483);
            this.Load += new System.EventHandler(this.UserControl_LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
