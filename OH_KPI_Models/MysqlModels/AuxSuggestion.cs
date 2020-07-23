using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class AuxSuggestion
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RealName { get; set; }
        public string OrganizeId { get; set; }
        public string OrganizeName { get; set; }
        public string Desc { get; set; }
        public sbyte Finished { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
