using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwSwData
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string DocNo { get; set; }
        public string DocType { get; set; }
        public string DocSource { get; set; }
        public string FromBranch { get; set; }
        public string RecvUser { get; set; }
        public string SafetyLevel { get; set; }
        public string DraftIdea { get; set; }
        public string ProcDetail { get; set; }
        public string GwStatus { get; set; }
        public string CopyNum { get; set; }
        public string MsendBranch { get; set; }
        public string CsendBranch { get; set; }
        public string FastLevel { get; set; }
        public string Subject { get; set; }
        public string FugleIdea { get; set; }
        public string RecvBranch { get; set; }
        public string RecvNo { get; set; }
        public string TopicKey { get; set; }
        public DateTime? RecvDate { get; set; }
        public string NsendBranch { get; set; }
        public string FromId { get; set; }
        public DateTime? FileDate { get; set; }
    }
}
