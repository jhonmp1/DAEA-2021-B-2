using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class clsDAO
    {
        public SqlConnection conn;
        public clsDAO()
        {
            String srt = "Server=DESKTOP-4OJ54RK\\SQLEXPRESS2017; DataBase=School;Integrated Security=true";
            conn = new SqlConnection(srt);
        }
    }

}

