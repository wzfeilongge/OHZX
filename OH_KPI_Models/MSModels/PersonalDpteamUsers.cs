using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class PersonalDpteamUsers
    {
        public int DayPlanId { get; set; }
        public string RequestedUserId { get; set; }
        public string ViewFlag { get; set; }
        public string AgreeFlag { get; set; }
    }
}
