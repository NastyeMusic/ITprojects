using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class AbstractTransaction
    {
        private SqlTransaction tr;
        public AbstractTransaction(SqlTransaction tran)
        {
            tr = tran;
        }
        public void Commit()
        {
            tr.Commit();
        }
        public void Rollback()
        {
            tr.Rollback();
        }
        public SqlTransaction getTransaction()
        {
            return tr;
        }
    }
}
