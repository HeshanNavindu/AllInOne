using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne.DataLayer
{
   public class DB
    {
        public string DBConnection()
        {
            SqlConnection con;
            con = new SqlConnection("Data Source=KAUSHALYA;Initial Catalog=supermarket;Integrated Security=True");
            return con.ToString();
           
        }




    }
}
