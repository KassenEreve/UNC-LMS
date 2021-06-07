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

namespace CapstoneProject.Controls.Teacher_ctrls
{
    public partial class UserControl_TeacherMainWindow : UserControl
    {
        public UserControl_TeacherMainWindow()
        {
            InitializeComponent();
        }

        private void UserControl_TeacherMainWindow_Load(object sender, EventArgs e)
        {
            LoadPanel();
            btn_Main.Tag = 1;
          



            btn_logOut.Tag = 0;


            //click event handler
            btn_Main.Click += Button_Click;



            btn_logOut.Click += Button_Click;
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
                  
                    ui.userControl_TechnicianMaintenance.LoadList();

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
            panel_main.Controls.Add(instance.userControl_TeacherAttendance);

            instance.userControl_TeacherAttendance.BringToFront();
          
           
        }
    }
}
