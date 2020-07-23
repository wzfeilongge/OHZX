using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SsoSoft
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public string EndFlag { get; set; }
        public string SystemText { get; set; }
        public string SoftName { get; set; }
        public string LoginUrl { get; set; }
        public string LoginNameParm { get; set; }
        public string LoginPasswordParm { get; set; }
        public string FormMethod { get; set; }
        public string OpenType { get; set; }
        public string SoftId { get; set; }
        public string PageContent { get; set; }
        public string PageType { get; set; }
    }
}
