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
    public partial class UserControl_SoftwareListItem : UserControl
    {
        Software software;
        int ctr;
        public UserControl_SoftwareListItem(Software software,int ctr)
        {
            InitializeComponent();
            this.software = software;
            this.ctr = ctr;
        }

        private void UserControl_SoftwareListItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            lbl_description.Text = software.description;
            lbl_ID.Text = ctr.ToString();
            lbl_name.Text = software.name;
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
