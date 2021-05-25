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
    public partial class UserControl_MaintenanceLevelItem : UserControl
    {
        MaintenanceLevel level;
        int ctr;
        public UserControl_MaintenanceLevelItem(MaintenanceLevel level, int ctr)
        {
            InitializeComponent();
            this.level = level;
            this.ctr = ctr;
        }

        private void UserControl_MaintenanceLevelItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            if (level == null)
                return;

            lbl_roomID.Text = ctr.ToString();
            lbl_name.Text = level.name;
            lbl_description.Text = level.description;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
