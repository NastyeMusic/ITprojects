using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class AbstractConnection
    {
        private SqlConnection conn;

        public AbstractConnection(SqlConnection c)
        {
            conn = c;
        }

        public void Open()
        {
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public AbstractTransaction BeginTransaction()
        {
            SqlTransaction tr = conn.BeginTransaction();
            AbstractTransaction result = new AbstractTransaction(tr);
            return result;
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
