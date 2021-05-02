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
            list.Reverse();
            foreach(PCSpecs specs in list)
            {
                var ctrl = new UserControl_PcSpecsItem(specs);
                ctrl.Dock = DockStyle.Top;
                panel_List.Controls.Add(ctrl);
            }
        }
    }
}
