using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwFwData
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string DocNo { get; set; }
        public string GwStatus { get; set; }
        public string DraftUser { get; set; }
        public string SafetyLevel { get; set; }
        public string TopicKey { get; set; }
        public string DraftIdea { get; set; }
        public string CheckIdea { get; set; }
        public string SignIdea { get; set; }
        public string SameIdea { get; set; }
        public DateTime? SignDate { get; set; }
        public string DocType { get; set; }
        public string CopyNum { get; set; }
        public DateTime? DraftDate { get; set; }
        public string MsendBranch { get; set; }
        public string DraftBranch { get; set; }
        public string CsendBranch { get; set; }
        public string FastLevel { get; set; }
        public string Subject { get; set; }
        public string NsendBranch { get; set; }
        public string ReceiverUsers { get; set; }
        public string IsSwflow { get; set; }
    }
}
