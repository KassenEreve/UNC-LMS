using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
   public class CustodianHelper
    {
       internal static Custodian GetCustodian(int custodian_id)
        {
            Custodian custodian = null;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;

                SqlParameter[] param = { new SqlParameter("@id", custodian_id) };
                var table = dal.ExecuteQuery("GetCustodian", param).Tables[0];

                foreach (DataRow dr in table.AsEnumerable())
                {


                    custodian = new Custodian()
                    {
                        id = dr.Field<int>("id"),
                        studentNum = dr.Field<string>("id_num"),
                        fname = dr.Field<string>("fname"),
                        mname = dr.Field<string>("mname"),
                        lname = dr.Field<string>("lname")
                    };


                }

                return custodian;
            }
        }

        internal static bool SaveCustodian(Custodian saveCustodian)
        {
            if (saveCustodian == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveCustodian.id),
                                       new  SqlParameter("@fname",  saveCustodian.fname),
                                        new  SqlParameter("@mname",  saveCustodian.mname),
                                         new  SqlParameter("@lname",  saveCustodian.lname),
                                          new  SqlParameter("@idNum",  saveCustodian.studentNum),

                                        new  SqlParameter("@birthDate",  saveCustodian.birthDate),

                                         new  SqlParameter("@phone", saveCustodian.phone),
                                         new  SqlParameter("@email",  saveCustodian.email),
                                         new  SqlParameter("@password", (saveCustodian.password==null)?(object)DBNull.Value:saveCustodian.password )



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveCustodian", param);




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

        public static List<Custodian> GetAllCustodians()
        {
            List<Custodian> list = null;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllCustodian").Tables[0];

                list = new List<Custodian>();

                foreach (DataRow dr in table.AsEnumerable())
                {

                    var cust = new Custodian()
                    {
                        id = dr.Field<int>("id"),
                        fname = dr.Field<string>("fname"),
                        mname = dr.Field<string>("mname"),
                        lname = dr.Field<string>("lname"),
                        studentNum = dr.Field<string>("id_num"),
                        birthDate = dr.Field<DateTime>("birthDate"),
                        phone = dr.Field<string>("phone"),
                        email = dr.Field<string>("email")


                    };


                    list.Add(cust);
                }
            }

            return (list.Count() > 0) ? list : null;
        }
    }
}
