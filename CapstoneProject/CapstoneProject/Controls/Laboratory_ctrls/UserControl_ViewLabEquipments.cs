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
    public partial class UserControl_ViewLabEquipments : UserControl
    {
       public List<Computer> selectedComputers;
        public UserControl_ViewLabEquipments()
        {
            InitializeComponent();
        }
        Equipment equipment1;
        Laboratory laboratory;
        public void RefreshControl()
        {
            LoadList(equipment1, laboratory);
        }

        public void LoadList(Equipment equipment,Laboratory lab)
        {
            equipment1 = equipment;
            laboratory = lab;
            label1.Text = lab.roomNum+" ";
            flowLayoutPanel1.Controls.Clear();
            if (equipment == null)
            {
                label1.Text += "Computer";
                var list = ComputerHelper.Computers(lab);
                if(list!=null)
                {
                    foreach(Computer computer in list)
                    {
                       var ctrl = new UserControl_ViewLabEquipmentItem(computer);
                        flowLayoutPanel1.Controls.Add(ctrl);
                    }
                }
            }
            else
                label1.Text += equipment.equipmentType.name;

            label1.Text += " List";
            
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLab.BringToFront();
        }

     
        private void xuiButton2_Click(object sender, EventArgs e)
        {
            
            /*
            int from = this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList().FindIndex(o => o.isSelected);
            int to = this.Parent.Controls.IndexOf(this);
            List<Computer> selectedComp = new List<Computer>();
            for (int i = from; i <= to; i++)
            {
                this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList()[i].SelectItem(true);
              
            }
            if (selectedComp!=null)
            */
            if (selectedComputers != null)
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_SetSpecification.BringToFront();
                ui.userControl_SetSpecification.LoadControl(selectedComputers);//selectedComp);
            }
            else
                MessageBox.Show("No selected computers");
        }
    }
}
