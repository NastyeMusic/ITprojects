﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    class PracticeLessonsDA
    {
        private SqlDataAdapter dataAdapter;

        // сохранить изменения строки
        public void Save(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();

            // на обновление
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE PracticeLessons SET ID = @ID, Student = @Student, " +
                "AppointedDate = @AppointedDate, AppointedTime = @AppointedTime, FactDate = @FactDate, FactTime = @FactTime " +
                "WHERE ID = @OldID", conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Student", System.Data.SqlDbType.Int, 255, "Student");
            dataAdapter.UpdateCommand.Parameters.Add("@AppointedDate", System.Data.SqlDbType.Date, 255, "AppointedDate");
            dataAdapter.UpdateCommand.Parameters.Add("@AppointedTime", System.Data.SqlDbType.Time, 255, "AppointedTime");
            dataAdapter.UpdateCommand.Parameters.Add("@FactDate", System.Data.SqlDbType.Date, 255, "FactDate");
            dataAdapter.UpdateCommand.Parameters.Add("@FactTime", System.Data.SqlDbType.Time, 255, "FactTime");
            dataAdapter.UpdateCommand.Parameters.Add("@OldID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            // на вставку 
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO PracticeLessons (ID, Surname, FirstName, PatronymicName, " +
                "PhoneNumber, Retraining, Group, CarrierUse, Photo)  VALUES (@ID, @Surname, @FirstName, @PatronymicName, " +
                "@PhoneNumber, @Retraining, @Group, @CarrierUse, @Photo)", conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Student", System.Data.SqlDbType.Int, 255, "Student");
            dataAdapter.InsertCommand.Parameters.Add("@AppointedDate", System.Data.SqlDbType.Date, 255, "AppointedDate");
            dataAdapter.InsertCommand.Parameters.Add("@AppointedTime", System.Data.SqlDbType.Time, 255, "AppointedTime");
            dataAdapter.InsertCommand.Parameters.Add("@FactDate", System.Data.SqlDbType.Date, 255, "FactDate");
            dataAdapter.InsertCommand.Parameters.Add("@FactTime", System.Data.SqlDbType.Time, 255, "FactTime");

            // на удаление
            dataAdapter.DeleteCommand = new SqlCommand("DELETE PracticeLessons WHERE ID = @ID", conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int, 255, "ID").SourceVersion = System.Data.DataRowVersion.Original;

            dataAdapter.Update(dataSet, "PracticeLessons");
        }

        // прочитать таблицу
        public void Read(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM PracticeLessons", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }
    }
}
