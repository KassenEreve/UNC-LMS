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

namespace CapstoneProject.Controls.Laboratory_ctrls.AdminMaintenance_ctrls
{
    public partial class UserControl_EmergencyMaintenanceAssignmentItem : UserControl
    {
        CustodianReportedItem item;
        public UserControl_EmergencyMaintenanceAssignmentItem(CustodianReportedItem item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void UserControl_EmergencyMaintenanceAssignmentItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            if (item is null)
                return;

            lbl_desc.Text = item.issueDescription;
            
            if(item.equipment.computer_id>0)
            {
                //its a computer
                lbl_equipment.Text = ComputerHelper.getComputer(item.equipment.computer_id).pc_num;
                lbl_pcPart.Text = item.equipment.equipmentType.name;
            }
            else
            {
                lbl_equipment.Text = item.equipment.equipmentType.name;
            }
           
        }
    }
}
