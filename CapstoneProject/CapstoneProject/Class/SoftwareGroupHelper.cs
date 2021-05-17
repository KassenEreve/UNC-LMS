using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class SoftwareGroupHelper
    {
        internal static List<SoftwareGroup>  GetAllSoftwareGroups()
        {
          
            List<SoftwareGroup> list;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllSoftwareGroups").Tables[0];

                list = new List<SoftwareGroup>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new SoftwareGroup()
                    {
                        id = dr.Field<int>("id"),
                        name = dr.Field<string>("name"),
                        softwares = GetSoftwareGroupMembers(dr.Field<int>("id"))
                        // equipments = EquipmentHelper.Equipments(dr.Field<int>("id"))


                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool HasSoftwareAssignment(Computer computer)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;
                SqlParameter[] param = { new SqlParameter("@id", computer.id) };
                var table = dal.ExecuteQuery("GetCountSoftwareAssignment", param).Tables[0];

                

                foreach (DataRow dr in table.AsEnumerable())
                {

                    if (dr.Field<int>("count") > 0)
                        return true;
                    
                }
            }
            return false;

        }

        internal static List<Software> GetSoftwareGroupMembers(int groupID)
        {
            List<Software> list;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@id", groupID) };
                var table = dal.ExecuteQuery("GetAllSoftwareGroupMembers",param).Tables[0];

                list = new List<Software>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new Software()
                    {
                        id = dr.Field<int>("software_id"),
                        name = dr.Field<string>("name"),
                        description = dr.Field<string>("description")
                        // equipments = EquipmentHelper.Equipments(dr.Field<int>("id"))


                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool SaveGroupSoftwares(SoftwareGroup softwareGroup)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;

                foreach (Software software in softwareGroup.softwares)
                {




                    SqlParameter[] param = { new  SqlParameter("@software_id",software.id),
                                       new  SqlParameter("@softwareGroup_id", softwareGroup.id)



                                       };

                    try
                    {
                        dal.ExecuteNonQuery("SaveSoftwareGroupList", param);
                      
                    }
                    catch (Exception ex)
                    {
                        //inspect ex.Message
                        string sd = ex.Message;
                        return false;
                    }
                }
                return true;

            }
        }

        

        internal static SoftwareGroup Save(SoftwareGroup softwareGroup)
        {
            SoftwareGroup groupReturn = null;
            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return null;


                SqlParameter[] param = { new  SqlParameter("@id",softwareGroup.id),
                                       new  SqlParameter("@name", softwareGroup.name)
                                  


                                       };

                try
                {

                    var table = dal.ExecuteQuery("SaveSoftwareGroup", param).Tables[0];


                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        groupReturn = new SoftwareGroup()
                        {
                            id = dr.Field<int>("id"),
                            name = dr.Field<string>("name")
                           
                        };


                    }


                    return groupReturn;


                }
                catch (Exception ex)
                {
                    //inspect ex.Message
                    string sd = ex.Message;
                    return null;
                }




            }
        }
    }
}
