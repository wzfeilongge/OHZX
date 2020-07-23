using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SsoSoftUser
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public string EndFlag { get; set; }
        public string SystemText { get; set; }
        public string UserId { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string SoftId { get; set; }
    }
}
