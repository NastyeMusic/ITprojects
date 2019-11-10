using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
        private MultipleDA multipleDA;

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
            multipleDA = new MultipleDA();
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
        public MultipleDA MultipleDA
        {
            set
            {
                multipleDA = value;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadReplacementsCarriersByCarrierUseID(int CarrierUseID)
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
                replacementsCarriersDA.ReadByCarrierUseID(ds, abstrCon, abstrTr, CarrierUseID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadReplacementsCarriersByCarrierReplacementID(int CarrierReplacementID)
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
                replacementsCarriersDA.ReadByCarrierReplacementID(ds, abstrCon, abstrTr, CarrierReplacementID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersRepairsByCarrierID(int CarrierID)
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
                carriersRepairsDA.ReadByCarrierID(ds, abstrCon, abstrTr, CarrierID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersRepairsByServiceMasterID(int ServiceMasterID)
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
                carriersRepairsDA.ReadByServiceMasterID(ds, abstrCon, abstrTr, ServiceMasterID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данного мастера сервиса невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления мастера сервиса");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadServiceMasterByID(int ID)
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
                serviceMastersDA.ReadByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данного инструктора невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления инструктора");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данную трансмиссию невозможно удалить, поскольку на неее имеются ссылки в других таблицах", "Ошибка удаления трансмиссии");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данное ТС невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления ТС");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersByCategory(int CategoryID)
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
                carriersDA.ReadByCategory(ds, abstrCon, abstrTr, CategoryID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersByStatusID(int StatusID)
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
                carriersDA.ReadByStatusID(ds, abstrCon, abstrTr, StatusID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данный статус ТС невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления статуса ТС");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersStatusesByID(int ID)
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                ds.EnforceConstraints = false;
                carriersStatusesDA.ReadByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данную связку инструктора и ТС невозможно удалить, поскольку на нее имеются ссылки в других таблицах", "Ошибка удаления связки инструктора и ТС");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersUsesByInstructorID(int ID)
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
                carriersUsesDA.ReadByInstructorID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadCarriersUsesByInstructorCarrierID(int InstructorID, int CarrierID)
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
                carriersUsesDA.ReadByInstructorCarrierID(ds, abstrCon, abstrTr, InstructorID, CarrierID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данную связку инструктора и категории невозможно удалить, поскольку на нее имеются ссылки в других таблицах", "Ошибка удаления связки инструктора и категории");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadInstructorsCategoriesByInstructorID(int ID)
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
                instructorsCategoriesDA.ReadByInstructorID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadInstructorsCategoriesByCategoryID(int ID)
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
                instructorsCategoriesDA.ReadByCategoryID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadInstructorsCategoriesByInstructorIdANDCategoryId(int InstructorID, int CategoryID)
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
                instructorsCategoriesDA.ReadByInstructorIdANDCategoryId(ds, abstrCon, abstrTr, InstructorID, CategoryID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данную категорию невозможно удалить, поскольку на нее имеются ссылки в других таблицах", "Ошибка удаления категории");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данного курсанта невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления курсанта");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                    abstrTr.Commit();
                }
                else
                {
                    throw new Exception("Группы с таким именем не существует");
                }                
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadStudentByID(int StudentID)
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
                studentsDA.ReadStudentByID(ds, abstrCon, abstrTr, StudentID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данную группу невозможно удалить, поскольку на нее имеются ссылки в других таблицах", "Ошибка удаления группы");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadGroupByName(string Name)
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
                groupsDA.ReadGroupByName(ds, abstrCon, abstrTr, Name);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadGroupByID(int ID)
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
                groupsDA.ReadGroupByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message == "Конфликт инструкции DELETE с ограничением REFERENCE \"TheoryLessons_Auditoriums\". Конфликт произошел в базе данных \"AutoschoolDataBase\", таблица \"dbo.TheoryLessons\", column 'Auditorium'.\r\nВыполнение данной инструкции было прервано.")
                    MessageBox.Show("Данную аудиторию невозможно удалить, поскольку в ней проходят занятия", "Ошибка удаления аудитории");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данный рабочий статус невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления рабочего статуса");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadPracticeLessonsByStudentID(int StudentID)
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
                practiceLessonsDA.ReadByStudentID(ds, abstrCon, abstrTr, StudentID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Данного преподавателя теории невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления преподавателя теории");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadTheoryTeacherByID(int ID)
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
                theoryTeachersDA.ReadByID(ds, abstrCon, abstrTr, ID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
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
                MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadTheoryLessonsByGroupID(int GroupID)
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
                theoryLessonsDA.ReadByGroupID(ds, abstrCon, abstrTr, GroupID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet ReadTheoryLessonsByAuditoriumID(int AuditoriumID)
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
                theoryLessonsDA.ReadByAuditoriumID(ds, abstrCon, abstrTr, AuditoriumID);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        // чтение всех сотрудников
        public AutoschoolDataSet ReadWorkers()
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
                instructorsDA.Read(ds, abstrCon, abstrTr);
                serviceMastersDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        /*public AutoschoolDataSet GetInstructorSchedule(int InstructorID)
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
                theoryTeachersDA.Read(ds, abstrCon, abstrTr);
                
                serviceMastersDA.Read(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }*/
        /*public AutoschoolDataSet GetInstructorOfStudent(int StudentID)
        {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();

                AutoschoolDataSet ds2 = new AutoschoolDataSet();
                studentsDA.ReadStudentByID(ds2, abstrCon, abstrTr, StudentID);
                if (ds2.Students.Rows.Count > 0)
                {
                    int CarrierUseID = Convert.ToInt32(ds2.Groups.Rows[0][7].ToString());
                    carriersUsesDA.ReadByID(ds2, abstrCon, abstrTr, CarrierUseID);
                    if (ds2.CarriersUses.Rows.Count > 0)
                    {
                        int InstructorID = Convert.ToInt32(ds2.CarriersUses.Rows[0][1].ToString());
                        instructorsDA.ReadByID(ds2, abstrCon, abstrTr, InstructorID);
                        abstrTr.Commit();
                    }
                    else
                    {
                        throw new Exception("Такая связка инструктора и ТС не найдена");
                    }
                }
                else
                {
                    throw new Exception("Студент с таким ID не найден");
                }
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }*/
        public AutoschoolDataSet GetInstructorSchedule(int InstructorID)
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

                multipleDA.ReadPracticeLessonsByInstructorID(ds, abstrCon, abstrTr, InstructorID);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet GetPracticeLessonsForCarrier(int CarrierID)
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

                multipleDA.ReadPracticeLessonsByCarrierID(ds, abstrCon, abstrTr, CarrierID);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
        public AutoschoolDataSet GetTheoryTeacherSchedule(int TeacherID)
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

                multipleDA.ReadTheoryLessonsByTeacherID(ds, abstrCon, abstrTr, TeacherID);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        public AutoschoolDataSet ReadCarriersByInstructorID(int InstructorID)
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

                multipleDA.ReadCarriersByInstructorID(ds, abstrCon, abstrTr, InstructorID);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        public AutoschoolDataSet ReadCarriersByStatusName(string CarrierStatusName)
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

                multipleDA.ReadCarriersByStatusName(ds, abstrCon, abstrTr, CarrierStatusName);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        public AutoschoolDataSet WriteWorkers(AutoschoolDataSet ds)
        {
            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();
                workStatusesDA.Save(ds, abstrCon, abstrTr);
                theoryTeachersDA.Save(ds, abstrCon, abstrTr);
                instructorsDA.Save(ds, abstrCon, abstrTr);
                serviceMastersDA.Save(ds, abstrCon, abstrTr);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                if (e.Message.StartsWith("Конфликт инструкции DELETE с ограничением REFERENCE"))
                    MessageBox.Show("Сотрудника невозможно удалить, поскольку на него имеются ссылки в других таблицах", "Ошибка удаления сотрудника");
                else
                    MessageBox.Show(e.Message, "Ошибка записи в базу данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        public DataSet ReadCarriersByServiceMasterID(int ServiceMasterID)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("RepairsOfServiceMaster");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("ID");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Brand");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Model");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("StateNumber");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Color");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Transmission");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Category");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Status");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("Work");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("BeginDate");
            ds.Tables["RepairsOfServiceMaster"].Columns.Add("EndDate");

            AbstractConnection abstrCon = ConnectionFactory.getConnection();
            abstrCon.Open();
            AbstractTransaction abstrTr = null;
            try
            {
                abstrTr = abstrCon.BeginTransaction();

                multipleDA.ReadCarriersByServiceMasterID(ds, abstrCon, abstrTr, ServiceMasterID);

                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }

        public AutoschoolDataSet ReadBusyCarriers(DateTime Date, TimeSpan Time, int LessonTime)
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
                multipleDA.ReadBusyCarriers(ds, abstrCon, abstrTr, Date, Time, LessonTime);
                abstrTr.Commit();
            }
            catch (Exception e)
            {
                abstrTr.Rollback();
                MessageBox.Show(e.Message, "Ошибка чтения из базы данных");
                //throw e;
            }
            finally
            {
                abstrCon.Close();
            }
            return ds;
        }
    }
}
