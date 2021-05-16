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
    public partial class UserControl_AddSoftwareGroup : UserControl
    {
        public UserControl_AddSoftwareGroup()
        {
            InitializeComponent();
        }

        private void UserControl_AddSoftwareGroup_Load(object sender, EventArgs e)
        {

        }

        internal void LoadList()
        {
            panel_list.Controls.Clear();
            var list = SoftwareHelper.GetAllSoftwares();
            if (list == null)
                return;
            list.Reverse();

            foreach(Software software in list)
            {
                var ctrl = new UserControl_AddSoftwareGroupItem(software);
                ctrl.Dock = DockStyle.Top;
                panel_list.Controls.Add(ctrl);

            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_SoftwareGroupList.BringToFront();
            ui.userControl_SoftwareGroupList.LoadList();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var selectedCtrls = panel_list.Controls.OfType<UserControl_AddSoftwareGroupItem>().ToList().FindAll(o => o.isSelected);
            if (selectedCtrls == null||selectedCtrls.Count.Equals(0))
            {
                MessageBox.Show("No softwares selected");
                return;
            }
            SoftwareGroup group = SoftwareGroupHelper.Save(new SoftwareGroup() { name = textBox_name.Text.ToUpper() });
            
            group.softwares = new List<Software>();
            foreach(UserControl_AddSoftwareGroupItem ctrl in selectedCtrls)
            {
                group.softwares.Add(ctrl.software);
            }

            if (SoftwareGroupHelper.SaveGroupSoftwares(group))
                MessageBox.Show("Save Successfully");
           
        }
    }
}
