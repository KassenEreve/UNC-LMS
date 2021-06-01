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

namespace CapstoneProject.Controls.Custodian_ctrls
{
    public partial class UserControl_CustodianReport : UserControl
    {
        Custodian custodian;
        public UserControl_CustodianReport()
        {
            InitializeComponent();
        }

        private void UserControl_CustodianReport_Load(object sender, EventArgs e)
        {

        }

        public void Login(Custodian custodian)
        {
            this.custodian = custodian;
        }
        public void LoadList()
        {

            if (custodian is null)
                return;

            panel_List.Controls.Clear();
            var list = CustodianReportHelper.GetAllCustodianReport(custodian);
            if (list == null)
                return;
            list.Reverse();
            int ctr = list.Count;
            foreach (CustodianReport report in list)
            {
                var ctrl = new UserControl_CustodianReportItem(report, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }


        }
    }
}
