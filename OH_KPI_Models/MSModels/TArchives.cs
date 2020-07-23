using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TArchives
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string ArchivesNo { get; set; }
        public string ArchivesType { get; set; }
        public string FileType { get; set; }
        public string CarrierType { get; set; }
        public string SafetyLevel { get; set; }
        public string DocNo { get; set; }
        public string Subject { get; set; }
        public string TopicKey { get; set; }
        public string Content { get; set; }
        public string LiabilityUser { get; set; }
        public string PageNum { get; set; }
        public string CopyNum { get; set; }
        public DateTime? FileDate { get; set; }
        public DateTime? PigeonholeDate { get; set; }
        public string StorageLimit { get; set; }
        public string ArchivesStatus { get; set; }
        public string FromTableId { get; set; }
        public string FromTableName { get; set; }
        public string PigeonholeType { get; set; }
        public string PigeonholeUser { get; set; }
        public string PigeonholeBranch { get; set; }
        public string PigeonholeYear { get; set; }
        public string AccessRightFlowUsers { get; set; }
        public string AccessRightTypeList { get; set; }
        public string AccessRightType { get; set; }
        public string AccessRightSafetyLevel { get; set; }
        public string AccessRightQueryApply { get; set; }
        public string AccessRight { get; set; }
    }
}
