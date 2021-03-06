using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class ComputerHelper
    {
        public static string firstRunTxt = "D:\\data.txt";// @"d:/UncLMS/firstRun.txt";
        public static List<Computer> Computers(Laboratory laboratory)
        {
            List<Computer> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@lab_id", laboratory.id) };
                var table = dal.ExecuteQuery("GetAllComputers",param).Tables[0];

                list = new List<Computer>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                    Computer computer = new Computer()
                    {
                        id = dr.Field<int>("id"),
                        pc_num = dr.Field<string>("pc_num"),
                       

                       

                    };
                    list.Add(computer);
                }
            }

            return (list.Count() > 0) ? list : null;

        }

        public static Computer getComputer(int comp_id)
        {
           Computer comp = null;
            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;

                SqlParameter[] param = { new SqlParameter("@id", comp_id) };
                var table = dal.ExecuteQuery("GetComputer", param).Tables[0];

                foreach (DataRow dr in table.AsEnumerable())
                {


                    comp = new Computer()
                    {
                        id = dr.Field<int>("id"),
                        pc_num = dr.Field<string>("pc_num"),
                        
                    };


                }

                return comp;
            }
        }
        public static List<Equipment> GetPCParts(int comp_id)
        {
            List<Equipment> list = null;

            using (DAL dal = new DAL())
            {
                if (!dal.IsConnected) return null;
                SqlParameter[] param = { new SqlParameter("@comp_id", comp_id) };
                var table = dal.ExecuteQuery("GetPCParts", param).Tables[0];

                list = new List<Equipment>();

                foreach (DataRow dr in table.AsEnumerable())
                {


                   var computer = new Equipment()
                    {
                        id = dr.Field<int>("id"),
                      
                        equipmentType = new EquipmentType() { id = dr.Field<int>("equipmentType_id"),name = dr.Field<string>("name") }




                    };
                    list.Add(computer);
                }
            }

            return (list.Count() > 0) ? list : null;
        }
        public static Computer GetComputerFromFile()
        {
            if (!File.Exists(ComputerHelper.firstRunTxt))
                return null;
            
            string[] comp_data = File.ReadAllLines(ComputerHelper.firstRunTxt);
            int labID = Convert.ToInt32(comp_data[0].Substring(comp_data[0].LastIndexOf(',') + 1));
            int compID = Convert.ToInt32(comp_data[1].Substring(comp_data[1].LastIndexOf(',') + 1));
            var compList = ComputerHelper.Computers(new Laboratory() { id = labID });
            var labList = LaboratoryHelper.GetAllLaboratories();
            var comp = compList.Find(o => o.id.Equals(compID));
            comp.laboratory = labList.Find(o => o.id.Equals(labID));
            return comp;
        }

        public static Computer SaveComputer(Computer computer)
        {
            Computer compReturn = null;
            using (DAL dal = new DAL())
            {

                if (!dal.IsConnected) return null;


                SqlParameter[] param = { new  SqlParameter("@id",computer.id),
                                       new  SqlParameter("@pc_num",  computer.pc_num)
                                        



                                       };

                try
                {

                    var table = dal.ExecuteQuery("SaveComputer", param).Tables[0];


                    foreach (DataRow dr in table.AsEnumerable())
                    {
                       compReturn = new Computer()
                        {
                            id = dr.Field<int>("id"),
                            pc_num = dr.Field<string>("pc_num")
                           
                        };


                    }


                    return compReturn;


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
