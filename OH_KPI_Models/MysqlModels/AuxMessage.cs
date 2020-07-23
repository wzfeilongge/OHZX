using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class AuxMessage
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public string ToUserId { get; set; }
        public string ToRealName { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime CreateTime { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupType { get; set; }
        public string ClientId { get; set; }
        public sbyte Vibrate { get; set; }
        public sbyte Lights { get; set; }
        public string Sound { get; set; }
        public string AppSystem { get; set; }
        public string AppVersion { get; set; }
        public string AppType { get; set; }
    }
}
