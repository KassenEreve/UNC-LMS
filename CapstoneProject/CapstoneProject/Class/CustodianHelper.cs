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
    }
}
