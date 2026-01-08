using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace MovieHubProjectV3
{
    
    public class SQLBaglantisi
    {
        public SqlConnection baglanti()
        {
            
            SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=movieHubDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}