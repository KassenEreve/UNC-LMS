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
              
                test.Add("0", "Student");
                test.Add("1", "Admin");
                test.Add("2", "Technician" );
                test.Add("3", "Custodian");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                comboBox1.SelectedIndex = 0;
                comboBox1.Text = "Select Type";


            

        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            
           
           
            switch(comboBox1.SelectedIndex)
            {
                case 0: //student
                    if (textBox_studentNum.TextLength.Equals(0))
                    {
                        MessageBox.Show("Empty Student Number");
                        return;
                    }
                    if (File.Exists(ComputerHelper.firstRunTxt))
                    {
                        string[] comp_data = File.ReadAllLines(ComputerHelper.firstRunTxt);
                        int labID = Convert.ToInt32(comp_data[0].Substring(comp_data[0].LastIndexOf(',') + 1));
                        int compID = Convert.ToInt32(comp_data[1].Substring(comp_data[1].LastIndexOf(',') + 1));
                        var labList = LaboratoryHelper.GetAllLaboratories();
                        var compList = ComputerHelper.Computers(new Laboratory() { id = labID });
                        string studentNum = textBox_studentNum.Text;
                        DateTime logDate = DateTime.Now;
                        panel_studentLog.BringToFront();
                        panel_studentLog.Visible = true;
                        lbl_comp.Text +="  "+compList.Find(o=>o.id.Equals(compID)).pc_num;
                        lbl_lab.Text += "  " + labList.Find(o => o.id.Equals(labID)).roomNum ;
                        lbl_dateTime.Text += "  " + logDate;
                        lbl_studentNum.Text +="  " +studentNum;

                        var saveLog = new ComputerLog()
                        {
                            student = new Student() { studentNum=studentNum},
                            computer = new Computer() { id=compID},
                            date = logDate
                        };
                        ComputerLogHelper.SaveComputerLog(saveLog);
                    }
                    else
                    {
                        MessageBox.Show("This computer has not been set up yet! Missing "+ComputerHelper.firstRunTxt);
                    }
                        break;
                case 1: //admin
                    ui.userControl_MainWindow.BringToFront();
                    break;
                case 2: //technician
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
                case 3:
                   
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
