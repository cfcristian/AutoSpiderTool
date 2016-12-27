using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Provider
{
    public static class DbHelper
    {




        public static List<string> GetTables()
        {
            string sql = @"Select Name FROM SysObjects Where XType='U' 
                            orDER BY Name ";

            using (var conn = new SqlConnection(DbConfig.DbConnection))
            {
                return conn.Query<string>(sql).ToList();
            }
        }


        public static List<string> GetColumns(string tbName)
        {
            string sql = @" Select Name FROM SysColumns Where id=Object_Id(@tbName)   ";

            using (var conn = new SqlConnection(DbConfig.DbConnection))
            {
                return conn.Query<string>(sql, new { tbName }).ToList();
            }
        }
    }
}
