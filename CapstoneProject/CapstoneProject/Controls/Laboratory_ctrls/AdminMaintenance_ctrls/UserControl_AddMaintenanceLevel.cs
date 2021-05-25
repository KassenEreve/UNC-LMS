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

namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    public partial class UserControl_AddMaintenanceLevel : UserControl
    {
        MaintenanceLevel level = null;
        public UserControl_AddMaintenanceLevel()
        {
            InitializeComponent();
        }

        internal void ClearItem()
        {
            textBox_name.Text = string.Empty;
            textBox_desc.Text = string.Empty;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveLevel = new MaintenanceLevel() { name = textBox_name.Text.Trim(),description = textBox_desc.Text.Trim() };
            if (level != null)
                saveLevel.id = level.id;
            if (MaintenanceLevelHelper.SaveMaintenanceLevel(saveLevel))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_MaintenanceLevel.BringToFront();
                ui.userControl_MaintenanceLevel.LoadList();
                level = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_MaintenanceLevel.BringToFront();
            level = null;
        }
    }
}
