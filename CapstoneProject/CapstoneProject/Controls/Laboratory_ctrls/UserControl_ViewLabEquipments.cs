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

            if (equipment == null)
                label1.Text += "Computer";
            else
                label1.Text += equipment.equipmentType.name;

            label1.Text += " List";
        }
    }
}
