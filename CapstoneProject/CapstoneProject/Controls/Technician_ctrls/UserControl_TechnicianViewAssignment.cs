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
    public partial class UserControl_TechnicianViewAssignment : UserControl
    {
        EmergenceMaintenanceAssignment assignment;
        public UserControl_TechnicianViewAssignment()
        {
            InitializeComponent();
        }

        internal void LoadAssignment(EmergenceMaintenanceAssignment assignment)
        {
            this.assignment = assignment;
            lbl_status.Text = assignment.maintenance.statusHistory[0].status.name;
            lbl_status.ForeColor = Color.FromArgb(assignment.maintenance.statusHistory[0].status.color_argb);
            LoadCombobox();
            
        }

        private void LoadCombobox()
        {
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
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            int  selectedStatus = 0;

            try
            {
               
                selectedStatus = Convert.ToInt32(comboBox_Status.SelectedValue);

            }
            catch (Exception ex)
            {
                return;
            }
            MaintenanceStatusHistory history = new MaintenanceStatusHistory();
            history.status = new MaintenanceStatus() { id = selectedStatus };
            history.date = DateTime.Now;
            history.description = textBox_description.Text;
            List<MaintenanceStatusHistory> listHistory = new List<MaintenanceStatusHistory>();
            listHistory.Add(history);
            assignment.maintenance.statusHistory = listHistory;

            if (MaintenanceStatusHistoryHelper.SaveStatusHistory(assignment.maintenance))
            {
                MessageBox.Show("Saved Successfully");
                
            }
            else
            {
                MessageBox.Show("Failed to save status");
            }

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();

            ui.userControl_TechnicianMaintenance.LoadList();
            ui.userControl_TechnicianMaintenance.BringToFront();
        }
    }
}
