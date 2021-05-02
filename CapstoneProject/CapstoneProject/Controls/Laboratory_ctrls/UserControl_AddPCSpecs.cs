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
    public partial class UserControl_AddPCSpecs : UserControl
    {
        PCSpecs specs = null;
        public UserControl_AddPCSpecs()
        {
            InitializeComponent();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_PcSpecsList.BringToFront();
            specs = null;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveSpec = new PCSpecs() {
                processor = textBox_processor.Text,
                motherboard = textBox_motherboard.Text,
                memory = textBox_memory.Text,
                video = textBox_video.Text,
                hdd=textBox_hdd.Text,
                casePsu = textBox_casePsu.Text,
                keyboardMouse = textBox_keyboardMouse.Text,
                monitor = textBox_monitor.Text,
                optical = textBox_optical.Text
            };

            if (specs != null)
                saveSpec.id = specs.id;
            if (PCSpecsHelper.SavePCSpecs(saveSpec))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_PcSpecsList.BringToFront();
                ui.userControl_PcSpecsList.LoadList();

                specs = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        internal void UpdateItem(PCSpecs specs)
        {
            this.specs = specs;
            textBox_casePsu.Text = specs.casePsu;
            textBox_hdd.Text = specs.hdd;
            textBox_keyboardMouse.Text = specs.keyboardMouse;
            textBox_memory.Text = specs.memory;
            textBox_monitor.Text = specs.monitor;
            textBox_motherboard.Text = specs.motherboard;
            textBox_optical.Text = specs.optical;
            textBox_processor.Text = specs.processor;
            textBox_video.Text = specs.video;
        }
        internal void ClearItem()
        {
            textBox_casePsu.Text = String.Empty;
            textBox_hdd.Text = String.Empty;
            textBox_keyboardMouse.Text = String.Empty;
            textBox_memory.Text = String.Empty;
            textBox_monitor.Text = String.Empty;
            textBox_motherboard.Text = String.Empty;
            textBox_optical.Text = String.Empty;
            textBox_processor.Text = String.Empty;
            textBox_video.Text = String.Empty;
        }
    }
}
