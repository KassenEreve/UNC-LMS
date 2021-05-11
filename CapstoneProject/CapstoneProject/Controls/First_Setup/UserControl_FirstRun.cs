using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject.Controls.First_Setup
{
    public partial class UserControl_FirstRun : UserControl
    {
        public UserControl_FirstRun()
        {
            InitializeComponent();
        }

        private void UserControl_FirstRun_Load(object sender, EventArgs e)
        {
            for(int i =0;i<10;i++)
            {
                var ctrl = new UserControl_SetupLabItem(); ;
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }
    }
}
