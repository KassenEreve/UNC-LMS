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

namespace CapstoneProject.Controls.User_ctrls
{
    public partial class UserControl_TechnicianItem : UserControl
    {
        Technician technician;
        int ctr;
        public UserControl_TechnicianItem(Technician technician, int ctr)
        {
            InitializeComponent();
            this.technician = technician;
            this.ctr = ctr;
        }

        private void UserControl_TechnicianItemcs_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            if (technician != null)
            {
                lbl_roomID.Text = ctr.ToString();
                lbl_name.Text = technician.lname + ", " + technician.fname + " " + technician.mname;
                lbl_phone.Text = technician.phone;
                lbl_email.Text = technician.email;
            }
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            if (TechnicianHelper.DeleteTechnician(technician))
            {
                ui.userControl_TechnicianList.LoadList();
            }
            else
            {
                MessageBox.Show("Failed to delete item!");
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddTechnician.UpdateItem(technician);
            ui.userControl_AddTechnician.BringToFront();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddTechnician.UpdateItem(technician);
            ui.userControl_AddTechnician.BringToFront();
        }
    }
}
