using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemMessage
    {
        public int MessageId { get; set; }
        public string Receiver { get; set; }
        public string Creater { get; set; }
        public string CreateBranch { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? AlertTime { get; set; }
        public string MessageType { get; set; }
        public int? AlertType { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public string ViewFlag { get; set; }
        public string ReceiversBound { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? ReplyTime { get; set; }
        public byte? SelectChk { get; set; }
        public byte? MarkChk { get; set; }
        public byte? CheckChk { get; set; }
        public string SlaveName { get; set; }
        public string Smsflag { get; set; }
    }
}
