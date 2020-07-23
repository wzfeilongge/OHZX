using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTableColInfo
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnCnname { get; set; }
        public int ColumnType { get; set; }
        public string SystemFlag { get; set; }
        public string DataType { get; set; }
        public int? FieldLength { get; set; }
        public int? FieldIndex { get; set; }
        public string FieldDefault { get; set; }
        public string IndexFlag { get; set; }
        public int? ListDisplayFlag { get; set; }
        public string AllowListDisplay { get; set; }
        public string ListOrderFlag { get; set; }
        public string ListQueryFlag { get; set; }
        public string DisplayType { get; set; }
        public string DisplayTypeData { get; set; }
        public string DisplayHelpMsg { get; set; }
        public int? RowIndex { get; set; }
        public int? ColIndex { get; set; }
        public int? TitleWidth { get; set; }
        public int? TitleHeight { get; set; }
        public string ValidType { get; set; }
        public string EmptyFlag { get; set; }
        public string OnlyFlag { get; set; }
        public string EditFlag { get; set; }
        public int? PosLeft { get; set; }
        public int? PosTop { get; set; }
        public int? FieldWidth { get; set; }
        public int? FieldHeight { get; set; }
        public string AssociatedTable { get; set; }
        public string AssociatedTableCol { get; set; }
        public string AssociatedName { get; set; }
        public string Descripe { get; set; }
    }
}
