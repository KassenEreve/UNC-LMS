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
    public partial class UserControl_AddEquipmentType : UserControl
    {
        public UserControl_AddEquipmentType()
        {
            InitializeComponent();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_EquipmentType.BringToFront();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveType = new EquipmentType() { name = textBox_name.Text,description = textBox_desc.Text };
            if (EquipmentTypeHelper.SaveType(saveType))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_EquipmentType.BringToFront();
                ui.userControl_EquipmentType.LoadList();
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }
    }
}
