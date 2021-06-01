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
    }
}
