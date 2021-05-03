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
        EquipmentType type = null;
        public UserControl_AddEquipmentType()
        {
            InitializeComponent();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_EquipmentType.BringToFront();
            type = null;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveType = new EquipmentType() { name = textBox_name.Text,description = textBox_desc.Text,isPcPart=(checkBox1.Checked)?1:0 };
            if (type != null)
                saveType.id = type.id;
            if (EquipmentTypeHelper.SaveType(saveType))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_EquipmentType.BringToFront();
                ui.userControl_EquipmentType.LoadList();

                type = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        internal void UpdateItem(EquipmentType type)
        {
            this.type = type;
            textBox_name.Text = type.name;
            textBox_desc.Text = type.description;
        }

        internal void ClearItem()
        {
            textBox_name.Text = "";
            textBox_desc.Text = "";
        }
    }
}
