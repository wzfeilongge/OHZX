using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class AuxMessageusergroup
    {
        public string Id { get; set; }
        public string MessageGroupId { get; set; }
        public string UserId { get; set; }
        public string Account { get; set; }
        public string RealName { get; set; }
    }
}
