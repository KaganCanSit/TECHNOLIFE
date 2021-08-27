using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Technolife
{
    class SqlConnect
    { 
        public SqlConnection Connect()
        {
            SqlConnection Connect = new SqlConnection(@"Data Source=KAGANCANSIT\KAGANCANSIT; Initial Catalog=Technolife; Integrated Security=True");
            Connect.Open();
            return Connect;
        }
    }
}
