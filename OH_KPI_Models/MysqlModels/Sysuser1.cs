using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class Sysuser1
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int? Version { get; set; }
        public string UserPhone { get; set; }
        public ulong? IsDelete { get; set; }
        public ulong? IsAdmin { get; set; }
        public string Department { get; set; }
    }
}
