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
    public partial class UserControl_TechnicianComputerLogItem : UserControl
    {
        ComputerLog log;
        int ctr;
        public UserControl_TechnicianComputerLogItem(ComputerLog log,int ctr)
        {
            InitializeComponent();
            this.log = log;
            this.ctr = ctr;
        }

        private void UserControl_TechnicianComputerLogItem_Load(object sender, EventArgs e)
        {
            updateUI();
        }
        private void updateUI()
        {
            if (log != null)
            {
                lbl_roomID.Text = ctr.ToString();
                lbl_studentNum.Text = log.student.studentNum;
                lbl_date.Text = log.date.ToString();
            }
        }

        private void lbl_studentNum_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }
    }
}
