using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        SqlConnection cn = new SqlConnection();
        
        public void OpenConnection()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=BDDorregoFC;Integrated Security=True;";
            cn.Open();
        }

        public void CloseConnection()
        {
            cn.Close();
        }

        public DataTable Read(string sp, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            OpenConnection();

            SqlCommand cmd = new SqlCommand
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = sp
            };
            
            if (parameters != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
            }

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            CloseConnection();
            return dt;
        }

        public bool Write(string sp, SqlParameter[] parameters)
        {
            if (parameters.Length == 0) return false;
            int Insert = -1;

            OpenConnection();
            SqlTransaction transaction = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sp,
                    Connection = cn,
                    Transaction = transaction
                };

                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
                Insert = cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message); //borrar dsp
            }
            finally
            {
                CloseConnection();
            }

            return Insert != -1;
        }

    }
}
