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
    public partial class UserControl_CustodianAddReportEquipmentItem : UserControl
    {
        Computer computer;
        Equipment equipment;
        public bool isSelected = false;
        public UserControl_CustodianAddReportEquipmentItem(Computer computer =null,Equipment equipment=null)
        {
            InitializeComponent();
            this.computer = computer;
            this.equipment = equipment;
        }

        private void UserControl_CustodianAddReportEquipmentItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }
        private void LoadItem()
        {
            if (computer != null)
                xuiButton1.ButtonText = computer.pc_num;
            else if (equipment != null)
                xuiButton1.ButtonText = equipment.equipmentType.name;

            this.BackColor = Color.FromArgb(248, 248, 248);

            

        }
        public void SelectItem(bool forceSelect = false, bool deSelect = false)
        {
            if (isSelected && !forceSelect)
            {
                isSelected = false;
                xuiButton1.BackgroundColor = Color.White;
            }
            else
            {
                isSelected = true;
                xuiButton1.BackgroundColor = Color.Gray;
            }

            if (deSelect)
            {
                isSelected = false;
                xuiButton1.BackgroundColor = Color.White;
            }
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
          
            List<Computer> selectedComputers = null;
            List<Equipment> selectedEquipments = null;
            if (ModifierKeys.HasFlag(Keys.Control))
            {

                int from = this.Parent.Controls.OfType<UserControl_CustodianAddReportEquipmentItem>().ToList().FindIndex(o => o.isSelected);
                int to = this.Parent.Controls.IndexOf(this);
                if (from >= 0 && to >= 0)
                {
                    selectedComputers = new List<Computer>();
                    selectedEquipments = new List<Equipment>();
                    for (int i = from; i <= to; i++)
                    {
                        this.Parent.Controls.OfType<UserControl_CustodianAddReportEquipmentItem>().ToList()[i].SelectItem(true);

                    }
                }


            }
            else
            {

                foreach (UserControl_CustodianAddReportEquipmentItem ctrl in this.Parent.Controls.OfType<UserControl_CustodianAddReportEquipmentItem>().ToList())
                {
                    ctrl.SelectItem(false, true);
                }

                SelectItem();
            }
            var list = this.Parent.Controls.OfType<UserControl_CustodianAddReportEquipmentItem>().ToList().FindAll(o => o.isSelected);
            if (list != null && list.Count > 0)
            {
                selectedComputers = new List<Computer>();
                selectedEquipments = new List<Equipment>();
                foreach (UserControl_CustodianAddReportEquipmentItem ctrl in list)
                {
                    if(ctrl.computer!=null)
                    selectedComputers.Add(ctrl.computer);
                    if (ctrl.equipment != null)
                        selectedEquipments.Add(ctrl.equipment);
                }
                UserInterface.GetInstance().userControl_CustodianAddReport.SetSelectedEquipments(selectedComputers,selectedEquipments) ;
            }
        }
    }
}
