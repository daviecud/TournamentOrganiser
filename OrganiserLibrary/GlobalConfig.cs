using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public static class GlobalConfig 
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {

            if(db == DatabaseType.Sql)
            {
                //TODO - setup the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - setup the text Conector
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string ConnectString(string name)
            {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
    }
}
