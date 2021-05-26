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
    public partial class UserControl_CustodianList : UserControl
    {
        public UserControl_CustodianList()
        {
            InitializeComponent();
        }

        private void UserControl_CustodianList_Load(object sender, EventArgs e)
        {
            
        }
        internal void LoadList()
        {
            panel_roomList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            var list = CustodianHelper.GetAllCustodians();
            if (list == null)
                return;

            list.Reverse();
            int ctr = list.Count;
            foreach (Custodian custodian in list)
            {
                var ctrl = new UserControl_CustodianItem(custodian, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddCustodian.ClearItem();
            ui.userControl_AddCustodian.BringToFront();
        }
    }
}
