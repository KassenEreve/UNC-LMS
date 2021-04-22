using CapstoneProject.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class UserInterface
    {
        public  UserControl_LoginPage userControl_LoginPage;
        public  UserControl_mainWindow userControl_MainWindow;
        public UserControl_LabList userControl_LabList;

        public static UserInterface instance;
     
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
        }
    }
}
