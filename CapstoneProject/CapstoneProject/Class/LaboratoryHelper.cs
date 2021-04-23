using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
