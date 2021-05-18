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
    public partial class UserControl_TechnicianComputer : UserControl
    {
        Computer thisComputer;
        public UserControl_TechnicianComputer()
        {
            InitializeComponent();
        }

        private void UserControl_TechnicianComputer_Load(object sender, EventArgs e)
        {
            LoadList();

        }
        public void LoadList()
        {
            panel_pcPartList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            /*
            if (labs == null)
                return;
            labs.Reverse();
            int ctr = labs.Count;
            foreach (Laboratory lab in labs)
            {
                var ctrl = new UserControl_LabItem(lab, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }  */
           thisComputer = ComputerHelper.GetComputerFromFile();
            if (thisComputer == null)
                return;

            lbl_pcName.Text = thisComputer.pc_num;
            lbl_lab.Text = thisComputer.laboratory.roomNum;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            panel_logHistory.Visible = true;
            loadLogHistory();
        }

        private void loadLogHistory()
        {
            panel_logHistoryList.Controls.Clear();
            List<ComputerLog> logs = ComputerLogHelper.GetAllLogs(thisComputer);
            if (logs == null)
                return;
            logs.Reverse();
            int ctr = logs.Count;
            
            foreach(ComputerLog log in logs)
            {
               
                var ctrl = new UserControl_TechnicianComputerLogItem(log, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_logHistoryList.Controls.Add(ctrl);
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            panel_logHistory.Visible = false;
        }
    }
}
