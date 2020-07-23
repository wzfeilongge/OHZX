using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TVoteUsers
    {
        public int VoteUserId { get; set; }
        public int? VoteId { get; set; }
        public string VoteIp { get; set; }
        public string UserName { get; set; }
    }
}
