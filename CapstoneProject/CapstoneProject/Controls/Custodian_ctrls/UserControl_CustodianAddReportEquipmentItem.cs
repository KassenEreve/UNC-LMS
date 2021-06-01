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
    }
}
