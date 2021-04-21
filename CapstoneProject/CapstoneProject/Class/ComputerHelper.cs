using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class ComputerHelper
    {
        public static List<Computer> Computers(Laboratory laboratory)
        {
            List<Computer> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@id", laboratory.id) };
                var table = dal.ExecuteQuery("GetAllComputers",param).Tables[0];

                list = new List<Computer>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    Computer computer = new Computer()
                    {
                        id = dr.Field<int>("id"),
                        pc_num = dr.Field<string>("pc_num"),
                       

                       

                    };
                    list.Add(computer);
                }
            }

            return (list.Count() > 0) ? list : null;

        }
    }
}
