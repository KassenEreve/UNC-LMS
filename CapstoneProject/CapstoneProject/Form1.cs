using CapstoneProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitPanels();
        }

        private void InitPanels()
        {
            var ui = UserInterface.GetInstance();
            panel_main.Controls.Add(ui.userControl_LoginPage);
            panel_main.Controls.Add(ui.userControl_MainWindow);
        }
    }
}
