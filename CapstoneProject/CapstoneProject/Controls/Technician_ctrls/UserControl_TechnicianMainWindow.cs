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

namespace CapstoneProject.Controls.Technician_ctrls
{
    public partial class UserControl_TechnicianMainWindow : UserControl
    {
        public UserControl_TechnicianMainWindow()
        {
            InitializeComponent();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_LoginPage.BringToFront();
        }
    }
}
