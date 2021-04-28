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

        internal static bool SaveType(EquipmentType saveType)
        {
            if (saveType == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveType.id),
                                       new  SqlParameter("@name",  saveType.name),
                                        new  SqlParameter("@description",  saveType.description)




                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveEquipmentType", param);




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

        internal static List<EquipmentType> GetAllEquipmentTypes()
        {
            List<EquipmentType> list;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllEquipmentType").Tables[0];

                list = new List<EquipmentType>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    EquipmentType type = new EquipmentType()
                    {
                        id = dr.Field<int>("id"),
                        name = dr.Field<string>("name"),
                        description = dr.Field<string>("description")
                        // equipments = EquipmentHelper.Equipments(dr.Field<int>("id"))


                    };
                    list.Add(type);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

    }
}
