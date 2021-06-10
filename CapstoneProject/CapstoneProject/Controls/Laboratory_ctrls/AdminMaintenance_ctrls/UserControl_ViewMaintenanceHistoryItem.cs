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
    public partial class UserControl_ViewMaintenanceHistoryItem : UserControl
    {
        Technician technician;
        MaintenanceStatusHistory history;
        int ctr;
        public UserControl_ViewMaintenanceHistoryItem(MaintenanceStatusHistory history,Technician technician, int ctr)
        {
            InitializeComponent();
            this.history = history;
            this.technician = technician;
            this.ctr = ctr;
        }

        private void UserControl_ViewMaintenanceHistoryItem_Load(object sender, EventArgs e)
        {
            lbl_ctr.Text = ctr.ToString();
            lbl_date.Text = history.date.ToString();
            lbl_level.Text = history.status.name;
            btn_indicator.BackgroundColor = Color.FromArgb(history.status.color_argb);
            lbl_technician.Text = technician.fullName;
            lbl_description.Text = history.description;
        }
    }
}
