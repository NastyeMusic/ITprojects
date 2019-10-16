using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    class GroupsDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Groups SET ID = @ID, Name = @Name, StartLearning = @StartLearning, " +
                "EndLearning = @EndLearning, Category = @Category, Teacher = @Teacher " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Name", System.Data.SqlDbType.Text, 255, "Name");
            dataAdapter.UpdateCommand.Parameters.Add("@StartLearning", System.Data.SqlDbType.Date, 255, "StartLearning");
            dataAdapter.UpdateCommand.Parameters.Add("@EndLearning", System.Data.SqlDbType.Date, 255, "EndLearning");
            dataAdapter.UpdateCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");
            dataAdapter.UpdateCommand.Parameters.Add("@Teacher", System.Data.SqlDbType.Int, 255, "Teacher");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Groups (ID, Name, StartLearning, EndLearning, " +
                "Category, Teacher)  VALUES (@ID, @Name, @StartLearning, @EndLearning, @Category, @Teacher)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Name", System.Data.SqlDbType.Text, 255, "Name");
            dataAdapter.InsertCommand.Parameters.Add("@StartLearning", System.Data.SqlDbType.Date, 255, "StartLearning");
            dataAdapter.InsertCommand.Parameters.Add("@EndLearning", System.Data.SqlDbType.Date, 255, "EndLearning");
            dataAdapter.InsertCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");
            dataAdapter.InsertCommand.Parameters.Add("@Teacher", System.Data.SqlDbType.Int, 255, "Teacher");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE Groups WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "Groups");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Groups", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Groups");
        }
    }
}
