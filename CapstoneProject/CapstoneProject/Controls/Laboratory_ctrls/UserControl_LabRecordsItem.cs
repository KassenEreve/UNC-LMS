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
    public partial class UserControl_LabRecordsItem : UserControl
    {
        ComputerLog log;
        int ctr;
        public UserControl_LabRecordsItem(ComputerLog log,int ctr)
        {
            InitializeComponent();
            this.log = log;
            this.ctr = ctr;
          
        }

        private void UserControl_LabRecordsItem_Load(object sender, EventArgs e)
        {
            if (log is null)
                return;
            lbl_ctr.Text = ctr.ToString();
            lbl_computer.Text = log.computer.pc_num;
            lbl_date.Text = log.date.ToString();
            lbl_student.Text = log.student.studentNum;
        }
    }
}
