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

namespace CapstoneProject.Controls.User_ctrls
{
    public partial class UserControl_CustodianItem : UserControl
    {
        Custodian custodian;
        int ctr;
        public UserControl_CustodianItem(Custodian custodian,int ctr)
        {
            InitializeComponent();
            this.custodian = custodian;
            this.ctr = ctr;
        }

        private void UserControl_CustodianItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            if (custodian == null)
                return;

            lbl_roomID.Text = ctr.ToString();
            lbl_name.Text = custodian.lname + ", " + custodian.fname + " " + custodian.mname;
            lbl_phone.Text = custodian.phone;
            lbl_email.Text = custodian.email;
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
