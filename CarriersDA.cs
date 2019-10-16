using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    class CarriersDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Carriers SET ID = @ID, Brand = @Brand, " +
                "Model = @Model, StateNumber = @StateNumber, Color = @Color, " +
                "Transmission = @Transmission, Category = @Category, Status = @Status " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Brand", System.Data.SqlDbType.Text, 255, "Brand");
            dataAdapter.UpdateCommand.Parameters.Add("@Model", System.Data.SqlDbType.Text, 255, "Model");
            dataAdapter.UpdateCommand.Parameters.Add("@StateNumber", System.Data.SqlDbType.Text, 255, "StateNumber");
            dataAdapter.UpdateCommand.Parameters.Add("@Color", System.Data.SqlDbType.Text, 255, "Color");
            dataAdapter.UpdateCommand.Parameters.Add("@Transmission", System.Data.SqlDbType.Int, 255, "Transmission");
            dataAdapter.UpdateCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");
            dataAdapter.UpdateCommand.Parameters.Add("@Status", System.Data.SqlDbType.Int, 255, "Status");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Carriers (ID, Surname, FirstName, PatronymicName, " +
                "PhoneNumber, Retraining, Group, CarrierUse, Photo)  VALUES (@ID, @Surname, @FirstName, @PatronymicName, " +
                "@PhoneNumber, @Retraining, @Group, @CarrierUse, @Photo)", conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Brand", System.Data.SqlDbType.Text, 255, "Brand");
            dataAdapter.InsertCommand.Parameters.Add("@Model", System.Data.SqlDbType.Text, 255, "Model");
            dataAdapter.InsertCommand.Parameters.Add("@StateNumber", System.Data.SqlDbType.Text, 255, "StateNumber");
            dataAdapter.InsertCommand.Parameters.Add("@Color", System.Data.SqlDbType.Text, 255, "Color");
            dataAdapter.InsertCommand.Parameters.Add("@Transmission", System.Data.SqlDbType.Int, 255, "Transmission");
            dataAdapter.InsertCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");
            dataAdapter.InsertCommand.Parameters.Add("@Status", System.Data.SqlDbType.Int, 255, "Status");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE Carriers WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "Carriers");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Carriers", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Carriers");
        }
    }
}
