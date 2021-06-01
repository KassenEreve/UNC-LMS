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

namespace CapstoneProject.Controls.Custodian_ctrls
{
    public partial class UserControl_CustodianAddReport : UserControl
    {
        Laboratory laboratory;
        public UserControl_CustodianAddReport()
        {
            InitializeComponent();
        }

        internal void ClearItem()
        {

        }

        internal void LoadList()
        {
            if (laboratory == null)
                return;
            lbl_room.Text = laboratory.roomNum;

            panel_list.Controls.Clear();
            //computers
            var compList = ComputerHelper.Computers(laboratory);
            if (compList != null)
            {
                foreach (Computer computer in compList)
                {
                    var ctrl = new UserControl_CustodianAddReportEquipmentItem(computer);

                    panel_list.Controls.Add(ctrl);
                }
            }

            //Other equipments
            var list = EquipmentHelper.Equipments(laboratory.id);
            if (list == null)
                return;
            list.Reverse();
           
            foreach (Equipment equipment in list)
            {
                var ctrl = new UserControl_CustodianAddReportEquipmentItem(null,equipment);
              
                panel_list.Controls.Add(ctrl);
            }
        }
        private void UserControl_CustodianAddReport_Load(object sender, EventArgs e)
        {
           var   comp =  ComputerHelper.GetComputerFromFile();
           if(comp!=null)
            {
                laboratory = comp.laboratory;
            }
           else
            {
                MessageBox.Show("This computer has not been setup yet.");
            }
        }
        private void xuiRadio1_Click(object sender, EventArgs e)
        {

        }

        private void xuiRadio2_Click(object sender, EventArgs e)
        {

        }

        private void xuiRadio3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_room_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            var ctrl = new UserControl_CustodianAddReportSelectedItem();
            ctrl.Dock = DockStyle.Top;
            panel_selectedEquipments.Controls.Add(ctrl);
            panel_selectedEquipments.Controls.Add(ctrl);
            panel_selectedEquipments.Controls.Add(ctrl);
        }
    }
}
