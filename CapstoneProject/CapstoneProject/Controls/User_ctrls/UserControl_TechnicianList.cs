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
using CapstoneProject.Controls.User_ctrls;

namespace CapstoneProject.Controls.User_ctrls
{
    public partial class UserControl_TechnicianList : UserControl
    {
        public UserControl_TechnicianList()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            panel_roomList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            var list = TechnicianHelper.GetAllTechnicians();
            if (list == null)
                return;

            list.Reverse();
            int ctr = list.Count;
            foreach (Technician tech in list)
            {
                var ctrl = new UserControl_TechnicianItem(tech, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddTechnician.ClearItem();
            ui.userControl_AddTechnician.BringToFront();
        }
    }
}
