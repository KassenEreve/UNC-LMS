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
    public partial class UserControl_EquipmentType : UserControl
    {
        public UserControl_EquipmentType()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            panel_typeList.Controls.Clear();
            //var labs = Singleton.GetInstance().GetCachedAllLaboratory();
            var types = EquipmentTypeHelper.GetAllEquipmentTypes();
            types.Reverse();
            foreach (EquipmentType type in types)
            {
                var ctrl = new UserControl_EquipmentTypeItem(type);
                ctrl.Dock = DockStyle.Top;
                panel_typeList.Controls.Add(ctrl);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddEquipmentType.BringToFront();
        }
    }
}
