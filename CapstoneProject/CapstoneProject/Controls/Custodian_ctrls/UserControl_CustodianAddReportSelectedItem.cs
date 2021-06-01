using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject.Controls.Custodian_ctrls
{
    public partial class UserControl_CustodianAddReportSelectedItem : UserControl
    {
        public UserControl_CustodianAddReportSelectedItem()
        {
            InitializeComponent();
        }

        private void UserControl_CustodianAddReportSelectedItem_Load(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
