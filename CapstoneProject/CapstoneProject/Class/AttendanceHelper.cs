using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class AttendanceHelper
    {
        static PrintDocument pdEmp = null;
        static List<Attendance> attendance_list;
       
        internal static void printAttendance(List<Attendance> _attendance_list)
        { 
            attendance_list = _attendance_list;
           
            pdEmp = new PrintDocument();
            pdEmp.PrintPage += pdEmp_PrintPage;


            System.Windows.Forms.PrintPreviewDialog ppdPreview = new System.Windows.Forms.PrintPreviewDialog();
            ppdPreview.Document = pdEmp;

            ppdPreview.ShowDialog();

            pdEmp.PrintPage -= pdEmp_PrintPage;
        }

        public static void pdEmp_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (attendance_list == null|| attendance_list.Count.Equals(0))
                return;


            //print a text
            Font font = new Font("Verdana", 12, FontStyle.Regular);
            Font boldFont = new Font("Verdana", 12, FontStyle.Bold);
            Font smallFont = new Font("Verdana", 9, FontStyle.Regular);
            Font underLine = new Font("Verdana", 13, FontStyle.Underline);
            int x = 30;
            int y = 50;
            //print logo

          //  e.Graphics.DrawImage((employee.photo != string.Empty) ? UserInterface.Base64StringToImage(employee.photo) : DB2_StaffRotationManager.Properties.Resources.profile, 25, 35, 190, 190); // profile pic
          //  if (employee.digitalSign != string.Empty) e.Graphics.DrawImage(UserInterface.Base64StringToImage(employee.digitalSign), 25, 235, 190, 80);//sign
            x += 230;


            e.Graphics.DrawString("UNIVERSITY OF NUEVA CACERES", boldFont, Brushes.Black, x-30, y);
            y += 25;
            e.Graphics.DrawString("CITY OF NAGA", boldFont, Brushes.Black, x+50, y);
            y += 60;
            e.Graphics.DrawString("STUDENT ATTENDANCE LIST", boldFont, Brushes.Black, x, y);
          //  y += 80;
           // e.Graphics.DrawString((employee.gender.Equals("Male") ? "MR. " + employee.fname + " " + employee.lname : "MS. " + employee.fname + " " + employee.lname), new Font("Arial", 32, FontStyle.Bold), Brushes.Black, x + 10, y);
            y += 65;
            //e.Graphics.DrawString(employee.contactInfo.address + ", " + employee.contactInfo.zipCode.location + " " + employee.contactInfo.zipCode.code, font, Brushes.Black, x, y);
            y += 35;
            //print a line
            e.Graphics.DrawString("DATE : " + DateTime.Now.ToShortDateString(), font, Brushes.Black, x-200, y) ;
            e.Graphics.DrawString("SCHEDULE : " + attendance_list[0].fromTime.ToString()+" - " + attendance_list[0].toTime.ToString(), font, Brushes.Black, x-200 , y+30);

            e.Graphics.DrawString("LABORATORY : " + ComputerHelper.GetComputerFromFile().laboratory.roomNum, font, Brushes.Black, x + 170, y);

            y += 125;
            x -= 180;
            e.Graphics.DrawString("LATE STUDENTS", boldFont, Brushes.Black, x+350, y);
            y += 50;
            int ctr=0;
            foreach(Attendance att in attendance_list.FindAll(o=>o.isLate))
            {
                e.Graphics.DrawString(att.log.student.studentNum, font, Brushes.Black, x + 370, y);
                y += 30;
                ctr += 30;
            }
            y -=ctr+50;
            e.Graphics.DrawString("STUDENTS", boldFont, Brushes.Black, x+10, y);
            y += 50;
            foreach (Attendance att in attendance_list.FindAll(o => !o.isLate))
            {
                e.Graphics.DrawString(att.log.student.studentNum, font, Brushes.Black, x + 20, y);
                y += 30;
            }
          
          



         
            e.HasMorePages = false;

        }
    }
}
