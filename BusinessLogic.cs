using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автошкола
{
    public class BusinessLogic
    {
        private ReplacementsCarriersDA replacementsCarriersDA;
        private CarriersRepairsDA carriersRepairsDA;
        private ServiceMastersDA serviceMastersDA;
        private InstructorsDA instructorsDA;
        private TransmissionsDA transmissionsDA;
        private CarriersDA carriersDA;
        private CarriersStatusesDA carriersStatusesDA;
        private CarriersUsesDA carriersUsesDA;
        private InstructorsCategoriesDA instructorsCategoriesDA;
        private CategoriesDA categoriesDA;
        private StudentsDA studentsDA;
        private GroupsDA groupsDA;
        private AuditoriumsDA auditoriumsDA;
        private WorkStatusesDA workStatusesDA;
        private PracticeLessonsDA practiceLessonsDA;
        private TheoryTeachersDA theoryTeachersDA;
        private TheoryLessonsDA theoryLessonsDA;

        public BusinessLogic()
        {
            replacementsCarriersDA = new ReplacementsCarriersDA();
            carriersRepairsDA = new CarriersRepairsDA();
            serviceMastersDA = new ServiceMastersDA();
            instructorsDA = new InstructorsDA();
            transmissionsDA = new TransmissionsDA();
            carriersDA = new CarriersDA();
            carriersStatusesDA = new CarriersStatusesDA();
            carriersUsesDA = new CarriersUsesDA();
            instructorsCategoriesDA = new InstructorsCategoriesDA();
            categoriesDA = new CategoriesDA();
            studentsDA = new StudentsDA();
            groupsDA = new GroupsDA();
            auditoriumsDA = new AuditoriumsDA();
            workStatusesDA = new WorkStatusesDA();
            practiceLessonsDA = new PracticeLessonsDA();
            theoryTeachersDA = new TheoryTeachersDA();
            theoryLessonsDA = new TheoryLessonsDA();
        }

        // конструкторы к DataAccessor'ам
        public ReplacementsCarriersDA ReplacementsCarriersDA
        {
            set
            {
                replacementsCarriersDA = value;
            }
        }
        public CarriersRepairsDA CarriersRepairsDA
        {
            set
            {
                carriersRepairsDA = value;
            }
        }
        public ServiceMastersDA ServiceMastersDA
        {
            set
            {
                serviceMastersDA = value;
            }
        }
        public InstructorsDA InstructorsDA
        {
            set
            {
                instructorsDA = value;
            }
        }
        public TransmissionsDA TransmissionsDA
        {
            set
            {
                transmissionsDA = value;
            }
        }
        public CarriersDA CarriersDA
        {
            set
            {
                carriersDA = value;
            }
        }
        public CarriersStatusesDA CarriersStatusesDA
        {
            set
            {
                carriersStatusesDA = value;
            }
        }
        public CarriersUsesDA CarriersUsesDA
        {
            set
            {
                carriersUsesDA = value;
            }
        }
        public InstructorsCategoriesDA InstructorsCategoriesDA
        {
            set
            {
                instructorsCategoriesDA = value;
            }
        }
        public CategoriesDA CategoriesDA
        {
            set
            {
                categoriesDA = value;
            }
        }
        public StudentsDA StudentsDA
        {
            set
            {
                studentsDA = value;
            }
        }
        public GroupsDA GroupsDA
        {
            set
            {
                groupsDA = value;
            }
        }
        public AuditoriumsDA AuditoriumsDA
        {
            set
            {
                auditoriumsDA = value;
            }
        }
        public WorkStatusesDA WorkStatusesDA
        {
            set
            {
                workStatusesDA = value;
            }
        }
        public PracticeLessonsDA PracticeLessonsDA
        {
            set
            {
                practiceLessonsDA = value;
            }
        }
        public TheoryTeachersDA TheoryTeachersDA
        {
            set
            {
                theoryTeachersDA = value;
            }
        }
        public TheoryLessonsDA TheoryLessonsDA
        {
            set
            {
                theoryLessonsDA = value;
            }
        }

        // методы к классу ReplacementsCarriers
        public AutoschoolDataSet ReadReplacementsCarriers()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                categoriesDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                carriersUsesDA.Read(ds, abstrCon, abstrTr);
                replacementsCarriersDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteReplacementsCarriers(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                categoriesDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                carriersUsesDA.Save(ds, abstrCon, abstrTr);
                replacementsCarriersDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу CarriersRepairs
        public AutoschoolDataSet ReadCarriersRepairs()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                serviceMastersDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                carriersRepairsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteCarriersRepairs(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                serviceMastersDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                carriersRepairsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу ServiceMasters
        public AutoschoolDataSet ReadServiceMasters()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                serviceMastersDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteServiceMasters(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                serviceMastersDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Instructors
        public AutoschoolDataSet ReadInstructors()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteInstructors(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadInstructorByID(int ID)
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.ReadByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Transmissions
        public AutoschoolDataSet ReadTransmissions()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteTransmissions(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Carriers
        public AutoschoolDataSet ReadCarriers()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteCarriers(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу CarriersStatuses
        public AutoschoolDataSet ReadCarriersStatuses()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteCarriersStatuses(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу CarriersUses
        public AutoschoolDataSet ReadCarriersUses()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                carriersUsesDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteCarriersUses(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                carriersUsesDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersUsesByID(int ID)
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                carriersUsesDA.ReadByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу InstructorsCategories
        public AutoschoolDataSet ReadInstructorsCategories()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                categoriesDA.Read(ds, abstrCon, abstrTr);
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                instructorsCategoriesDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteInstructorsCategories(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                categoriesDA.Save(ds, abstrCon, abstrTr);
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                instructorsCategoriesDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Categories
        public AutoschoolDataSet ReadCategories()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                categoriesDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteCategories(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                categoriesDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Students
        public AutoschoolDataSet ReadStudents()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                groupsDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                carriersUsesDA.Read(ds, abstrCon, abstrTr);
                studentsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteStudents(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                groupsDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                carriersUsesDA.Save(ds, abstrCon, abstrTr);
                studentsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadStudentsOfGroup(string Name)
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();                

                AutoschoolDataSet ds2 = new AutoschoolDataSet();
                groupsDA.ReadGroupByName(ds2, abstrCon, abstrTr, Name);
                if (ds2.Groups.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(ds2.Groups.Rows[0][0].ToString());

                    ds.EnforceConstraints = false;
                    workStatusesDA.Read(ds, abstrCon, abstrTr);
                    theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                    categoriesDA.Read(ds, abstrCon, abstrTr);
                    groupsDA.Read(ds, abstrCon, abstrTr);
                    carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                    transmissionsDA.Read(ds, abstrCon, abstrTr);
                    carriersDA.Read(ds, abstrCon, abstrTr);
                    instructorsDA.Read(ds, abstrCon, abstrTr);
                    carriersUsesDA.Read(ds, abstrCon, abstrTr);

                    studentsDA.ReadStudentsOfGroup(ds, abstrCon, abstrTr, ID);
                }
                else
                {
                    throw new Exception();
                }

                studentsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Groups
        public AutoschoolDataSet ReadGroups()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                groupsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteGroups(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                groupsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу Auditoriums
        public AutoschoolDataSet ReadAuditoriums()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                auditoriumsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteAuditoriums(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                auditoriumsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу WorkStatuses
        public AutoschoolDataSet ReadWorkStatuses()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteWorkStatuses(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу PracticeLessons
        public AutoschoolDataSet ReadPracticeLessons()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                groupsDA.Read(ds, abstrCon, abstrTr);
                carriersStatusesDA.Read(ds, abstrCon, abstrTr);
                transmissionsDA.Read(ds, abstrCon, abstrTr);
                carriersDA.Read(ds, abstrCon, abstrTr);
                instructorsDA.Read(ds, abstrCon, abstrTr);
                carriersUsesDA.Read(ds, abstrCon, abstrTr);
                studentsDA.Read(ds, abstrCon, abstrTr);
                practiceLessonsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WritePracticeLessons(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                groupsDA.Save(ds, abstrCon, abstrTr);
                carriersStatusesDA.Save(ds, abstrCon, abstrTr);
                transmissionsDA.Save(ds, abstrCon, abstrTr);
                carriersDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                carriersUsesDA.Save(ds, abstrCon, abstrTr);
                studentsDA.Save(ds, abstrCon, abstrTr);
                practiceLessonsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу TheoryTeachers
        public AutoschoolDataSet ReadTheoryTeachers()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);                
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteTheoryTeachers(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);                
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // методы к классу TheoryLessons
        public AutoschoolDataSet ReadTheoryLessons()
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                workStatusesDA.Read(ds, abstrCon, abstrTr);
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                categoriesDA.Read(ds, abstrCon, abstrTr);
                groupsDA.Read(ds, abstrCon, abstrTr);
                auditoriumsDA.Read(ds, abstrCon, abstrTr);
                theoryLessonsDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet WriteTheoryLessons(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);
                categoriesDA.Save(ds, abstrCon, abstrTr);
                groupsDA.Save(ds, abstrCon, abstrTr);
                auditoriumsDA.Save(ds, abstrCon, abstrTr);
                theoryLessonsDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
    }
}
