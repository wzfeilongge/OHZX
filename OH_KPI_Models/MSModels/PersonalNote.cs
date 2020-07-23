using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class PersonalNote
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Content { get; set; }
    }
}
