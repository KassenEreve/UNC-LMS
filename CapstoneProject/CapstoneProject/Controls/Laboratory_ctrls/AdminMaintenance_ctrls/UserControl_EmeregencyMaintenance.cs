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
    public partial class UserControl_EmeregencyMaintenance : UserControl
    {
        public UserControl_EmeregencyMaintenance()
        {
            InitializeComponent();
        }

        private void UserControl_EmeregencyMaintenance_Load(object sender, EventArgs e)
        {

        }

        internal void LoadList()
        {
            panel_List.Controls.Clear();
            var list = CustodianReportHelper.GetAllUnAssignedCustodianReports();
            if (list == null)
                return;
            list.Reverse();
            int ctr = list.Count;
            foreach (CustodianReport report in list)
            {
                var ctrl = new UserControl_EmergencyMaintenanceItem(report, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
