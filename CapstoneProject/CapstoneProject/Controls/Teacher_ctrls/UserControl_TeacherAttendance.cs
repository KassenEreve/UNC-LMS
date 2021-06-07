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

namespace CapstoneProject.Controls.Teacher_ctrls
{
    public partial class UserControl_TeacherAttendance : UserControl
    {
        Laboratory selectedLab;
        public UserControl_TeacherAttendance()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            LoadList();
        }
        
        void LoadList()
        {
            flowLayoutPanel1.Controls.Clear();
            var computers = ComputerHelper.Computers(selectedLab);
            if (computers == null)
            {
                MessageBox.Show("This Laboratory doesnt have any saved Computers");
                return;
            }
            TimeSpan from,to;
            /*
            try
            {
                from = TimeSpan.Parse(numeric_time1A.Value + ":" + numeric_time1B.Value);
                to = TimeSpan.Parse(numeric_time2A.Value + ":" + numeric_time2B.Value);
            }
            catch (FormatException)
            {
                return;
            }
           */
            from = fromPicker.Value.TimeOfDay;
            to = toPicker.Value.TimeOfDay;
            foreach (Computer computer in computers)
            {
               
                var ctrl = new UserControl_TeacherAttendanceItem(computer,from,to); 
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        private void UserControl_TeacherAttendance_Load(object sender, EventArgs e)
        {
            fromPicker.Value = DateTime.Now.Date + new TimeSpan(0, 0, 0);
            toPicker.Value = DateTime.Now.Date + new TimeSpan(0, 0, 0);
            var comp = ComputerHelper.GetComputerFromFile();

            if(comp!=null)
            {
                selectedLab = comp.laboratory;
               
                lbl_lab.Text = "LABORATORY: "+selectedLab.roomNum;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            List<Attendance> attendance_print = new List<Attendance>();
            foreach(UserControl_TeacherAttendanceItem ctrl in flowLayoutPanel1.Controls.OfType<UserControl_TeacherAttendanceItem>())
            {
                attendance_print.Add(ctrl.GetLatestLog());
            }
            if(attendance_print.Count>0)
            AttendanceHelper.printAttendance(attendance_print);
        }
    }
}
