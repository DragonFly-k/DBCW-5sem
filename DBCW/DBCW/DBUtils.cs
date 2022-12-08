using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "192.168.155.6";
            int port = 1521;
            string sid = "orcl";
            string user = "C##Client";
            string password = "Password123";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
