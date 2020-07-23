using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class InMQuery
    {
        public List<InMQuery_Info> Info { set; get; }//传入的查询条件
    }

    public class InMQuery_Info
    {
        public string Type { set; get; }//类型（bm:部门,lx：案件类型,xz：性质,ay：案由,cbr：承办人,qt：其他<全院>）
        public string Name { set; get; }//条件筛选对应名称
        public string Data { set; get; }//数值
        public string StartTime { set; get; }//开始时间
        public string EndTime { set; get; }//结束时间
    }
}
