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
    public partial class UserControl_ViewLabEquipmentItem : UserControl
    {
        Computer computer;
        public bool isSelected = false;
        public UserControl_ViewLabEquipmentItem(Computer computer)
        {
            InitializeComponent();
            this.computer = computer;
        }

        private void UserControl_ViewLabEquipmentItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            xuiButton1.ButtonText = computer.pc_num;
            
            this.BackColor = Color.FromArgb(248, 248, 248);
          
            if (!PCSpecsHelper.HasSpecsAssignment(computer))
                this.BackColor = Color.Yellow;
            if (!SoftwareGroupHelper.HasSoftwareAssignment(computer))
                this.BackColor = Color.Red;

        }
        public void SelectItem(bool forceSelect=false,bool deSelect=false)
        {
            if (isSelected&&!forceSelect)
            {
                isSelected = false;
                xuiButton1.BackgroundColor = Color.White;
            }
            else
            {
                isSelected = true;
                xuiButton1.BackgroundColor = Color.Gray;
            }

            if(deSelect)
            {
                isSelected = false;
                xuiButton1.BackgroundColor = Color.White;
            }
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            
            List<Computer> selectedComputers  = null;
            if (ModifierKeys.HasFlag(Keys.Control))
            {
               
               int from= this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList().FindIndex(o => o.isSelected);
                int to = this.Parent.Controls.IndexOf(this);
                if (from >= 0 && to >= 0)
                {
                   selectedComputers =  new List<Computer>();
                    for (int i = from; i <= to; i++)
                    {
                        this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList()[i].SelectItem(true);
                       
                    }
                }
               

            }
            else
            {
               
                foreach(UserControl_ViewLabEquipmentItem ctrl in this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList())
                {
                    ctrl.SelectItem(false, true);
                }
                      
                SelectItem();
            }
            var list = this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList().FindAll(o => o.isSelected);
            if (list != null&&list.Count>0)
            {
                selectedComputers = new List<Computer>();
                foreach (UserControl_ViewLabEquipmentItem ctrl in list)
                {
                    selectedComputers.Add(ctrl.computer);
                }
                UserInterface.GetInstance().userControl_ViewLabEquipments.selectedComputers = selectedComputers;
            }
        }
    }
}
