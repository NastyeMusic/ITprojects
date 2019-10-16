using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    class ConnectionFactory
    {
        public AbstractConnection getConnection()
        {
            String connString = @"Data Source=DESKTOP-RPN2KIG\SQLEXPRESS;Initial Catalog=Autoschool;Integrated Security=True;Pooling=False";
            AbstractConnection conn = new AbstractConnection(new SqlConnection(connString));
            return conn;
        }
    }
}
