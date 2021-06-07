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

namespace CapstoneProject.Controls.Technician_ctrls
{
    public partial class UserControl_TechnicianMaintenance : UserControl
    {
        Technician current_technician;
        public UserControl_TechnicianMaintenance()
        {
            InitializeComponent();
        }

        internal void LoadList( )
        {
            if (current_technician is null)
                return;

            panel_List.Controls.Clear();
            var list = TechnicianHelper.GetAllTechnicianMaintenance(current_technician);
            if (list == null)
                return;
            list.Reverse();
            int ctr = list.Count;
            foreach (Maintenance maintenance in list)
            {
                var ctrl = new UserControl_TechnicianMaintenanceItem(maintenance, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }

        }

        internal void Login(Technician technician)
        {
            current_technician = technician;
        }
    }
}
