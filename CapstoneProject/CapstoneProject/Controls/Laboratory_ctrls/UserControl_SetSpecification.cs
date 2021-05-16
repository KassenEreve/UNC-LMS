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
    public partial class UserControl_SetSpecification : UserControl
    {
        List<PCSpecs> list;
        List<Computer> computers;
        public UserControl_SetSpecification()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_ViewLabEquipments.BringToFront();
            ui.userControl_ViewLabEquipments.selectedComputers = null;
            ui.userControl_ViewLabEquipments.RefreshControl();
        }

        public void LoadControl(List<Computer> computers)
        {
            this.computers = computers;
          
            foreach(Computer computer in computers)
            {
                textBox1.Text += computer.pc_num+", ";
            }
            InitComboBox();
        }
        private void InitComboBox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            list = PCSpecsHelper.GetAllPCSpecs();
           
            foreach (PCSpecs type in list)
            {
                test.Add(type.id.ToString(), type.code);

            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = -1;
           
            comboBox1.Text = "Select Specification";


        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            if (list == null || computers == null)
                return;

            var selectedSpecs = list.Find(o => o.id.Equals(Convert.ToInt32(comboBox1.SelectedValue)));

            foreach (Computer computer in computers)
            {
                computer.specifcation = selectedSpecs;
                PCSpecsHelper.AssignPCSpecs(computer);
            }
           var ui = UserInterface.GetInstance();
            ui.userControl_ViewLabEquipments.BringToFront();
            ui.userControl_ViewLabEquipments.RefreshControl();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = 0;

            try
            {
                selected = Convert.ToInt32(comboBox1.SelectedValue);
               
            }
            catch(Exception ex)
            {
                return;
            }
            var selectedSpecs = list.Find(o => o.id.Equals(selected));
            if (selectedSpecs == null)
                return;
            lbl_case.Text = selectedSpecs.casePsu;
            lbl_hdd.Text = selectedSpecs.hdd;
            lbl_memory.Text = selectedSpecs.memory;
            lbl_monitor.Text = selectedSpecs.monitor;
            lbl_motherboard.Text = selectedSpecs.motherboard;
            lbl_mouse.Text = selectedSpecs.keyboardMouse;
            lbl_processor.Text = selectedSpecs.processor;
            lbl_video.Text = selectedSpecs.video;


        }
    }
}
