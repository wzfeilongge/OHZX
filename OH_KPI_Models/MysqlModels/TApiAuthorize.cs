using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TApiAuthorize
    {
        public string Id { get; set; }
        public string Route { get; set; }
        public string PrivilegeId { get; set; }
        public string Describe { get; set; }
        public string HttpMethod { get; set; }
    }
}
