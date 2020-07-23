using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfPigeonhole
    {
        public int PigeonholeId { get; set; }
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string FormTableName { get; set; }
        public string FilePath { get; set; }
    }
}
