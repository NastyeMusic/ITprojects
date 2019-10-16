using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    class InstructorsCategoriesDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE InstructorsCategories SET ID = @ID, Instructor = @Instructor, Category = @Category " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Instructor", System.Data.SqlDbType.Int, 255, "Instructor");
            dataAdapter.UpdateCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO InstructorsCategories (ID, Instructor, Category) VALUES (@ID, @Instructor, @Category)",
                conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Instructor", System.Data.SqlDbType.Int, 255, "Instructor");
            dataAdapter.InsertCommand.Parameters.Add("@Category", System.Data.SqlDbType.Int, 255, "Category");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE InstructorsCategories WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "InstructorsCategories");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM InstructorsCategories", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "InstructorsCategories");
        }
    }
}
