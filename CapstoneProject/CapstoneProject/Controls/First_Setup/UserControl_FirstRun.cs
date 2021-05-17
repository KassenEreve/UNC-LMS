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

namespace CapstoneProject.Controls.First_Setup
{
    public partial class UserControl_FirstRun : UserControl
    {
         Laboratory selectedLab;
        Computer selectedComp;
        public UserControl_FirstRun()
        {
            InitializeComponent();
        }
        public void SelectLaboratory(Laboratory lab)
        {
            lbl_selectedComp.Text = string.Empty;
            selectedLab = lab;
            lbl_selectedComp.Text = "Laboratory : " + selectedLab.roomNum;
            LoadComputers();
        }
        public void SelectComputer(Computer computer)
        {
            lbl_selectedComp.Text = "Laboratory : " + selectedLab.roomNum;
            lbl_selectedComp.Text += "  Computer : " + computer.pc_num;
            selectedComp = computer;
        }
        private void LoadComputers()
        {
            flowLayoutPanel1.Controls.Clear();
            var computers = ComputerHelper.Computers(selectedLab);
            if (computers == null)
            {
                MessageBox.Show("This Laboratory doesnt have any saved Computers");
                return;
            }
            foreach(Computer computer in computers)
            {
                var ctrl = new UserControl_SetupComputerItem(computer); ;
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        internal void ShowHideBackButton()
        {
            if (btn_back.Visible)
                btn_back.Visible = false;
            else
                btn_back.Visible = true;
        }

        private void UserControl_FirstRun_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            selectedLab = null;
            selectedComp = null;
            lbl_selectedComp.Text = string.Empty;
            flowLayoutPanel1.Controls.Clear();
            var list = LaboratoryHelper.GetAllLaboratories();

            if (list == null)
                return;

            foreach (Laboratory lab in list)
            {
                var ctrl = new UserControl_SetupLabItem(lab); ;
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ShowHideBackButton();
            LoadList();
        }
        

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if(selectedComp==null)
            {
                MessageBox.Show("No selected computer");
                return;
            }

            string[] lines = { selectedLab.id.ToString(), selectedComp.id.ToString() };

           
            using (StreamWriter sw = File.AppendText(ComputerHelper.firstRunTxt))
            {
               
                    sw.WriteLine(selectedLab.id);
                    sw.WriteLine(selectedComp.id);
                  
                
            }
            //open main window
            var ui = UserInterface.GetInstance();
            ui.userControl_TechnicianMainWindow.BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
