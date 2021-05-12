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

namespace CapstoneProject.Controls.Laboratory_ctrls
{
    public partial class UserControl_SetSpecification : UserControl
    {
        public UserControl_SetSpecification()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLabEquipments.BringToFront();
        }

        public void LoadControl()
        {
            /*
            foreach(Computer computer in computers)
            {
                textBox1.Text += computer.pc_num+", ";
            }*/
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
