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
    public partial class UserControl_MaintenanceHistory : UserControl
    {
        public UserControl_MaintenanceHistory()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            

            panel_List.Controls.Clear();
            var list = EmergenceMaintenanceAssignmentHelper.GetAllAssignmentHistory();
            if (list == null)
                return;
            
            int ctr = list.Count;
            foreach (EmergenceMaintenanceAssignment assignment in list)
            {
                var ctrl = new UserControl_MaintenanceHistoryItem(assignment, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }
        }
    }
}
