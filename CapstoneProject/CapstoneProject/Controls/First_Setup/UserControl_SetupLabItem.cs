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

namespace CapstoneProject.Controls.First_Setup
{
    public partial class UserControl_SetupLabItem : UserControl
    {
        Laboratory laboratory;
        public UserControl_SetupLabItem(Laboratory lab)
        {
            InitializeComponent();
            laboratory = lab;
        }

        private void UserControl_SetupLabItem_Load(object sender, EventArgs e)
        {
            loadItem();
        }

        private void loadItem()
        {
            xuiButton1.ButtonText = laboratory.roomNum;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_FirstRun.SelectLaboratory(laboratory);
            ui.userControl_FirstRun.ShowHideBackButton();
        }
    }
}
