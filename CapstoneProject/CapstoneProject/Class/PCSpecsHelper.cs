using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public  class PCSpecsHelper
    {

        public static List<PCSpecs> GetAllPCSpecs()
        {
            List<PCSpecs> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllPCSpecs").Tables[0];

                list = new List<PCSpecs>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    var save = new PCSpecs()
                    {
                        id = dr.Field<int>("id"),
                        code = dr.Field<string>("specs_code"),
                        processor = dr.Field<string>("processor"),
                        motherboard = dr.Field<string>("motherboard"),
                        memory = dr.Field<string>("memory"),
                        video = dr.Field<string>("video"),
                        hdd = dr.Field<string>("hdd"),
                        casePsu = dr.Field<string>("casePsu"),
                        keyboardMouse = dr.Field<string>("keyboardMouse"),
                        monitor = dr.Field<string>("monitor"),
                        optical = dr.Field<string>("processor"),
                        // equipments = EquipmentHelper.Equipments(dr.Field<int>("id"))


                    };
                    list.Add(save);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool HasSpecsAssignment(Computer computer)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;
                SqlParameter[] param = { new SqlParameter("@computer_id", computer.id) };
                var table = dal.ExecuteQuery("GetCountSpecsAssignment", param).Tables[0];



                foreach (DataRow dr in table.AsEnumerable())
                {

                    if (dr.Field<int>("count") > 0)
                        return true;

                }
            }
            return false;
        }

        internal static bool SavePCSpecs(PCSpecs saveSpec)
        {
            if (saveSpec == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveSpec.id),
                                       new  SqlParameter("@code",saveSpec.code),
                                       new  SqlParameter("@processor",saveSpec.processor),
                                       new  SqlParameter("@motherboard",saveSpec.motherboard),
                                       new  SqlParameter("@memory",saveSpec.memory),
                                       new  SqlParameter("@video",saveSpec.video),
                                       new  SqlParameter("@hdd",saveSpec.hdd),
                                       new  SqlParameter("@casePsu",saveSpec.casePsu),
                                       new  SqlParameter("@keyboardMouse",saveSpec.keyboardMouse),
                                       new  SqlParameter("@monitor",saveSpec.monitor),
                                       new  SqlParameter("@optical",saveSpec.optical)




                                       };

                try
                {

                    dal.ExecuteNonQuery("SavePCSpecs", param);




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

        internal static bool Delete(PCSpecs specs)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;

                SqlParameter[] param = { new SqlParameter("@id", specs.id) };

                try
                {
                    dal.ExecuteNonQuery("DeletePCSpecs", param);
                    return true;
                }
                catch (Exception ex)
                {
                    string dsd = ex.ToString();
                    return false;
                }

            }
        }
    }
}
