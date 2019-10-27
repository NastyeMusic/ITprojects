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
            string query = "SELECT pl.ID, pl.Student, pl.AppointedDate, pl.AppointedTime, pl.FactDate, pl.FactTime " + 
                "FROM PracticeLessons pl " +
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
            string query = "SELECT pl.ID, pl.Student, pl.AppointedDate, pl.AppointedTime, pl.FactDate, pl.FactTime " +
                "FROM PracticeLessons pl " +
                "INNER JOIN Students St ON pl.Student=St.ID " +
                "INNER JOIN CarriersUses CU ON St.CarrierUse=CU.ID " +
                "WHERE CU.Carrier = @CarrierID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }
        public void ReadTheoryLessonsByTeacherID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int TeacherID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT tl.ID, tl.Date, tl.Time, tl.Auditorium, tl.[Group] " +
                "FROM TheoryLessons TL " +
                "INNER JOIN Groups Gr ON tl.[Group]=Gr.ID " +
                "WHERE Gr.Teacher = @TeacherID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@TeacherID", TeacherID);
            dataAdapter.Fill(dataSet, "TheoryLessons");
        }
    }
}
