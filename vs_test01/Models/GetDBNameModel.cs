using System;
using System.Configuration;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_test01.Models
{
    class GetDBNameModel
    {
        public static readonly string LocalSqlServer = "LocalSqlServer";
        public static List<DBModel> getDBName()
        {
            List<DBModel> dblist = new List<DBModel>();
            foreach (ConnectionStringSettings conn in ConfigurationManager.ConnectionStrings)
            {
                if ( !conn.Name.Equals(LocalSqlServer) )
                {
                    DBModel model = new DBModel();
                    model.DBName = conn.Name;
                    dblist.Add(model);
                }
            }
            return dblist;
        }
    }
}
