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

namespace CapstoneProject.Controls.Laboratory_ctrls
{
    public partial class UserControl_AddSoftware : UserControl
    {
        Software software;
        public UserControl_AddSoftware()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var save = new Software() { name = txtBox_name.Text,description=txtBox_desc.Text };
            if (software != null)
                save.id = software.id;
            if (SoftwareHelper.Save(save))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_SoftwareList.BringToFront();
                ui.userControl_SoftwareList.LoadList();

               software = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        internal void ClearItem()
        {
            software = null;
            txtBox_desc.Text = string.Empty;
            txtBox_name.Text = string.Empty;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_SoftwareList.BringToFront();
        }
    }
}
