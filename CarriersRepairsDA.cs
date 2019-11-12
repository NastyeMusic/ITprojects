using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class CarriersRepairsDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE CarriersRepairs SET ID = @ID, Carrier = @Carrier, Master = @Master, " +
                "Work = @Work, BeginDate = @BeginDate, EndDate = @EndDate " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Carrier", System.Data.SqlDbType.Int, 255, "Carrier");
            dataAdapter.UpdateCommand.Parameters.Add("@Master", System.Data.SqlDbType.Int, 255, "Master");
            dataAdapter.UpdateCommand.Parameters.Add("@Work", System.Data.SqlDbType.Text, 255, "Work");
            dataAdapter.UpdateCommand.Parameters.Add("@BeginDate", System.Data.SqlDbType.Date, 255, "BeginDate");
            dataAdapter.UpdateCommand.Parameters.Add("@EndDate", System.Data.SqlDbType.Date, 255, "EndDate");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO CarriersRepairs (ID, Carrier, Master, Work, " +
                "BeginDate, EndDate)  VALUES (@ID, @Carrier, @Master, @Work, @BeginDate, @EndDate)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Carrier", System.Data.SqlDbType.Int, 255, "Carrier");
            dataAdapter.InsertCommand.Parameters.Add("@Master", System.Data.SqlDbType.Int, 255, "Master");
            dataAdapter.InsertCommand.Parameters.Add("@Work", System.Data.SqlDbType.Text, 255, "Work");
            dataAdapter.InsertCommand.Parameters.Add("@BeginDate", System.Data.SqlDbType.Date, 255, "BeginDate");
            dataAdapter.InsertCommand.Parameters.Add("@EndDate", System.Data.SqlDbType.Date, 255, "EndDate");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE CarriersRepairs WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "CarriersRepairs");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CarriersRepairs", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "CarriersRepairs");
        }

        public void ReadByCarrierID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CarriersRepairs WHERE Carrier = @CarrierID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.Fill(dataSet, "CarriersRepairs");
        }
        public void ReadByServiceMasterID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int ServiceMasterID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CarriersRepairs WHERE Master = @ServiceMasterID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ServiceMasterID", ServiceMasterID);
            dataAdapter.Fill(dataSet, "CarriersRepairs");
        }

        public void ReadByBeginEndDates(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime BeginDate, DateTime EndDate)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CarriersRepairs WHERE BeginDate >= @BeginDate AND EndDate <= @EndDate", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@BeginDate", BeginDate);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate);
            dataAdapter.Fill(dataSet, "CarriersRepairs");
        }

        public void ReadByCarrierID_AND_LessonDate(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierID, DateTime LessonDate)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM CarriersRepairs WHERE Carrier = @CarrierID AND @LessonDate >= BeginDate AND @LessonsDate <= EndDate", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@LessonDate", LessonDate);
            dataAdapter.Fill(dataSet, "CarriersRepairs");
        }
    }
}
