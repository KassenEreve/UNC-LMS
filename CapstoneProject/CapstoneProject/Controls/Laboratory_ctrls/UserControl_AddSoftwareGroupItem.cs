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
    public partial class UserControl_AddSoftwareGroupItem : UserControl
    {
       public Software software;
        public bool isSelected = false;
        public UserControl_AddSoftwareGroupItem(Software software)
        {
            InitializeComponent();
            this.software = software;
        }

        private void UserControl_AddSoftwareGroupItem_Load(object sender, EventArgs e)
        {
            lbl_name.Text = software.name;
            lbl_desc.Text = software.description;
        }

        private void xuiCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSelected = checkBox1.Checked;
        }
    }
}
