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
    public partial class UserControl_ViewLab : UserControl
    {
        Laboratory lab;
        public UserControl_ViewLab()
        {
            InitializeComponent();
        }

        internal void LoadLab(Laboratory lab)
        {
            label1.Text = lab.roomNum + " EQUIPMENTS";
            this.lab = lab;
            panel_roomList.Controls.Clear();
            //other equipments
            var list = EquipmentHelper.Equipments(lab.id);

            if (list != null)
            {

                var newList = list.GroupBy(x => x.equipmentType.id).Select(y => y.First()).ToList<Equipment>();
                list.Reverse();
                if (newList != null)
                {
                    int ctr = newList.Count + 1;
                    foreach (Equipment equipment in newList)
                    {
                        var new_ctrl = new UserControl_ViewLabItem(equipment, ctr--);


                        new_ctrl.Dock = DockStyle.Top;
                        panel_roomList.Controls.Add(new_ctrl);
                    }
                }
            }

            //computer list item
            var ctrl = new UserControl_ViewLabItem(null, 1, EquipmentHelper.GetComputerCount(lab.id));
            

            ctrl.Dock = DockStyle.Top;
            panel_roomList.Controls.Add(ctrl);
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddLabEquipment.BringToFront();
            ui.userControl_AddLabEquipment.RefreshItems(lab);
        }
    }
}
