using System;
using System.Collections.Generic;
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
    }
}
