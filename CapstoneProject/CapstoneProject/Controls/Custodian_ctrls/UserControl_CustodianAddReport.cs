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
        List<Computer> selectedComputers;
        List<Equipment> selectedEquipments;
        Custodian custodian;
        public UserControl_CustodianAddReport()
        {
            InitializeComponent();
        }

        internal void ClearItem()
        {

        }

        internal void LoadList(Custodian _custodian)
        {
            if (laboratory == null)
                return;

            if (_custodian == null)
                return;

            this.custodian = _custodian;
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
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            if (selectedComputers != null)
            {
                selectedComputers.Reverse();
               
                foreach (Computer computer in selectedComputers)
                {
                    


                    var selectedCtrl = new UserControl_CustodianAddReportSelectedItem(computer,null);
                    selectedCtrl.Dock = DockStyle.Top;
                    panel_selectedEquipments.Controls.Add(selectedCtrl);
                 



                }
            }

            if(selectedEquipments!=null)
            {
                selectedEquipments.Reverse();
               
                foreach (Equipment equipment in selectedEquipments)
                {
                   

                    var selectedCtrl = new UserControl_CustodianAddReportSelectedItem( null, equipment);
                    selectedCtrl.Dock = DockStyle.Top;
                    panel_selectedEquipments.Controls.Add(selectedCtrl);



                }
            }
          
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
           var list = selectedComputers.FindAll(o => o.pcparts_equipment.Exists(eq => eq.selectedDefective));
            selectedComputers = new List<Computer>();
            

            var reportItems = new List<CustodianReportedItem>();
            //save
            foreach (UserControl_CustodianAddReportSelectedItem ctrl in panel_selectedEquipments.Controls.OfType<UserControl_CustodianAddReportSelectedItem>())
            {
                var save = new CustodianReportedItem();
                if (ctrl.computer != null)
                {
                    selectedComputers.Add(ctrl.computer);
                    var defective = ctrl.computer.pcparts_equipment.Find(o => o.selectedDefective);
                    if(defective==null)
                    {
                        MessageBox.Show("Pls select the pc part for computer[ " + ctrl.computer.pc_num + " ].");
                        return;
                    }
                    save.equipment = defective;
                }
                else if (ctrl.equipment != null)
                {
                    save.equipment = ctrl.equipment;
                }

                save.issueDescription = ctrl.GetDescription();
               
                reportItems.Add(save);
            }


            if (laboratory == null)
            {
                MessageBox.Show("Computer has not been setup yet.");
                return;
            }
            //proceed saving

            CustodianReport report = CustodianReportHelper.SaveReport(new CustodianReport() { custodian = this.custodian, laboratory = this.laboratory, date = DateTime.Now });

            report.custodianReportedItems = reportItems;
            if (CustodianReportedItemHelper.SaveReportedItems(report))
            {
                MessageBox.Show("Saved successfully!");
            }

        }

        internal void SetSelectedEquipments(List<Computer> selectedComputers, List<Equipment> selectedEquipments)
        {
            this.selectedComputers = selectedComputers;
            this.selectedEquipments = selectedEquipments;
        }
        private void xuiButton2_Click(object sender, EventArgs e)
        {

            var ui = UserInterface.GetInstance();
            ui.userControl_CustodianReport.LoadList();
            ui.userControl_CustodianReport.BringToFront();
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

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
