using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class EquipmentTypeHelper
    {
        private static List<EquipmentType> types;
        public static EquipmentType getEquipmentType(int type_id)
        {
           EquipmentType type = null;
            
          
            if (types == null)//if theres a store object use it instead of querying to the db
            {
                using (DAL dal = new DAL())
                {
                   

                    if (!dal.IsConnected) return null;
                    var table = dal.ExecuteQuery("GetAllEquipmentType").Tables[0];

                    types = new List<EquipmentType>();

                    foreach (DataRow dr in table.AsEnumerable())
                    {


                       var save_type = new EquipmentType()
                        {
                            id = dr.Field<int>("id"),
                            name = dr.Field<string>("name"),

                        };

                       types.Add(save_type);
                    }

                    

                   
                }
            }
            else
            {
                type = types.Find(o => o.id.Equals(type_id));
            }


            return type;
        }
    }
}
