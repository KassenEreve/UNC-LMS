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
    public partial class UserControl_PcSpecsItem : UserControl
    {
        private PCSpecs specs;
        int ctr;

        

        public UserControl_PcSpecsItem(PCSpecs specs,int ctr)
        {
            InitializeComponent();
            this.specs = specs;
            this.ctr = ctr;
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void UserControl_PcSpecsItem_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (specs == null)
                return;

            lbl_ctr.Text = ctr.ToString();
            lbl_processor.Text = specs.processor;
            lbl_motherboard.Text = specs.motherboard;
            lbl_video.Text = specs.video;
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddPCSpecs.UpdateItem(specs);

            ui.userControl_AddPCSpecs.BringToFront();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            if (PCSpecsHelper.Delete(specs))
            {
                ui.userControl_PcSpecsList.LoadList();
            }
            else
            {
                MessageBox.Show("Failed to delete item!");
            }
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_AddPCSpecs.UpdateItem(specs);

            ui.userControl_AddPCSpecs.BringToFront();
        }
    }
}
