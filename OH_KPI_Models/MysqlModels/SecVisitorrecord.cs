using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SecVisitorrecord
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public string RealName { get; set; }
        public string OrganizeName { get; set; }
        public string HeadImage { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string Nation { get; set; }
        public string Sfzh { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
