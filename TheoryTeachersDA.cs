using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class TheoryTeachersDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE TheoryTeachers SET ID = @ID, Surname = @Surname, " +
                "FirstName = @FirstName, PatronymicName = @PatronymicName, Photo = @Photo, WorkStatus = @WorkStatus " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Surname", System.Data.SqlDbType.Text, 255, "Surname");
            dataAdapter.UpdateCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.Text, 255, "FirstName");
            dataAdapter.UpdateCommand.Parameters.Add("@PatronymicName", System.Data.SqlDbType.Text, 255, "PatronymicName");
            dataAdapter.UpdateCommand.Parameters.Add("@Photo", System.Data.SqlDbType.Image, 255, "Photo");
            dataAdapter.UpdateCommand.Parameters.Add("@WorkStatus", System.Data.SqlDbType.Int, 255, "WorkStatus");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO TheoryTeachers (ID, Surname, FirstName, PatronymicName, " +
                "Photo, WorkStatus)  VALUES (@ID, @Surname, @FirstName, @PatronymicName, @Photo, @WorkStatus)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Surname", System.Data.SqlDbType.Text, 255, "Surname");
            dataAdapter.InsertCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.Text, 255, "FirstName");
            dataAdapter.InsertCommand.Parameters.Add("@PatronymicName", System.Data.SqlDbType.Text, 255, "PatronymicName");
            dataAdapter.InsertCommand.Parameters.Add("@Photo", System.Data.SqlDbType.Image, 255, "Photo");
            dataAdapter.InsertCommand.Parameters.Add("@WorkStatus", System.Data.SqlDbType.Int, 255, "WorkStatus");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE TheoryTeachers WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "TheoryTeachers");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM TheoryTeachers", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "TheoryTeachers");
        }
        public void ReadByID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int ID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM TheoryTeachers WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
            dataAdapter.Fill(dataSet, "TheoryTeachers");
        }
    }
}
