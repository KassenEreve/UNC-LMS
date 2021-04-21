using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Class
{
    public class DAL : IDisposable
    {
        SqlConnection sqlConn = null;
        public bool IsConnected { get; private set; }

        public DAL()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Server=LAPTOP-GRU0N4NE\SQLEXPRESS01; Integrated Security = True; Database = UncLMSDB";

            IsConnected = false;
            try
            {
                sqlConn.Open();
                IsConnected = true;
            }
            catch (Exception)
            {
                //REPORT AN OCCURRENCE OF AN ERROR
                throw;
            }
        }

        void IDisposable.Dispose()
        {
            sqlConn.Close();
        }


        public DataSet ExecuteQuery(string spName, SqlParameter[] param = null)
        {
            using (SqlCommand cmd = new SqlCommand(spName, sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;
            }
        }


        public void ExecuteNonQuery(string spName, SqlParameter[] param = null)
        {
            using (SqlCommand cmd = new SqlCommand(spName, sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);

                cmd.ExecuteNonQuery();
            }
        }


    }
}
