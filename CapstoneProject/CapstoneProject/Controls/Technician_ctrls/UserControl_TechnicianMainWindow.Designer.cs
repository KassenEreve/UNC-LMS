﻿namespace CapstoneProject.Controls.Technician_ctrls
{
    partial class UserControl_TechnicianMainWindow
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
            this.btn_logOut = new XanderUI.XUIButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDownPanel_tools = new System.Windows.Forms.Panel();
            this.btn_Tools = new XanderUI.XUIButton();
            this.dropDownPanel_report = new System.Windows.Forms.Panel();
            this.btn_StudentAssistant = new XanderUI.XUIButton();
            this.btn_Technician = new XanderUI.XUIButton();
            this.btn_User = new XanderUI.XUIButton();
            this.dropDownPanel_lab = new System.Windows.Forms.Panel();
            this.btn_softwareGroup = new XanderUI.XUIButton();
            this.btn_specsList = new XanderUI.XUIButton();
            this.btn_softwares = new XanderUI.XUIButton();
            this.btn_equipmentType = new XanderUI.XUIButton();
            this.btn_labList = new XanderUI.XUIButton();
            this.btn_lab = new XanderUI.XUIButton();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.btn_Main = new XanderUI.XUIButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dropDownPanel_tools.SuspendLayout();
            this.dropDownPanel_report.SuspendLayout();
            this.dropDownPanel_lab.SuspendLayout();
            this.dropDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_logOut.ButtonImage = null;
            this.btn_logOut.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_logOut.ButtonText = "Log Out";
            this.btn_logOut.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_logOut.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_logOut.CornerRadius = 5;
            this.btn_logOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logOut.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_logOut.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_logOut.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_logOut.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_logOut.Location = new System.Drawing.Point(0, 0);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(246, 94);
            this.btn_logOut.TabIndex = 4;
            this.btn_logOut.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_logOut.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(246, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1082, 554);
            this.panel_main.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dropDownPanel_tools);
            this.panel3.Controls.Add(this.dropDownPanel_report);
            this.panel3.Controls.Add(this.dropDownPanel_lab);
            this.panel3.Controls.Add(this.dropDownPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 554);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_logOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.MaximumSize = new System.Drawing.Size(246, 250);
            this.panel1.MinimumSize = new System.Drawing.Size(246, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 97);
            this.panel1.TabIndex = 5;
            // 
            // dropDownPanel_tools
            // 
            this.dropDownPanel_tools.BackColor = System.Drawing.Color.Gainsboro;
            this.dropDownPanel_tools.Controls.Add(this.btn_Tools);
            this.dropDownPanel_tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel_tools.Location = new System.Drawing.Point(0, 291);
            this.dropDownPanel_tools.MaximumSize = new System.Drawing.Size(246, 250);
            this.dropDownPanel_tools.MinimumSize = new System.Drawing.Size(246, 97);
            this.dropDownPanel_tools.Name = "dropDownPanel_tools";
            this.dropDownPanel_tools.Size = new System.Drawing.Size(246, 97);
            this.dropDownPanel_tools.TabIndex = 3;
            // 
            // btn_Tools
            // 
            this.btn_Tools.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Tools.ButtonImage = null;
            this.btn_Tools.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Tools.ButtonText = "Option";
            this.btn_Tools.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_Tools.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Tools.CornerRadius = 5;
            this.btn_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tools.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tools.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Tools.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Tools.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Tools.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Tools.Location = new System.Drawing.Point(0, 0);
            this.btn_Tools.Name = "btn_Tools";
            this.btn_Tools.Size = new System.Drawing.Size(246, 94);
            this.btn_Tools.TabIndex = 2;
            this.btn_Tools.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Tools.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dropDownPanel_report
            // 
            this.dropDownPanel_report.BackColor = System.Drawing.Color.Gainsboro;
            this.dropDownPanel_report.Controls.Add(this.btn_StudentAssistant);
            this.dropDownPanel_report.Controls.Add(this.btn_Technician);
            this.dropDownPanel_report.Controls.Add(this.btn_User);
            this.dropDownPanel_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel_report.Location = new System.Drawing.Point(0, 194);
            this.dropDownPanel_report.MaximumSize = new System.Drawing.Size(246, 300);
            this.dropDownPanel_report.MinimumSize = new System.Drawing.Size(246, 97);
            this.dropDownPanel_report.Name = "dropDownPanel_report";
            this.dropDownPanel_report.Size = new System.Drawing.Size(246, 97);
            this.dropDownPanel_report.TabIndex = 2;
            // 
            // btn_StudentAssistant
            // 
            this.btn_StudentAssistant.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_StudentAssistant.ButtonImage = null;
            this.btn_StudentAssistant.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_StudentAssistant.ButtonText = "Custodian";
            this.btn_StudentAssistant.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_StudentAssistant.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_StudentAssistant.CornerRadius = 5;
            this.btn_StudentAssistant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_StudentAssistant.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_StudentAssistant.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_StudentAssistant.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_StudentAssistant.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_StudentAssistant.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_StudentAssistant.Location = new System.Drawing.Point(0, 188);
            this.btn_StudentAssistant.Name = "btn_StudentAssistant";
            this.btn_StudentAssistant.Size = new System.Drawing.Size(246, 94);
            this.btn_StudentAssistant.TabIndex = 4;
            this.btn_StudentAssistant.TextColor = System.Drawing.Color.Gray;
            this.btn_StudentAssistant.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_Technician
            // 
            this.btn_Technician.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Technician.ButtonImage = null;
            this.btn_Technician.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Technician.ButtonText = "Technician";
            this.btn_Technician.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_Technician.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Technician.CornerRadius = 5;
            this.btn_Technician.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Technician.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_Technician.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Technician.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Technician.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Technician.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_Technician.Location = new System.Drawing.Point(0, 94);
            this.btn_Technician.Name = "btn_Technician";
            this.btn_Technician.Size = new System.Drawing.Size(246, 94);
            this.btn_Technician.TabIndex = 3;
            this.btn_Technician.TextColor = System.Drawing.Color.Gray;
            this.btn_Technician.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_User
            // 
            this.btn_User.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_User.ButtonImage = null;
            this.btn_User.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_User.ButtonText = "Reports";
            this.btn_User.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_User.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_User.CornerRadius = 5;
            this.btn_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_User.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_User.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_User.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_User.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_User.Location = new System.Drawing.Point(0, 0);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(246, 94);
            this.btn_User.TabIndex = 2;
            this.btn_User.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_User.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dropDownPanel_lab
            // 
            this.dropDownPanel_lab.BackColor = System.Drawing.Color.Gainsboro;
            this.dropDownPanel_lab.Controls.Add(this.btn_softwareGroup);
            this.dropDownPanel_lab.Controls.Add(this.btn_specsList);
            this.dropDownPanel_lab.Controls.Add(this.btn_softwares);
            this.dropDownPanel_lab.Controls.Add(this.btn_equipmentType);
            this.dropDownPanel_lab.Controls.Add(this.btn_labList);
            this.dropDownPanel_lab.Controls.Add(this.btn_lab);
            this.dropDownPanel_lab.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel_lab.Location = new System.Drawing.Point(0, 97);
            this.dropDownPanel_lab.MaximumSize = new System.Drawing.Size(246, 570);
            this.dropDownPanel_lab.MinimumSize = new System.Drawing.Size(246, 97);
            this.dropDownPanel_lab.Name = "dropDownPanel_lab";
            this.dropDownPanel_lab.Size = new System.Drawing.Size(246, 97);
            this.dropDownPanel_lab.TabIndex = 1;
            // 
            // btn_softwareGroup
            // 
            this.btn_softwareGroup.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_softwareGroup.ButtonImage = null;
            this.btn_softwareGroup.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_softwareGroup.ButtonText = "Software Group";
            this.btn_softwareGroup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_softwareGroup.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_softwareGroup.CornerRadius = 5;
            this.btn_softwareGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_softwareGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_softwareGroup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_softwareGroup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_softwareGroup.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_softwareGroup.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_softwareGroup.Location = new System.Drawing.Point(0, 470);
            this.btn_softwareGroup.Name = "btn_softwareGroup";
            this.btn_softwareGroup.Size = new System.Drawing.Size(246, 94);
            this.btn_softwareGroup.TabIndex = 6;
            this.btn_softwareGroup.TextColor = System.Drawing.Color.Gray;
            this.btn_softwareGroup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_specsList
            // 
            this.btn_specsList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_specsList.ButtonImage = null;
            this.btn_specsList.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_specsList.ButtonText = "PC Specification";
            this.btn_specsList.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_specsList.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_specsList.CornerRadius = 5;
            this.btn_specsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_specsList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_specsList.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_specsList.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_specsList.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_specsList.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_specsList.Location = new System.Drawing.Point(0, 376);
            this.btn_specsList.Name = "btn_specsList";
            this.btn_specsList.Size = new System.Drawing.Size(246, 94);
            this.btn_specsList.TabIndex = 5;
            this.btn_specsList.TextColor = System.Drawing.Color.Gray;
            this.btn_specsList.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_softwares
            // 
            this.btn_softwares.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_softwares.ButtonImage = null;
            this.btn_softwares.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_softwares.ButtonText = "Softwares";
            this.btn_softwares.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_softwares.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_softwares.CornerRadius = 5;
            this.btn_softwares.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_softwares.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_softwares.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_softwares.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_softwares.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_softwares.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_softwares.Location = new System.Drawing.Point(0, 282);
            this.btn_softwares.Name = "btn_softwares";
            this.btn_softwares.Size = new System.Drawing.Size(246, 94);
            this.btn_softwares.TabIndex = 4;
            this.btn_softwares.TextColor = System.Drawing.Color.Gray;
            this.btn_softwares.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_equipmentType
            // 
            this.btn_equipmentType.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_equipmentType.ButtonImage = null;
            this.btn_equipmentType.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_equipmentType.ButtonText = "Equipment Type";
            this.btn_equipmentType.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_equipmentType.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_equipmentType.CornerRadius = 5;
            this.btn_equipmentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_equipmentType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_equipmentType.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_equipmentType.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_equipmentType.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_equipmentType.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_equipmentType.Location = new System.Drawing.Point(0, 188);
            this.btn_equipmentType.Name = "btn_equipmentType";
            this.btn_equipmentType.Size = new System.Drawing.Size(246, 94);
            this.btn_equipmentType.TabIndex = 3;
            this.btn_equipmentType.TextColor = System.Drawing.Color.Gray;
            this.btn_equipmentType.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_labList
            // 
            this.btn_labList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_labList.ButtonImage = null;
            this.btn_labList.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_labList.ButtonText = "Laboratory";
            this.btn_labList.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_labList.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_labList.CornerRadius = 5;
            this.btn_labList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_labList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_labList.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_labList.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_labList.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_labList.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_labList.Location = new System.Drawing.Point(0, 94);
            this.btn_labList.Name = "btn_labList";
            this.btn_labList.Size = new System.Drawing.Size(246, 94);
            this.btn_labList.TabIndex = 2;
            this.btn_labList.TextColor = System.Drawing.Color.Gray;
            this.btn_labList.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_lab
            // 
            this.btn_lab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_lab.ButtonImage = null;
            this.btn_lab.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_lab.ButtonText = "Maintenance";
            this.btn_lab.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_lab.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_lab.CornerRadius = 5;
            this.btn_lab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lab.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lab.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_lab.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_lab.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_lab.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btn_lab.Location = new System.Drawing.Point(0, 0);
            this.btn_lab.Name = "btn_lab";
            this.btn_lab.Size = new System.Drawing.Size(246, 94);
            this.btn_lab.TabIndex = 1;
            this.btn_lab.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_lab.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.dropDownPanel.Controls.Add(this.btn_Main);
            this.dropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel.Location = new System.Drawing.Point(0, 0);
            this.dropDownPanel.MaximumSize = new System.Drawing.Size(246, 250);
            this.dropDownPanel.MinimumSize = new System.Drawing.Size(246, 97);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(246, 97);
            this.dropDownPanel.TabIndex = 0;
            // 
            // btn_Main
            // 
            this.btn_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Main.ButtonImage = null;
            this.btn_Main.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Main.ButtonText = "Home";
            this.btn_Main.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_Main.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Main.CornerRadius = 5;
            this.btn_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Main.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Main.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Main.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Main.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Main.Location = new System.Drawing.Point(0, 0);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(246, 94);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Main.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // UserControl_TechnicianMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel3);
            this.Name = "UserControl_TechnicianMainWindow";
            this.Size = new System.Drawing.Size(1328, 554);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.dropDownPanel_tools.ResumeLayout(false);
            this.dropDownPanel_report.ResumeLayout(false);
            this.dropDownPanel_lab.ResumeLayout(false);
            this.dropDownPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btn_logOut;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dropDownPanel_tools;
        private XanderUI.XUIButton btn_Tools;
        private System.Windows.Forms.Panel dropDownPanel_report;
        private XanderUI.XUIButton btn_StudentAssistant;
        private XanderUI.XUIButton btn_Technician;
        private XanderUI.XUIButton btn_User;
        private System.Windows.Forms.Panel dropDownPanel_lab;
        private XanderUI.XUIButton btn_softwareGroup;
        private XanderUI.XUIButton btn_specsList;
        private XanderUI.XUIButton btn_softwares;
        private XanderUI.XUIButton btn_equipmentType;
        private XanderUI.XUIButton btn_labList;
        private XanderUI.XUIButton btn_lab;
        private System.Windows.Forms.Panel dropDownPanel;
        private XanderUI.XUIButton btn_Main;
    }
}