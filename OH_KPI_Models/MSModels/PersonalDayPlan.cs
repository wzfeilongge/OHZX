using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class PersonalDayPlan
    {
        public int DayPlanId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int? DayTypeId { get; set; }
        public string IsRemind { get; set; }
        public int? RemindType { get; set; }
        public int? Renum { get; set; }
        public int? Rmnum { get; set; }
        public string IsRepeat { get; set; }
        public string RepeatType { get; set; }
        public int? RepeatNum { get; set; }
        public DateTime? RepeatEndTime { get; set; }
        public string IsPublic { get; set; }
        public string IsTeam { get; set; }
        public string FromProp { get; set; }
        public string FromId { get; set; }
    }
}
