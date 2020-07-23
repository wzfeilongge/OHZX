using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class New
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public string NewContent { get; set; }
        public string Author { get; set; }
        public int? Hit { get; set; }
        public int? IsShow { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? NewClassId { get; set; }
        public int? SpotNum { get; set; }
        public DateTime? UpdateTime { get; set; }
        public byte[] PicBody { get; set; }
        public int? PicSize { get; set; }
        public string PicType { get; set; }
    }
}
