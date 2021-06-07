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
    public partial class UserControl_TeacherAttendanceItem : UserControl
    {
        Computer computer;
        TimeSpan from, to;
        Attendance attendance;
        public UserControl_TeacherAttendanceItem(Computer computer,TimeSpan from,TimeSpan to)
        {
            InitializeComponent();
            this.computer = computer;
            this.from = from;
            this.to = to;
        }

        private void UserControl_TeacherAttendanceItem_Load(object sender, EventArgs e)
        {
            if (computer is null)
                return;
            attendance = new Attendance();
            computer.computeLogs = ComputerLogHelper.GetAllLogs(computer);
            if (computer.computeLogs != null)
            {
                computer.computeLogs = computer.computeLogs.FindAll(o => o.date.Date.Equals(DateTime.Now.Date));
                if (computer.computeLogs != null)
                    computer.computeLogs = computer.computeLogs.FindAll(o => o.date.TimeOfDay >= from && o.date.TimeOfDay <= to);
                computer.computeLogs.Reverse();
            }
            LoadItem();
        }
        internal void LoadItem()
        {
            lbl_comp.Text = computer.pc_num;
            if (computer.computeLogs != null)
            {
                if (computer.computeLogs.Count > 0)
                {
                    attendance.log = computer.computeLogs[0];
                    attendance.fromTime = from;
                    attendance.toTime = to;
                    lbl_student.Text = computer.computeLogs[0].student.studentNum;
                    lbl_time.Text = computer.computeLogs[0].date.TimeOfDay.ToString();
                    var timeSub = computer.computeLogs[0].date.TimeOfDay.Subtract(from);
                    if (timeSub>new TimeSpan(0,15,0))
                    {
                        //means the student was late
                        lbl_time.ForeColor = Color.Red;
                        lbl_time.Text += "\n LATE";
                        attendance.isLate = true;
                    }
                }
                else
                {

                    Parent.Controls.Remove(this);
                }
            }
            else
            {
                Parent.Controls.Remove(this);
            }

        }
        public Attendance GetLatestLog()
        {

            return attendance;
        }
    }
}
