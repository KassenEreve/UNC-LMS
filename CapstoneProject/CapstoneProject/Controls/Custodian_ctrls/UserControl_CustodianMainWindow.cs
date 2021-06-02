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

namespace CapstoneProject.Controls.Custodian_ctrls
{
    public partial class UserControl_CustodianMainWindow : UserControl
    {
        Custodian current_custodian;
        public UserControl_CustodianMainWindow()
        {
            InitializeComponent();
        }

        public void Login(Custodian custodian)
        {
            current_custodian = custodian;
            LoadPanel();
        }
        private void LoadPanel()
        {
            var instance = UserInterface.GetInstance();
            panel_main.Controls.Add(instance.userControl_CustodianReport);
            panel_main.Controls.Add(instance.userControl_CustodianAddReport);
            instance.userControl_CustodianReport.Login(current_custodian);
            instance.userControl_CustodianReport.LoadList();
           
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
                    ui.userControl_LoginPage.ClearItems();
                    ui.userControl_LoginPage.BringToFront();
                    break;
              


            }
        }
        private void expandCollapseMenu(XUIButton btn)
        {
            UserInterface.button = btn;
            UserInterface.timer.Start();
        }
        private void UserControl_CustodianMainWindow_Load(object sender, EventArgs e)
        {
            btn_logOut.Tag = 0;
            btn_logOut.Click += Button_Click;


        }
    }
}
