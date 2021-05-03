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
    public partial class UserControl_AddLabEquipment : UserControl
    {
        Laboratory lab;
        public UserControl_AddLabEquipment()
        {
            InitializeComponent();
        }

        private void UserControl_AddLabEquipment_Load(object sender, EventArgs e)
        {
            InitComboBox();
        }

        private void InitComboBox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            List<EquipmentType> list = EquipmentTypeHelper.GetAllEquipmentTypes().FindAll(o=>o.isPcPart.Equals(0));
            test.Add("99", "Computer");
            foreach (EquipmentType type in list)
            {
                test.Add(type.id.ToString(), type.name);

            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Type";

            
        }

        internal void RefreshItems(Laboratory lab)
        {
            this.lab = lab;
            InitComboBox();
            numericUpDown1.Value = 0;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            ReturnViewLab();

        }
        private void ReturnViewLab()
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLab.BringToFront();
            ui.userControl_ViewLab.LoadLab(lab);
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString().Equals("99"))
            {
                //add new computers
                for(int i=0;i<numericUpDown1.Value;i++)
                {
                  var savedComp =   ComputerHelper.SaveComputer(new Computer() { pc_num = "PC-" + (i+1).ToString("00") });
                  

                  List<EquipmentType> list = EquipmentTypeHelper.GetAllEquipmentTypes().FindAll(o => o.isPcPart.Equals(1));
                    foreach(EquipmentType type in list)
                    {
                        var equip = new Equipment() { computer_id = savedComp.id, equipmentType = type,laboratory=lab };
                        EquipmentHelper.SaveEquipment(equip);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                   

                   
                     var equip = new Equipment() {  equipmentType =new EquipmentType() { id = Convert.ToInt32(comboBox1.SelectedValue)}, laboratory = lab };
                        EquipmentHelper.SaveEquipment(equip);
                    
                }
            }
            ReturnViewLab();

        }
    }
}
