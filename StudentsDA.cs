using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class StudentsDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Students SET ID = @ID, Surname = @Surname, " +
                "FirstName = @FirstName, PatronymicName = @PatronymicName, PhoneNumber = @PhoneNumber, " +
                "Retraining = @Retraining, [Group] = @Group, CarrierUse = @CarrierUse, Photo = @Photo " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Surname", System.Data.SqlDbType.Text, 255, "Surname");
            dataAdapter.UpdateCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.Text, 255, "FirstName");
            dataAdapter.UpdateCommand.Parameters.Add("@PatronymicName", System.Data.SqlDbType.Text, 255, "PatronymicName");
            dataAdapter.UpdateCommand.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.Text, 255, "PhoneNumber");
            dataAdapter.UpdateCommand.Parameters.Add("@Retraining", System.Data.SqlDbType.Bit, 255, "Retraining");
            dataAdapter.UpdateCommand.Parameters.Add("@Group", System.Data.SqlDbType.Int, 255, "Group");
            dataAdapter.UpdateCommand.Parameters.Add("@CarrierUse", System.Data.SqlDbType.Int, 255, "CarrierUse");
            dataAdapter.UpdateCommand.Parameters.Add("@Photo", System.Data.SqlDbType.Image, 255, "Photo");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Students (ID, Surname, FirstName, PatronymicName, " +
                "PhoneNumber, Retraining, [Group], CarrierUse, Photo)  VALUES (@ID, @Surname, @FirstName, @PatronymicName, " +
                "@PhoneNumber, @Retraining, @Group, @CarrierUse, @Photo)", conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Surname", System.Data.SqlDbType.Text, 255, "Surname");
            dataAdapter.InsertCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.Text, 255, "FirstName");
            dataAdapter.InsertCommand.Parameters.Add("@PatronymicName", System.Data.SqlDbType.Text, 255, "PatronymicName");
            dataAdapter.InsertCommand.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.Text, 255, "PhoneNumber");
            dataAdapter.InsertCommand.Parameters.Add("@Retraining", System.Data.SqlDbType.Bit, 255, "Retraining");
            dataAdapter.InsertCommand.Parameters.Add("@Group", System.Data.SqlDbType.Int, 255, "Group");
            dataAdapter.InsertCommand.Parameters.Add("@CarrierUse", System.Data.SqlDbType.Int, 255, "CarrierUse");
            dataAdapter.InsertCommand.Parameters.Add("@Photo", System.Data.SqlDbType.Image, 255, "Photo");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE Students WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "Students");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Students", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Students");
        }

        public void ReadStudentsOfGroup(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int ID)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Students WHERE [Group] = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
            dataAdapter.Fill(dataSet, "Students");
        }
    }
}
