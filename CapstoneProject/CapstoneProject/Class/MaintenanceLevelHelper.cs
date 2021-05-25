using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class MaintenanceLevelHelper
    {
       public static List<MaintenanceLevel> GetAllMaintenanceLevels()
        {
            List<MaintenanceLevel> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                
                var table = dal.ExecuteQuery("GetAllMaintenanceLevel").Tables[0];

                list = new List<MaintenanceLevel>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var level = new MaintenanceLevel()
                    {
                        id = dr.Field<int>("id"),
                        name =  dr.Field<string>("name") ,
                        //computer_id = dr.Field<int>("comp_id"),

                        description= dr.Field<string>("description")
                        // equipmentHistory = 



                    };
                    list.Add(level);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

       

        internal static bool SaveMaintenanceLevel(MaintenanceLevel level)
        {
            if (level == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",level.id),
                                       new  SqlParameter("@name",level.name),
                                       new  SqlParameter("@description",level.description)



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveMaintenanceLevel", param);




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
