using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject.Controls.Laboratory;

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
           for(int i=0;i<5;i++)
            {
                var ctrl = new UserControl_LabItem();
                ctrl.Dock = DockStyle.Top;
                panel_roomList.Controls.Add(ctrl);
            }
        }
    }
}
