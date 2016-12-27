using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Provider
{
   public class DbConfig
    {

       public static string DbConnection
       {
           get
           {
               return ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            
           }
       }
    }
}
