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

namespace CapstoneProject.Controls.Technician_ctrls
{
    public partial class UserControl_TechnicianMainWindow : UserControl
    {
        Technician current_technician;
        public UserControl_TechnicianMainWindow()
        {
            InitializeComponent();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_LoginPage.BringToFront();
        }

        private void UserControl_TechnicianMainWindow_Load(object sender, EventArgs e)
        {
            

            btn_Main.Tag= 1;
            btn_computer.Tag = 2;
            btn_maintenance.Tag = 3;
            btn_mainteList.Tag = 4;
         


            btn_logOut.Tag = 0;


            //click event handler
            btn_Main.Click += Button_Click;
         


            btn_logOut.Click += Button_Click;
            btn_computer.Click += Button_Click;
            btn_maintenance.Click += Button_Click;
            btn_mainteList.Click += Button_Click;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            int tag = 0;
            var ui = UserInterface.GetInstance();


            if (sender is XUIButton)
            {
                var b = sender as XUIButton;
                tag = (int)b.Tag;
            }


            switch (tag)
            {
                case 0:
                    ui.userControl_LoginPage.BringToFront();
                    break;
                case 1:
                    expandCollapseMenu(sender as XUIButton);



                    break;
                case 2:
                    ui.userControl_TechnicianComputer.BringToFront();
                    ui.userControl_TechnicianComputer.LoadList();
                    break;
                case 3:
                    expandCollapseMenu(sender as XUIButton);
                    break;
                case 4:
                    ui.userControl_TechnicianMaintenance.BringToFront();
                    ui.userControl_TechnicianMaintenance.Login(current_technician);
                    ui.userControl_TechnicianMaintenance.LoadList();
                    
                    break;
                case 5:
                    expandCollapseMenu(sender as XUIButton);
                    break;
                case 6:
                    ui.userControl_TechnicianList.BringToFront();
                    ui.userControl_TechnicianList.LoadList();
                    break;
                case 7:
                    break;
                case 8:
                    ui.userControl_SoftwareList.BringToFront();
                    ui.userControl_SoftwareList.LoadList();
                    break;
                case 9:
                    ui.userControl_SoftwareGroupList.BringToFront();
                    ui.userControl_SoftwareGroupList.LoadList();
                    break;




            }
        }
        private void expandCollapseMenu(XUIButton btn)
        {
            UserInterface.button = btn;
            UserInterface.timer.Start();
        }

        private void LoadPanel()
        {
            var instance = UserInterface.GetInstance();
            panel_main.Controls.Add(instance.userControl_TechnicianComputer);
            panel_main.Controls.Add(instance.userControl_TechnicianMaintenance);
            panel_main.Controls.Add(instance.userControl_TechnicianViewAssignment);
            instance.userControl_TechnicianComputer.Login(current_technician);
        }

        internal void Login(Technician technician)
        {
            current_technician = technician;
            LoadPanel();
        }
    }
}
