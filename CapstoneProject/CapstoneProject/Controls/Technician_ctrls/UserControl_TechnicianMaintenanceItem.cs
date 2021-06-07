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
    public partial class UserControl_TechnicianMaintenanceItem : UserControl
    {
        Maintenance maintenance;
        int ctr;
        public UserControl_TechnicianMaintenanceItem(Maintenance maintenance,int ctr)
        {
            InitializeComponent();
            this.maintenance = maintenance;
            this.ctr = ctr;
        }

        private void UserControl_TechnicianMaintenanceItem_Load(object sender, EventArgs e)
        {
            lbl_ctr.Text = ctr.ToString();
            lbl_date.Text = maintenance.date.ToString();
            lbl_level.Text = maintenance.maintenanceLevel.name;
          
        }
    }
}
