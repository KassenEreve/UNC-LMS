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
    public partial class UserControl_mainWindow : UserControl
    {
        public UserControl_mainWindow()
        {
            InitializeComponent();
            
        }

        private void LoadPanel()
        {
            var instance = UserInterface.GetInstance();
            panel_main.Controls.Add(instance.userControl_LabList);      
        }

        private void UserControl_mainWindow_Load(object sender, EventArgs e)
        {
            LoadPanel();
        }
    }
}
