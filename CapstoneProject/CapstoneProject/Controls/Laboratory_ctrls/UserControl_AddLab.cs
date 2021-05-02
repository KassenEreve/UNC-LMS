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
    public partial class UserControl_AddLab : UserControl
    {
        Laboratory lab = null;
        public UserControl_AddLab()
        {
            InitializeComponent();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_LabList.BringToFront();
            lab = null;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveLab = new Laboratory() { roomNum = textBox_room.Text };
            if (lab != null)
                saveLab.id = lab.id;
            if(LaboratoryHelper.SaveLab(saveLab))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_LabList.BringToFront();
                ui.userControl_LabList.LoadList();
                lab = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        internal void ClearItem()
        {
            textBox_room.Text = "";
        }

        internal void UpdateItem(Laboratory lab)
        {
            this.lab = lab;
            textBox_room.Text = lab.roomNum;
        }

        
    }
}
