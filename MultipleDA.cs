using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Автошкола
{
    public class MultipleDA
    {
        private SqlDataAdapter dataAdapter;
        public void ReadPracticeLessonsByInstructorID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int InstructorID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT * FROM PracticeLessons pl " +
                "INNER JOIN Students st ON pl.Student=st.ID " + 
                "INNER JOIN CarriersUses csu ON st.CarrierUse=csu.ID " +
                "WHERE csu.Instructor = @InstructorID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@InstructorID", InstructorID);
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }
        public void ReadPracticeLessonsByCarrierID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT * FROM PracticeLessons PL " +
                "INNER JOIN Students St ON PL.Student=St.ID " +
                "INNER JOIN CarriersUses CU ON St.CarrierUse=CU.ID " +
                "WHERE CU.Carrier = @CarrierID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }
    }
}
