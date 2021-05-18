using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class ComputerLogHelper
    {
        public static bool SaveComputerLog(ComputerLog log)
        {
            if (log == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@student_num",log.student.studentNum),
                                       new  SqlParameter("@comp_id",log.computer.id),
                                       new  SqlParameter("@date",log.date)
                                     




                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveComputerLog", param);




                    return true;


                }
                catch (Exception ex)
                {
                    //inspect ex.Message
                    string sd = ex.Message;
                    return false;
                }




            }
        }

        internal static List<ComputerLog> GetAllLogs(Computer thisComputer)
        {
            List<ComputerLog> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@comp_id", thisComputer.id) };
                var table = dal.ExecuteQuery("GetAllCompLogs", param).Tables[0];

                list = new List<ComputerLog>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                   var saveLog = new ComputerLog()
                    {
                        id = dr.Field<int>("id"),
                        student = new Student() { studentNum= dr.Field<string>("student_num") },
                        //computer_id = dr.Field<int>("comp_id"),
                       
                        date = dr.Field<DateTime>("date_log")
                        // equipmentHistory = 



                    };
                    list.Add(saveLog);
                }
            }

            return (list.Count() > 0) ? list : null;
        }
    }
}
