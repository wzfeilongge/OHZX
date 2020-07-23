using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class InZBCom
    {
        public List<InZBCom_Info> Info { set; get; }//传入的查询条件
        public List<InZBCom_ZB> ZB { set; get; }//传入的查询条件
    }

    public class InZBCom_Info
    {
        public string Type { set; get; }//类型（bm:部门,lx：案件类型,xz：性质,ay：案由,cbr：承办人,qt：其他<全院>）
        public string Data { set; get; }//数值
    }
    public class InZBCom_ZB
    {
        public string ID { set; get; }//指标唯一编号
        public string Name { set; get; }//指标名称
        public string StartTime { set; get; }//开始时间
        public string EndTime { set; get; }//结束时间
    }
}
