using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class TheoryLessonsDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE TheoryLessons SET ID = @ID, Date = @Date, " +
                "Time = @Time, Auditorium = @Auditorium, Group = @Group " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Date", System.Data.SqlDbType.Date, 255, "Date");
            dataAdapter.UpdateCommand.Parameters.Add("@Time", System.Data.SqlDbType.Time, 255, "Time");
            dataAdapter.UpdateCommand.Parameters.Add("@Auditorium", System.Data.SqlDbType.Int, 255, "Auditorium");
            dataAdapter.UpdateCommand.Parameters.Add("@Group", System.Data.SqlDbType.Int, 255, "Group");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO TheoryLessons (ID, Surname, FirstName, PatronymicName, " +
                "PhoneNumber, Retraining, Group, CarrierUse, Photo)  VALUES (@ID, @Surname, @FirstName, @PatronymicName, " +
                "@PhoneNumber, @Retraining, @Group, @CarrierUse, @Photo)", conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Date", System.Data.SqlDbType.Date, 255, "Date");
            dataAdapter.InsertCommand.Parameters.Add("@Time", System.Data.SqlDbType.Time, 255, "Time");
            dataAdapter.InsertCommand.Parameters.Add("@Auditorium", System.Data.SqlDbType.Int, 255, "Auditorium");
            dataAdapter.InsertCommand.Parameters.Add("@Group", System.Data.SqlDbType.Int, 255, "Group");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE TheoryLessons WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "TheoryLessons");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM TheoryLessons", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "TheoryLessons");
        }

        public void ReadByGroupID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int GroupID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM TheoryLessons WHERE [Group] = @GroupID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@GroupID", GroupID);
            dataAdapter.Fill(dataSet, "TheoryLessons");
        }
    }
}
