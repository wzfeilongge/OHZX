using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class DdUser
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Id { get; set; }
        public string Xm { get; set; }
        public string Oaid { get; set; }
        public string OpenId { get; set; }
        public string Unionid { get; set; }
    }
}
