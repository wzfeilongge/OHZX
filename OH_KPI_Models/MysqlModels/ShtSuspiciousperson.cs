using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtSuspiciousperson
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public int CertCategoryIndex { get; set; }
        public string CertNo { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Desc { get; set; }
        public string GatherAddress { get; set; }
        public int PersonnelHandlingIndex { get; set; }
        public string PersonnelHandlingDesc { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbUrl { get; set; }
        public int MediaCount { get; set; }
        public int UpMediaCount { get; set; }
        public DateTime CreateTime { get; set; }
        public sbyte Enable { get; set; }
        public string RealName { get; set; }
        public string OrganizeName { get; set; }
    }
}
