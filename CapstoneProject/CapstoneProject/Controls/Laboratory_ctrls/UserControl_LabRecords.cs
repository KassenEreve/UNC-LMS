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
    public partial class UserControl_LabRecords : UserControl
    {
        public UserControl_LabRecords()
        {
            InitializeComponent();
        }

        internal void LoadList()
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            //technician
            var labs = LaboratoryHelper.GetAllLaboratories();
            Dictionary<string, string> test = new Dictionary<string, string>();

            foreach (Laboratory lab in labs)
            {
                test.Add(lab.id.ToString(), lab.roomNum);

            }

            comboBox_Laboratory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Laboratory.DataSource = new BindingSource(test, null);
            comboBox_Laboratory.DisplayMember = "Value";
            comboBox_Laboratory.ValueMember = "Key";
            comboBox_Laboratory.SelectedIndex = -1;
            comboBox_Laboratory.Text = "Select Type";
        }
    }
}
