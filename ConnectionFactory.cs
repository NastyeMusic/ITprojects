using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    static class ConnectionFactory
    {
        static public AbstractConnection getConnection()
        {
            //String connString = @"Data Source=DESKTOP-RPN2KIG\SQLEXPRESS;Initial Catalog=AutoschoolDataBase;Integrated Security=True;Pooling=False";

            string connString = Properties.Settings.Default.ConnectionString;
            AbstractConnection conn = new AbstractConnection(new SqlConnection(connString));
            return conn;
        }
    }
}
