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
        public UserControl_AddLab UserControl_AddLab;

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
            userControl_LoginPage.Dock = System.Windows.Forms.DockStyle.Fill;


            userControl_MainWindow = new UserControl_mainWindow();
            userControl_MainWindow.Dock = System.Windows.Forms.DockStyle.Fill;

            userControl_LabList = new UserControl_LabList();
            userControl_LabList.Dock = System.Windows.Forms.DockStyle.Fill;

            UserControl_AddLab = new UserControl_AddLab();
            UserControl_AddLab.Dock = System.Windows.Forms.DockStyle.Fill;

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
