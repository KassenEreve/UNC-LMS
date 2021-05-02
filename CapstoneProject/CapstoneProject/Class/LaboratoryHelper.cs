using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class LaboratoryHelper
    {
        public static List<Laboratory>  GetAllLaboratories()
        {
            List<Laboratory> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                var table = dal.ExecuteQuery("GetAllLaboratory").Tables[0];

                list = new List<Laboratory>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    Laboratory lab = new Laboratory()
                    {
                        id = dr.Field<int>("id"),
                        roomNum = dr.Field<string>("room_num"),
                       // equipments = EquipmentHelper.Equipments(dr.Field<int>("id"))
                        

                    };
                    list.Add(lab) ;
                }
            }

            return (list.Count() > 0) ? list : null;
        }

        internal static bool SaveLab(Laboratory saveLab)
        {
            if (saveLab == null)
                return false;

            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return false;


                SqlParameter[] param = { new  SqlParameter("@id",saveLab.id),
                                       new  SqlParameter("@name",  saveLab.roomNum)
                                        



                                       };

                try
                {

                    dal.ExecuteNonQuery("SaveLaboratory", param);




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

        internal static bool DeleteLab(Laboratory lab)
        {
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return false;

                SqlParameter[] param = { new SqlParameter("@id", lab.id) };

                try
                {
                    dal.ExecuteNonQuery("DeleteLaboratory", param);
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
