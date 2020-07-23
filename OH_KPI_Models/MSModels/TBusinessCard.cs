using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TBusinessCard
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string EmailAddress { get; set; }
        public string MobilPhone { get; set; }
        public string OfficePhone { get; set; }
        public string HomePhone { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddr { get; set; }
        public string Duty { get; set; }
        public string HomeAddr { get; set; }
        public string CompanySite { get; set; }
        public string PersonalSite { get; set; }
        public string Detail { get; set; }
        public string OtherMailAddr { get; set; }
        public string ManGroup { get; set; }
    }
}
