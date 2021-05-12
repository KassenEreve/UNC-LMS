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
    public partial class UserControl_SoftwareList : UserControl
    {
        public UserControl_SoftwareList()
        {
            InitializeComponent();
        }

        public void LoadList()
        {
            panel_typeList.Controls.Clear();
            var list = SoftwareHelper.GetAllSoftwares();
            if (list == null)
                return;
            list.Reverse();
            int ctr = list.Count;
            foreach (Software software in list)
            {
                var ctrl = new UserControl_SoftwareListItem(software, ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_typeList.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddSoftware.BringToFront();
            ui.userControl_AddSoftware.ClearItem();
        }
    }
}
