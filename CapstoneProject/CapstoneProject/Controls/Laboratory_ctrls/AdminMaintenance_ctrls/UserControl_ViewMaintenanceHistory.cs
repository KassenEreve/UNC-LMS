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
    public partial class UserControl_ViewMaintenanceHistory : UserControl
    {
        EmergenceMaintenanceAssignment assignment;
        public UserControl_ViewMaintenanceHistory()
        {
            InitializeComponent();
        }

        private void UserControl_ViewMaintenanceHistory_Load(object sender, EventArgs e)
        {

        }
        internal void LoadAssignment(EmergenceMaintenanceAssignment assignment)
        {
            this.assignment = assignment;
            lbl_status.Text = assignment.maintenance.statusHistory[0].status.name;
            lbl_status.ForeColor = Color.FromArgb(assignment.maintenance.statusHistory[0].status.color_argb);
            lbl_custodian.Text = assignment.custodianReport.custodian.fullName;

            lbl_lab.Text = assignment.custodianReport.laboratory.roomNum;
            lbl_date.Text = assignment.maintenance.statusHistory[0].date.ToShortDateString();
            lbl_time.Text = assignment.maintenance.statusHistory[0].date.ToShortTimeString();
            LoadTable();

            LoadLogTable();

        }

        private void LoadLogTable()
        {
            panel_List.Controls.Clear();
            int ctr = assignment.maintenance.statusHistory.Count;
            foreach (MaintenanceStatusHistory history in assignment.maintenance.statusHistory)
            {
                var ctrl = new UserControl_ViewMaintenanceHistoryItem(history,assignment.maintenance.technician,ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }
        }

        private void LoadTable()
        {

            panel_selectedEquipments.Controls.Clear();

            if (assignment.custodianReport.custodianReportedItems == null)
                return;
            assignment.custodianReport.custodianReportedItems.Reverse();
            int ctr = assignment.custodianReport.custodianReportedItems.Count;
            foreach (CustodianReportedItem item in assignment.custodianReport.custodianReportedItems)
            {
                var ctrl = new UserControl_EmergencyMaintenanceAssignmentItem(item);
                ctrl.Dock = DockStyle.Top;
                panel_selectedEquipments.Controls.Add(ctrl);
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            UserInterface.GetInstance().userControl_MaintenanceHistory.BringToFront();
        }
    }
}
