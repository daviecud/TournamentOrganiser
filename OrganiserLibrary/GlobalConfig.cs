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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database == true)
            {
                //TODO - setup the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - setup the text Conector
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string ConnectString(string name)
            {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
    }
}
