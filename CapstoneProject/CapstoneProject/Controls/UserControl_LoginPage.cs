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
using System.IO;

namespace CapstoneProject.Controls
{
    public partial class UserControl_LoginPage : UserControl
    {
        private UserInterface ui;
        public UserControl_LoginPage()
        {
            InitializeComponent();
          
        }

     
        private void UserControl_LoginPage_Load(object sender, EventArgs e)
        {
            ui = UserInterface.GetInstance();
            InitComboBox();
        }

        private void InitComboBox()
        {
         
                Dictionary<string, string> test = new Dictionary<string, string>();
              
                test.Add("0", "Technician");
                test.Add("1", "Admin");


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                comboBox1.SelectedIndex = 1;
                comboBox1.Text = "Select Type";


            

        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            ui.userControl_MainWindow.BringToFront();
            if (!comboBox1.SelectedIndex.Equals(0)) 
                return;
            if (!File.Exists(ComputerHelper.firstRunTxt))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_FirstRun.BringToFront();
            }
        }
    }
}
