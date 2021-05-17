using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    class SoftwareGroupAssignmentHelper
    {
        internal static SoftwareGroupAssignment SaveAssignment(Computer computer)
        {
            SoftwareGroupAssignment returnAssignment = null;
            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return null;


                SqlParameter[] param = { new  SqlParameter("@comp_id",computer.id),
                                       new  SqlParameter("@group_id", computer.softwareGroup.id)



                                       };

                try
                {

                    var table = dal.ExecuteQuery("AssignSoftwareGroup", param).Tables[0];

                    returnAssignment = new SoftwareGroupAssignment();
                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        returnAssignment.id = dr.Field<int>("id");


                    }


                    return returnAssignment;


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
