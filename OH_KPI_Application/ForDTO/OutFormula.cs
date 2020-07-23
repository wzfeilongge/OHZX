using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ForDTO
{
    public class OutFormula
    {
        public string QueryTime { set; get; }//时间段(筛选条件)
        public string StartTime { set; get; }//开始时间
        public string EndTime { set; get; }//结束时间
        public string Formula_c { set; get; }//计算公式中文描述
        public List<OutFormula_Info> Info { set; get; }
    }

    public class OutFormula_Info
    {
        public string Col { set; get; }//列名称
        public string Num { set; get; }//指标数值
        public string ID { set; get; }//下级指标唯一编号
    }
}
