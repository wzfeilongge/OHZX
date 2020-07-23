using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class FileManageFileInfo
    {
        public int FileId { get; set; }
        public int? FolderId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string FileDetail { get; set; }
        public string PhysicalName { get; set; }
        public string FileStatus { get; set; }
        public string FileSize { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string KeyWord { get; set; }
        public string ViewRightList { get; set; }
        public string EditRightList { get; set; }
        public string DeleteRightList { get; set; }
    }
}
