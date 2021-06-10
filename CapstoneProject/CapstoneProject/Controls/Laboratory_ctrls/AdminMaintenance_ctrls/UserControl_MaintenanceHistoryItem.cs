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
    public partial class UserControl_MaintenanceHistoryItem : UserControl
    {
        EmergenceMaintenanceAssignment assignment;
        int ctr;
        public UserControl_MaintenanceHistoryItem(EmergenceMaintenanceAssignment assignment,int ctr)
        {
            InitializeComponent();
            this.assignment = assignment;
            this.ctr = ctr;
        }

        private void UserControl_MaintenanceHistoryItem_Load(object sender, EventArgs e)
        {
           
            lbl_ctr.Text = ctr.ToString();
           

            lbl_items.Text = string.Empty;


            
          
            lbl_level.Text = assignment.maintenance.statusHistory[0].status.name;
            lbl_date.Text = assignment.maintenance.statusHistory[0].date.ToString();
            btn_indicator.BackgroundColor = Color.FromArgb(assignment.maintenance.statusHistory[0].status.color_argb);
        

           
            lbl_lab.Text = assignment.custodianReport.custodianReportedItems[0].equipment.laboratory.roomNum;
            foreach (CustodianReportedItem item in assignment.custodianReport.custodianReportedItems)
            {
                if (item.equipment.computer_id > 0)
                    lbl_items.Text += ComputerHelper.getComputer(item.equipment.computer_id).pc_num + ", ";
                else
                    lbl_items.Text += item.equipment.equipmentType.name + ", ";
            }
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            var ui = UserInterface.GetInstance();
            ui.userControl_TechnicianViewAssignment.LoadAssignment(assignment);
            ui.userControl_TechnicianViewAssignment.BringToFront(); */
        }
    }
}
