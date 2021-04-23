using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject.Controls.Laboratory_ctrls;
using CapstoneProject.Class;

namespace CapstoneProject.Controls
{
    public partial class UserControl_LabList : UserControl
    {
        public UserControl_LabList()
        {
            InitializeComponent();
        }

        private void UserControl_LabList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            labs.Reverse();
           foreach(Laboratory lab in labs)
            {
                var ctrl = new UserControl_LabItem(lab);
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }
    }
}
