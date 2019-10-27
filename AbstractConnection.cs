using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии соединения с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
