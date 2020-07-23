using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysModulebutton
    {
        public string Id { get; set; }
        public string ModuleId { get; set; }
        public string ParentId { get; set; }
        public int? Layers { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public int? Location { get; set; }
        public string JsEvent { get; set; }
        public string UrlAddress { get; set; }
        public sbyte? Split { get; set; }
        public sbyte? IsPublic { get; set; }
        public sbyte? AllowEdit { get; set; }
        public sbyte? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public sbyte? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public string LastModifyUserId { get; set; }
    }
}
