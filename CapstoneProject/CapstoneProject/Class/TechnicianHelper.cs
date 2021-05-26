using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class TechnicianHelper
    {
        public static List<Technician> GetAllTechnicians()
        {
            List<Technician> list;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllTechnician").Tables[0];

                list = new List<Technician>();

                foreach (DataRow dr in table.AsEnumerable())
                {

                    var tech = new Technician()
                    {
                        id = dr.Field<int>("id"),
                        fname = dr.Field<string>("fname"),
                        mname = dr.Field<string>("mname"),
                        lname = dr.Field<string>("lname"),
                        idNum = dr.Field<string>("idNumber"),
                        gender = dr.Field<int>("gender"),
                        birthDate = dr.Field<DateTime>("birthDate"),
                        photo = dr.Field<string>("photo"),
                        phone = dr.Field<string>("phone"),
                        email = dr.Field<string>("email"),
                        password = dr.Field<string>("password")
                    };

                   
                    list.Add(tech);
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool DeleteTechnician(Technician technician)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;

                SqlParameter[] param = { new SqlParameter("@id", technician.id) };

                try
                {
                    dal.ExecuteNonQuery("DeleteTechnician", param);
                    return true;
                }
                catch (Exception ex)
                {
                    string dsd = ex.ToString();
                    return false;
                }

            }
        }

        internal static bool SaveTechnician(Technician saveTech)
        {
            if (saveTech == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveTech.id),
                                       new  SqlParameter("@fname",  saveTech.fname),
                                        new  SqlParameter("@mname",  saveTech.mname),
                                         new  SqlParameter("@lname",  saveTech.lname),
                                          new  SqlParameter("@idNum",  saveTech.idNum),
                                          new  SqlParameter("@gender",  saveTech.gender),
                                        new  SqlParameter("@birthDate",  saveTech.birthDate),
                                         new  SqlParameter("@photo",  saveTech.photo),
                                         new  SqlParameter("@phone",  saveTech.phone),
                                         new  SqlParameter("@email",  saveTech.email),
                                         new  SqlParameter("@password", (saveTech.password==null)?(object)DBNull.Value:saveTech.password )



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveTechnician", param);




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
