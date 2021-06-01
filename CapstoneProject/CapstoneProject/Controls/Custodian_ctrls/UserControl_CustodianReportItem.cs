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
    public partial class UserControl_CustodianReportItem : UserControl
    {
        CustodianReport report;
        int ctr;

        public UserControl_CustodianReportItem(CustodianReport report, int ctr)
        {
            InitializeComponent();
            this.report = report;
            this.ctr = ctr;
        }

        private void UserControl_CustodianReportItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            if (report == null)
                return;
            lbl_ctr.Text = ctr.ToString();
            lbl_laboratory.Text = report.laboratory.roomNum;
            lbl_date.Text = report.date.ToString() ;

            if (report.maintenanceAssignment is null)
            {
                btn_indicator.BackgroundColor = Color.DarkGray;
                lbl_status.Text = "PENDING";
            }
            else
            {
                btn_indicator.BackgroundColor = Color.FromArgb(report.maintenanceAssignment.maintenance.statusHistory[0].status.color_argb);
                lbl_status.Text = report.maintenanceAssignment.maintenance.statusHistory[0].status.name;
                
            }
            var reportedEquipments = report.custodianReportedItems.FindAll(o => o.equipment != null);
            var reportedSoftwares = report.custodianReportedItems.FindAll(o => o.softwareInventory != null);
            lbl_items.Text = string.Empty;
            if (reportedEquipments.Count > 0)
            {
                List<int> compID = new List<int>();
                foreach (CustodianReportedItem reportedItem in reportedEquipments)
                {

                    if (reportedItem.equipment.computer_id > 0) //computer
                    {
                        if (!compID.Exists(o => o == reportedItem.equipment.computer_id))
                        {
                            compID.Add(reportedItem.equipment.computer_id);
                            lbl_items.Text += ComputerHelper.getComputer(reportedItem.equipment.computer_id).pc_num + ", ";
                        }
                    }
                    else //other equipment
                    {
                        lbl_items.Text += reportedItem.equipment.equipmentType.name + ", ";
                    }


                }
             

            }


        }
    }
}
