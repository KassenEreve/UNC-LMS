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

namespace CapstoneProject.Controls.Custodian_ctrls
{
    public partial class UserControl_CustodianAddReportSelectedItem : UserControl
    {
       
        public Computer computer;
        public Equipment equipment;
        public UserControl_CustodianAddReportSelectedItem(Computer computer, Equipment equipment)
        {
            InitializeComponent();
           
            this.computer = computer;
            this.equipment = equipment;
        }

        private void UserControl_CustodianAddReportSelectedItem_Load(object sender, EventArgs e)
        {
            LoadItem();
            if (computer != null)
            {
                computer.pcparts_equipment = ComputerHelper.GetPCParts(computer.id);
                InitComboBox();
            }
        }
        private void InitComboBox()
        {
            comboBox1.Visible = true;
            Dictionary<string, string> test = new Dictionary<string, string>();
            
            foreach (Equipment equip in computer.pcparts_equipment)
            {
                test.Add(equip.id.ToString(), equip.equipmentType.name);

            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Type";


        }
        public string GetDescription()
        {

            return textBox1.Text;
        }
        private void LoadItem()
        {
           
           if(computer!=null)
            {

                lbl_name.Text = computer.pc_num;
            }
           else if(equipment!=null)
            {
                lbl_name.Text = equipment.equipmentType.name;
            }

           
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = 0;
            
            try
            {
                selected = Convert.ToInt32(comboBox1.SelectedValue);

            }
            catch (Exception ex)
            {
                return;
            }
            var selectedPart = computer.pcparts_equipment.Find(o=>o.id==selected);
            if(selectedPart!=null)
            selectedPart.selectedDefective = true;
         
            
        }
    }
}
