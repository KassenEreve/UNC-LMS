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
    public partial class UserControl_EmergencyMaintenanceItem : UserControl
    {
        CustodianReport custodianReport;
        int ctr;
        public UserControl_EmergencyMaintenanceItem(CustodianReport custodianReport, int ctr)
        {
            InitializeComponent();
            this.custodianReport = custodianReport;
            this.ctr = ctr;
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void UserControl_EmergencyMaintenanceItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            if (custodianReport == null)
                return;

            lbl_roomID.Text = ctr.ToString();
            lbl_reportedItems.Text = string.Empty;
            var reportedEquipments = custodianReport.custodianReportedItems.FindAll(o => o.equipment != null);
            var reportedSoftwares = custodianReport.custodianReportedItems.FindAll(o => o.softwareInventory != null);
            
            if(reportedEquipments.Count>0)
            {
                List<int> compID = new List<int>();
                foreach(CustodianReportedItem reportedItem in reportedEquipments)
                {
                    
                    if(reportedItem.equipment.computer_id>0) //computer
                    {
                        if (!compID.Exists(o => o == reportedItem.equipment.computer_id))
                        {
                            compID.Add(reportedItem.equipment.computer_id);
                            lbl_reportedItems.Text += ComputerHelper.getComputer(reportedItem.equipment.computer_id).pc_num+", ";
                        }
                    }
                    else //other equipment
                    {
                        lbl_reportedItems.Text += reportedItem.equipment.equipmentType.name+", ";
                    }

                   
                    
                }
                if(custodianReport.laboratory!=null)
                lbl_laboratory.Text = custodianReport.laboratory.roomNum;
                          
            }
           
        }
    }
}
