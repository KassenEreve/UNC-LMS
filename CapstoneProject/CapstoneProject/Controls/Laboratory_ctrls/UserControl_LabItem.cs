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
        private int ctr;
        public UserControl_LabItem(Laboratory lab,int count)
        {
            InitializeComponent();
            this.lab = lab;
            ctr = count;
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
                lbl_roomID.Text = ctr.ToString() ;
                lbl_roomNum.Text = lab.roomNum;
            }
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddLab.UpdateItem(lab);
            ui.userControl_AddLab.BringToFront();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            if (LaboratoryHelper.DeleteLab(lab))
            {
                ui.userControl_LabList.LoadList();
            }
            else
            {
                MessageBox.Show("Failed to delete item!");
            }
           
        }
    }
}
