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
            CONNTOBD:
            try
            {
                conn.Open();
            }
            catch
            {
                //MessageBox.Show("Ошибка при открытии соединения с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult result = MessageBox.Show("Произошла ошибка при открытии соединения с БД. Хотите изменить параметры подключения к БД?", "Ошибка подключения к БД", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PathToBDForm PathToBDForm = new PathToBDForm();
                    PathToBDForm.ShowDialog();
                    if (PathToBDForm.DialogResult == DialogResult.OK)
                    {
                        conn = new SqlConnection(ConnectionFactory.getConnection().conn.ConnectionString);
                        goto CONNTOBD;
                    }
                }
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
