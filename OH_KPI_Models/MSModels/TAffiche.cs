using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TAffiche
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
        public string AfficheType { get; set; }
        public DateTime? SendDate { get; set; }
        public string AccessRight { get; set; }
        public string SendBranch { get; set; }
        public string CreateUser { get; set; }
    }
}
