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

namespace CapstoneProject.Controls
{
    public partial class UserControl_LoginPage : UserControl
    {
        private UserInterface ui;
        public UserControl_LoginPage()
        {
            InitializeComponent();
          
        }

     
        private void UserControl_LoginPage_Load(object sender, EventArgs e)
        {
            ui = UserInterface.GetInstance();
        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            ui.userControl_MainWindow.BringToFront();
        }
    }
}
