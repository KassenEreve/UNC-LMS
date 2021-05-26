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
    public partial class UserControl_MaintenanceStatusItem : UserControl
    {
        MaintenanceStatus status;
        int ctr;
        public UserControl_MaintenanceStatusItem(MaintenanceStatus status, int ctr)
        {
            InitializeComponent();
            this.status = status;
            this.ctr = ctr;
        }

        private void UserControl_MaintenanceStatusItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            btn_indicator.BackgroundColor = Color.FromArgb(status.color_argb);
            lbl_name.Text = status.name;
            lbl_description.Text = status.description;
            lbl_roomID.Text = ctr.ToString();
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
