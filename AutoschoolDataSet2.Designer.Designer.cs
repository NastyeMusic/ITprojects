﻿#pragma warning disable 1591

namespace Автошкола {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("AutoschoolDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class AutoschoolDataSet : global::System.Data.DataSet {
        
        private CategoriesDataTable tableCategories;
        
        private CarriersDataTable tableCarriers;
        
        private InstructorsDataTable tableInstructors;
        
        private ServiceMastersDataTable tableServiceMasters;
        
        private TheoryTeachersDataTable tableTheoryTeachers;
        
        private AuditoriumsDataTable tableAuditoriums;
        
        private GroupsDataTable tableGroups;
        
        private InstructorsCategoriesDataTable tableInstructorsCategories;
        
        private TheoryLessonsDataTable tableTheoryLessons;
        
        private CarriersStatusesDataTable tableCarriersStatuses;
        
        private TransmissionsDataTable tableTransmissions;
        
        private PracticeLessonsDataTable tablePracticeLessons;
        
        private CarriersUsesDataTable tableCarriersUses;
        
        private CarriersRepairsDataTable tableCarriersRepairs;
        
        private ReplacementsCarriersDataTable tableReplacementsCarriers;
        
        private WorkStatusesDataTable tableWorkStatuses;
        
        private StudentsDataTable tableStudents;
        
        private global::System.Data.DataRelation relationCarriesStatuses_Carriers;
        
        private global::System.Data.DataRelation relationCategories_Carriers;
        
        private global::System.Data.DataRelation relationTransmissions_Carriers;
        
        private global::System.Data.DataRelation relationCategories_InstructorsCategories;
        
        private global::System.Data.DataRelation relationInstructors_InstructorsCategories;
        
        private global::System.Data.DataRelation relationInstructors_CarriersUses;
        
        private global::System.Data.DataRelation relationCarriers_CarriersUses;
        
        private global::System.Data.DataRelation relationAuditoriums_TheoryLessons;
        
        private global::System.Data.DataRelation relationGroups_TheoryLessons;
        
        private global::System.Data.DataRelation relationCarriers_CarriesRepairs;
        
        private global::System.Data.DataRelation relationServiceMasters_CarriesRepairs;
        
        private global::System.Data.DataRelation relationCarriersUses_ReplacementCarrier;
        
        private global::System.Data.DataRelation relationCarriers_ReplacementCarrier;
        
        private global::System.Data.DataRelation relationWorkStatuses_ServiceMasters;
        
        private global::System.Data.DataRelation relationWorkStatuses_Instructors;
        
        private global::System.Data.DataRelation relationWorkStatuses_TheoryTeachers;
        
        private global::System.Data.DataRelation relationTheoryTeachers_Groups;
        
        private global::System.Data.DataRelation relationCategories_Groups;
        
        private global::System.Data.DataRelation relationStudents_PracticeLessons;
        
        private global::System.Data.DataRelation relationCarriersUses_Students;
        
        private global::System.Data.DataRelation relationGroups_Students;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public AutoschoolDataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
            this.InitExpressions();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected AutoschoolDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.ExcludeSchema)) {
                    this.InitExpressions();
                }
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Categories"] != null)) {
                    base.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
                }
                if ((ds.Tables["Carriers"] != null)) {
                    base.Tables.Add(new CarriersDataTable(ds.Tables["Carriers"]));
                }
                if ((ds.Tables["Instructors"] != null)) {
                    base.Tables.Add(new InstructorsDataTable(ds.Tables["Instructors"]));
                }
                if ((ds.Tables["ServiceMasters"] != null)) {
                    base.Tables.Add(new ServiceMastersDataTable(ds.Tables["ServiceMasters"]));
                }
                if ((ds.Tables["TheoryTeachers"] != null)) {
                    base.Tables.Add(new TheoryTeachersDataTable(ds.Tables["TheoryTeachers"]));
                }
                if ((ds.Tables["Auditoriums"] != null)) {
                    base.Tables.Add(new AuditoriumsDataTable(ds.Tables["Auditoriums"]));
                }
                if ((ds.Tables["Groups"] != null)) {
                    base.Tables.Add(new GroupsDataTable(ds.Tables["Groups"]));
                }
                if ((ds.Tables["InstructorsCategories"] != null)) {
                    base.Tables.Add(new InstructorsCategoriesDataTable(ds.Tables["InstructorsCategories"]));
                }
                if ((ds.Tables["TheoryLessons"] != null)) {
                    base.Tables.Add(new TheoryLessonsDataTable(ds.Tables["TheoryLessons"]));
                }
                if ((ds.Tables["CarriersStatuses"] != null)) {
                    base.Tables.Add(new CarriersStatusesDataTable(ds.Tables["CarriersStatuses"]));
                }
                if ((ds.Tables["Transmissions"] != null)) {
                    base.Tables.Add(new TransmissionsDataTable(ds.Tables["Transmissions"]));
                }
                if ((ds.Tables["PracticeLessons"] != null)) {
                    base.Tables.Add(new PracticeLessonsDataTable(ds.Tables["PracticeLessons"]));
                }
                if ((ds.Tables["CarriersUses"] != null)) {
                    base.Tables.Add(new CarriersUsesDataTable(ds.Tables["CarriersUses"]));
                }
                if ((ds.Tables["CarriersRepairs"] != null)) {
                    base.Tables.Add(new CarriersRepairsDataTable(ds.Tables["CarriersRepairs"]));
                }
                if ((ds.Tables["ReplacementsCarriers"] != null)) {
                    base.Tables.Add(new ReplacementsCarriersDataTable(ds.Tables["ReplacementsCarriers"]));
                }
                if ((ds.Tables["WorkStatuses"] != null)) {
                    base.Tables.Add(new WorkStatusesDataTable(ds.Tables["WorkStatuses"]));
                }
                if ((ds.Tables["Students"] != null)) {
                    base.Tables.Add(new StudentsDataTable(ds.Tables["Students"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                this.InitExpressions();
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CategoriesDataTable Categories {
            get {
                return this.tableCategories;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CarriersDataTable Carriers {
            get {
                return this.tableCarriers;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public InstructorsDataTable Instructors {
            get {
                return this.tableInstructors;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ServiceMastersDataTable ServiceMasters {
            get {
                return this.tableServiceMasters;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TheoryTeachersDataTable TheoryTeachers {
            get {
                return this.tableTheoryTeachers;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public AuditoriumsDataTable Auditoriums {
            get {
                return this.tableAuditoriums;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public GroupsDataTable Groups {
            get {
                return this.tableGroups;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public InstructorsCategoriesDataTable InstructorsCategories {
            get {
                return this.tableInstructorsCategories;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TheoryLessonsDataTable TheoryLessons {
            get {
                return this.tableTheoryLessons;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CarriersStatusesDataTable CarriersStatuses {
            get {
                return this.tableCarriersStatuses;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TransmissionsDataTable Transmissions {
            get {
                return this.tableTransmissions;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PracticeLessonsDataTable PracticeLessons {
            get {
                return this.tablePracticeLessons;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CarriersUsesDataTable CarriersUses {
            get {
                return this.tableCarriersUses;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CarriersRepairsDataTable CarriersRepairs {
            get {
                return this.tableCarriersRepairs;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ReplacementsCarriersDataTable ReplacementsCarriers {
            get {
                return this.tableReplacementsCarriers;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public WorkStatusesDataTable WorkStatuses {
            get {
                return this.tableWorkStatuses;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public StudentsDataTable Students {
            get {
                return this.tableStudents;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            AutoschoolDataSet cln = ((AutoschoolDataSet)(base.Clone()));
            cln.InitVars();
            cln.InitExpressions();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Categories"] != null)) {
                    base.Tables.Add(new CategoriesDataTable(ds.Tables["Categories"]));
                }
                if ((ds.Tables["Carriers"] != null)) {
                    base.Tables.Add(new CarriersDataTable(ds.Tables["Carriers"]));
                }
                if ((ds.Tables["Instructors"] != null)) {
                    base.Tables.Add(new InstructorsDataTable(ds.Tables["Instructors"]));
                }
                if ((ds.Tables["ServiceMasters"] != null)) {
                    base.Tables.Add(new ServiceMastersDataTable(ds.Tables["ServiceMasters"]));
                }
                if ((ds.Tables["TheoryTeachers"] != null)) {
                    base.Tables.Add(new TheoryTeachersDataTable(ds.Tables["TheoryTeachers"]));
                }
                if ((ds.Tables["Auditoriums"] != null)) {
                    base.Tables.Add(new AuditoriumsDataTable(ds.Tables["Auditoriums"]));
                }
                if ((ds.Tables["Groups"] != null)) {
                    base.Tables.Add(new GroupsDataTable(ds.Tables["Groups"]));
                }
                if ((ds.Tables["InstructorsCategories"] != null)) {
                    base.Tables.Add(new InstructorsCategoriesDataTable(ds.Tables["InstructorsCategories"]));
                }
                if ((ds.Tables["TheoryLessons"] != null)) {
                    base.Tables.Add(new TheoryLessonsDataTable(ds.Tables["TheoryLessons"]));
                }
                if ((ds.Tables["CarriersStatuses"] != null)) {
                    base.Tables.Add(new CarriersStatusesDataTable(ds.Tables["CarriersStatuses"]));
                }
                if ((ds.Tables["Transmissions"] != null)) {
                    base.Tables.Add(new TransmissionsDataTable(ds.Tables["Transmissions"]));
                }
                if ((ds.Tables["PracticeLessons"] != null)) {
                    base.Tables.Add(new PracticeLessonsDataTable(ds.Tables["PracticeLessons"]));
                }
                if ((ds.Tables["CarriersUses"] != null)) {
                    base.Tables.Add(new CarriersUsesDataTable(ds.Tables["CarriersUses"]));
                }
                if ((ds.Tables["CarriersRepairs"] != null)) {
                    base.Tables.Add(new CarriersRepairsDataTable(ds.Tables["CarriersRepairs"]));
                }
                if ((ds.Tables["ReplacementsCarriers"] != null)) {
                    base.Tables.Add(new ReplacementsCarriersDataTable(ds.Tables["ReplacementsCarriers"]));
                }
                if ((ds.Tables["WorkStatuses"] != null)) {
                    base.Tables.Add(new WorkStatusesDataTable(ds.Tables["WorkStatuses"]));
                }
                if ((ds.Tables["Students"] != null)) {
                    base.Tables.Add(new StudentsDataTable(ds.Tables["Students"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableCategories = ((CategoriesDataTable)(base.Tables["Categories"]));
            if ((initTable == true)) {
                if ((this.tableCategories != null)) {
                    this.tableCategories.InitVars();
                }
            }
            this.tableCarriers = ((CarriersDataTable)(base.Tables["Carriers"]));
            if ((initTable == true)) {
                if ((this.tableCarriers != null)) {
                    this.tableCarriers.InitVars();
                }
            }
            this.tableInstructors = ((InstructorsDataTable)(base.Tables["Instructors"]));
            if ((initTable == true)) {
                if ((this.tableInstructors != null)) {
                    this.tableInstructors.InitVars();
                }
            }
            this.tableServiceMasters = ((ServiceMastersDataTable)(base.Tables["ServiceMasters"]));
            if ((initTable == true)) {
                if ((this.tableServiceMasters != null)) {
                    this.tableServiceMasters.InitVars();
                }
            }
            this.tableTheoryTeachers = ((TheoryTeachersDataTable)(base.Tables["TheoryTeachers"]));
            if ((initTable == true)) {
                if ((this.tableTheoryTeachers != null)) {
                    this.tableTheoryTeachers.InitVars();
                }
            }
            this.tableAuditoriums = ((AuditoriumsDataTable)(base.Tables["Auditoriums"]));
            if ((initTable == true)) {
                if ((this.tableAuditoriums != null)) {
                    this.tableAuditoriums.InitVars();
                }
            }
            this.tableGroups = ((GroupsDataTable)(base.Tables["Groups"]));
            if ((initTable == true)) {
                if ((this.tableGroups != null)) {
                    this.tableGroups.InitVars();
                }
            }
            this.tableInstructorsCategories = ((InstructorsCategoriesDataTable)(base.Tables["InstructorsCategories"]));
            if ((initTable == true)) {
                if ((this.tableInstructorsCategories != null)) {
                    this.tableInstructorsCategories.InitVars();
                }
            }
            this.tableTheoryLessons = ((TheoryLessonsDataTable)(base.Tables["TheoryLessons"]));
            if ((initTable == true)) {
                if ((this.tableTheoryLessons != null)) {
                    this.tableTheoryLessons.InitVars();
                }
            }
            this.tableCarriersStatuses = ((CarriersStatusesDataTable)(base.Tables["CarriersStatuses"]));
            if ((initTable == true)) {
                if ((this.tableCarriersStatuses != null)) {
                    this.tableCarriersStatuses.InitVars();
                }
            }
            this.tableTransmissions = ((TransmissionsDataTable)(base.Tables["Transmissions"]));
            if ((initTable == true)) {
                if ((this.tableTransmissions != null)) {
                    this.tableTransmissions.InitVars();
                }
            }
            this.tablePracticeLessons = ((PracticeLessonsDataTable)(base.Tables["PracticeLessons"]));
            if ((initTable == true)) {
                if ((this.tablePracticeLessons != null)) {
                    this.tablePracticeLessons.InitVars();
                }
            }
            this.tableCarriersUses = ((CarriersUsesDataTable)(base.Tables["CarriersUses"]));
            if ((initTable == true)) {
                if ((this.tableCarriersUses != null)) {
                    this.tableCarriersUses.InitVars();
                }
            }
            this.tableCarriersRepairs = ((CarriersRepairsDataTable)(base.Tables["CarriersRepairs"]));
            if ((initTable == true)) {
                if ((this.tableCarriersRepairs != null)) {
                    this.tableCarriersRepairs.InitVars();
                }
            }
            this.tableReplacementsCarriers = ((ReplacementsCarriersDataTable)(base.Tables["ReplacementsCarriers"]));
            if ((initTable == true)) {
                if ((this.tableReplacementsCarriers != null)) {
                    this.tableReplacementsCarriers.InitVars();
                }
            }
            this.tableWorkStatuses = ((WorkStatusesDataTable)(base.Tables["WorkStatuses"]));
            if ((initTable == true)) {
                if ((this.tableWorkStatuses != null)) {
                    this.tableWorkStatuses.InitVars();
                }
            }
            this.tableStudents = ((StudentsDataTable)(base.Tables["Students"]));
            if ((initTable == true)) {
                if ((this.tableStudents != null)) {
                    this.tableStudents.InitVars();
                }
            }
            this.relationCarriesStatuses_Carriers = this.Relations["CarriesStatuses_Carriers"];
            this.relationCategories_Carriers = this.Relations["Categories_Carriers"];
            this.relationTransmissions_Carriers = this.Relations["Transmissions_Carriers"];
            this.relationCategories_InstructorsCategories = this.Relations["Categories_InstructorsCategories"];
            this.relationInstructors_InstructorsCategories = this.Relations["Instructors_InstructorsCategories"];
            this.relationInstructors_CarriersUses = this.Relations["Instructors_CarriersUses"];
            this.relationCarriers_CarriersUses = this.Relations["Carriers_CarriersUses"];
            this.relationAuditoriums_TheoryLessons = this.Relations["Auditoriums_TheoryLessons"];
            this.relationGroups_TheoryLessons = this.Relations["Groups_TheoryLessons"];
            this.relationCarriers_CarriesRepairs = this.Relations["Carriers_CarriesRepairs"];
            this.relationServiceMasters_CarriesRepairs = this.Relations["ServiceMasters_CarriesRepairs"];
            this.relationCarriersUses_ReplacementCarrier = this.Relations["CarriersUses_ReplacementCarrier"];
            this.relationCarriers_ReplacementCarrier = this.Relations["Carriers_ReplacementCarrier"];
            this.relationWorkStatuses_ServiceMasters = this.Relations["WorkStatuses_ServiceMasters"];
            this.relationWorkStatuses_Instructors = this.Relations["WorkStatuses_Instructors"];
            this.relationWorkStatuses_TheoryTeachers = this.Relations["WorkStatuses_TheoryTeachers"];
            this.relationTheoryTeachers_Groups = this.Relations["TheoryTeachers_Groups"];
            this.relationCategories_Groups = this.Relations["Categories_Groups"];
            this.relationStudents_PracticeLessons = this.Relations["Students_PracticeLessons"];
            this.relationCarriersUses_Students = this.Relations["CarriersUses_Students"];
            this.relationGroups_Students = this.Relations["Groups_Students"];
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "AutoschoolDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/AutoschoolDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableCategories = new CategoriesDataTable();
            base.Tables.Add(this.tableCategories);
            this.tableCarriers = new CarriersDataTable(false);
            base.Tables.Add(this.tableCarriers);
            this.tableInstructors = new InstructorsDataTable(false);
            base.Tables.Add(this.tableInstructors);
            this.tableServiceMasters = new ServiceMastersDataTable(false);
            base.Tables.Add(this.tableServiceMasters);
            this.tableTheoryTeachers = new TheoryTeachersDataTable(false);
            base.Tables.Add(this.tableTheoryTeachers);
            this.tableAuditoriums = new AuditoriumsDataTable();
            base.Tables.Add(this.tableAuditoriums);
            this.tableGroups = new GroupsDataTable(false);
            base.Tables.Add(this.tableGroups);
            this.tableInstructorsCategories = new InstructorsCategoriesDataTable(false);
            base.Tables.Add(this.tableInstructorsCategories);
            this.tableTheoryLessons = new TheoryLessonsDataTable();
            base.Tables.Add(this.tableTheoryLessons);
            this.tableCarriersStatuses = new CarriersStatusesDataTable();
            base.Tables.Add(this.tableCarriersStatuses);
            this.tableTransmissions = new TransmissionsDataTable();
            base.Tables.Add(this.tableTransmissions);
            this.tablePracticeLessons = new PracticeLessonsDataTable(false);
            base.Tables.Add(this.tablePracticeLessons);
            this.tableCarriersUses = new CarriersUsesDataTable(false);
            base.Tables.Add(this.tableCarriersUses);
            this.tableCarriersRepairs = new CarriersRepairsDataTable();
            base.Tables.Add(this.tableCarriersRepairs);
            this.tableReplacementsCarriers = new ReplacementsCarriersDataTable();
            base.Tables.Add(this.tableReplacementsCarriers);
            this.tableWorkStatuses = new WorkStatusesDataTable();
            base.Tables.Add(this.tableWorkStatuses);
            this.tableStudents = new StudentsDataTable(false);
            base.Tables.Add(this.tableStudents);
            this.relationCarriesStatuses_Carriers = new global::System.Data.DataRelation("CarriesStatuses_Carriers", new global::System.Data.DataColumn[] {
                        this.tableCarriersStatuses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriers.StatusColumn}, false);
            this.Relations.Add(this.relationCarriesStatuses_Carriers);
            this.relationCategories_Carriers = new global::System.Data.DataRelation("Categories_Carriers", new global::System.Data.DataColumn[] {
                        this.tableCategories.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriers.CategoryColumn}, false);
            this.Relations.Add(this.relationCategories_Carriers);
            this.relationTransmissions_Carriers = new global::System.Data.DataRelation("Transmissions_Carriers", new global::System.Data.DataColumn[] {
                        this.tableTransmissions.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriers.TransmissionColumn}, false);
            this.Relations.Add(this.relationTransmissions_Carriers);
            this.relationCategories_InstructorsCategories = new global::System.Data.DataRelation("Categories_InstructorsCategories", new global::System.Data.DataColumn[] {
                        this.tableCategories.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableInstructorsCategories.CategoryColumn}, false);
            this.Relations.Add(this.relationCategories_InstructorsCategories);
            this.relationInstructors_InstructorsCategories = new global::System.Data.DataRelation("Instructors_InstructorsCategories", new global::System.Data.DataColumn[] {
                        this.tableInstructors.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableInstructorsCategories.InstructorColumn}, false);
            this.Relations.Add(this.relationInstructors_InstructorsCategories);
            this.relationInstructors_CarriersUses = new global::System.Data.DataRelation("Instructors_CarriersUses", new global::System.Data.DataColumn[] {
                        this.tableInstructors.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriersUses.InstructorColumn}, false);
            this.Relations.Add(this.relationInstructors_CarriersUses);
            this.relationCarriers_CarriersUses = new global::System.Data.DataRelation("Carriers_CarriersUses", new global::System.Data.DataColumn[] {
                        this.tableCarriers.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriersUses.CarrierColumn}, false);
            this.Relations.Add(this.relationCarriers_CarriersUses);
            this.relationAuditoriums_TheoryLessons = new global::System.Data.DataRelation("Auditoriums_TheoryLessons", new global::System.Data.DataColumn[] {
                        this.tableAuditoriums.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableTheoryLessons.AuditoriumColumn}, false);
            this.Relations.Add(this.relationAuditoriums_TheoryLessons);
            this.relationGroups_TheoryLessons = new global::System.Data.DataRelation("Groups_TheoryLessons", new global::System.Data.DataColumn[] {
                        this.tableGroups.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableTheoryLessons.GroupColumn}, false);
            this.Relations.Add(this.relationGroups_TheoryLessons);
            this.relationCarriers_CarriesRepairs = new global::System.Data.DataRelation("Carriers_CarriesRepairs", new global::System.Data.DataColumn[] {
                        this.tableCarriers.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriersRepairs.CarrierColumn}, false);
            this.Relations.Add(this.relationCarriers_CarriesRepairs);
            this.relationServiceMasters_CarriesRepairs = new global::System.Data.DataRelation("ServiceMasters_CarriesRepairs", new global::System.Data.DataColumn[] {
                        this.tableServiceMasters.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableCarriersRepairs.MasterColumn}, false);
            this.Relations.Add(this.relationServiceMasters_CarriesRepairs);
            this.relationCarriersUses_ReplacementCarrier = new global::System.Data.DataRelation("CarriersUses_ReplacementCarrier", new global::System.Data.DataColumn[] {
                        this.tableCarriersUses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableReplacementsCarriers.CarrierUseColumn}, false);
            this.Relations.Add(this.relationCarriersUses_ReplacementCarrier);
            this.relationCarriers_ReplacementCarrier = new global::System.Data.DataRelation("Carriers_ReplacementCarrier", new global::System.Data.DataColumn[] {
                        this.tableCarriers.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableReplacementsCarriers.CarrierReplacementColumn}, false);
            this.Relations.Add(this.relationCarriers_ReplacementCarrier);
            this.relationWorkStatuses_ServiceMasters = new global::System.Data.DataRelation("WorkStatuses_ServiceMasters", new global::System.Data.DataColumn[] {
                        this.tableWorkStatuses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableServiceMasters.WorkStatusColumn}, false);
            this.Relations.Add(this.relationWorkStatuses_ServiceMasters);
            this.relationWorkStatuses_Instructors = new global::System.Data.DataRelation("WorkStatuses_Instructors", new global::System.Data.DataColumn[] {
                        this.tableWorkStatuses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableInstructors.WorkStatusColumn}, false);
            this.Relations.Add(this.relationWorkStatuses_Instructors);
            this.relationWorkStatuses_TheoryTeachers = new global::System.Data.DataRelation("WorkStatuses_TheoryTeachers", new global::System.Data.DataColumn[] {
                        this.tableWorkStatuses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableTheoryTeachers.WorkStatusColumn}, false);
            this.Relations.Add(this.relationWorkStatuses_TheoryTeachers);
            this.relationTheoryTeachers_Groups = new global::System.Data.DataRelation("TheoryTeachers_Groups", new global::System.Data.DataColumn[] {
                        this.tableTheoryTeachers.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableGroups.TeacherColumn}, false);
            this.Relations.Add(this.relationTheoryTeachers_Groups);
            this.relationCategories_Groups = new global::System.Data.DataRelation("Categories_Groups", new global::System.Data.DataColumn[] {
                        this.tableCategories.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableGroups.CategoryColumn}, false);
            this.Relations.Add(this.relationCategories_Groups);
            this.relationStudents_PracticeLessons = new global::System.Data.DataRelation("Students_PracticeLessons", new global::System.Data.DataColumn[] {
                        this.tableStudents.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tablePracticeLessons.StudentColumn}, false);
            this.Relations.Add(this.relationStudents_PracticeLessons);
            this.relationCarriersUses_Students = new global::System.Data.DataRelation("CarriersUses_Students", new global::System.Data.DataColumn[] {
                        this.tableCarriersUses.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableStudents.CarrierUseColumn}, false);
            this.Relations.Add(this.relationCarriersUses_Students);
            this.relationGroups_Students = new global::System.Data.DataRelation("Groups_Students", new global::System.Data.DataColumn[] {
                        this.tableGroups.IDColumn}, new global::System.Data.DataColumn[] {
                        this.tableStudents.GroupColumn}, false);
            this.Relations.Add(this.relationGroups_Students);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCategories() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCarriers() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeInstructors() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeServiceMasters() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeTheoryTeachers() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeAuditoriums() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeGroups() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeInstructorsCategories() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeTheoryLessons() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCarriersStatuses() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeTransmissions() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializePracticeLessons() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCarriersUses() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeCarriersRepairs() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeReplacementsCarriers() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeWorkStatuses() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeStudents() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            AutoschoolDataSet ds = new AutoschoolDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitExpressions() {
            this.Carriers.FinalNameColumn.Expression = "Brand + \' \' + Model + \' \' + StateNumber";
            this.Instructors.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
            this.Instructors.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_Instructors).Name";
            this.ServiceMasters.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
            this.ServiceMasters.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_ServiceMasters).Name";
            this.TheoryTeachers.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
            this.TheoryTeachers.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_TheoryTeachers).Name";
            this.Groups.TeacherFIOColumn.Expression = "Parent(TheoryTeachers_Groups).FIO";
            this.Groups.CategoryNameColumn.Expression = "Parent(Categories_Groups).Name";
            this.InstructorsCategories.InstructorFIOColumn.Expression = "Parent(Instructors_InstructorsCategories).FIO";
            this.PracticeLessons.StudentFIOColumn.Expression = "Parent(Students_PracticeLessons).FIO";
            this.PracticeLessons.CarrierNameColumn.Expression = "Parent(Students_PracticeLessons).CarrierName";
            this.CarriersUses.InstructorNameColumn.Expression = "Parent(Instructors_CarriersUses).FIO";
            this.CarriersUses.CarrierNameColumn.Expression = "Parent(Carriers_CarriersUses).FinalName";
            this.CarriersUses.CategoryCarrierIDColumn.Expression = "Parent(Carriers_CarriersUses).Category";
            this.Students.InstructorNameColumn.Expression = "Parent(CarriersUses_Students).InstructorName";
            this.Students.CarrierNameColumn.Expression = "Parent(CarriersUses_Students).CarrierName";
            this.Students.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CategoriesRowChangeEventHandler(object sender, CategoriesRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CarriersRowChangeEventHandler(object sender, CarriersRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void InstructorsRowChangeEventHandler(object sender, InstructorsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void ServiceMastersRowChangeEventHandler(object sender, ServiceMastersRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void TheoryTeachersRowChangeEventHandler(object sender, TheoryTeachersRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void AuditoriumsRowChangeEventHandler(object sender, AuditoriumsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void GroupsRowChangeEventHandler(object sender, GroupsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void InstructorsCategoriesRowChangeEventHandler(object sender, InstructorsCategoriesRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void TheoryLessonsRowChangeEventHandler(object sender, TheoryLessonsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CarriersStatusesRowChangeEventHandler(object sender, CarriersStatusesRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void TransmissionsRowChangeEventHandler(object sender, TransmissionsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void PracticeLessonsRowChangeEventHandler(object sender, PracticeLessonsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CarriersUsesRowChangeEventHandler(object sender, CarriersUsesRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void CarriersRepairsRowChangeEventHandler(object sender, CarriersRepairsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void ReplacementsCarriersRowChangeEventHandler(object sender, ReplacementsCarriersRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void WorkStatusesRowChangeEventHandler(object sender, WorkStatusesRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void StudentsRowChangeEventHandler(object sender, StudentsRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CategoriesDataTable : global::System.Data.TypedTableBase<CategoriesRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesDataTable() {
                this.TableName = "Categories";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CategoriesDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected CategoriesDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow this[int index] {
                get {
                    return ((CategoriesRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CategoriesRowChangeEventHandler CategoriesRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CategoriesRowChangeEventHandler CategoriesRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CategoriesRowChangeEventHandler CategoriesRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CategoriesRowChangeEventHandler CategoriesRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCategoriesRow(CategoriesRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow AddCategoriesRow(string Name) {
                CategoriesRow rowCategoriesRow = ((CategoriesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name};
                rowCategoriesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCategoriesRow);
                return rowCategoriesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow FindByID(int ID) {
                return ((CategoriesRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CategoriesDataTable cln = ((CategoriesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CategoriesDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName = base.Columns["Name"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Categories", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow NewCategoriesRow() {
                return ((CategoriesRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CategoriesRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CategoriesRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CategoriesRowChanged != null)) {
                    this.CategoriesRowChanged(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CategoriesRowChanging != null)) {
                    this.CategoriesRowChanging(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CategoriesRowDeleted != null)) {
                    this.CategoriesRowDeleted(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CategoriesRowDeleting != null)) {
                    this.CategoriesRowDeleting(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveCategoriesRow(CategoriesRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CategoriesDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CarriersDataTable : global::System.Data.TypedTableBase<CarriersRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnBrand;
            
            private global::System.Data.DataColumn columnModel;
            
            private global::System.Data.DataColumn columnStateNumber;
            
            private global::System.Data.DataColumn columnColor;
            
            private global::System.Data.DataColumn columnTransmission;
            
            private global::System.Data.DataColumn columnCategory;
            
            private global::System.Data.DataColumn columnStatus;
            
            private global::System.Data.DataColumn columnFinalName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersDataTable(bool initExpressions) {
                this.TableName = "Carriers";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected CarriersDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn BrandColumn {
                get {
                    return this.columnBrand;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ModelColumn {
                get {
                    return this.columnModel;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StateNumberColumn {
                get {
                    return this.columnStateNumber;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ColorColumn {
                get {
                    return this.columnColor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TransmissionColumn {
                get {
                    return this.columnTransmission;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CategoryColumn {
                get {
                    return this.columnCategory;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FinalNameColumn {
                get {
                    return this.columnFinalName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow this[int index] {
                get {
                    return ((CarriersRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRowChangeEventHandler CarriersRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRowChangeEventHandler CarriersRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRowChangeEventHandler CarriersRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRowChangeEventHandler CarriersRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCarriersRow(CarriersRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow AddCarriersRow(string Brand, string Model, string StateNumber, string Color, TransmissionsRow parentTransmissionsRowByTransmissions_Carriers, CategoriesRow parentCategoriesRowByCategories_Carriers, CarriersStatusesRow parentCarriersStatusesRowByCarriesStatuses_Carriers, string FinalName) {
                CarriersRow rowCarriersRow = ((CarriersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Brand,
                        Model,
                        StateNumber,
                        Color,
                        null,
                        null,
                        null,
                        FinalName};
                if ((parentTransmissionsRowByTransmissions_Carriers != null)) {
                    columnValuesArray[5] = parentTransmissionsRowByTransmissions_Carriers[0];
                }
                if ((parentCategoriesRowByCategories_Carriers != null)) {
                    columnValuesArray[6] = parentCategoriesRowByCategories_Carriers[0];
                }
                if ((parentCarriersStatusesRowByCarriesStatuses_Carriers != null)) {
                    columnValuesArray[7] = parentCarriersStatusesRowByCarriesStatuses_Carriers[0];
                }
                rowCarriersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersRow);
                return rowCarriersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow AddCarriersRow(string Brand, string Model, string StateNumber, string Color, TransmissionsRow parentTransmissionsRowByTransmissions_Carriers, CategoriesRow parentCategoriesRowByCategories_Carriers, CarriersStatusesRow parentCarriersStatusesRowByCarriesStatuses_Carriers) {
                CarriersRow rowCarriersRow = ((CarriersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Brand,
                        Model,
                        StateNumber,
                        Color,
                        null,
                        null,
                        null,
                        null};
                if ((parentTransmissionsRowByTransmissions_Carriers != null)) {
                    columnValuesArray[5] = parentTransmissionsRowByTransmissions_Carriers[0];
                }
                if ((parentCategoriesRowByCategories_Carriers != null)) {
                    columnValuesArray[6] = parentCategoriesRowByCategories_Carriers[0];
                }
                if ((parentCarriersStatusesRowByCarriesStatuses_Carriers != null)) {
                    columnValuesArray[7] = parentCarriersStatusesRowByCarriesStatuses_Carriers[0];
                }
                rowCarriersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersRow);
                return rowCarriersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow FindByID(int ID) {
                return ((CarriersRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CarriersDataTable cln = ((CarriersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CarriersDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnBrand = base.Columns["Brand"];
                this.columnModel = base.Columns["Model"];
                this.columnStateNumber = base.Columns["StateNumber"];
                this.columnColor = base.Columns["Color"];
                this.columnTransmission = base.Columns["Transmission"];
                this.columnCategory = base.Columns["Category"];
                this.columnStatus = base.Columns["Status"];
                this.columnFinalName = base.Columns["FinalName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnBrand = new global::System.Data.DataColumn("Brand", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBrand);
                this.columnModel = new global::System.Data.DataColumn("Model", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnModel);
                this.columnStateNumber = new global::System.Data.DataColumn("StateNumber", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStateNumber);
                this.columnColor = new global::System.Data.DataColumn("Color", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnColor);
                this.columnTransmission = new global::System.Data.DataColumn("Transmission", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTransmission);
                this.columnCategory = new global::System.Data.DataColumn("Category", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCategory);
                this.columnStatus = new global::System.Data.DataColumn("Status", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStatus);
                this.columnFinalName = new global::System.Data.DataColumn("FinalName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFinalName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersTransmissions", new global::System.Data.DataColumn[] {
                                this.columnTransmission}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersCategories", new global::System.Data.DataColumn[] {
                                this.columnCategory}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersStatuses", new global::System.Data.DataColumn[] {
                                this.columnStatus}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Carriers", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnColor.Caption = "Model";
                this.columnTransmission.Unique = true;
                this.columnCategory.Unique = true;
                this.columnStatus.Unique = true;
                this.columnFinalName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow NewCarriersRow() {
                return ((CarriersRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CarriersRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CarriersRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.FinalNameColumn.Expression = "Brand + \' \' + Model + \' \' + StateNumber";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CarriersRowChanged != null)) {
                    this.CarriersRowChanged(this, new CarriersRowChangeEvent(((CarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CarriersRowChanging != null)) {
                    this.CarriersRowChanging(this, new CarriersRowChangeEvent(((CarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CarriersRowDeleted != null)) {
                    this.CarriersRowDeleted(this, new CarriersRowChangeEvent(((CarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CarriersRowDeleting != null)) {
                    this.CarriersRowDeleting(this, new CarriersRowChangeEvent(((CarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveCarriersRow(CarriersRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CarriersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class InstructorsDataTable : global::System.Data.TypedTableBase<InstructorsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnSurname;
            
            private global::System.Data.DataColumn columnFirstName;
            
            private global::System.Data.DataColumn columnPatronymicName;
            
            private global::System.Data.DataColumn columnPhoto;
            
            private global::System.Data.DataColumn columnWorkStatus;
            
            private global::System.Data.DataColumn columnFIO;
            
            private global::System.Data.DataColumn columnWorkStatusName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsDataTable(bool initExpressions) {
                this.TableName = "Instructors";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal InstructorsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected InstructorsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn SurnameColumn {
                get {
                    return this.columnSurname;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PatronymicNameColumn {
                get {
                    return this.columnPatronymicName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PhotoColumn {
                get {
                    return this.columnPhoto;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusColumn {
                get {
                    return this.columnWorkStatus;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FIOColumn {
                get {
                    return this.columnFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusNameColumn {
                get {
                    return this.columnWorkStatusName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow this[int index] {
                get {
                    return ((InstructorsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsRowChangeEventHandler InstructorsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsRowChangeEventHandler InstructorsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsRowChangeEventHandler InstructorsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsRowChangeEventHandler InstructorsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddInstructorsRow(InstructorsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow AddInstructorsRow(string Surname, string FirstName, string PatronymicName, string Photo, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_Instructors, string FIO, string WorkStatusName) {
                InstructorsRow rowInstructorsRow = ((InstructorsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        Photo,
                        null,
                        FIO,
                        WorkStatusName};
                if ((parentWorkStatusesRowByWorkStatuses_Instructors != null)) {
                    columnValuesArray[5] = parentWorkStatusesRowByWorkStatuses_Instructors[0];
                }
                rowInstructorsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowInstructorsRow);
                return rowInstructorsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow AddInstructorsRow(string Surname, string FirstName, string PatronymicName, string Photo, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_Instructors) {
                InstructorsRow rowInstructorsRow = ((InstructorsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        Photo,
                        null,
                        null,
                        null};
                if ((parentWorkStatusesRowByWorkStatuses_Instructors != null)) {
                    columnValuesArray[5] = parentWorkStatusesRowByWorkStatuses_Instructors[0];
                }
                rowInstructorsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowInstructorsRow);
                return rowInstructorsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow FindByID(int ID) {
                return ((InstructorsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                InstructorsDataTable cln = ((InstructorsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new InstructorsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnSurname = base.Columns["Surname"];
                this.columnFirstName = base.Columns["FirstName"];
                this.columnPatronymicName = base.Columns["PatronymicName"];
                this.columnPhoto = base.Columns["Photo"];
                this.columnWorkStatus = base.Columns["WorkStatus"];
                this.columnFIO = base.Columns["FIO"];
                this.columnWorkStatusName = base.Columns["WorkStatusName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnSurname = new global::System.Data.DataColumn("Surname", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSurname);
                this.columnFirstName = new global::System.Data.DataColumn("FirstName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFirstName);
                this.columnPatronymicName = new global::System.Data.DataColumn("PatronymicName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPatronymicName);
                this.columnPhoto = new global::System.Data.DataColumn("Photo", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPhoto);
                this.columnWorkStatus = new global::System.Data.DataColumn("WorkStatus", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatus);
                this.columnFIO = new global::System.Data.DataColumn("FIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnWorkStatusName = new global::System.Data.DataColumn("WorkStatusName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatusName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_InstructorsWorkStatuses", new global::System.Data.DataColumn[] {
                                this.columnWorkStatus}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Instructors", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnWorkStatus.Unique = true;
                this.columnFIO.ReadOnly = true;
                this.columnWorkStatusName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow NewInstructorsRow() {
                return ((InstructorsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new InstructorsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(InstructorsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
                this.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_Instructors).Name";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.InstructorsRowChanged != null)) {
                    this.InstructorsRowChanged(this, new InstructorsRowChangeEvent(((InstructorsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.InstructorsRowChanging != null)) {
                    this.InstructorsRowChanging(this, new InstructorsRowChangeEvent(((InstructorsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.InstructorsRowDeleted != null)) {
                    this.InstructorsRowDeleted(this, new InstructorsRowChangeEvent(((InstructorsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.InstructorsRowDeleting != null)) {
                    this.InstructorsRowDeleting(this, new InstructorsRowChangeEvent(((InstructorsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveInstructorsRow(InstructorsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "InstructorsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class ServiceMastersDataTable : global::System.Data.TypedTableBase<ServiceMastersRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnSurname;
            
            private global::System.Data.DataColumn columnFirstName;
            
            private global::System.Data.DataColumn columnPatronymicName;
            
            private global::System.Data.DataColumn columnWorkStatus;
            
            private global::System.Data.DataColumn columnFIO;
            
            private global::System.Data.DataColumn columnWorkStatusName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersDataTable(bool initExpressions) {
                this.TableName = "ServiceMasters";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ServiceMastersDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ServiceMastersDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn SurnameColumn {
                get {
                    return this.columnSurname;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PatronymicNameColumn {
                get {
                    return this.columnPatronymicName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusColumn {
                get {
                    return this.columnWorkStatus;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FIOColumn {
                get {
                    return this.columnFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusNameColumn {
                get {
                    return this.columnWorkStatusName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow this[int index] {
                get {
                    return ((ServiceMastersRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ServiceMastersRowChangeEventHandler ServiceMastersRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ServiceMastersRowChangeEventHandler ServiceMastersRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ServiceMastersRowChangeEventHandler ServiceMastersRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ServiceMastersRowChangeEventHandler ServiceMastersRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddServiceMastersRow(ServiceMastersRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow AddServiceMastersRow(string Surname, string FirstName, string PatronymicName, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_ServiceMasters, string FIO, string WorkStatusName) {
                ServiceMastersRow rowServiceMastersRow = ((ServiceMastersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        null,
                        FIO,
                        WorkStatusName};
                if ((parentWorkStatusesRowByWorkStatuses_ServiceMasters != null)) {
                    columnValuesArray[4] = parentWorkStatusesRowByWorkStatuses_ServiceMasters[0];
                }
                rowServiceMastersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowServiceMastersRow);
                return rowServiceMastersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow AddServiceMastersRow(string Surname, string FirstName, string PatronymicName, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_ServiceMasters) {
                ServiceMastersRow rowServiceMastersRow = ((ServiceMastersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        null,
                        null,
                        null};
                if ((parentWorkStatusesRowByWorkStatuses_ServiceMasters != null)) {
                    columnValuesArray[4] = parentWorkStatusesRowByWorkStatuses_ServiceMasters[0];
                }
                rowServiceMastersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowServiceMastersRow);
                return rowServiceMastersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow FindByID(int ID) {
                return ((ServiceMastersRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                ServiceMastersDataTable cln = ((ServiceMastersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new ServiceMastersDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnSurname = base.Columns["Surname"];
                this.columnFirstName = base.Columns["FirstName"];
                this.columnPatronymicName = base.Columns["PatronymicName"];
                this.columnWorkStatus = base.Columns["WorkStatus"];
                this.columnFIO = base.Columns["FIO"];
                this.columnWorkStatusName = base.Columns["WorkStatusName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnSurname = new global::System.Data.DataColumn("Surname", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSurname);
                this.columnFirstName = new global::System.Data.DataColumn("FirstName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFirstName);
                this.columnPatronymicName = new global::System.Data.DataColumn("PatronymicName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPatronymicName);
                this.columnWorkStatus = new global::System.Data.DataColumn("WorkStatus", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatus);
                this.columnFIO = new global::System.Data.DataColumn("FIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnWorkStatusName = new global::System.Data.DataColumn("WorkStatusName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatusName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_ServiceMastersWorkStatuses", new global::System.Data.DataColumn[] {
                                this.columnWorkStatus}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_ServiceMasters", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnWorkStatus.Unique = true;
                this.columnFIO.ReadOnly = true;
                this.columnWorkStatusName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow NewServiceMastersRow() {
                return ((ServiceMastersRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new ServiceMastersRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(ServiceMastersRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
                this.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_ServiceMasters).Name";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ServiceMastersRowChanged != null)) {
                    this.ServiceMastersRowChanged(this, new ServiceMastersRowChangeEvent(((ServiceMastersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ServiceMastersRowChanging != null)) {
                    this.ServiceMastersRowChanging(this, new ServiceMastersRowChangeEvent(((ServiceMastersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ServiceMastersRowDeleted != null)) {
                    this.ServiceMastersRowDeleted(this, new ServiceMastersRowChangeEvent(((ServiceMastersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ServiceMastersRowDeleting != null)) {
                    this.ServiceMastersRowDeleting(this, new ServiceMastersRowChangeEvent(((ServiceMastersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveServiceMastersRow(ServiceMastersRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "ServiceMastersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TheoryTeachersDataTable : global::System.Data.TypedTableBase<TheoryTeachersRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnSurname;
            
            private global::System.Data.DataColumn columnFirstName;
            
            private global::System.Data.DataColumn columnPatronymicName;
            
            private global::System.Data.DataColumn columnPhoto;
            
            private global::System.Data.DataColumn columnWorkStatus;
            
            private global::System.Data.DataColumn columnFIO;
            
            private global::System.Data.DataColumn columnWorkStatusName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersDataTable(bool initExpressions) {
                this.TableName = "TheoryTeachers";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TheoryTeachersDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected TheoryTeachersDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn SurnameColumn {
                get {
                    return this.columnSurname;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PatronymicNameColumn {
                get {
                    return this.columnPatronymicName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PhotoColumn {
                get {
                    return this.columnPhoto;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusColumn {
                get {
                    return this.columnWorkStatus;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FIOColumn {
                get {
                    return this.columnFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkStatusNameColumn {
                get {
                    return this.columnWorkStatusName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow this[int index] {
                get {
                    return ((TheoryTeachersRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryTeachersRowChangeEventHandler TheoryTeachersRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryTeachersRowChangeEventHandler TheoryTeachersRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryTeachersRowChangeEventHandler TheoryTeachersRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryTeachersRowChangeEventHandler TheoryTeachersRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddTheoryTeachersRow(TheoryTeachersRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow AddTheoryTeachersRow(string Surname, string FirstName, string PatronymicName, string Photo, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_TheoryTeachers, string FIO, string WorkStatusName) {
                TheoryTeachersRow rowTheoryTeachersRow = ((TheoryTeachersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        Photo,
                        null,
                        FIO,
                        WorkStatusName};
                if ((parentWorkStatusesRowByWorkStatuses_TheoryTeachers != null)) {
                    columnValuesArray[5] = parentWorkStatusesRowByWorkStatuses_TheoryTeachers[0];
                }
                rowTheoryTeachersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTheoryTeachersRow);
                return rowTheoryTeachersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow AddTheoryTeachersRow(string Surname, string FirstName, string PatronymicName, string Photo, WorkStatusesRow parentWorkStatusesRowByWorkStatuses_TheoryTeachers) {
                TheoryTeachersRow rowTheoryTeachersRow = ((TheoryTeachersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        Photo,
                        null,
                        null,
                        null};
                if ((parentWorkStatusesRowByWorkStatuses_TheoryTeachers != null)) {
                    columnValuesArray[5] = parentWorkStatusesRowByWorkStatuses_TheoryTeachers[0];
                }
                rowTheoryTeachersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTheoryTeachersRow);
                return rowTheoryTeachersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow FindByID(int ID) {
                return ((TheoryTeachersRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TheoryTeachersDataTable cln = ((TheoryTeachersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TheoryTeachersDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnSurname = base.Columns["Surname"];
                this.columnFirstName = base.Columns["FirstName"];
                this.columnPatronymicName = base.Columns["PatronymicName"];
                this.columnPhoto = base.Columns["Photo"];
                this.columnWorkStatus = base.Columns["WorkStatus"];
                this.columnFIO = base.Columns["FIO"];
                this.columnWorkStatusName = base.Columns["WorkStatusName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnSurname = new global::System.Data.DataColumn("Surname", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSurname);
                this.columnFirstName = new global::System.Data.DataColumn("FirstName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFirstName);
                this.columnPatronymicName = new global::System.Data.DataColumn("PatronymicName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPatronymicName);
                this.columnPhoto = new global::System.Data.DataColumn("Photo", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPhoto);
                this.columnWorkStatus = new global::System.Data.DataColumn("WorkStatus", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatus);
                this.columnFIO = new global::System.Data.DataColumn("FIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnWorkStatusName = new global::System.Data.DataColumn("WorkStatusName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWorkStatusName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_TheoryTeachersWorkStatuses", new global::System.Data.DataColumn[] {
                                this.columnWorkStatus}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_TheoryTeachers", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnWorkStatus.Unique = true;
                this.columnFIO.ReadOnly = true;
                this.columnWorkStatusName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow NewTheoryTeachersRow() {
                return ((TheoryTeachersRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TheoryTeachersRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TheoryTeachersRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
                this.WorkStatusNameColumn.Expression = "Parent(WorkStatuses_TheoryTeachers).Name";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TheoryTeachersRowChanged != null)) {
                    this.TheoryTeachersRowChanged(this, new TheoryTeachersRowChangeEvent(((TheoryTeachersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TheoryTeachersRowChanging != null)) {
                    this.TheoryTeachersRowChanging(this, new TheoryTeachersRowChangeEvent(((TheoryTeachersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TheoryTeachersRowDeleted != null)) {
                    this.TheoryTeachersRowDeleted(this, new TheoryTeachersRowChangeEvent(((TheoryTeachersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TheoryTeachersRowDeleting != null)) {
                    this.TheoryTeachersRowDeleting(this, new TheoryTeachersRowChangeEvent(((TheoryTeachersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveTheoryTeachersRow(TheoryTeachersRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TheoryTeachersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class AuditoriumsDataTable : global::System.Data.TypedTableBase<AuditoriumsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsDataTable() {
                this.TableName = "Auditoriums";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal AuditoriumsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected AuditoriumsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow this[int index] {
                get {
                    return ((AuditoriumsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AuditoriumsRowChangeEventHandler AuditoriumsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AuditoriumsRowChangeEventHandler AuditoriumsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AuditoriumsRowChangeEventHandler AuditoriumsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event AuditoriumsRowChangeEventHandler AuditoriumsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddAuditoriumsRow(AuditoriumsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow AddAuditoriumsRow(string Name) {
                AuditoriumsRow rowAuditoriumsRow = ((AuditoriumsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name};
                rowAuditoriumsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowAuditoriumsRow);
                return rowAuditoriumsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow FindByID(int ID) {
                return ((AuditoriumsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                AuditoriumsDataTable cln = ((AuditoriumsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new AuditoriumsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName = base.Columns["Name"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Auditoriums", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow NewAuditoriumsRow() {
                return ((AuditoriumsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new AuditoriumsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(AuditoriumsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.AuditoriumsRowChanged != null)) {
                    this.AuditoriumsRowChanged(this, new AuditoriumsRowChangeEvent(((AuditoriumsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.AuditoriumsRowChanging != null)) {
                    this.AuditoriumsRowChanging(this, new AuditoriumsRowChangeEvent(((AuditoriumsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.AuditoriumsRowDeleted != null)) {
                    this.AuditoriumsRowDeleted(this, new AuditoriumsRowChangeEvent(((AuditoriumsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.AuditoriumsRowDeleting != null)) {
                    this.AuditoriumsRowDeleting(this, new AuditoriumsRowChangeEvent(((AuditoriumsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveAuditoriumsRow(AuditoriumsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "AuditoriumsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class GroupsDataTable : global::System.Data.TypedTableBase<GroupsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName;
            
            private global::System.Data.DataColumn columnStartLearning;
            
            private global::System.Data.DataColumn columnEndLearning;
            
            private global::System.Data.DataColumn columnCategory;
            
            private global::System.Data.DataColumn columnTeacher;
            
            private global::System.Data.DataColumn columnTeacherFIO;
            
            private global::System.Data.DataColumn columnCategoryName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsDataTable(bool initExpressions) {
                this.TableName = "Groups";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal GroupsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected GroupsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StartLearningColumn {
                get {
                    return this.columnStartLearning;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn EndLearningColumn {
                get {
                    return this.columnEndLearning;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CategoryColumn {
                get {
                    return this.columnCategory;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TeacherColumn {
                get {
                    return this.columnTeacher;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TeacherFIOColumn {
                get {
                    return this.columnTeacherFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CategoryNameColumn {
                get {
                    return this.columnCategoryName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow this[int index] {
                get {
                    return ((GroupsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event GroupsRowChangeEventHandler GroupsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event GroupsRowChangeEventHandler GroupsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event GroupsRowChangeEventHandler GroupsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event GroupsRowChangeEventHandler GroupsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddGroupsRow(GroupsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow AddGroupsRow(string Name, System.DateTime StartLearning, System.DateTime EndLearning, CategoriesRow parentCategoriesRowByCategories_Groups, TheoryTeachersRow parentTheoryTeachersRowByTheoryTeachers_Groups, string TeacherFIO, string CategoryName) {
                GroupsRow rowGroupsRow = ((GroupsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name,
                        StartLearning,
                        EndLearning,
                        null,
                        null,
                        TeacherFIO,
                        CategoryName};
                if ((parentCategoriesRowByCategories_Groups != null)) {
                    columnValuesArray[4] = parentCategoriesRowByCategories_Groups[0];
                }
                if ((parentTheoryTeachersRowByTheoryTeachers_Groups != null)) {
                    columnValuesArray[5] = parentTheoryTeachersRowByTheoryTeachers_Groups[0];
                }
                rowGroupsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowGroupsRow);
                return rowGroupsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow AddGroupsRow(string Name, System.DateTime StartLearning, System.DateTime EndLearning, CategoriesRow parentCategoriesRowByCategories_Groups, TheoryTeachersRow parentTheoryTeachersRowByTheoryTeachers_Groups) {
                GroupsRow rowGroupsRow = ((GroupsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name,
                        StartLearning,
                        EndLearning,
                        null,
                        null,
                        null,
                        null};
                if ((parentCategoriesRowByCategories_Groups != null)) {
                    columnValuesArray[4] = parentCategoriesRowByCategories_Groups[0];
                }
                if ((parentTheoryTeachersRowByTheoryTeachers_Groups != null)) {
                    columnValuesArray[5] = parentTheoryTeachersRowByTheoryTeachers_Groups[0];
                }
                rowGroupsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowGroupsRow);
                return rowGroupsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow FindByID(int ID) {
                return ((GroupsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                GroupsDataTable cln = ((GroupsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new GroupsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName = base.Columns["Name"];
                this.columnStartLearning = base.Columns["StartLearning"];
                this.columnEndLearning = base.Columns["EndLearning"];
                this.columnCategory = base.Columns["Category"];
                this.columnTeacher = base.Columns["Teacher"];
                this.columnTeacherFIO = base.Columns["TeacherFIO"];
                this.columnCategoryName = base.Columns["CategoryName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnStartLearning = new global::System.Data.DataColumn("StartLearning", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStartLearning);
                this.columnEndLearning = new global::System.Data.DataColumn("EndLearning", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEndLearning);
                this.columnCategory = new global::System.Data.DataColumn("Category", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCategory);
                this.columnTeacher = new global::System.Data.DataColumn("Teacher", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTeacher);
                this.columnTeacherFIO = new global::System.Data.DataColumn("TeacherFIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTeacherFIO);
                this.columnCategoryName = new global::System.Data.DataColumn("CategoryName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCategoryName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_GroupsCategories", new global::System.Data.DataColumn[] {
                                this.columnCategory}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_GroupsTheoryTeachers", new global::System.Data.DataColumn[] {
                                this.columnTeacher}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Groups", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnCategory.Unique = true;
                this.columnTeacher.Unique = true;
                this.columnTeacherFIO.ReadOnly = true;
                this.columnCategoryName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow NewGroupsRow() {
                return ((GroupsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new GroupsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(GroupsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.TeacherFIOColumn.Expression = "Parent(TheoryTeachers_Groups).FIO";
                this.CategoryNameColumn.Expression = "Parent(Categories_Groups).Name";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.GroupsRowChanged != null)) {
                    this.GroupsRowChanged(this, new GroupsRowChangeEvent(((GroupsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.GroupsRowChanging != null)) {
                    this.GroupsRowChanging(this, new GroupsRowChangeEvent(((GroupsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.GroupsRowDeleted != null)) {
                    this.GroupsRowDeleted(this, new GroupsRowChangeEvent(((GroupsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.GroupsRowDeleting != null)) {
                    this.GroupsRowDeleting(this, new GroupsRowChangeEvent(((GroupsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveGroupsRow(GroupsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "GroupsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class InstructorsCategoriesDataTable : global::System.Data.TypedTableBase<InstructorsCategoriesRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnInstructor;
            
            private global::System.Data.DataColumn columnCategory;
            
            private global::System.Data.DataColumn columnInstructorFIO;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesDataTable(bool initExpressions) {
                this.TableName = "InstructorsCategories";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal InstructorsCategoriesDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected InstructorsCategoriesDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn InstructorColumn {
                get {
                    return this.columnInstructor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CategoryColumn {
                get {
                    return this.columnCategory;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn InstructorFIOColumn {
                get {
                    return this.columnInstructorFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow this[int index] {
                get {
                    return ((InstructorsCategoriesRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsCategoriesRowChangeEventHandler InstructorsCategoriesRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsCategoriesRowChangeEventHandler InstructorsCategoriesRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsCategoriesRowChangeEventHandler InstructorsCategoriesRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event InstructorsCategoriesRowChangeEventHandler InstructorsCategoriesRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddInstructorsCategoriesRow(InstructorsCategoriesRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow AddInstructorsCategoriesRow(InstructorsRow parentInstructorsRowByInstructors_InstructorsCategories, CategoriesRow parentCategoriesRowByCategories_InstructorsCategories, string InstructorFIO) {
                InstructorsCategoriesRow rowInstructorsCategoriesRow = ((InstructorsCategoriesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        InstructorFIO};
                if ((parentInstructorsRowByInstructors_InstructorsCategories != null)) {
                    columnValuesArray[1] = parentInstructorsRowByInstructors_InstructorsCategories[0];
                }
                if ((parentCategoriesRowByCategories_InstructorsCategories != null)) {
                    columnValuesArray[2] = parentCategoriesRowByCategories_InstructorsCategories[0];
                }
                rowInstructorsCategoriesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowInstructorsCategoriesRow);
                return rowInstructorsCategoriesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow AddInstructorsCategoriesRow(InstructorsRow parentInstructorsRowByInstructors_InstructorsCategories, CategoriesRow parentCategoriesRowByCategories_InstructorsCategories) {
                InstructorsCategoriesRow rowInstructorsCategoriesRow = ((InstructorsCategoriesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        null};
                if ((parentInstructorsRowByInstructors_InstructorsCategories != null)) {
                    columnValuesArray[1] = parentInstructorsRowByInstructors_InstructorsCategories[0];
                }
                if ((parentCategoriesRowByCategories_InstructorsCategories != null)) {
                    columnValuesArray[2] = parentCategoriesRowByCategories_InstructorsCategories[0];
                }
                rowInstructorsCategoriesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowInstructorsCategoriesRow);
                return rowInstructorsCategoriesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow FindByID(int ID) {
                return ((InstructorsCategoriesRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                InstructorsCategoriesDataTable cln = ((InstructorsCategoriesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new InstructorsCategoriesDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnInstructor = base.Columns["Instructor"];
                this.columnCategory = base.Columns["Category"];
                this.columnInstructorFIO = base.Columns["InstructorFIO"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnInstructor = new global::System.Data.DataColumn("Instructor", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnInstructor);
                this.columnCategory = new global::System.Data.DataColumn("Category", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCategory);
                this.columnInstructorFIO = new global::System.Data.DataColumn("InstructorFIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnInstructorFIO);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_InstructorsCategoriesInstructors", new global::System.Data.DataColumn[] {
                                this.columnInstructor}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_InstructorsCategoriesCategories", new global::System.Data.DataColumn[] {
                                this.columnCategory}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_InstructorsCategories", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnInstructor.Unique = true;
                this.columnCategory.Unique = true;
                this.columnInstructorFIO.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow NewInstructorsCategoriesRow() {
                return ((InstructorsCategoriesRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new InstructorsCategoriesRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(InstructorsCategoriesRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.InstructorFIOColumn.Expression = "Parent(Instructors_InstructorsCategories).FIO";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.InstructorsCategoriesRowChanged != null)) {
                    this.InstructorsCategoriesRowChanged(this, new InstructorsCategoriesRowChangeEvent(((InstructorsCategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.InstructorsCategoriesRowChanging != null)) {
                    this.InstructorsCategoriesRowChanging(this, new InstructorsCategoriesRowChangeEvent(((InstructorsCategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.InstructorsCategoriesRowDeleted != null)) {
                    this.InstructorsCategoriesRowDeleted(this, new InstructorsCategoriesRowChangeEvent(((InstructorsCategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.InstructorsCategoriesRowDeleting != null)) {
                    this.InstructorsCategoriesRowDeleting(this, new InstructorsCategoriesRowChangeEvent(((InstructorsCategoriesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveInstructorsCategoriesRow(InstructorsCategoriesRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "InstructorsCategoriesDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TheoryLessonsDataTable : global::System.Data.TypedTableBase<TheoryLessonsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnDate;
            
            private global::System.Data.DataColumn columnTime;
            
            private global::System.Data.DataColumn columnAuditorium;
            
            private global::System.Data.DataColumn columnGroup;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsDataTable() {
                this.TableName = "TheoryLessons";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TheoryLessonsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected TheoryLessonsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn DateColumn {
                get {
                    return this.columnDate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TimeColumn {
                get {
                    return this.columnTime;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AuditoriumColumn {
                get {
                    return this.columnAuditorium;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn GroupColumn {
                get {
                    return this.columnGroup;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow this[int index] {
                get {
                    return ((TheoryLessonsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryLessonsRowChangeEventHandler TheoryLessonsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryLessonsRowChangeEventHandler TheoryLessonsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryLessonsRowChangeEventHandler TheoryLessonsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TheoryLessonsRowChangeEventHandler TheoryLessonsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddTheoryLessonsRow(TheoryLessonsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow AddTheoryLessonsRow(System.DateTime Date, System.TimeSpan Time, AuditoriumsRow parentAuditoriumsRowByAuditoriums_TheoryLessons, GroupsRow parentGroupsRowByGroups_TheoryLessons) {
                TheoryLessonsRow rowTheoryLessonsRow = ((TheoryLessonsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Date,
                        Time,
                        null,
                        null};
                if ((parentAuditoriumsRowByAuditoriums_TheoryLessons != null)) {
                    columnValuesArray[3] = parentAuditoriumsRowByAuditoriums_TheoryLessons[0];
                }
                if ((parentGroupsRowByGroups_TheoryLessons != null)) {
                    columnValuesArray[4] = parentGroupsRowByGroups_TheoryLessons[0];
                }
                rowTheoryLessonsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTheoryLessonsRow);
                return rowTheoryLessonsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow FindByID(int ID) {
                return ((TheoryLessonsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TheoryLessonsDataTable cln = ((TheoryLessonsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TheoryLessonsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnDate = base.Columns["Date"];
                this.columnTime = base.Columns["Time"];
                this.columnAuditorium = base.Columns["Auditorium"];
                this.columnGroup = base.Columns["Group"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnDate = new global::System.Data.DataColumn("Date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDate);
                this.columnTime = new global::System.Data.DataColumn("Time", typeof(global::System.TimeSpan), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTime);
                this.columnAuditorium = new global::System.Data.DataColumn("Auditorium", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAuditorium);
                this.columnGroup = new global::System.Data.DataColumn("Group", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnGroup);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_TheoryLessonsAuditoriums", new global::System.Data.DataColumn[] {
                                this.columnAuditorium}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_TheoryLessonsGroups", new global::System.Data.DataColumn[] {
                                this.columnGroup}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_TheoryLessons", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnTime.Caption = "DateTime";
                this.columnAuditorium.Unique = true;
                this.columnGroup.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow NewTheoryLessonsRow() {
                return ((TheoryLessonsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TheoryLessonsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TheoryLessonsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TheoryLessonsRowChanged != null)) {
                    this.TheoryLessonsRowChanged(this, new TheoryLessonsRowChangeEvent(((TheoryLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TheoryLessonsRowChanging != null)) {
                    this.TheoryLessonsRowChanging(this, new TheoryLessonsRowChangeEvent(((TheoryLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TheoryLessonsRowDeleted != null)) {
                    this.TheoryLessonsRowDeleted(this, new TheoryLessonsRowChangeEvent(((TheoryLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TheoryLessonsRowDeleting != null)) {
                    this.TheoryLessonsRowDeleting(this, new TheoryLessonsRowChangeEvent(((TheoryLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveTheoryLessonsRow(TheoryLessonsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TheoryLessonsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CarriersStatusesDataTable : global::System.Data.TypedTableBase<CarriersStatusesRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesDataTable() {
                this.TableName = "CarriersStatuses";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersStatusesDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected CarriersStatusesDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow this[int index] {
                get {
                    return ((CarriersStatusesRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersStatusesRowChangeEventHandler CarriersStatusesRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersStatusesRowChangeEventHandler CarriersStatusesRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersStatusesRowChangeEventHandler CarriersStatusesRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersStatusesRowChangeEventHandler CarriersStatusesRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCarriersStatusesRow(CarriersStatusesRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow AddCarriersStatusesRow(string Name) {
                CarriersStatusesRow rowCarriersStatusesRow = ((CarriersStatusesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name};
                rowCarriersStatusesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersStatusesRow);
                return rowCarriersStatusesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow FindByID(int ID) {
                return ((CarriersStatusesRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CarriersStatusesDataTable cln = ((CarriersStatusesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CarriersStatusesDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName = base.Columns["Name"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_CarriesStatuses", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow NewCarriersStatusesRow() {
                return ((CarriersStatusesRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CarriersStatusesRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CarriersStatusesRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CarriersStatusesRowChanged != null)) {
                    this.CarriersStatusesRowChanged(this, new CarriersStatusesRowChangeEvent(((CarriersStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CarriersStatusesRowChanging != null)) {
                    this.CarriersStatusesRowChanging(this, new CarriersStatusesRowChangeEvent(((CarriersStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CarriersStatusesRowDeleted != null)) {
                    this.CarriersStatusesRowDeleted(this, new CarriersStatusesRowChangeEvent(((CarriersStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CarriersStatusesRowDeleting != null)) {
                    this.CarriersStatusesRowDeleting(this, new CarriersStatusesRowChangeEvent(((CarriersStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveCarriersStatusesRow(CarriersStatusesRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CarriersStatusesDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TransmissionsDataTable : global::System.Data.TypedTableBase<TransmissionsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnTransmission;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsDataTable() {
                this.TableName = "Transmissions";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TransmissionsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected TransmissionsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TransmissionColumn {
                get {
                    return this.columnTransmission;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow this[int index] {
                get {
                    return ((TransmissionsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TransmissionsRowChangeEventHandler TransmissionsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TransmissionsRowChangeEventHandler TransmissionsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TransmissionsRowChangeEventHandler TransmissionsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TransmissionsRowChangeEventHandler TransmissionsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddTransmissionsRow(TransmissionsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow AddTransmissionsRow(string Transmission) {
                TransmissionsRow rowTransmissionsRow = ((TransmissionsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Transmission};
                rowTransmissionsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTransmissionsRow);
                return rowTransmissionsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow FindByID(int ID) {
                return ((TransmissionsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TransmissionsDataTable cln = ((TransmissionsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TransmissionsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnTransmission = base.Columns["Transmission"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnTransmission = new global::System.Data.DataColumn("Transmission", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTransmission);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Transmissions", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow NewTransmissionsRow() {
                return ((TransmissionsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TransmissionsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TransmissionsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TransmissionsRowChanged != null)) {
                    this.TransmissionsRowChanged(this, new TransmissionsRowChangeEvent(((TransmissionsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TransmissionsRowChanging != null)) {
                    this.TransmissionsRowChanging(this, new TransmissionsRowChangeEvent(((TransmissionsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TransmissionsRowDeleted != null)) {
                    this.TransmissionsRowDeleted(this, new TransmissionsRowChangeEvent(((TransmissionsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TransmissionsRowDeleting != null)) {
                    this.TransmissionsRowDeleting(this, new TransmissionsRowChangeEvent(((TransmissionsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveTransmissionsRow(TransmissionsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TransmissionsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PracticeLessonsDataTable : global::System.Data.TypedTableBase<PracticeLessonsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnStudent;
            
            private global::System.Data.DataColumn columnAppointedDate;
            
            private global::System.Data.DataColumn columnAppointedTime;
            
            private global::System.Data.DataColumn columnFactDate;
            
            private global::System.Data.DataColumn columnFactTime;
            
            private global::System.Data.DataColumn columnStudentFIO;
            
            private global::System.Data.DataColumn columnCarrierName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsDataTable(bool initExpressions) {
                this.TableName = "PracticeLessons";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PracticeLessonsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected PracticeLessonsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StudentColumn {
                get {
                    return this.columnStudent;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AppointedDateColumn {
                get {
                    return this.columnAppointedDate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AppointedTimeColumn {
                get {
                    return this.columnAppointedTime;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FactDateColumn {
                get {
                    return this.columnFactDate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FactTimeColumn {
                get {
                    return this.columnFactTime;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StudentFIOColumn {
                get {
                    return this.columnStudentFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierNameColumn {
                get {
                    return this.columnCarrierName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow this[int index] {
                get {
                    return ((PracticeLessonsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PracticeLessonsRowChangeEventHandler PracticeLessonsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PracticeLessonsRowChangeEventHandler PracticeLessonsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PracticeLessonsRowChangeEventHandler PracticeLessonsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PracticeLessonsRowChangeEventHandler PracticeLessonsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddPracticeLessonsRow(PracticeLessonsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow AddPracticeLessonsRow(StudentsRow parentStudentsRowByStudents_PracticeLessons, System.DateTime AppointedDate, System.TimeSpan AppointedTime, System.DateTime FactDate, System.TimeSpan FactTime, string StudentFIO, string CarrierName) {
                PracticeLessonsRow rowPracticeLessonsRow = ((PracticeLessonsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        AppointedDate,
                        AppointedTime,
                        FactDate,
                        FactTime,
                        StudentFIO,
                        CarrierName};
                if ((parentStudentsRowByStudents_PracticeLessons != null)) {
                    columnValuesArray[1] = parentStudentsRowByStudents_PracticeLessons[0];
                }
                rowPracticeLessonsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPracticeLessonsRow);
                return rowPracticeLessonsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow AddPracticeLessonsRow(StudentsRow parentStudentsRowByStudents_PracticeLessons, System.DateTime AppointedDate, System.TimeSpan AppointedTime, System.DateTime FactDate, System.TimeSpan FactTime) {
                PracticeLessonsRow rowPracticeLessonsRow = ((PracticeLessonsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        AppointedDate,
                        AppointedTime,
                        FactDate,
                        FactTime,
                        null,
                        null};
                if ((parentStudentsRowByStudents_PracticeLessons != null)) {
                    columnValuesArray[1] = parentStudentsRowByStudents_PracticeLessons[0];
                }
                rowPracticeLessonsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPracticeLessonsRow);
                return rowPracticeLessonsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow FindByID(int ID) {
                return ((PracticeLessonsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                PracticeLessonsDataTable cln = ((PracticeLessonsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new PracticeLessonsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnStudent = base.Columns["Student"];
                this.columnAppointedDate = base.Columns["AppointedDate"];
                this.columnAppointedTime = base.Columns["AppointedTime"];
                this.columnFactDate = base.Columns["FactDate"];
                this.columnFactTime = base.Columns["FactTime"];
                this.columnStudentFIO = base.Columns["StudentFIO"];
                this.columnCarrierName = base.Columns["CarrierName"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnStudent = new global::System.Data.DataColumn("Student", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStudent);
                this.columnAppointedDate = new global::System.Data.DataColumn("AppointedDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAppointedDate);
                this.columnAppointedTime = new global::System.Data.DataColumn("AppointedTime", typeof(global::System.TimeSpan), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAppointedTime);
                this.columnFactDate = new global::System.Data.DataColumn("FactDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFactDate);
                this.columnFactTime = new global::System.Data.DataColumn("FactTime", typeof(global::System.TimeSpan), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFactTime);
                this.columnStudentFIO = new global::System.Data.DataColumn("StudentFIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStudentFIO);
                this.columnCarrierName = new global::System.Data.DataColumn("CarrierName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_PracticeLessonsStudents", new global::System.Data.DataColumn[] {
                                this.columnStudent}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_PracticeLessons", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnStudent.Unique = true;
                this.columnAppointedDate.Caption = "AppointedDateTime";
                this.columnAppointedTime.Caption = "AppointedDateTime";
                this.columnFactDate.Caption = "FactDateTime";
                this.columnStudentFIO.ReadOnly = true;
                this.columnCarrierName.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow NewPracticeLessonsRow() {
                return ((PracticeLessonsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new PracticeLessonsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(PracticeLessonsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.StudentFIOColumn.Expression = "Parent(Students_PracticeLessons).FIO";
                this.CarrierNameColumn.Expression = "Parent(Students_PracticeLessons).CarrierName";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PracticeLessonsRowChanged != null)) {
                    this.PracticeLessonsRowChanged(this, new PracticeLessonsRowChangeEvent(((PracticeLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PracticeLessonsRowChanging != null)) {
                    this.PracticeLessonsRowChanging(this, new PracticeLessonsRowChangeEvent(((PracticeLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PracticeLessonsRowDeleted != null)) {
                    this.PracticeLessonsRowDeleted(this, new PracticeLessonsRowChangeEvent(((PracticeLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PracticeLessonsRowDeleting != null)) {
                    this.PracticeLessonsRowDeleting(this, new PracticeLessonsRowChangeEvent(((PracticeLessonsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovePracticeLessonsRow(PracticeLessonsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PracticeLessonsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CarriersUsesDataTable : global::System.Data.TypedTableBase<CarriersUsesRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnInstructor;
            
            private global::System.Data.DataColumn columnCarrier;
            
            private global::System.Data.DataColumn columnInstructorName;
            
            private global::System.Data.DataColumn columnCarrierName;
            
            private global::System.Data.DataColumn columnCategoryCarrierID;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesDataTable(bool initExpressions) {
                this.TableName = "CarriersUses";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersUsesDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected CarriersUsesDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn InstructorColumn {
                get {
                    return this.columnInstructor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierColumn {
                get {
                    return this.columnCarrier;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn InstructorNameColumn {
                get {
                    return this.columnInstructorName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierNameColumn {
                get {
                    return this.columnCarrierName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CategoryCarrierIDColumn {
                get {
                    return this.columnCategoryCarrierID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow this[int index] {
                get {
                    return ((CarriersUsesRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersUsesRowChangeEventHandler CarriersUsesRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersUsesRowChangeEventHandler CarriersUsesRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersUsesRowChangeEventHandler CarriersUsesRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersUsesRowChangeEventHandler CarriersUsesRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCarriersUsesRow(CarriersUsesRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow AddCarriersUsesRow(InstructorsRow parentInstructorsRowByInstructors_CarriersUses, CarriersRow parentCarriersRowByCarriers_CarriersUses, string InstructorName, string CarrierName, string CategoryCarrierID) {
                CarriersUsesRow rowCarriersUsesRow = ((CarriersUsesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        InstructorName,
                        CarrierName,
                        CategoryCarrierID};
                if ((parentInstructorsRowByInstructors_CarriersUses != null)) {
                    columnValuesArray[1] = parentInstructorsRowByInstructors_CarriersUses[0];
                }
                if ((parentCarriersRowByCarriers_CarriersUses != null)) {
                    columnValuesArray[2] = parentCarriersRowByCarriers_CarriersUses[0];
                }
                rowCarriersUsesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersUsesRow);
                return rowCarriersUsesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow AddCarriersUsesRow(InstructorsRow parentInstructorsRowByInstructors_CarriersUses, CarriersRow parentCarriersRowByCarriers_CarriersUses) {
                CarriersUsesRow rowCarriersUsesRow = ((CarriersUsesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        null,
                        null,
                        null};
                if ((parentInstructorsRowByInstructors_CarriersUses != null)) {
                    columnValuesArray[1] = parentInstructorsRowByInstructors_CarriersUses[0];
                }
                if ((parentCarriersRowByCarriers_CarriersUses != null)) {
                    columnValuesArray[2] = parentCarriersRowByCarriers_CarriersUses[0];
                }
                rowCarriersUsesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersUsesRow);
                return rowCarriersUsesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow FindByID(int ID) {
                return ((CarriersUsesRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CarriersUsesDataTable cln = ((CarriersUsesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CarriersUsesDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnInstructor = base.Columns["Instructor"];
                this.columnCarrier = base.Columns["Carrier"];
                this.columnInstructorName = base.Columns["InstructorName"];
                this.columnCarrierName = base.Columns["CarrierName"];
                this.columnCategoryCarrierID = base.Columns["CategoryCarrierID"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnInstructor = new global::System.Data.DataColumn("Instructor", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnInstructor);
                this.columnCarrier = new global::System.Data.DataColumn("Carrier", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrier);
                this.columnInstructorName = new global::System.Data.DataColumn("InstructorName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnInstructorName);
                this.columnCarrierName = new global::System.Data.DataColumn("CarrierName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierName);
                this.columnCategoryCarrierID = new global::System.Data.DataColumn("CategoryCarrierID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCategoryCarrierID);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersUsesCarriers", new global::System.Data.DataColumn[] {
                                this.columnCarrier}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersUsesInstructors", new global::System.Data.DataColumn[] {
                                this.columnInstructor}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_CarriersUses", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnInstructor.Unique = true;
                this.columnCarrier.Unique = true;
                this.columnInstructorName.ReadOnly = true;
                this.columnCarrierName.ReadOnly = true;
                this.columnCategoryCarrierID.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow NewCarriersUsesRow() {
                return ((CarriersUsesRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CarriersUsesRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CarriersUsesRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.InstructorNameColumn.Expression = "Parent(Instructors_CarriersUses).FIO";
                this.CarrierNameColumn.Expression = "Parent(Carriers_CarriersUses).FinalName";
                this.CategoryCarrierIDColumn.Expression = "Parent(Carriers_CarriersUses).Category";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CarriersUsesRowChanged != null)) {
                    this.CarriersUsesRowChanged(this, new CarriersUsesRowChangeEvent(((CarriersUsesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CarriersUsesRowChanging != null)) {
                    this.CarriersUsesRowChanging(this, new CarriersUsesRowChangeEvent(((CarriersUsesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CarriersUsesRowDeleted != null)) {
                    this.CarriersUsesRowDeleted(this, new CarriersUsesRowChangeEvent(((CarriersUsesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CarriersUsesRowDeleting != null)) {
                    this.CarriersUsesRowDeleting(this, new CarriersUsesRowChangeEvent(((CarriersUsesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveCarriersUsesRow(CarriersUsesRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CarriersUsesDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CarriersRepairsDataTable : global::System.Data.TypedTableBase<CarriersRepairsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnCarrier;
            
            private global::System.Data.DataColumn columnMaster;
            
            private global::System.Data.DataColumn columnWork;
            
            private global::System.Data.DataColumn columnBeginDate;
            
            private global::System.Data.DataColumn columnEndDate;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsDataTable() {
                this.TableName = "CarriersRepairs";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersRepairsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected CarriersRepairsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierColumn {
                get {
                    return this.columnCarrier;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn MasterColumn {
                get {
                    return this.columnMaster;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn WorkColumn {
                get {
                    return this.columnWork;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn BeginDateColumn {
                get {
                    return this.columnBeginDate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn EndDateColumn {
                get {
                    return this.columnEndDate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow this[int index] {
                get {
                    return ((CarriersRepairsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRepairsRowChangeEventHandler CarriersRepairsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRepairsRowChangeEventHandler CarriersRepairsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRepairsRowChangeEventHandler CarriersRepairsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event CarriersRepairsRowChangeEventHandler CarriersRepairsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddCarriersRepairsRow(CarriersRepairsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow AddCarriersRepairsRow(CarriersRow parentCarriersRowByCarriers_CarriesRepairs, ServiceMastersRow parentServiceMastersRowByServiceMasters_CarriesRepairs, string Work, System.DateTime BeginDate, System.DateTime EndDate) {
                CarriersRepairsRow rowCarriersRepairsRow = ((CarriersRepairsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        Work,
                        BeginDate,
                        EndDate};
                if ((parentCarriersRowByCarriers_CarriesRepairs != null)) {
                    columnValuesArray[1] = parentCarriersRowByCarriers_CarriesRepairs[0];
                }
                if ((parentServiceMastersRowByServiceMasters_CarriesRepairs != null)) {
                    columnValuesArray[2] = parentServiceMastersRowByServiceMasters_CarriesRepairs[0];
                }
                rowCarriersRepairsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCarriersRepairsRow);
                return rowCarriersRepairsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow FindByID(int ID) {
                return ((CarriersRepairsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CarriersRepairsDataTable cln = ((CarriersRepairsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CarriersRepairsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnCarrier = base.Columns["Carrier"];
                this.columnMaster = base.Columns["Master"];
                this.columnWork = base.Columns["Work"];
                this.columnBeginDate = base.Columns["BeginDate"];
                this.columnEndDate = base.Columns["EndDate"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnCarrier = new global::System.Data.DataColumn("Carrier", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrier);
                this.columnMaster = new global::System.Data.DataColumn("Master", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnMaster);
                this.columnWork = new global::System.Data.DataColumn("Work", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWork);
                this.columnBeginDate = new global::System.Data.DataColumn("BeginDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBeginDate);
                this.columnEndDate = new global::System.Data.DataColumn("EndDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEndDate);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersRepairsServiceMasters", new global::System.Data.DataColumn[] {
                                this.columnMaster}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_CarriersRepairsCarriers", new global::System.Data.DataColumn[] {
                                this.columnCarrier}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_CarriersRepairs", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnCarrier.Unique = true;
                this.columnMaster.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow NewCarriersRepairsRow() {
                return ((CarriersRepairsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CarriersRepairsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CarriersRepairsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CarriersRepairsRowChanged != null)) {
                    this.CarriersRepairsRowChanged(this, new CarriersRepairsRowChangeEvent(((CarriersRepairsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CarriersRepairsRowChanging != null)) {
                    this.CarriersRepairsRowChanging(this, new CarriersRepairsRowChangeEvent(((CarriersRepairsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CarriersRepairsRowDeleted != null)) {
                    this.CarriersRepairsRowDeleted(this, new CarriersRepairsRowChangeEvent(((CarriersRepairsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CarriersRepairsRowDeleting != null)) {
                    this.CarriersRepairsRowDeleting(this, new CarriersRepairsRowChangeEvent(((CarriersRepairsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveCarriersRepairsRow(CarriersRepairsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CarriersRepairsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class ReplacementsCarriersDataTable : global::System.Data.TypedTableBase<ReplacementsCarriersRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnCarrierUse;
            
            private global::System.Data.DataColumn columnCarrierReplacement;
            
            private global::System.Data.DataColumn columnDateBeginReplacement;
            
            private global::System.Data.DataColumn columnDateEndReplacement;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersDataTable() {
                this.TableName = "ReplacementsCarriers";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReplacementsCarriersDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ReplacementsCarriersDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierUseColumn {
                get {
                    return this.columnCarrierUse;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierReplacementColumn {
                get {
                    return this.columnCarrierReplacement;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn DateBeginReplacementColumn {
                get {
                    return this.columnDateBeginReplacement;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn DateEndReplacementColumn {
                get {
                    return this.columnDateEndReplacement;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow this[int index] {
                get {
                    return ((ReplacementsCarriersRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ReplacementsCarriersRowChangeEventHandler ReplacementsCarriersRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ReplacementsCarriersRowChangeEventHandler ReplacementsCarriersRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ReplacementsCarriersRowChangeEventHandler ReplacementsCarriersRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ReplacementsCarriersRowChangeEventHandler ReplacementsCarriersRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddReplacementsCarriersRow(ReplacementsCarriersRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow AddReplacementsCarriersRow(CarriersUsesRow parentCarriersUsesRowByCarriersUses_ReplacementCarrier, CarriersRow parentCarriersRowByCarriers_ReplacementCarrier, System.DateTime DateBeginReplacement, System.DateTime DateEndReplacement) {
                ReplacementsCarriersRow rowReplacementsCarriersRow = ((ReplacementsCarriersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        DateBeginReplacement,
                        DateEndReplacement};
                if ((parentCarriersUsesRowByCarriersUses_ReplacementCarrier != null)) {
                    columnValuesArray[1] = parentCarriersUsesRowByCarriersUses_ReplacementCarrier[0];
                }
                if ((parentCarriersRowByCarriers_ReplacementCarrier != null)) {
                    columnValuesArray[2] = parentCarriersRowByCarriers_ReplacementCarrier[0];
                }
                rowReplacementsCarriersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowReplacementsCarriersRow);
                return rowReplacementsCarriersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow FindByID(int ID) {
                return ((ReplacementsCarriersRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                ReplacementsCarriersDataTable cln = ((ReplacementsCarriersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new ReplacementsCarriersDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnCarrierUse = base.Columns["CarrierUse"];
                this.columnCarrierReplacement = base.Columns["CarrierReplacement"];
                this.columnDateBeginReplacement = base.Columns["DateBeginReplacement"];
                this.columnDateEndReplacement = base.Columns["DateEndReplacement"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnCarrierUse = new global::System.Data.DataColumn("CarrierUse", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierUse);
                this.columnCarrierReplacement = new global::System.Data.DataColumn("CarrierReplacement", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierReplacement);
                this.columnDateBeginReplacement = new global::System.Data.DataColumn("DateBeginReplacement", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDateBeginReplacement);
                this.columnDateEndReplacement = new global::System.Data.DataColumn("DateEndReplacement", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDateEndReplacement);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_ReplacementsCarriersCarriersUses", new global::System.Data.DataColumn[] {
                                this.columnCarrierUse}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_ReplacementsCarriersCarriers", new global::System.Data.DataColumn[] {
                                this.columnCarrierReplacement}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_ReplacementsCarriers", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnCarrierUse.Unique = true;
                this.columnCarrierReplacement.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow NewReplacementsCarriersRow() {
                return ((ReplacementsCarriersRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new ReplacementsCarriersRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(ReplacementsCarriersRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ReplacementsCarriersRowChanged != null)) {
                    this.ReplacementsCarriersRowChanged(this, new ReplacementsCarriersRowChangeEvent(((ReplacementsCarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ReplacementsCarriersRowChanging != null)) {
                    this.ReplacementsCarriersRowChanging(this, new ReplacementsCarriersRowChangeEvent(((ReplacementsCarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ReplacementsCarriersRowDeleted != null)) {
                    this.ReplacementsCarriersRowDeleted(this, new ReplacementsCarriersRowChangeEvent(((ReplacementsCarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ReplacementsCarriersRowDeleting != null)) {
                    this.ReplacementsCarriersRowDeleting(this, new ReplacementsCarriersRowChangeEvent(((ReplacementsCarriersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveReplacementsCarriersRow(ReplacementsCarriersRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "ReplacementsCarriersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class WorkStatusesDataTable : global::System.Data.TypedTableBase<WorkStatusesRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesDataTable() {
                this.TableName = "WorkStatuses";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal WorkStatusesDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected WorkStatusesDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow this[int index] {
                get {
                    return ((WorkStatusesRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event WorkStatusesRowChangeEventHandler WorkStatusesRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event WorkStatusesRowChangeEventHandler WorkStatusesRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event WorkStatusesRowChangeEventHandler WorkStatusesRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event WorkStatusesRowChangeEventHandler WorkStatusesRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddWorkStatusesRow(WorkStatusesRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow AddWorkStatusesRow(string Name) {
                WorkStatusesRow rowWorkStatusesRow = ((WorkStatusesRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name};
                rowWorkStatusesRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowWorkStatusesRow);
                return rowWorkStatusesRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow FindByID(int ID) {
                return ((WorkStatusesRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                WorkStatusesDataTable cln = ((WorkStatusesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new WorkStatusesDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName = base.Columns["Name"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_WorkStatuses", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow NewWorkStatusesRow() {
                return ((WorkStatusesRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new WorkStatusesRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(WorkStatusesRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.WorkStatusesRowChanged != null)) {
                    this.WorkStatusesRowChanged(this, new WorkStatusesRowChangeEvent(((WorkStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.WorkStatusesRowChanging != null)) {
                    this.WorkStatusesRowChanging(this, new WorkStatusesRowChangeEvent(((WorkStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.WorkStatusesRowDeleted != null)) {
                    this.WorkStatusesRowDeleted(this, new WorkStatusesRowChangeEvent(((WorkStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.WorkStatusesRowDeleting != null)) {
                    this.WorkStatusesRowDeleting(this, new WorkStatusesRowChangeEvent(((WorkStatusesRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveWorkStatusesRow(WorkStatusesRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "WorkStatusesDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class StudentsDataTable : global::System.Data.TypedTableBase<StudentsRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnSurname;
            
            private global::System.Data.DataColumn columnFirstName;
            
            private global::System.Data.DataColumn columnPatronymicName;
            
            private global::System.Data.DataColumn columnPhoneNumber;
            
            private global::System.Data.DataColumn columnRetraining;
            
            private global::System.Data.DataColumn columnGroup;
            
            private global::System.Data.DataColumn columnCarrierUse;
            
            private global::System.Data.DataColumn columnPhoto;
            
            private global::System.Data.DataColumn columnInstructorName;
            
            private global::System.Data.DataColumn columnCarrierName;
            
            private global::System.Data.DataColumn columnFIO;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsDataTable() : 
                    this(false) {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsDataTable(bool initExpressions) {
                this.TableName = "Students";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true)) {
                    this.InitExpressions();
                }
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal StudentsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected StudentsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn SurnameColumn {
                get {
                    return this.columnSurname;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PatronymicNameColumn {
                get {
                    return this.columnPatronymicName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PhoneNumberColumn {
                get {
                    return this.columnPhoneNumber;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn RetrainingColumn {
                get {
                    return this.columnRetraining;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn GroupColumn {
                get {
                    return this.columnGroup;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierUseColumn {
                get {
                    return this.columnCarrierUse;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PhotoColumn {
                get {
                    return this.columnPhoto;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn InstructorNameColumn {
                get {
                    return this.columnInstructorName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CarrierNameColumn {
                get {
                    return this.columnCarrierName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn FIOColumn {
                get {
                    return this.columnFIO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow this[int index] {
                get {
                    return ((StudentsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event StudentsRowChangeEventHandler StudentsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event StudentsRowChangeEventHandler StudentsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event StudentsRowChangeEventHandler StudentsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event StudentsRowChangeEventHandler StudentsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddStudentsRow(StudentsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow AddStudentsRow(string Surname, string FirstName, string PatronymicName, string PhoneNumber, bool Retraining, GroupsRow parentGroupsRowByGroups_Students, CarriersUsesRow parentCarriersUsesRowByCarriersUses_Students, byte[] Photo, string InstructorName, string CarrierName, string FIO) {
                StudentsRow rowStudentsRow = ((StudentsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        PhoneNumber,
                        Retraining,
                        null,
                        null,
                        Photo,
                        InstructorName,
                        CarrierName,
                        FIO};
                if ((parentGroupsRowByGroups_Students != null)) {
                    columnValuesArray[6] = parentGroupsRowByGroups_Students[0];
                }
                if ((parentCarriersUsesRowByCarriersUses_Students != null)) {
                    columnValuesArray[7] = parentCarriersUsesRowByCarriersUses_Students[0];
                }
                rowStudentsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowStudentsRow);
                return rowStudentsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow AddStudentsRow(string Surname, string FirstName, string PatronymicName, string PhoneNumber, bool Retraining, GroupsRow parentGroupsRowByGroups_Students, CarriersUsesRow parentCarriersUsesRowByCarriersUses_Students, byte[] Photo) {
                StudentsRow rowStudentsRow = ((StudentsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Surname,
                        FirstName,
                        PatronymicName,
                        PhoneNumber,
                        Retraining,
                        null,
                        null,
                        Photo,
                        null,
                        null,
                        null};
                if ((parentGroupsRowByGroups_Students != null)) {
                    columnValuesArray[6] = parentGroupsRowByGroups_Students[0];
                }
                if ((parentCarriersUsesRowByCarriersUses_Students != null)) {
                    columnValuesArray[7] = parentCarriersUsesRowByCarriersUses_Students[0];
                }
                rowStudentsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowStudentsRow);
                return rowStudentsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow FindByID(int ID) {
                return ((StudentsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                StudentsDataTable cln = ((StudentsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new StudentsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnSurname = base.Columns["Surname"];
                this.columnFirstName = base.Columns["FirstName"];
                this.columnPatronymicName = base.Columns["PatronymicName"];
                this.columnPhoneNumber = base.Columns["PhoneNumber"];
                this.columnRetraining = base.Columns["Retraining"];
                this.columnGroup = base.Columns["Group"];
                this.columnCarrierUse = base.Columns["CarrierUse"];
                this.columnPhoto = base.Columns["Photo"];
                this.columnInstructorName = base.Columns["InstructorName"];
                this.columnCarrierName = base.Columns["CarrierName"];
                this.columnFIO = base.Columns["FIO"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnSurname = new global::System.Data.DataColumn("Surname", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSurname);
                this.columnFirstName = new global::System.Data.DataColumn("FirstName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFirstName);
                this.columnPatronymicName = new global::System.Data.DataColumn("PatronymicName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPatronymicName);
                this.columnPhoneNumber = new global::System.Data.DataColumn("PhoneNumber", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPhoneNumber);
                this.columnRetraining = new global::System.Data.DataColumn("Retraining", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRetraining);
                this.columnGroup = new global::System.Data.DataColumn("Group", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnGroup);
                this.columnCarrierUse = new global::System.Data.DataColumn("CarrierUse", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierUse);
                this.columnPhoto = new global::System.Data.DataColumn("Photo", typeof(byte[]), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPhoto);
                this.columnInstructorName = new global::System.Data.DataColumn("InstructorName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnInstructorName);
                this.columnCarrierName = new global::System.Data.DataColumn("CarrierName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCarrierName);
                this.columnFIO = new global::System.Data.DataColumn("FIO", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_StudentsGroups", new global::System.Data.DataColumn[] {
                                this.columnGroup}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("FK_StudentsCarriersUses", new global::System.Data.DataColumn[] {
                                this.columnCarrierUse}, false));
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_Students", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnGroup.Unique = true;
                this.columnCarrierUse.Unique = true;
                this.columnInstructorName.ReadOnly = true;
                this.columnCarrierName.ReadOnly = true;
                this.columnFIO.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow NewStudentsRow() {
                return ((StudentsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new StudentsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(StudentsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions() {
                this.InstructorNameColumn.Expression = "Parent(CarriersUses_Students).InstructorName";
                this.CarrierNameColumn.Expression = "Parent(CarriersUses_Students).CarrierName";
                this.FIOColumn.Expression = "Surname + \' \' + FirstName + \' \' + PatronymicName";
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.StudentsRowChanged != null)) {
                    this.StudentsRowChanged(this, new StudentsRowChangeEvent(((StudentsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.StudentsRowChanging != null)) {
                    this.StudentsRowChanging(this, new StudentsRowChangeEvent(((StudentsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.StudentsRowDeleted != null)) {
                    this.StudentsRowDeleted(this, new StudentsRowChangeEvent(((StudentsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.StudentsRowDeleting != null)) {
                    this.StudentsRowDeleting(this, new StudentsRowChangeEvent(((StudentsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveStudentsRow(StudentsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AutoschoolDataSet ds = new AutoschoolDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "StudentsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CategoriesRow : global::System.Data.DataRow {
            
            private CategoriesDataTable tableCategories;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CategoriesRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCategories = ((CategoriesDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableCategories.IDColumn]));
                }
                set {
                    this[this.tableCategories.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableCategories.NameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Name\' в таблице \'Categories\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCategories.NameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull() {
                return this.IsNull(this.tableCategories.NameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNameNull() {
                this[this.tableCategories.NameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow[] GetCarriersRows() {
                if ((this.Table.ChildRelations["Categories_Carriers"] == null)) {
                    return new CarriersRow[0];
                }
                else {
                    return ((CarriersRow[])(base.GetChildRows(this.Table.ChildRelations["Categories_Carriers"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow[] GetInstructorsCategoriesRows() {
                if ((this.Table.ChildRelations["Categories_InstructorsCategories"] == null)) {
                    return new InstructorsCategoriesRow[0];
                }
                else {
                    return ((InstructorsCategoriesRow[])(base.GetChildRows(this.Table.ChildRelations["Categories_InstructorsCategories"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow[] GetGroupsRows() {
                if ((this.Table.ChildRelations["Categories_Groups"] == null)) {
                    return new GroupsRow[0];
                }
                else {
                    return ((GroupsRow[])(base.GetChildRows(this.Table.ChildRelations["Categories_Groups"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CarriersRow : global::System.Data.DataRow {
            
            private CarriersDataTable tableCarriers;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCarriers = ((CarriersDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableCarriers.IDColumn]));
                }
                set {
                    this[this.tableCarriers.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Brand {
                get {
                    try {
                        return ((string)(this[this.tableCarriers.BrandColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Brand\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.BrandColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Model {
                get {
                    try {
                        return ((string)(this[this.tableCarriers.ModelColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Model\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.ModelColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string StateNumber {
                get {
                    try {
                        return ((string)(this[this.tableCarriers.StateNumberColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'StateNumber\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.StateNumberColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Color {
                get {
                    try {
                        return ((string)(this[this.tableCarriers.ColorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Color\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.ColorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Transmission {
                get {
                    try {
                        return ((int)(this[this.tableCarriers.TransmissionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Transmission\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.TransmissionColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Category {
                get {
                    try {
                        return ((int)(this[this.tableCarriers.CategoryColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Category\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.CategoryColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Status {
                get {
                    try {
                        return ((int)(this[this.tableCarriers.StatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Status\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.StatusColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FinalName {
                get {
                    try {
                        return ((string)(this[this.tableCarriers.FinalNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FinalName\' в таблице \'Carriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriers.FinalNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow CarriersStatusesRow {
                get {
                    return ((CarriersStatusesRow)(this.GetParentRow(this.Table.ParentRelations["CarriesStatuses_Carriers"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["CarriesStatuses_Carriers"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow CategoriesRow {
                get {
                    return ((CategoriesRow)(this.GetParentRow(this.Table.ParentRelations["Categories_Carriers"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Categories_Carriers"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow TransmissionsRow {
                get {
                    return ((TransmissionsRow)(this.GetParentRow(this.Table.ParentRelations["Transmissions_Carriers"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Transmissions_Carriers"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsBrandNull() {
                return this.IsNull(this.tableCarriers.BrandColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetBrandNull() {
                this[this.tableCarriers.BrandColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModelNull() {
                return this.IsNull(this.tableCarriers.ModelColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModelNull() {
                this[this.tableCarriers.ModelColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStateNumberNull() {
                return this.IsNull(this.tableCarriers.StateNumberColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStateNumberNull() {
                this[this.tableCarriers.StateNumberColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsColorNull() {
                return this.IsNull(this.tableCarriers.ColorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetColorNull() {
                this[this.tableCarriers.ColorColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTransmissionNull() {
                return this.IsNull(this.tableCarriers.TransmissionColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTransmissionNull() {
                this[this.tableCarriers.TransmissionColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCategoryNull() {
                return this.IsNull(this.tableCarriers.CategoryColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCategoryNull() {
                this[this.tableCarriers.CategoryColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStatusNull() {
                return this.IsNull(this.tableCarriers.StatusColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStatusNull() {
                this[this.tableCarriers.StatusColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFinalNameNull() {
                return this.IsNull(this.tableCarriers.FinalNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFinalNameNull() {
                this[this.tableCarriers.FinalNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow[] GetCarriersUsesRows() {
                if ((this.Table.ChildRelations["Carriers_CarriersUses"] == null)) {
                    return new CarriersUsesRow[0];
                }
                else {
                    return ((CarriersUsesRow[])(base.GetChildRows(this.Table.ChildRelations["Carriers_CarriersUses"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow[] GetCarriersRepairsRows() {
                if ((this.Table.ChildRelations["Carriers_CarriesRepairs"] == null)) {
                    return new CarriersRepairsRow[0];
                }
                else {
                    return ((CarriersRepairsRow[])(base.GetChildRows(this.Table.ChildRelations["Carriers_CarriesRepairs"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow[] GetReplacementsCarriersRows() {
                if ((this.Table.ChildRelations["Carriers_ReplacementCarrier"] == null)) {
                    return new ReplacementsCarriersRow[0];
                }
                else {
                    return ((ReplacementsCarriersRow[])(base.GetChildRows(this.Table.ChildRelations["Carriers_ReplacementCarrier"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class InstructorsRow : global::System.Data.DataRow {
            
            private InstructorsDataTable tableInstructors;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal InstructorsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableInstructors = ((InstructorsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableInstructors.IDColumn]));
                }
                set {
                    this[this.tableInstructors.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Surname {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.SurnameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Surname\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.SurnameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.FirstNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FirstName\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.FirstNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PatronymicName {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.PatronymicNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'PatronymicName\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.PatronymicNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Photo {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.PhotoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Photo\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.PhotoColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int WorkStatus {
                get {
                    try {
                        return ((int)(this[this.tableInstructors.WorkStatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatus\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.WorkStatusColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.FIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FIO\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.FIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WorkStatusName {
                get {
                    try {
                        return ((string)(this[this.tableInstructors.WorkStatusNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatusName\' в таблице \'Instructors\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructors.WorkStatusNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow WorkStatusesRow {
                get {
                    return ((WorkStatusesRow)(this.GetParentRow(this.Table.ParentRelations["WorkStatuses_Instructors"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["WorkStatuses_Instructors"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSurnameNull() {
                return this.IsNull(this.tableInstructors.SurnameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSurnameNull() {
                this[this.tableInstructors.SurnameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableInstructors.FirstNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull() {
                this[this.tableInstructors.FirstNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPatronymicNameNull() {
                return this.IsNull(this.tableInstructors.PatronymicNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPatronymicNameNull() {
                this[this.tableInstructors.PatronymicNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhotoNull() {
                return this.IsNull(this.tableInstructors.PhotoColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhotoNull() {
                this[this.tableInstructors.PhotoColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNull() {
                return this.IsNull(this.tableInstructors.WorkStatusColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNull() {
                this[this.tableInstructors.WorkStatusColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFIONull() {
                return this.IsNull(this.tableInstructors.FIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFIONull() {
                this[this.tableInstructors.FIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNameNull() {
                return this.IsNull(this.tableInstructors.WorkStatusNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNameNull() {
                this[this.tableInstructors.WorkStatusNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow[] GetInstructorsCategoriesRows() {
                if ((this.Table.ChildRelations["Instructors_InstructorsCategories"] == null)) {
                    return new InstructorsCategoriesRow[0];
                }
                else {
                    return ((InstructorsCategoriesRow[])(base.GetChildRows(this.Table.ChildRelations["Instructors_InstructorsCategories"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow[] GetCarriersUsesRows() {
                if ((this.Table.ChildRelations["Instructors_CarriersUses"] == null)) {
                    return new CarriersUsesRow[0];
                }
                else {
                    return ((CarriersUsesRow[])(base.GetChildRows(this.Table.ChildRelations["Instructors_CarriersUses"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class ServiceMastersRow : global::System.Data.DataRow {
            
            private ServiceMastersDataTable tableServiceMasters;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ServiceMastersRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableServiceMasters = ((ServiceMastersDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableServiceMasters.IDColumn]));
                }
                set {
                    this[this.tableServiceMasters.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Surname {
                get {
                    try {
                        return ((string)(this[this.tableServiceMasters.SurnameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Surname\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.SurnameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableServiceMasters.FirstNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FirstName\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.FirstNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PatronymicName {
                get {
                    try {
                        return ((string)(this[this.tableServiceMasters.PatronymicNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'PatronymicName\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.PatronymicNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int WorkStatus {
                get {
                    try {
                        return ((int)(this[this.tableServiceMasters.WorkStatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatus\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.WorkStatusColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO {
                get {
                    try {
                        return ((string)(this[this.tableServiceMasters.FIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FIO\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.FIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WorkStatusName {
                get {
                    try {
                        return ((string)(this[this.tableServiceMasters.WorkStatusNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatusName\' в таблице \'ServiceMasters\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableServiceMasters.WorkStatusNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow WorkStatusesRow {
                get {
                    return ((WorkStatusesRow)(this.GetParentRow(this.Table.ParentRelations["WorkStatuses_ServiceMasters"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["WorkStatuses_ServiceMasters"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSurnameNull() {
                return this.IsNull(this.tableServiceMasters.SurnameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSurnameNull() {
                this[this.tableServiceMasters.SurnameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableServiceMasters.FirstNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull() {
                this[this.tableServiceMasters.FirstNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPatronymicNameNull() {
                return this.IsNull(this.tableServiceMasters.PatronymicNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPatronymicNameNull() {
                this[this.tableServiceMasters.PatronymicNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNull() {
                return this.IsNull(this.tableServiceMasters.WorkStatusColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNull() {
                this[this.tableServiceMasters.WorkStatusColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFIONull() {
                return this.IsNull(this.tableServiceMasters.FIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFIONull() {
                this[this.tableServiceMasters.FIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNameNull() {
                return this.IsNull(this.tableServiceMasters.WorkStatusNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNameNull() {
                this[this.tableServiceMasters.WorkStatusNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow[] GetCarriersRepairsRows() {
                if ((this.Table.ChildRelations["ServiceMasters_CarriesRepairs"] == null)) {
                    return new CarriersRepairsRow[0];
                }
                else {
                    return ((CarriersRepairsRow[])(base.GetChildRows(this.Table.ChildRelations["ServiceMasters_CarriesRepairs"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class TheoryTeachersRow : global::System.Data.DataRow {
            
            private TheoryTeachersDataTable tableTheoryTeachers;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TheoryTeachersRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTheoryTeachers = ((TheoryTeachersDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableTheoryTeachers.IDColumn]));
                }
                set {
                    this[this.tableTheoryTeachers.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Surname {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.SurnameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Surname\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.SurnameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.FirstNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FirstName\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.FirstNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PatronymicName {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.PatronymicNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'PatronymicName\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.PatronymicNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Photo {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.PhotoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Photo\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.PhotoColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int WorkStatus {
                get {
                    try {
                        return ((int)(this[this.tableTheoryTeachers.WorkStatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatus\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.WorkStatusColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.FIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FIO\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.FIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string WorkStatusName {
                get {
                    try {
                        return ((string)(this[this.tableTheoryTeachers.WorkStatusNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'WorkStatusName\' в таблице \'TheoryTeachers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryTeachers.WorkStatusNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow WorkStatusesRow {
                get {
                    return ((WorkStatusesRow)(this.GetParentRow(this.Table.ParentRelations["WorkStatuses_TheoryTeachers"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["WorkStatuses_TheoryTeachers"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSurnameNull() {
                return this.IsNull(this.tableTheoryTeachers.SurnameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSurnameNull() {
                this[this.tableTheoryTeachers.SurnameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableTheoryTeachers.FirstNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull() {
                this[this.tableTheoryTeachers.FirstNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPatronymicNameNull() {
                return this.IsNull(this.tableTheoryTeachers.PatronymicNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPatronymicNameNull() {
                this[this.tableTheoryTeachers.PatronymicNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhotoNull() {
                return this.IsNull(this.tableTheoryTeachers.PhotoColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhotoNull() {
                this[this.tableTheoryTeachers.PhotoColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNull() {
                return this.IsNull(this.tableTheoryTeachers.WorkStatusColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNull() {
                this[this.tableTheoryTeachers.WorkStatusColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFIONull() {
                return this.IsNull(this.tableTheoryTeachers.FIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFIONull() {
                this[this.tableTheoryTeachers.FIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkStatusNameNull() {
                return this.IsNull(this.tableTheoryTeachers.WorkStatusNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkStatusNameNull() {
                this[this.tableTheoryTeachers.WorkStatusNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow[] GetGroupsRows() {
                if ((this.Table.ChildRelations["TheoryTeachers_Groups"] == null)) {
                    return new GroupsRow[0];
                }
                else {
                    return ((GroupsRow[])(base.GetChildRows(this.Table.ChildRelations["TheoryTeachers_Groups"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class AuditoriumsRow : global::System.Data.DataRow {
            
            private AuditoriumsDataTable tableAuditoriums;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal AuditoriumsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableAuditoriums = ((AuditoriumsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableAuditoriums.IDColumn]));
                }
                set {
                    this[this.tableAuditoriums.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableAuditoriums.NameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Name\' в таблице \'Auditoriums\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableAuditoriums.NameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull() {
                return this.IsNull(this.tableAuditoriums.NameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNameNull() {
                this[this.tableAuditoriums.NameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow[] GetTheoryLessonsRows() {
                if ((this.Table.ChildRelations["Auditoriums_TheoryLessons"] == null)) {
                    return new TheoryLessonsRow[0];
                }
                else {
                    return ((TheoryLessonsRow[])(base.GetChildRows(this.Table.ChildRelations["Auditoriums_TheoryLessons"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class GroupsRow : global::System.Data.DataRow {
            
            private GroupsDataTable tableGroups;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal GroupsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableGroups = ((GroupsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableGroups.IDColumn]));
                }
                set {
                    this[this.tableGroups.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableGroups.NameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Name\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.NameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime StartLearning {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableGroups.StartLearningColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'StartLearning\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.StartLearningColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime EndLearning {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableGroups.EndLearningColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'EndLearning\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.EndLearningColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Category {
                get {
                    try {
                        return ((int)(this[this.tableGroups.CategoryColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Category\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.CategoryColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Teacher {
                get {
                    try {
                        return ((int)(this[this.tableGroups.TeacherColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Teacher\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.TeacherColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string TeacherFIO {
                get {
                    try {
                        return ((string)(this[this.tableGroups.TeacherFIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'TeacherFIO\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.TeacherFIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CategoryName {
                get {
                    try {
                        return ((string)(this[this.tableGroups.CategoryNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CategoryName\' в таблице \'Groups\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableGroups.CategoryNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow TheoryTeachersRow {
                get {
                    return ((TheoryTeachersRow)(this.GetParentRow(this.Table.ParentRelations["TheoryTeachers_Groups"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["TheoryTeachers_Groups"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow CategoriesRow {
                get {
                    return ((CategoriesRow)(this.GetParentRow(this.Table.ParentRelations["Categories_Groups"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Categories_Groups"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull() {
                return this.IsNull(this.tableGroups.NameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNameNull() {
                this[this.tableGroups.NameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStartLearningNull() {
                return this.IsNull(this.tableGroups.StartLearningColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStartLearningNull() {
                this[this.tableGroups.StartLearningColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEndLearningNull() {
                return this.IsNull(this.tableGroups.EndLearningColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEndLearningNull() {
                this[this.tableGroups.EndLearningColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCategoryNull() {
                return this.IsNull(this.tableGroups.CategoryColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCategoryNull() {
                this[this.tableGroups.CategoryColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTeacherNull() {
                return this.IsNull(this.tableGroups.TeacherColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTeacherNull() {
                this[this.tableGroups.TeacherColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTeacherFIONull() {
                return this.IsNull(this.tableGroups.TeacherFIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTeacherFIONull() {
                this[this.tableGroups.TeacherFIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCategoryNameNull() {
                return this.IsNull(this.tableGroups.CategoryNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCategoryNameNull() {
                this[this.tableGroups.CategoryNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow[] GetTheoryLessonsRows() {
                if ((this.Table.ChildRelations["Groups_TheoryLessons"] == null)) {
                    return new TheoryLessonsRow[0];
                }
                else {
                    return ((TheoryLessonsRow[])(base.GetChildRows(this.Table.ChildRelations["Groups_TheoryLessons"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow[] GetStudentsRows() {
                if ((this.Table.ChildRelations["Groups_Students"] == null)) {
                    return new StudentsRow[0];
                }
                else {
                    return ((StudentsRow[])(base.GetChildRows(this.Table.ChildRelations["Groups_Students"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class InstructorsCategoriesRow : global::System.Data.DataRow {
            
            private InstructorsCategoriesDataTable tableInstructorsCategories;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal InstructorsCategoriesRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableInstructorsCategories = ((InstructorsCategoriesDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableInstructorsCategories.IDColumn]));
                }
                set {
                    this[this.tableInstructorsCategories.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Instructor {
                get {
                    try {
                        return ((int)(this[this.tableInstructorsCategories.InstructorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Instructor\' в таблице \'InstructorsCategories\' равно DBNull." +
                                "", e);
                    }
                }
                set {
                    this[this.tableInstructorsCategories.InstructorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Category {
                get {
                    try {
                        return ((int)(this[this.tableInstructorsCategories.CategoryColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Category\' в таблице \'InstructorsCategories\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableInstructorsCategories.CategoryColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string InstructorFIO {
                get {
                    try {
                        return ((string)(this[this.tableInstructorsCategories.InstructorFIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'InstructorFIO\' в таблице \'InstructorsCategories\' равно DBNu" +
                                "ll.", e);
                    }
                }
                set {
                    this[this.tableInstructorsCategories.InstructorFIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow CategoriesRow {
                get {
                    return ((CategoriesRow)(this.GetParentRow(this.Table.ParentRelations["Categories_InstructorsCategories"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Categories_InstructorsCategories"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow InstructorsRow {
                get {
                    return ((InstructorsRow)(this.GetParentRow(this.Table.ParentRelations["Instructors_InstructorsCategories"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Instructors_InstructorsCategories"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsInstructorNull() {
                return this.IsNull(this.tableInstructorsCategories.InstructorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetInstructorNull() {
                this[this.tableInstructorsCategories.InstructorColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCategoryNull() {
                return this.IsNull(this.tableInstructorsCategories.CategoryColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCategoryNull() {
                this[this.tableInstructorsCategories.CategoryColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsInstructorFIONull() {
                return this.IsNull(this.tableInstructorsCategories.InstructorFIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetInstructorFIONull() {
                this[this.tableInstructorsCategories.InstructorFIOColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class TheoryLessonsRow : global::System.Data.DataRow {
            
            private TheoryLessonsDataTable tableTheoryLessons;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TheoryLessonsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTheoryLessons = ((TheoryLessonsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableTheoryLessons.IDColumn]));
                }
                set {
                    this[this.tableTheoryLessons.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime Date {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableTheoryLessons.DateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Date\' в таблице \'TheoryLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryLessons.DateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.TimeSpan Time {
                get {
                    try {
                        return ((global::System.TimeSpan)(this[this.tableTheoryLessons.TimeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Time\' в таблице \'TheoryLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryLessons.TimeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Auditorium {
                get {
                    try {
                        return ((int)(this[this.tableTheoryLessons.AuditoriumColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Auditorium\' в таблице \'TheoryLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryLessons.AuditoriumColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Group {
                get {
                    try {
                        return ((int)(this[this.tableTheoryLessons.GroupColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Group\' в таблице \'TheoryLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTheoryLessons.GroupColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow AuditoriumsRow {
                get {
                    return ((AuditoriumsRow)(this.GetParentRow(this.Table.ParentRelations["Auditoriums_TheoryLessons"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Auditoriums_TheoryLessons"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow GroupsRow {
                get {
                    return ((GroupsRow)(this.GetParentRow(this.Table.ParentRelations["Groups_TheoryLessons"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Groups_TheoryLessons"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateNull() {
                return this.IsNull(this.tableTheoryLessons.DateColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateNull() {
                this[this.tableTheoryLessons.DateColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTimeNull() {
                return this.IsNull(this.tableTheoryLessons.TimeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTimeNull() {
                this[this.tableTheoryLessons.TimeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAuditoriumNull() {
                return this.IsNull(this.tableTheoryLessons.AuditoriumColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAuditoriumNull() {
                this[this.tableTheoryLessons.AuditoriumColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsGroupNull() {
                return this.IsNull(this.tableTheoryLessons.GroupColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetGroupNull() {
                this[this.tableTheoryLessons.GroupColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CarriersStatusesRow : global::System.Data.DataRow {
            
            private CarriersStatusesDataTable tableCarriersStatuses;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersStatusesRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCarriersStatuses = ((CarriersStatusesDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableCarriersStatuses.IDColumn]));
                }
                set {
                    this[this.tableCarriersStatuses.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableCarriersStatuses.NameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Name\' в таблице \'CarriersStatuses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersStatuses.NameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull() {
                return this.IsNull(this.tableCarriersStatuses.NameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNameNull() {
                this[this.tableCarriersStatuses.NameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow[] GetCarriersRows() {
                if ((this.Table.ChildRelations["CarriesStatuses_Carriers"] == null)) {
                    return new CarriersRow[0];
                }
                else {
                    return ((CarriersRow[])(base.GetChildRows(this.Table.ChildRelations["CarriesStatuses_Carriers"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class TransmissionsRow : global::System.Data.DataRow {
            
            private TransmissionsDataTable tableTransmissions;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TransmissionsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTransmissions = ((TransmissionsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableTransmissions.IDColumn]));
                }
                set {
                    this[this.tableTransmissions.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Transmission {
                get {
                    try {
                        return ((string)(this[this.tableTransmissions.TransmissionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Transmission\' в таблице \'Transmissions\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransmissions.TransmissionColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTransmissionNull() {
                return this.IsNull(this.tableTransmissions.TransmissionColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTransmissionNull() {
                this[this.tableTransmissions.TransmissionColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow[] GetCarriersRows() {
                if ((this.Table.ChildRelations["Transmissions_Carriers"] == null)) {
                    return new CarriersRow[0];
                }
                else {
                    return ((CarriersRow[])(base.GetChildRows(this.Table.ChildRelations["Transmissions_Carriers"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PracticeLessonsRow : global::System.Data.DataRow {
            
            private PracticeLessonsDataTable tablePracticeLessons;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PracticeLessonsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablePracticeLessons = ((PracticeLessonsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tablePracticeLessons.IDColumn]));
                }
                set {
                    this[this.tablePracticeLessons.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Student {
                get {
                    try {
                        return ((int)(this[this.tablePracticeLessons.StudentColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Student\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.StudentColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime AppointedDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tablePracticeLessons.AppointedDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'AppointedDate\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.AppointedDateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.TimeSpan AppointedTime {
                get {
                    try {
                        return ((global::System.TimeSpan)(this[this.tablePracticeLessons.AppointedTimeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'AppointedTime\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.AppointedTimeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime FactDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tablePracticeLessons.FactDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FactDate\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.FactDateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.TimeSpan FactTime {
                get {
                    try {
                        return ((global::System.TimeSpan)(this[this.tablePracticeLessons.FactTimeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FactTime\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.FactTimeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string StudentFIO {
                get {
                    try {
                        return ((string)(this[this.tablePracticeLessons.StudentFIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'StudentFIO\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.StudentFIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CarrierName {
                get {
                    try {
                        return ((string)(this[this.tablePracticeLessons.CarrierNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierName\' в таблице \'PracticeLessons\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tablePracticeLessons.CarrierNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow StudentsRow {
                get {
                    return ((StudentsRow)(this.GetParentRow(this.Table.ParentRelations["Students_PracticeLessons"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Students_PracticeLessons"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStudentNull() {
                return this.IsNull(this.tablePracticeLessons.StudentColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStudentNull() {
                this[this.tablePracticeLessons.StudentColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAppointedDateNull() {
                return this.IsNull(this.tablePracticeLessons.AppointedDateColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAppointedDateNull() {
                this[this.tablePracticeLessons.AppointedDateColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAppointedTimeNull() {
                return this.IsNull(this.tablePracticeLessons.AppointedTimeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAppointedTimeNull() {
                this[this.tablePracticeLessons.AppointedTimeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFactDateNull() {
                return this.IsNull(this.tablePracticeLessons.FactDateColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFactDateNull() {
                this[this.tablePracticeLessons.FactDateColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFactTimeNull() {
                return this.IsNull(this.tablePracticeLessons.FactTimeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFactTimeNull() {
                this[this.tablePracticeLessons.FactTimeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStudentFIONull() {
                return this.IsNull(this.tablePracticeLessons.StudentFIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStudentFIONull() {
                this[this.tablePracticeLessons.StudentFIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierNameNull() {
                return this.IsNull(this.tablePracticeLessons.CarrierNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierNameNull() {
                this[this.tablePracticeLessons.CarrierNameColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CarriersUsesRow : global::System.Data.DataRow {
            
            private CarriersUsesDataTable tableCarriersUses;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersUsesRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCarriersUses = ((CarriersUsesDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableCarriersUses.IDColumn]));
                }
                set {
                    this[this.tableCarriersUses.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Instructor {
                get {
                    try {
                        return ((int)(this[this.tableCarriersUses.InstructorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Instructor\' в таблице \'CarriersUses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersUses.InstructorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Carrier {
                get {
                    try {
                        return ((int)(this[this.tableCarriersUses.CarrierColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Carrier\' в таблице \'CarriersUses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersUses.CarrierColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string InstructorName {
                get {
                    try {
                        return ((string)(this[this.tableCarriersUses.InstructorNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'InstructorName\' в таблице \'CarriersUses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersUses.InstructorNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CarrierName {
                get {
                    try {
                        return ((string)(this[this.tableCarriersUses.CarrierNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierName\' в таблице \'CarriersUses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersUses.CarrierNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CategoryCarrierID {
                get {
                    try {
                        return ((string)(this[this.tableCarriersUses.CategoryCarrierIDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CategoryCarrierID\' в таблице \'CarriersUses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersUses.CategoryCarrierIDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow InstructorsRow {
                get {
                    return ((InstructorsRow)(this.GetParentRow(this.Table.ParentRelations["Instructors_CarriersUses"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Instructors_CarriersUses"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow CarriersRow {
                get {
                    return ((CarriersRow)(this.GetParentRow(this.Table.ParentRelations["Carriers_CarriersUses"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Carriers_CarriersUses"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsInstructorNull() {
                return this.IsNull(this.tableCarriersUses.InstructorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetInstructorNull() {
                this[this.tableCarriersUses.InstructorColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierNull() {
                return this.IsNull(this.tableCarriersUses.CarrierColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierNull() {
                this[this.tableCarriersUses.CarrierColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsInstructorNameNull() {
                return this.IsNull(this.tableCarriersUses.InstructorNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetInstructorNameNull() {
                this[this.tableCarriersUses.InstructorNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierNameNull() {
                return this.IsNull(this.tableCarriersUses.CarrierNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierNameNull() {
                this[this.tableCarriersUses.CarrierNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCategoryCarrierIDNull() {
                return this.IsNull(this.tableCarriersUses.CategoryCarrierIDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCategoryCarrierIDNull() {
                this[this.tableCarriersUses.CategoryCarrierIDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow[] GetReplacementsCarriersRows() {
                if ((this.Table.ChildRelations["CarriersUses_ReplacementCarrier"] == null)) {
                    return new ReplacementsCarriersRow[0];
                }
                else {
                    return ((ReplacementsCarriersRow[])(base.GetChildRows(this.Table.ChildRelations["CarriersUses_ReplacementCarrier"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow[] GetStudentsRows() {
                if ((this.Table.ChildRelations["CarriersUses_Students"] == null)) {
                    return new StudentsRow[0];
                }
                else {
                    return ((StudentsRow[])(base.GetChildRows(this.Table.ChildRelations["CarriersUses_Students"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class CarriersRepairsRow : global::System.Data.DataRow {
            
            private CarriersRepairsDataTable tableCarriersRepairs;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CarriersRepairsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCarriersRepairs = ((CarriersRepairsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableCarriersRepairs.IDColumn]));
                }
                set {
                    this[this.tableCarriersRepairs.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Carrier {
                get {
                    try {
                        return ((int)(this[this.tableCarriersRepairs.CarrierColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Carrier\' в таблице \'CarriersRepairs\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersRepairs.CarrierColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Master {
                get {
                    try {
                        return ((int)(this[this.tableCarriersRepairs.MasterColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Master\' в таблице \'CarriersRepairs\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersRepairs.MasterColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Work {
                get {
                    try {
                        return ((string)(this[this.tableCarriersRepairs.WorkColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Work\' в таблице \'CarriersRepairs\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersRepairs.WorkColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime BeginDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableCarriersRepairs.BeginDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'BeginDate\' в таблице \'CarriersRepairs\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersRepairs.BeginDateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime EndDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableCarriersRepairs.EndDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'EndDate\' в таблице \'CarriersRepairs\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableCarriersRepairs.EndDateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow CarriersRow {
                get {
                    return ((CarriersRow)(this.GetParentRow(this.Table.ParentRelations["Carriers_CarriesRepairs"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Carriers_CarriesRepairs"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow ServiceMastersRow {
                get {
                    return ((ServiceMastersRow)(this.GetParentRow(this.Table.ParentRelations["ServiceMasters_CarriesRepairs"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["ServiceMasters_CarriesRepairs"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierNull() {
                return this.IsNull(this.tableCarriersRepairs.CarrierColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierNull() {
                this[this.tableCarriersRepairs.CarrierColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsMasterNull() {
                return this.IsNull(this.tableCarriersRepairs.MasterColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetMasterNull() {
                this[this.tableCarriersRepairs.MasterColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWorkNull() {
                return this.IsNull(this.tableCarriersRepairs.WorkColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWorkNull() {
                this[this.tableCarriersRepairs.WorkColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsBeginDateNull() {
                return this.IsNull(this.tableCarriersRepairs.BeginDateColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetBeginDateNull() {
                this[this.tableCarriersRepairs.BeginDateColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEndDateNull() {
                return this.IsNull(this.tableCarriersRepairs.EndDateColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEndDateNull() {
                this[this.tableCarriersRepairs.EndDateColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class ReplacementsCarriersRow : global::System.Data.DataRow {
            
            private ReplacementsCarriersDataTable tableReplacementsCarriers;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReplacementsCarriersRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableReplacementsCarriers = ((ReplacementsCarriersDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableReplacementsCarriers.IDColumn]));
                }
                set {
                    this[this.tableReplacementsCarriers.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int CarrierUse {
                get {
                    try {
                        return ((int)(this[this.tableReplacementsCarriers.CarrierUseColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierUse\' в таблице \'ReplacementsCarriers\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableReplacementsCarriers.CarrierUseColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int CarrierReplacement {
                get {
                    try {
                        return ((int)(this[this.tableReplacementsCarriers.CarrierReplacementColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierReplacement\' в таблице \'ReplacementsCarriers\' равно " +
                                "DBNull.", e);
                    }
                }
                set {
                    this[this.tableReplacementsCarriers.CarrierReplacementColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime DateBeginReplacement {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableReplacementsCarriers.DateBeginReplacementColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'DateBeginReplacement\' в таблице \'ReplacementsCarriers\' равн" +
                                "о DBNull.", e);
                    }
                }
                set {
                    this[this.tableReplacementsCarriers.DateBeginReplacementColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime DateEndReplacement {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableReplacementsCarriers.DateEndReplacementColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'DateEndReplacement\' в таблице \'ReplacementsCarriers\' равно " +
                                "DBNull.", e);
                    }
                }
                set {
                    this[this.tableReplacementsCarriers.DateEndReplacementColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow CarriersUsesRow {
                get {
                    return ((CarriersUsesRow)(this.GetParentRow(this.Table.ParentRelations["CarriersUses_ReplacementCarrier"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["CarriersUses_ReplacementCarrier"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow CarriersRow {
                get {
                    return ((CarriersRow)(this.GetParentRow(this.Table.ParentRelations["Carriers_ReplacementCarrier"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Carriers_ReplacementCarrier"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierUseNull() {
                return this.IsNull(this.tableReplacementsCarriers.CarrierUseColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierUseNull() {
                this[this.tableReplacementsCarriers.CarrierUseColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierReplacementNull() {
                return this.IsNull(this.tableReplacementsCarriers.CarrierReplacementColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierReplacementNull() {
                this[this.tableReplacementsCarriers.CarrierReplacementColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateBeginReplacementNull() {
                return this.IsNull(this.tableReplacementsCarriers.DateBeginReplacementColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateBeginReplacementNull() {
                this[this.tableReplacementsCarriers.DateBeginReplacementColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsDateEndReplacementNull() {
                return this.IsNull(this.tableReplacementsCarriers.DateEndReplacementColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetDateEndReplacementNull() {
                this[this.tableReplacementsCarriers.DateEndReplacementColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class WorkStatusesRow : global::System.Data.DataRow {
            
            private WorkStatusesDataTable tableWorkStatuses;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal WorkStatusesRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableWorkStatuses = ((WorkStatusesDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableWorkStatuses.IDColumn]));
                }
                set {
                    this[this.tableWorkStatuses.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableWorkStatuses.NameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Name\' в таблице \'WorkStatuses\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableWorkStatuses.NameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull() {
                return this.IsNull(this.tableWorkStatuses.NameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetNameNull() {
                this[this.tableWorkStatuses.NameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow[] GetServiceMastersRows() {
                if ((this.Table.ChildRelations["WorkStatuses_ServiceMasters"] == null)) {
                    return new ServiceMastersRow[0];
                }
                else {
                    return ((ServiceMastersRow[])(base.GetChildRows(this.Table.ChildRelations["WorkStatuses_ServiceMasters"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow[] GetInstructorsRows() {
                if ((this.Table.ChildRelations["WorkStatuses_Instructors"] == null)) {
                    return new InstructorsRow[0];
                }
                else {
                    return ((InstructorsRow[])(base.GetChildRows(this.Table.ChildRelations["WorkStatuses_Instructors"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow[] GetTheoryTeachersRows() {
                if ((this.Table.ChildRelations["WorkStatuses_TheoryTeachers"] == null)) {
                    return new TheoryTeachersRow[0];
                }
                else {
                    return ((TheoryTeachersRow[])(base.GetChildRows(this.Table.ChildRelations["WorkStatuses_TheoryTeachers"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class StudentsRow : global::System.Data.DataRow {
            
            private StudentsDataTable tableStudents;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal StudentsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableStudents = ((StudentsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableStudents.IDColumn]));
                }
                set {
                    this[this.tableStudents.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Surname {
                get {
                    try {
                        return ((string)(this[this.tableStudents.SurnameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Surname\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.SurnameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableStudents.FirstNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FirstName\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.FirstNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PatronymicName {
                get {
                    try {
                        return ((string)(this[this.tableStudents.PatronymicNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'PatronymicName\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.PatronymicNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PhoneNumber {
                get {
                    try {
                        return ((string)(this[this.tableStudents.PhoneNumberColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'PhoneNumber\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.PhoneNumberColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Retraining {
                get {
                    try {
                        return ((bool)(this[this.tableStudents.RetrainingColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Retraining\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.RetrainingColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Group {
                get {
                    try {
                        return ((int)(this[this.tableStudents.GroupColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Group\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.GroupColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int CarrierUse {
                get {
                    try {
                        return ((int)(this[this.tableStudents.CarrierUseColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierUse\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.CarrierUseColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte[] Photo {
                get {
                    try {
                        return ((byte[])(this[this.tableStudents.PhotoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'Photo\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.PhotoColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string InstructorName {
                get {
                    try {
                        return ((string)(this[this.tableStudents.InstructorNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'InstructorName\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.InstructorNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CarrierName {
                get {
                    try {
                        return ((string)(this[this.tableStudents.CarrierNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'CarrierName\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.CarrierNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO {
                get {
                    try {
                        return ((string)(this[this.tableStudents.FIOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("Значение для столбца \'FIO\' в таблице \'Students\' равно DBNull.", e);
                    }
                }
                set {
                    this[this.tableStudents.FIOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow CarriersUsesRow {
                get {
                    return ((CarriersUsesRow)(this.GetParentRow(this.Table.ParentRelations["CarriersUses_Students"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["CarriersUses_Students"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow GroupsRow {
                get {
                    return ((GroupsRow)(this.GetParentRow(this.Table.ParentRelations["Groups_Students"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["Groups_Students"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsSurnameNull() {
                return this.IsNull(this.tableStudents.SurnameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetSurnameNull() {
                this[this.tableStudents.SurnameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableStudents.FirstNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFirstNameNull() {
                this[this.tableStudents.FirstNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPatronymicNameNull() {
                return this.IsNull(this.tableStudents.PatronymicNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPatronymicNameNull() {
                this[this.tableStudents.PatronymicNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhoneNumberNull() {
                return this.IsNull(this.tableStudents.PhoneNumberColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhoneNumberNull() {
                this[this.tableStudents.PhoneNumberColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRetrainingNull() {
                return this.IsNull(this.tableStudents.RetrainingColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRetrainingNull() {
                this[this.tableStudents.RetrainingColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsGroupNull() {
                return this.IsNull(this.tableStudents.GroupColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetGroupNull() {
                this[this.tableStudents.GroupColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierUseNull() {
                return this.IsNull(this.tableStudents.CarrierUseColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierUseNull() {
                this[this.tableStudents.CarrierUseColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPhotoNull() {
                return this.IsNull(this.tableStudents.PhotoColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPhotoNull() {
                this[this.tableStudents.PhotoColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsInstructorNameNull() {
                return this.IsNull(this.tableStudents.InstructorNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetInstructorNameNull() {
                this[this.tableStudents.InstructorNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCarrierNameNull() {
                return this.IsNull(this.tableStudents.CarrierNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCarrierNameNull() {
                this[this.tableStudents.CarrierNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFIONull() {
                return this.IsNull(this.tableStudents.FIOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetFIONull() {
                this[this.tableStudents.FIOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow[] GetPracticeLessonsRows() {
                if ((this.Table.ChildRelations["Students_PracticeLessons"] == null)) {
                    return new PracticeLessonsRow[0];
                }
                else {
                    return ((PracticeLessonsRow[])(base.GetChildRows(this.Table.ChildRelations["Students_PracticeLessons"])));
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CategoriesRowChangeEvent : global::System.EventArgs {
            
            private CategoriesRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRowChangeEvent(CategoriesRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CategoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CarriersRowChangeEvent : global::System.EventArgs {
            
            private CarriersRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRowChangeEvent(CarriersRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class InstructorsRowChangeEvent : global::System.EventArgs {
            
            private InstructorsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRowChangeEvent(InstructorsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class ServiceMastersRowChangeEvent : global::System.EventArgs {
            
            private ServiceMastersRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRowChangeEvent(ServiceMastersRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ServiceMastersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class TheoryTeachersRowChangeEvent : global::System.EventArgs {
            
            private TheoryTeachersRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRowChangeEvent(TheoryTeachersRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryTeachersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class AuditoriumsRowChangeEvent : global::System.EventArgs {
            
            private AuditoriumsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRowChangeEvent(AuditoriumsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public AuditoriumsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class GroupsRowChangeEvent : global::System.EventArgs {
            
            private GroupsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRowChangeEvent(GroupsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public GroupsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class InstructorsCategoriesRowChangeEvent : global::System.EventArgs {
            
            private InstructorsCategoriesRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRowChangeEvent(InstructorsCategoriesRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public InstructorsCategoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class TheoryLessonsRowChangeEvent : global::System.EventArgs {
            
            private TheoryLessonsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRowChangeEvent(TheoryLessonsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TheoryLessonsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CarriersStatusesRowChangeEvent : global::System.EventArgs {
            
            private CarriersStatusesRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRowChangeEvent(CarriersStatusesRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersStatusesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class TransmissionsRowChangeEvent : global::System.EventArgs {
            
            private TransmissionsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRowChangeEvent(TransmissionsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TransmissionsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class PracticeLessonsRowChangeEvent : global::System.EventArgs {
            
            private PracticeLessonsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRowChangeEvent(PracticeLessonsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PracticeLessonsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CarriersUsesRowChangeEvent : global::System.EventArgs {
            
            private CarriersUsesRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRowChangeEvent(CarriersUsesRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersUsesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class CarriersRepairsRowChangeEvent : global::System.EventArgs {
            
            private CarriersRepairsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRowChangeEvent(CarriersRepairsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public CarriersRepairsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class ReplacementsCarriersRowChangeEvent : global::System.EventArgs {
            
            private ReplacementsCarriersRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRowChangeEvent(ReplacementsCarriersRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReplacementsCarriersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class WorkStatusesRowChangeEvent : global::System.EventArgs {
            
            private WorkStatusesRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRowChangeEvent(WorkStatusesRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public WorkStatusesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class StudentsRowChangeEvent : global::System.EventArgs {
            
            private StudentsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRowChangeEvent(StudentsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public StudentsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591