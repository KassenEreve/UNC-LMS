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
    public partial class UserControl_SoftwareGroupListItem : UserControl
    {
        SoftwareGroup group;
        int ctr;
        public UserControl_SoftwareGroupListItem(SoftwareGroup group, int ctr)
        {
            InitializeComponent();
            this.group = group;
            this.ctr = ctr;
        }

        private void UserControl_SoftwareGroupListItem_Load(object sender, EventArgs e)
        {
            loadItem();
        }

        private void loadItem()
        {
            lbl_ctr.Text = ctr.ToString();
            lbl_name.Text = group.name;
            lbl_list.Text = "";
            group.softwares.Reverse();
            foreach (Software software in group.softwares)
            {
                lbl_list.Text += software.name + ", ";
            }
            
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
