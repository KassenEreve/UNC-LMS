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

namespace CapstoneProject.Controls.Laboratory_ctrls
{
    public partial class UserControl_LabRecords : UserControl
    {
        List<ComputerLog> logMasterList;
        public UserControl_LabRecords()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            //technician
            var labs = LaboratoryHelper.GetAllLaboratories();
            Dictionary<string, string> test = new Dictionary<string, string>();

            foreach (Laboratory lab in labs)
            {
                test.Add(lab.id.ToString(), lab.roomNum);

            }

            comboBox_Laboratory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Laboratory.DataSource = new BindingSource(test, null);
            comboBox_Laboratory.DisplayMember = "Value";
            comboBox_Laboratory.ValueMember = "Key";
            comboBox_Laboratory.SelectedIndex = -1;
            comboBox_Laboratory.Text = "Select Type";
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            int selectedLab = 0 ;
            panel_roomList.Controls.Clear();
            try
            {
                selectedLab = Convert.ToInt32(comboBox_Laboratory.SelectedValue);
             
            }
            catch (Exception ex)
            {
                return;
            }
            if(selectedLab.Equals(0))
            {
                MessageBox.Show("Invalid Selected Laboratory!");
                return;
            }
            var computers = ComputerHelper.Computers(new Laboratory() { id = selectedLab });
            if(computers is null)
            {
                MessageBox.Show("This Laboratory has no computers yet!");
                return;
            }
            computers.ToString();
            logMasterList = new List<ComputerLog>();
            foreach(Computer comp in computers)
            {
                var log = ComputerLogHelper.GetAllLogs(comp);
                if (log is null)
                    continue;
                // var sortedLogs = log.OrderByDescending(o => o.date);
               
                foreach (ComputerLog log1 in log)
                {
                    logMasterList.Add(log1);
                }

            }
            LoadTable();


        }
        void LoadTable()
        {
            if (logMasterList is null)
                return;
            int ctr = logMasterList.Count;
            foreach (ComputerLog log in logMasterList)
            {
                var ctrl = new UserControl_LabRecordsItem(log, ctr--);
                 ctrl.Dock = DockStyle.Top;
                 panel_roomList.Controls.Add(ctrl); 
            }
        }
    }
}
