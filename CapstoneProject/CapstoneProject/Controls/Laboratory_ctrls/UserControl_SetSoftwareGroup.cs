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
    public partial class UserControl_SetSoftwareGroup : UserControl
    {
        List<SoftwareGroup> list;
        List<Computer> computers;
        public UserControl_SetSoftwareGroup()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLabEquipments.BringToFront();
            ui.userControl_ViewLabEquipments.selectedComputers = null;
            ui.userControl_ViewLabEquipments.RefreshControl();
        }
        public void LoadControl(List<Computer> computers)
        {
            this.computers = computers;
            textBox1.Text = string.Empty;
            foreach (Computer computer in computers)
            {
                textBox1.Text += computer.pc_num + ", ";
            }
            InitComboBox();
        }
        private void InitComboBox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            list = SoftwareGroupHelper.GetAllSoftwareGroups();
          
            foreach (SoftwareGroup group in list)
            {
                test.Add(group.id.ToString(), group.name);

            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = -1;

            comboBox1.Text = "Select Software Group";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = 0;
           
            textBox2.Text = string.Empty;
            try
            {
                selected = Convert.ToInt32(comboBox1.SelectedValue);

            }
            catch (Exception ex)
            {
                return;
            }
            var selectedGroup = list.Find(o => o.id.Equals(selected));
            if (selectedGroup == null)
                return;

            foreach(Software software in selectedGroup.softwares)
            {
                textBox2.Text += software.name + ", ";
            }
            
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {

            if (list == null || computers == null)
                return;

            var selectedGroup = list.Find(o => o.id.Equals(Convert.ToInt32(comboBox1.SelectedValue)));
            
            foreach (Computer comp in computers)
            {
                comp.softwareGroup = selectedGroup;
               var groupAssignmenID = SoftwareGroupAssignmentHelper.SaveAssignment(comp);
               foreach(Software software in selectedGroup.softwares)
                {
                    var inventory = new SoftwareInventory() { computer = comp, software = software };
                    SoftwareInventoryHelper.Save(inventory, groupAssignmenID);
                }
            }
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLabEquipments.BringToFront();
            ui.userControl_ViewLabEquipments.RefreshControl();
        }
    }
}
