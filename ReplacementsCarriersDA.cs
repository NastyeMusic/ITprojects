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
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE ReplacementsCarriers SET ID = @ID, CarrierUse = @CarrierUse, " +
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
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO ReplacementsCarriers (ID, CarrierUse, CarrierReplacement, " +
                "DateBeginReplacement, DateEndReplacement)  VALUES (@ID, @CarrierUse, @CarrierReplacement, @DateBeginReplacement, @DateEndReplacement)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@CarrierUse", System.Data.SqlDbType.Int, 255, "CarrierUse");
            dataAdapter.InsertCommand.Parameters.Add("@CarrierReplacement", System.Data.SqlDbType.Int, 255, "CarrierReplacement");
            dataAdapter.InsertCommand.Parameters.Add("@DateBeginReplacement", System.Data.SqlDbType.Date, 255, "DateBeginReplacement");
            dataAdapter.InsertCommand.Parameters.Add("@DateEndReplacement", System.Data.SqlDbType.Date, 255, "DateEndReplacement");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE ReplacementsCarriers WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "ReplacementsCarriers");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM ReplacementsCarriers", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }

        public void ReadByCarrierUseID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierUseID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM ReplacementsCarriers WHERE CarrierUse = @CarrierUseID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierUseID", CarrierUseID);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }

        public void ReadByCarrierReplacementID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierReplacementID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM ReplacementsCarriers WHERE CarrierReplacement = @CarrierReplacementID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierReplacementID", CarrierReplacementID);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }

        public void ReadReplacementsCarriersByBeginDateANDCarrierUseID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime Date, int CarrierUseID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT * FROM ReplacementsCarriers " +
                "WHERE CarrierUse=@CarrierUseID AND DateBeginReplacement <= @Date AND @Date <= DateEndReplacement";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Date", Date);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierUseID", CarrierUseID);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }

        public void ReadReplacementsCarriersByLessonDateANDCarrierUseID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime LessonDate, int CarrierUseID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT * FROM ReplacementsCarriers " +
                "WHERE CarrierUse=@CarrierUseID AND DateBeginReplacement <= @LessonDate AND DateEndReplacement >=@LessonDate";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@LessonDate", LessonDate.ToShortDateString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierUseID", CarrierUseID);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }

        public void ReadByCarrierReplacementID_AND_BeginEndDates(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierReplacementID, DateTime BeginDate, DateTime EndDate)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM ReplacementsCarriers WHERE CarrierReplacement = @CarrierReplacementID AND DateBeginReplacement >= @BeginDate AND DateBeginReplacement <= @EndDate", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierReplacementID", CarrierReplacementID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@BeginDate", BeginDate);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }
    }
}
