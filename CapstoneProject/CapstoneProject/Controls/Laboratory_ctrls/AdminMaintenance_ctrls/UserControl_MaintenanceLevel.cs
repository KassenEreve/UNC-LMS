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
    public partial class UserControl_MaintenanceLevel : UserControl
    {
        public UserControl_MaintenanceLevel()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            panel_roomList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            var levels = MaintenanceLevelHelper.GetAllMaintenanceLevels();
            if (levels == null)
                return;
            levels.Reverse();
            int ctr = levels.Count;
            foreach (MaintenanceLevel level in levels)
            {
                var ctrl = new UserControl_MaintenanceLevelItem(level, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }

        private void UserControl_MaintenanceLevel_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddMaintenanceLevel.ClearItem();
            ui.userControl_AddMaintenanceLevel.BringToFront();
        }
    }
}
