using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject.Controls.Laboratory
{
    public partial class UserControl_LabItem : UserControl
    {
        public UserControl_LabItem()
        {
            InitializeComponent();
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
           xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }
    }
}
