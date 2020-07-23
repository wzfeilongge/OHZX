using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemUpdateLists
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public int? EndFlag { get; set; }
        public string SystemText { get; set; }
        public int AutoId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int ChkType { get; set; }
        public int UpdateType { get; set; }
        public string Version { get; set; }
        public DateTime? FileLastDate { get; set; }
        public int? FileSize { get; set; }
        public string DeskFile { get; set; }
        public string CmdLine { get; set; }
        public bool? ShortCut { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
