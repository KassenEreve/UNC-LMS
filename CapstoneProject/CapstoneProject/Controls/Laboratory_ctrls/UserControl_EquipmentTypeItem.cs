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
    public partial class UserControl_EquipmentTypeItem : UserControl
    {
        EquipmentType type;
        int ctr;
        public UserControl_EquipmentTypeItem(EquipmentType type,int ctr)
        {
            InitializeComponent();
            this.type = type;
            this.ctr = ctr;
        }

        private void UserControl_EquipmentTypeItem_Load(object sender, EventArgs e)
        {
            updateUI();
        }
        private void updateUI()
        {
            if (type != null)
            {
                lbl_ID.Text = ctr.ToString();
                lbl_name.Text = type.name;
                lbl_description.Text = type.description;
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddEquipmentType.UpdateItem(type);

            ui.userControl_AddEquipmentType.BringToFront();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            if (EquipmentTypeHelper.DeleteType(type))
            {
                ui.userControl_EquipmentType.LoadList();
            }
            else
            {
                MessageBox.Show("Failed to delete item!");
            }
        }
    }
}
