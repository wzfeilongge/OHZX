using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class HisTime
    {
        public List<HisTime_Info> Info { set; get; }
    }

    public class HisTime_Info
    {
        public string StartTime { set; get; }//开始时间
        public string EndTime { set; get; }//结束时间
        public string Name { set; get; }//时间名称
    }
}
