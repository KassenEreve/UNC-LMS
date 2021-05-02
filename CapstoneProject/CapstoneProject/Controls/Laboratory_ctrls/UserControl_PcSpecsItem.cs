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

        

        public UserControl_PcSpecsItem(PCSpecs specs)
        {
            InitializeComponent();
            this.specs = specs;
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

            lbl_ctr.Text = specs.id.ToString();
            lbl_processor.Text = specs.processor;
            lbl_motherboard.Text = specs.motherboard;
            lbl_video.Text = specs.video;
            lbl_memory.Text = specs.memory;
        }
    }
}
