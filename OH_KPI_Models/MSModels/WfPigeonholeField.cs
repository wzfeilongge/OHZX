using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfPigeonholeField
    {
        public int? PigeonholeId { get; set; }
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public string Type { get; set; }
        public int? Length { get; set; }
        public string IsKeyField { get; set; }
    }
}
