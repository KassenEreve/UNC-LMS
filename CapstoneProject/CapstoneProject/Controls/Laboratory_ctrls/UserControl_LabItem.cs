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
    public partial class UserControl_LabItem : UserControl
    {
        private Laboratory lab;
        public UserControl_LabItem(Laboratory lab)
        {
            InitializeComponent();
            this.lab = lab;
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
           xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void UserControl_LabItem_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
           if(lab!=null)
            {
                lbl_roomID.Text = lab.id.ToString() ;
                lbl_roomNum.Text = lab.roomNum;
            }
        }
    }
}
