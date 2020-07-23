using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtCluereport
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public int CategoryIndex { get; set; }
        public string Title { get; set; }
        public string Describe { get; set; }
        public string Address { get; set; }
        public int MediaCount { get; set; }
        public int UpMediaCount { get; set; }
        public DateTime CreateTime { get; set; }
        public sbyte Enable { get; set; }
        public string RealName { get; set; }
        public string OrganizeName { get; set; }
    }
}
