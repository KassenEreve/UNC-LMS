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

namespace CapstoneProject.Controls.First_Setup
{
    public partial class UserControl_SetupComputerItem : UserControl
    {
        public bool isSelected = false;
        Computer computer;
        public UserControl_SetupComputerItem(Computer computer)
        {
            InitializeComponent();
            this.computer = computer;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            SelectItem();
           
        }

        private void SelectItem()
        {
            if(isSelected)
            {
                isSelected = false;
                this.BackColor = Color.FromArgb(248, 248, 248);
            }
            else
            {        
                this.Parent.Controls.OfType<UserControl_SetupComputerItem>().ToList().FindAll(o => o.isSelected).ForEach(o=>o.SelectItem());
                isSelected = true;
                this.BackColor = Color.Green;
                UserInterface.GetInstance().userControl_FirstRun.SelectComputer(computer);
            }
        }

        private void UserControl_SetupComputerItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            xuiButton1.ButtonText = computer.pc_num; 
        }
    }
}
