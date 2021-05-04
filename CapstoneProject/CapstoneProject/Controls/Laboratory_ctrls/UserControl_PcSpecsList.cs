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
    public partial class UserControl_PcSpecsList : UserControl
    {
        public UserControl_PcSpecsList()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            panel_List.Controls.Clear();
            var list = PCSpecsHelper.GetAllPCSpecs();
            if (list == null)
                return;
            list.Reverse();
            int ctr = list.Count;
            foreach (PCSpecs specs in list)
            {
                var ctrl = new UserControl_PcSpecsItem(specs,ctr--);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddPCSpecs.ClearItem();
            ui.userControl_AddPCSpecs.BringToFront();
        }
    }
}
