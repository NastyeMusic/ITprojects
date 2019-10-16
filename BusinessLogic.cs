using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автошкола
{
    class BusinessLogic
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

        }
        public AutoschoolDataSet WriteReplacementsCarriers()
        {

        }
    }
}
