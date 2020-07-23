using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemUsers
    {
        public string UserId { get; set; }
        public short? LoginAttemptCount { get; set; }
        public string Password { get; set; }
        public string PswData { get; set; }
        public string LoginId { get; set; }
        public string LoginType { get; set; }
        public string IsFirstLogin { get; set; }
        public string Name { get; set; }
        public string DepartIds { get; set; }
        public string DutyIds { get; set; }
        public string IsLogin { get; set; }
        public short? ListLines { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Mobile2 { get; set; }
        public string OfficePhone { get; set; }
        public string HousePhone { get; set; }
        public string OtherPhone { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public string StylePath { get; set; }
        public string DateFormat { get; set; }
        public string TimeFormat { get; set; }
        public string AlertVoice { get; set; }
        public string PrivateSeal { get; set; }
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string EndFlag { get; set; }
        public int? Sequence { get; set; }
        public byte? OnOff { get; set; }
        public string Status { get; set; }
        public byte? IsOnLine { get; set; }
        public byte? ImgIndex { get; set; }
        public string Cakey { get; set; }
        public string ToMsgFlag { get; set; }
        public string Note { get; set; }
    }
}
