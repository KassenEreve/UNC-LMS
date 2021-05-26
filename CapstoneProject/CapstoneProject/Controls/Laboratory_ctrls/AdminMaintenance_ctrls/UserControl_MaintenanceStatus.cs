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
    public partial class UserControl_MaintenanceStatus : UserControl
    {
        public UserControl_MaintenanceStatus()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            panel_roomList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            var status = MaintenanceStatusHelper.GetAllMaintenanceStatus();
            if (status == null)
                return;
            status.Reverse();
            int ctr = status.Count;
            foreach (MaintenanceStatus stats in status)
            {
                var ctrl = new UserControl_MaintenanceStatusItem(stats, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddMaintenanceStatus.ClearItem();
            ui.userControl_AddMaintenanceStatus.BringToFront();
        }
    }
}
