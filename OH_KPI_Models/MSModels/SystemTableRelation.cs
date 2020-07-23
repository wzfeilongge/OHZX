using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTableRelation
    {
        public int RelationId { get; set; }
        public string RelationName { get; set; }
        public string ChildTableName { get; set; }
        public string ChildColumn { get; set; }
        public string ParentTableName { get; set; }
        public string ParentColumn { get; set; }
        public string ParentColumnType { get; set; }
        public string IsRelationDelete { get; set; }
    }
}
