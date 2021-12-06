using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            conn.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable SearchName(string FirstName)
        {
            DataTable dt = new DataTable();
            conn.Open();
            String sp = "BuscarPersonaNombre";
            SqlCommand cmd = new SqlCommand(sp, conn);

            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter param = new SqlParameter();
            param.ParameterName = "@FirstName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = FirstName;

            cmd.Parameters.Add(param);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            return dt;
        }
    }
}
