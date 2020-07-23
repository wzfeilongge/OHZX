using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtSuspiciousvehicle
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public int VehicleCategoryIndex { get; set; }
        public string VehicleCard { get; set; }
        public int VehicleColorIndex { get; set; }
        public string GatherAddress { get; set; }
        public string Desc { get; set; }
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
