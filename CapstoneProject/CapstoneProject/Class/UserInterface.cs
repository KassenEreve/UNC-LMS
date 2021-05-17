using CapstoneProject.Controls;
using CapstoneProject.Controls.First_Setup;
using CapstoneProject.Controls.Laboratory_ctrls;
using CapstoneProject.Controls.User_ctrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject.Class
{
    public class UserInterface
    {
        public  UserControl_LoginPage userControl_LoginPage;
        public  UserControl_mainWindow userControl_MainWindow;
        public UserControl_LabList userControl_LabList;
        public UserControl_AddLab userControl_AddLab;
        public UserControl_EquipmentType userControl_EquipmentType;
        public UserControl_AddEquipmentType userControl_AddEquipmentType;
        public UserControl_PcSpecsList userControl_PcSpecsList;
        public UserControl_AddPCSpecs userControl_AddPCSpecs;
        public UserControl_ViewLab userControl_ViewLab;
        public UserControl_AddLabEquipment userControl_AddLabEquipment;
        public UserControl_TechnicianList userControl_TechnicianList;
        public UserControl_AddTechnician userControl_AddTechnician;
        public UserControl_ViewLabEquipments userControl_ViewLabEquipments;
        public UserControl_SoftwareList userControl_SoftwareList;
        public UserControl_AddSoftware userControl_AddSoftware;
        public UserControl_SetSpecification userControl_SetSpecification;
        public UserControl_SoftwareGroupList userControl_SoftwareGroupList;
        public UserControl_AddSoftwareGroup userControl_AddSoftwareGroup;
        public UserControl_SetSoftwareGroup userControl_SetSoftwareGroup;

        //first run
        public UserControl_FirstRun userControl_FirstRun;


        private static UserInterface instance;

        public static Timer timer;
        private static bool isCollapsed;
        public static XanderUI.XUIButton button;
        private UserInterface()
        {
            initialize();
        }

        //singleton
        public static UserInterface GetInstance()
        {
            if (instance == null)
            {
                instance = new UserInterface();
            }
            return instance;
        }
        public  void initialize()
        {
            userControl_LoginPage = new UserControl_LoginPage();
            userControl_LoginPage.Dock = DockStyle.Fill;


            userControl_MainWindow = new UserControl_mainWindow();
            userControl_MainWindow.Dock = DockStyle.Fill;

            userControl_LabList = new UserControl_LabList();
            userControl_LabList.Dock = DockStyle.Fill;

            userControl_AddLab = new UserControl_AddLab();
            userControl_AddLab.Dock = DockStyle.Fill;

            userControl_EquipmentType = new UserControl_EquipmentType();
            userControl_EquipmentType.Dock = DockStyle.Fill;

            userControl_AddEquipmentType = new UserControl_AddEquipmentType();
            userControl_AddEquipmentType.Dock = DockStyle.Fill;

            userControl_PcSpecsList = new UserControl_PcSpecsList();
            userControl_PcSpecsList.Dock = DockStyle.Fill;

            userControl_AddPCSpecs = new UserControl_AddPCSpecs();
            userControl_AddPCSpecs.Dock = DockStyle.Fill;

            userControl_ViewLab = new UserControl_ViewLab();
            userControl_ViewLab.Dock = DockStyle.Fill;

            userControl_AddLabEquipment = new UserControl_AddLabEquipment();
            userControl_AddLabEquipment.Dock = DockStyle.Fill;

            userControl_TechnicianList = new UserControl_TechnicianList();
            userControl_TechnicianList.Dock = DockStyle.Fill;

            userControl_AddTechnician = new UserControl_AddTechnician();
            userControl_AddTechnician.Dock = DockStyle.Fill;

            userControl_FirstRun = new UserControl_FirstRun();
            userControl_FirstRun.Dock = DockStyle.Fill;

            userControl_ViewLabEquipments = new UserControl_ViewLabEquipments();
            userControl_ViewLabEquipments.Dock = DockStyle.Fill;

            userControl_SoftwareList = new UserControl_SoftwareList();
            userControl_SoftwareList.Dock = DockStyle.Fill;

            userControl_AddSoftware = new UserControl_AddSoftware();
            userControl_AddSoftware.Dock = DockStyle.Fill;

            userControl_SetSpecification = new UserControl_SetSpecification();
            userControl_SetSpecification.Dock = DockStyle.Fill;

            userControl_SoftwareGroupList = new UserControl_SoftwareGroupList();
            userControl_SoftwareGroupList.Dock = DockStyle.Fill;

            userControl_AddSoftwareGroup = new UserControl_AddSoftwareGroup();
            userControl_AddSoftwareGroup.Dock = DockStyle.Fill;

            userControl_SetSoftwareGroup = new UserControl_SetSoftwareGroup();
            userControl_SetSoftwareGroup.Dock = DockStyle.Fill;

            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += new System.EventHandler(timer_Tick);
            
        }


        private static void timer_Tick(object sender, EventArgs e)
        {
           
         
           
            if (!isCollapsed)
            {

                
                button.Parent.Height += 10;
                if (button.Parent.Size == button.Parent.MaximumSize)
                {
                    timer.Stop();

                    isCollapsed = true;
                }
            }
            else
            {
               
                button.Parent.Height -= 10;
                if (button.Parent.Size == button.Parent.MinimumSize)
                {


                    timer.Stop();
                    isCollapsed = false;
                }

            }
        }
    }
}
