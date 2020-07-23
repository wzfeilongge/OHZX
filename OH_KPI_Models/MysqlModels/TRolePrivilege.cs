using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TRolePrivilege
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string PrivilegeId { get; set; }
    }
}
