using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Common
{
   public static class AppConfig
    {

       public static string WorkSpace
       {
           get { return ConfigurationManager.AppSettings["workspace"]; }
       }
    }
}
