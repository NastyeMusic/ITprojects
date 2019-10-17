using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class ReplacementsCarriersDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE ReplacementsCarries SET ID = @ID, CarrierUse = @CarrierUse, " +
                "CarrierReplacement = @CarrierReplacement, DateBeginReplacement = @DateBeginReplacement, " +
                "DateEndReplacement = @DateEndReplacement " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@CarrierUse", System.Data.SqlDbType.Int, 255, "CarrierUse");
            dataAdapter.UpdateCommand.Parameters.Add("@CarrierReplacement", System.Data.SqlDbType.Int, 255, "CarrierReplacement");
            dataAdapter.UpdateCommand.Parameters.Add("@DateBeginReplacement", System.Data.SqlDbType.Date, 255, "DateBeginReplacement");
            dataAdapter.UpdateCommand.Parameters.Add("@DateEndReplacement", System.Data.SqlDbType.Date, 255, "DateEndReplacement");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO ReplacementsCarries (ID, Carrier, Master, Work, " +
                "BeginDate, EndDate)  VALUES (@ID, @Carrier, @Master, @Work, @BeginDate, @EndDate)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@CarrierUse", System.Data.SqlDbType.Int, 255, "CarrierUse");
            dataAdapter.InsertCommand.Parameters.Add("@CarrierReplacement", System.Data.SqlDbType.Int, 255, "CarrierReplacement");
            dataAdapter.InsertCommand.Parameters.Add("@DateBeginReplacement", System.Data.SqlDbType.Date, 255, "DateBeginReplacement");
            dataAdapter.InsertCommand.Parameters.Add("@DateEndReplacement", System.Data.SqlDbType.Date, 255, "DateEndReplacement");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE ReplacementsCarries WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "ReplacementsCarries");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM ReplacementsCarries", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "ReplacementsCarries");
        }
    }
}
