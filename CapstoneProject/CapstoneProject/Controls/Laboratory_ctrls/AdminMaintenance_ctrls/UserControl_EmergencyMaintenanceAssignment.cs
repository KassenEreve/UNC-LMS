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
    public partial class UserControl_EmergencyMaintenanceAssignment : UserControl
    {
        CustodianReport report;
        public UserControl_EmergencyMaintenanceAssignment()
        {
            InitializeComponent();
        }

        internal void LoadItem(CustodianReport custodianReport)
        {
            report = custodianReport;
            InitComboBox();
            ClearItem();
            InitializeControls();
        }

        private void InitComboBox()
        {
            //technician
            var technicians = TechnicianHelper.GetAllTechnicians();
            Dictionary<string, string> test = new Dictionary<string, string>();

            foreach (Technician tech in technicians)
            {
                test.Add(tech.id.ToString(), tech.fullName);

            }

            comboBox_Technician.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Technician.DataSource = new BindingSource(test, null);
            comboBox_Technician.DisplayMember = "Value";
            comboBox_Technician.ValueMember = "Key";
            comboBox_Technician.SelectedIndex = -1;
            comboBox_Technician.Text = "Select Type";


            //maintenance status
            var statusList = MaintenanceStatusHelper.GetAllMaintenanceStatus();
            Dictionary<string, string> status_dic = new Dictionary<string, string>();

            foreach (MaintenanceStatus status in statusList)
            {
                status_dic.Add(status.id.ToString(), status.name);

            }

            comboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Status.DataSource = new BindingSource(status_dic, null);
            comboBox_Status.DisplayMember = "Value";
            comboBox_Status.ValueMember = "Key";
            comboBox_Status.SelectedIndex = -1;
            comboBox_Status.Text = "Select Type";


            //maintenance level

            var levels = MaintenanceLevelHelper.GetAllMaintenanceLevels();
            Dictionary<string, string> level_dic = new Dictionary<string, string>();

            foreach (MaintenanceLevel level in levels)
            {
                level_dic.Add(level.id.ToString(), level.name);

            }

            comboBox_Level.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Level.DataSource = new BindingSource(level_dic, null);
            comboBox_Level.DisplayMember = "Value";
            comboBox_Level.ValueMember = "Key";
            comboBox_Level.SelectedIndex = -1;
            comboBox_Level.Text = "Select Type";
        }

        private void InitializeControls()
        {
            lbl_custodian.Text = report.custodian.fullName;
            lbl_date.Text = report.date.ToShortDateString();
            lbl_lab.Text = report.laboratory.roomNum;
            lbl_time.Text = report.date.ToShortTimeString() ;
            LoadTable();
        }

        private void LoadTable()
        {
            panel_selectedEquipments.Controls.Clear();
          
            if (report.custodianReportedItems == null)
                return;
            report.custodianReportedItems.Reverse();
            int ctr = report.custodianReportedItems.Count;
            foreach (CustodianReportedItem item in report.custodianReportedItems)
            {
                var ctrl = new UserControl_EmergencyMaintenanceAssignmentItem(item);
                ctrl.Dock = DockStyle.Top;
                panel_selectedEquipments.Controls.Add(ctrl);
            }
        }

        private void ClearItem()
        {
            lbl_custodian.Text = string.Empty;
            lbl_date.Text = string.Empty;
            lbl_lab.Text = string.Empty;
            lbl_time.Text = string.Empty;
            comboBox_Status.SelectedIndex = -1;
            comboBox_Technician.SelectedIndex = -1;
            comboBox_Level.SelectedIndex = -1;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            int selectedLevel = 0,selectedTechnician=0,selectedStatus=0;

            try
            {
                selectedLevel = Convert.ToInt32(comboBox_Level.SelectedValue);
                selectedTechnician = Convert.ToInt32(comboBox_Technician.SelectedValue);
                selectedStatus = Convert.ToInt32(comboBox_Status.SelectedValue);

            }
            catch (Exception ex)
            {
                return;
            }
            MaintenanceStatusHistory history = new MaintenanceStatusHistory();
            history.status = new MaintenanceStatus() { id = selectedStatus };
            history.date = DateTime.Now;
            List<MaintenanceStatusHistory> listHistory = new List<MaintenanceStatusHistory>();
            listHistory.Add(history);
            var maintenance = new Maintenance()
            {
                maintenanceLevel = new MaintenanceLevel() { id = selectedLevel },
                technician = new Technician() { id = selectedTechnician },
                date = DateTime.Now,
                statusHistory =listHistory
            };

            Maintenance returnedMaintenance = MaintenanceHelper.SaveMaintenance(maintenance);
            if(returnedMaintenance is null)
            {
                MessageBox.Show("Failed to save Maintenance");
                return;
            }
            returnedMaintenance.statusHistory = listHistory;
            if(!MaintenanceStatusHistoryHelper.SaveStatusHistory(returnedMaintenance))
            {
                MessageBox.Show("Failed to save Maintenance");
                return;
            }

            var assignment = new EmergenceMaintenanceAssignment()
            {
                custodianReport = report,
                maintenance = returnedMaintenance
            };
           
            if(!EmergenceMaintenanceAssignmentHelper.SaveMaintenanceAssignment(assignment))
            {
                MessageBox.Show("Failed to save Maintenance");
                return;
            }
            MessageBox.Show("Saved successfully");
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_EmergencyMaintenance.LoadList();
            ui.userControl_EmergencyMaintenance.BringToFront();
        }
    }
}
