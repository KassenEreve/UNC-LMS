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
  
    public partial class UserControl_ViewLabItem : UserControl
    {
        
        private int computerCount = 0,ctr=0;
        Equipment Equipment;
        public UserControl_ViewLabItem(Equipment equipment, int ctr,int  computerCount=0 )
        {
            InitializeComponent();
            this.Equipment = equipment;
            this.computerCount = computerCount;
            this.ctr = ctr;
        }

        private void UserControl_ViewLabItem_Load(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void xuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            xuiButton1.ContextMenuStrip.Show(xuiButton1, new Point(e.X, e.Y));
        }

        private void UpdateItem()
        {
            lbl_roomID.Text = ctr.ToString();
            if (Equipment==null)
            {
                lbl_equipment.Text = "Computers";
                lbl_count.Text = computerCount.ToString();
            }
            else
            {
               

                lbl_equipment.Text = Equipment.equipmentType.name;
                lbl_count.Text = "";
            }
        }
    }
}
