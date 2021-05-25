using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject.Class;
using XanderUI;

namespace CapstoneProject.Controls
{
    public partial class UserControl_mainWindow : UserControl
    {
        public UserControl_mainWindow()
        {
            InitializeComponent();
            
        }

        private void LoadPanel()
        {
            var instance = UserInterface.GetInstance();
            panel_main.Controls.Add(instance.userControl_LabList);
            panel_main.Controls.Add(instance.userControl_AddLab);
            panel_main.Controls.Add(instance.userControl_EquipmentType);
            panel_main.Controls.Add(instance.userControl_AddEquipmentType);
            panel_main.Controls.Add(instance.userControl_PcSpecsList);
            panel_main.Controls.Add(instance.userControl_AddPCSpecs);
            panel_main.Controls.Add(instance.userControl_ViewLab);
            panel_main.Controls.Add(instance.userControl_AddLabEquipment);
            panel_main.Controls.Add(instance.userControl_TechnicianList);
            panel_main.Controls.Add(instance.userControl_AddTechnician);
            panel_main.Controls.Add(instance.userControl_ViewLabEquipments);
            panel_main.Controls.Add(instance.userControl_SoftwareList);
            panel_main.Controls.Add(instance.userControl_AddSoftware);
            panel_main.Controls.Add(instance.userControl_SetSpecification);
            panel_main.Controls.Add(instance.userControl_SoftwareGroupList);
            panel_main.Controls.Add(instance.userControl_AddSoftwareGroup);
            panel_main.Controls.Add(instance.userControl_SetSoftwareGroup);
            panel_main.Controls.Add(instance.userControl_MaintenanceLevel);
            panel_main.Controls.Add(instance.userControl_AddMaintenanceLevel);
        }

        private void UserControl_mainWindow_Load(object sender, EventArgs e)
        {
            LoadPanel();

            btn_lab.Tag = 1;
            btn_labList.Tag = 2;
            btn_equipmentType.Tag =3;
            btn_specsList.Tag = 4;
            btn_User.Tag = 5;
            btn_Technician.Tag = 6;
            btn_StudentAssistant.Tag = 7;
            btn_softwares.Tag = 8;
            btn_softwareGroup.Tag = 9;
            btn_maintenance.Tag = 10;
            btn_maintenanceLevel.Tag = 11;



            btn_logOut.Tag = 0;


            //click event handler
            btn_lab.Click += Button_Click;
            btn_labList.Click += Button_Click;
            btn_equipmentType.Click += Button_Click;
            btn_specsList.Click += Button_Click;
            btn_User.Click += Button_Click;
            btn_Technician.Click += Button_Click;
            btn_StudentAssistant.Click += Button_Click;
            btn_logOut.Click += Button_Click;
            btn_softwares.Click += Button_Click;
            btn_softwareGroup.Click += Button_Click;
            btn_maintenance.Click += Button_Click;
            btn_maintenanceLevel.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int tag=0;
            var ui = UserInterface.GetInstance();


            if (sender is XUIButton)
            {
                var b = sender as XUIButton;
                tag = (int)b.Tag;
            }
           
           
            switch (tag)
            {
                case 0: ui.userControl_LoginPage.BringToFront();
                    break;
                case 1:
                    expandCollapseMenu(sender as XUIButton);



                    break;
                case 2: ui.userControl_LabList.BringToFront();
                    ui.userControl_LabList.LoadList();
                    break;
                case 3:ui.userControl_EquipmentType.BringToFront();
                    ui.userControl_EquipmentType.LoadList();
                    break;
                case 4: ui.userControl_PcSpecsList.BringToFront();
                    ui.userControl_PcSpecsList.LoadList();
                    break;
                case 5: expandCollapseMenu(sender as XUIButton);
                    break;
                case 6: ui.userControl_TechnicianList.BringToFront();
                    ui.userControl_TechnicianList.LoadList();
                    break;
                case 7:
                    break;
                case 8: ui.userControl_SoftwareList.BringToFront();
                    ui.userControl_SoftwareList.LoadList();
                    break;
                case 9:ui.userControl_SoftwareGroupList.BringToFront();
                    ui.userControl_SoftwareGroupList.LoadList();
                    break;
                case 10: expandCollapseMenu(sender as XUIButton);
                    break;
                case 11: ui.userControl_MaintenanceLevel.BringToFront();
                    ui.userControl_MaintenanceLevel.LoadList();
                    break;




            }
        }
        private void expandCollapseMenu(XUIButton btn)
        {
            UserInterface.button = btn;
            UserInterface.timer.Start();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Technician_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
