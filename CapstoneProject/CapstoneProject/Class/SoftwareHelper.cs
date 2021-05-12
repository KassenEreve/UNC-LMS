using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class SoftwareHelper
    {
        public static List<Software> GetAllSoftwares()
        {
            List<Software> list;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllSoftware").Tables[0];

                list = new List<Software>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var type = new Software()
                    {
                        id = dr.Field<int>("id"),
                        name = dr.Field<string>("name"),
                        description = dr.Field<string>("description")
                       


                    };
                    list.Add(type);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool Save(Software save)
        {
            if (save == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",save.id),
                                       new  SqlParameter("@name",  save.name),
                                        new  SqlParameter("@description",  save.description)
                                   



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveSoftware", param);




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
