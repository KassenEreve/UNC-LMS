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
                test.Add("2", "Custodian");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                comboBox1.SelectedIndex = 1;
                comboBox1.Text = "Select Type";


            

        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            
           
           
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    if (!File.Exists(ComputerHelper.firstRunTxt)) //if first run show setup computer panel
                    {  
                        ui.userControl_FirstRun.BringToFront();
                    }
                    else //show the dashboard for technician
                    {
                        //open main window
                       
                        ui.userControl_TechnicianMainWindow.BringToFront();
                    }
                    break;
                case 1:
                    ui.userControl_MainWindow.BringToFront();
                    break;
            }
        }
    }
}
