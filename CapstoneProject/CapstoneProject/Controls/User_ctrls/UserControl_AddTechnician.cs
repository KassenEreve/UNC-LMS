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

namespace CapstoneProject.Controls.User_ctrls
{
    public partial class UserControl_AddTechnician : UserControl
    {
        Technician technician = null;
        public UserControl_AddTechnician()
        {
            InitializeComponent();
        }

       

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveTech = new Technician()
            {
                idNum = textBox_idNum.Text,
                fname = textBox_fname.Text,
                mname = textBox_mname.Text,
                lname = textBox_lname.Text,
                gender = 0,
                dateHired = dateTimePicker1.Value,
                phone = textBox_phone.Text,
                email = textBox_email.Text,
                photo = ""

            };
            if (technician != null)
                saveTech.id = technician.id;
            if (TechnicianHelper.SaveTechnician(saveTech))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_TechnicianList.BringToFront();
                ui.userControl_TechnicianList.LoadList();

                technician = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_TechnicianList.BringToFront();
            technician = null;
        }
      
        internal void UpdateItem(Technician technician)
        {
            this.technician = technician;
            textBox_idNum.Text = technician.idNum;
            textBox_fname.Text = technician.fname;
            textBox_mname.Text = technician.mname;
            textBox_lname.Text = technician.lname;
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = technician.dateHired;
            textBox_phone.Text = technician.phone;
            textBox_email.Text = technician.email;
        }
        public void ClearItem()
        {
            textBox_idNum.Text = string.Empty;
            textBox_fname.Text = string.Empty;
            textBox_mname.Text = string.Empty;
            textBox_lname.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            textBox_phone.Text = string.Empty;
            textBox_email.Text = string.Empty;
        }
    }
}
