using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickre
{
   
    public class ClasseCon
    {
        public void conexao() 
        {
            string sql = "server = ranking.cp2iq4siiv3a.us-east-2.rds.amazonaws.com;user = admin;pwd = 2303Simon123; database = ranking";
            MySqlConnection conn = new MySqlConnection(sql);
        }

    }
}
