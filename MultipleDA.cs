using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public void ReadCarriersByInstructorID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int InstructorID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersUses CU ON Cr.ID=CU.Carrier " +
                "WHERE CU.Instructor = @InstructorID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@InstructorID", InstructorID);
            dataAdapter.Fill(dataSet, "Carriers");
        }

        public void ReadCarriersByStatusName(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, string StatusName)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersStatuses CS ON Cr.Status=CS.ID " +
                "WHERE CS.Name = @StatusName";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@StatusName", StatusName);
            dataAdapter.Fill(dataSet, "Carriers");
        }

        public void ReadCarriersByServiceMasterID(DataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int ServiceMasterID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Tr.Transmission, Cat.Name AS [Category], CarSt.Name AS [Status], CarR.Work, CarR.BeginDate, CarR.EndDate " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersRepairs CarR ON Cr.ID=CarR.Carrier " +
                "INNER JOIN Transmissions Tr ON Cr.Transmission=Tr.ID " +
                "INNER JOIN CarriersStatuses CarSt ON Cr.Status=CarSt.ID " +
                "INNER JOIN Categories Cat ON Cr.Category=Cat.ID " +
                "WHERE CarR.Master = @ServiceMasterID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ServiceMasterID", ServiceMasterID);
            dataAdapter.Fill(dataSet, "RepairsOfServiceMaster");
        }

        public void ReadBusyCarriers(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime Date, TimeSpan Time, int LessonTime)
        {
            dataAdapter = new SqlDataAdapter();
            /*string query = "SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersUses CU ON Cr.ID=CU.Carrier " +
                "INNER JOIN Students St ON CU.ID=St.CarrierUse " +
                "INNER JOIN PracticeLessons PL ON St.ID=PL.Student " +
                "WHERE PL.AppointedDate = @Date AND PL.AppointedTime <= @Time AND DATEADD(MINUTE, @LessonTime, PL.AppointedTime) > @Time";*/
            string query = @"SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status
FROM Carriers Cr
INNER JOIN CarriersUses CU ON Cr.ID=CU.Carrier
INNER JOIN Students St ON CU.ID=St.CarrierUse
INNER JOIN PracticeLessons PL ON St.ID=PL.Student
WHERE
@Date = CASE
WHEN PL.FactDate <> '0001-01-01'
THEN PL.FactDate
ELSE PL.AppointedDate
END
AND
@Time >= CASE
WHEN PL.FactDate <> '0001-01-01'
THEN PL.FactTime
ELSE PL.AppointedTime
END
AND
@Time < CASE
WHEN PL.FactDate <> '0001-01-01'
THEN DATEADD(MINUTE, @LessonTime, PL.FactTime)
ELSE DATEADD(MINUTE, @LessonTime, PL.AppointedTime)
END";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Date", Date);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Time", Time);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@LessonTime", LessonTime);
            dataAdapter.Fill(dataSet, "Carriers");
        }

        public void ReadRepairingCarriers(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime Date)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT DISTINCT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersRepairs CarR ON Cr.ID=CarR.Carrier " +
                "WHERE CarR.BeginDate <= @Date AND CarR.EndDate >= @Date";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Date", Date);
            dataAdapter.Fill(dataSet, "Carriers");
        }        

        public void ReadCarriersUsesWithRepairingCarriers(DataSet dataSet, AbstractConnection conn, AbstractTransaction tr, DateTime BeginDate, DateTime EndDate)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cr.ID AS [CarrierID], Cr.Brand AS [Brand], Cr.Model AS [Model], Cr.StateNumber AS [StateNumber], " +
                "CarR.BeginDate AS [BeginDate], CarR.EndDate AS [EndDate], " +
                "CU.Instructor AS [InstructorID], (Instr.Surname + ' ' + Instr.FirstName + ' ' + Instr.PatronymicName) AS [InstructorName], " + 
                "CU.ID AS [CarrierUseID]" +
                "FROM CarriersUses CU " +
                "INNER JOIN Carriers Cr ON CU.Carrier=Cr.ID " +
                "INNER JOIN CarriersRepairs CarR ON Cr.ID=CarR.Carrier " +
                "INNER JOIN Instructors Instr ON CU.Instructor=Instr.ID " +
                "WHERE (@BeginDate <= CarR.BeginDate AND CarR.BeginDate <= @EndDate) OR (@BeginDate <= CarR.EndDate AND CarR.EndDate <= @EndDate)";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@BeginDate", BeginDate);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate);
            dataAdapter.Fill(dataSet, "CarrierUsesWithRepairingCarriers");
        }

        public void ReadCategoriesOfInstructor(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int InstructorID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cat.ID, Cat.Name " +
                "FROM Categories Cat " +
                "INNER JOIN InstructorsCategories InstrCat ON Cat.ID=InstrCat.Category " +
                "WHERE InstrCat.Instructor = @InstructorID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@InstructorID", InstructorID);
            dataAdapter.Fill(dataSet, "Categories");
        }

        public void ReadCarriersByCategoryIDANDInstructorID(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CategoryID, int InstructorID)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT Cr.ID, Cr.Brand, Cr.Model, Cr.StateNumber, Cr.Color, Cr.Transmission, Cr.Category, Cr.Status " +
                "FROM Carriers Cr " +
                "INNER JOIN CarriersUses CU ON Cr.ID=CU.Carrier " +
                "WHERE Cr.Category = @CategoryID AND CU.Instructor = @InstructorID";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@InstructorID", InstructorID);
            dataAdapter.Fill(dataSet, "Carriers");
        }

        public void ReadPracticeLessonsByCarrierID_AND_BeginEndDates(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierID, DateTime BeginDate, DateTime EndDate)
        {
            dataAdapter = new SqlDataAdapter();
            string query = /*"SELECT pl.ID, pl.Student, pl.AppointedDate, pl.AppointedTime, pl.FactDate, pl.FactTime " +
                "FROM PracticeLessons pl " +
                "INNER JOIN Students St ON pl.Student=St.ID " +
                "INNER JOIN CarriersUses CU ON St.CarrierUse=CU.ID " +
                "WHERE CU.Carrier = @CarrierID AND " +
                "@BeginDate <= IIF(pl.FactDate <> '01.01.0001', pl.FactDate, pl.AppointedDate) " +
                "@EndDate >= IIF(pl.FactDate <> '01.01.0001', pl.FactDate, pl.AppointedDate)";*/
                           /*"IF (pl.FactDate <> '01.01.0001') " + 
                           "THEN pl.FactDate >= @BeginDate AND pl.FactDate <= @EndDate " + 
                           "ELSE pl.AppointedDate >= @BeginDate AND pl.AppointedDate <= @EndDate";*/
                @"SELECT pl.ID, pl.Student, pl.AppointedDate, pl.AppointedTime, pl.FactDate, pl.FactTime 
FROM PracticeLessons pl 
INNER JOIN Students St ON pl.Student=St.ID 
INNER JOIN CarriersUses CU ON St.CarrierUse=CU.ID 
WHERE CU.Carrier = @CarrierID AND 
@BeginDate <= CASE 
WHEN pl.FactDate <> '0001-01-01' 
THEN pl.FactDate 
ELSE pl.AppointedDate 
END 
AND 
@EndDate >= CASE 
WHEN pl.FactDate <> '0001-01-01' 
THEN pl.FactDate 
ELSE pl.AppointedDate 
END";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@BeginDate", BeginDate.ToShortDateString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate.ToShortDateString());
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }

        public void ReadPracticeLessonsByCarrierUseID_AND_DatesBeginEnd(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierUseID, DateTime BeginDate, DateTime EndDate)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT pl.ID, pl.Student, pl.AppointedDate, pl.AppointedTime, pl.FactDate, pl.FactTime " +
                "FROM PracticeLessons pl " +
                "INNER JOIN Students St ON pl.Student=St.ID " +
                "WHERE St.CarrierUse = @CarrierUseID AND " +
                @"@BeginDate <= CASE 
WHEN pl.FactDate <> '0001-01-01' 
THEN pl.FactDate 
ELSE pl.AppointedDate 
END 
AND 
@EndDate >= CASE 
WHEN pl.FactDate <> '0001-01-01' 
THEN pl.FactDate 
ELSE pl.AppointedDate 
END";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierUseID", CarrierUseID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@BeginDate", BeginDate.ToShortDateString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate.ToShortDateString());
            dataAdapter.Fill(dataSet, "PracticeLessons");
        }

        public void ReadReplacementsCarriersByCarrierID_AND_Date(AutoschoolDataSet dataSet, AbstractConnection conn, AbstractTransaction tr, int CarrierID, DateTime Date)
        {
            dataAdapter = new SqlDataAdapter();
            string query = "SELECT RC.ID, RC.CarrierUse, RC.CarrierReplacement, RC.DateBeginReplacement, RC.DateEndReplacement " +
                "FROM ReplacementsCarriers RC " +
                "INNER JOIN CarriersUses CU ON RC.CarrierUse=CU.ID " +
                "WHERE CU.Carrier = @CarrierID AND @Date >= RC.DateBeginReplacement AND @Date <= RC.DateEndReplacement";
            dataAdapter.SelectCommand = new SqlCommand(query, conn.getConnection(), tr.getTransaction());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@CarrierID", CarrierID);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Date", Date);
            dataAdapter.Fill(dataSet, "ReplacementsCarriers");
        }
    }
}
