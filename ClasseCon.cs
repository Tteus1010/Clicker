using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clickre
{
   
    public class ClasseCon
    {
        string sql = "server = localhost;user = root;pwd = 12345678; database = rankingatual";
        MySqlConnection conn = new MySqlConnection();
    }
}
