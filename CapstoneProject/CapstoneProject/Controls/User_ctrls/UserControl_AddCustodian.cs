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
    public partial class UserControl_AddCustodian : UserControl
    {
        Custodian custodian;
        public UserControl_AddCustodian()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var saveCustodian = new Custodian()
            {
                studentNum = textBox_idNum.Text.Trim(),
                fname = textBox_fname.Text.Trim(),
                mname = textBox_mname.Text.Trim(),
                lname = textBox_lname.Text.Trim(),
                
                birthDate = dateTimePicker1.Value,
                phone = textBox_phone.Text.Trim(),
                email = textBox_email.Text.Trim(),
              

            };
            if (custodian != null)
                saveCustodian.id = custodian.id;
            if (CustodianHelper.SaveCustodian(saveCustodian))
            {
                var ui = UserInterface.GetInstance();
                ui.userControl_CustodianList.BringToFront();
                ui.userControl_CustodianList.LoadList();

                custodian = null;
            }
            else
            {
                MessageBox.Show("Failed to save!");
            }
        }

        internal void ClearItem()
        {
            custodian = null;
            textBox_idNum.Text = string.Empty;
            textBox_fname.Text = string.Empty;
            textBox_mname.Text = string.Empty;
            textBox_lname.Text = string.Empty;
           
            dateTimePicker1.Value = DateTime.Now;
            textBox_phone.Text = string.Empty;
            textBox_email.Text = string.Empty;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            var ui = UserInterface.GetInstance();
            ui.userControl_CustodianList.BringToFront();
            custodian = null;
        }
    }
}
