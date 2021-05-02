using CapstoneProject.Controls;
using CapstoneProject.Controls.Laboratory_ctrls;
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
