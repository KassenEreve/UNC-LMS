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
    public partial class UserControl_ViewLabEquipments : UserControl
    {
        public UserControl_ViewLabEquipments()
        {
            InitializeComponent();
        }

        public void UpdateUI(Equipment equipment,Laboratory lab)
        {
            label1.Text = lab.roomNum+" ";
            flowLayoutPanel1.Controls.Clear();
            if (equipment == null)
            {
                label1.Text += "Computer";
                var list = ComputerHelper.Computers(lab);
                if(list!=null)
                {
                    foreach(Computer computer in list)
                    {
                       var ctrl = new UserControl_ViewLabEquipmentItem(computer);
                        flowLayoutPanel1.Controls.Add(ctrl);
                    }
                }
            }
            else
                label1.Text += equipment.equipmentType.name;

            label1.Text += " List";
            
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLab.BringToFront();
        }
    }
}
