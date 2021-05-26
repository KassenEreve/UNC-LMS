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
    public partial class UserControl_AddMaintenanceStatus : UserControl
    {
        int color;
        MaintenanceStatus status;
        public UserControl_AddMaintenanceStatus()
        {
            InitializeComponent();
        }

        

        private void xuiColorPane1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn_indicator.BackgroundColor = colorDialog1.Color;
                color = colorDialog1.Color.ToArgb();
            }
        }

        internal void ClearItem()
        {
            color = 0;
            status = null;
            textBox_name.Text = string.Empty;
            textBox_desc.Text = string.Empty;
            btn_indicator.BackgroundColor = Color.White;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveStatus = new MaintenanceStatus()
            {
                color_argb = color,
                name = textBox_name.Text,
                description = textBox_desc.Text

            };
            if (status != null)
                saveStatus.id = status.id;
            if (MaintenanceStatusHelper.SaveMaintenanceStatus(saveStatus))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_MaintenanceStatus.BringToFront();
                ui.userControl_MaintenanceStatus.LoadList();
                status = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_MaintenanceStatus.BringToFront();
            status = null;
        }
    }
}
