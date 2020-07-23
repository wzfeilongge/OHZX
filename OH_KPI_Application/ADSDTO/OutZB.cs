using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class OutZB
    {
        public List<OutZB_Info> Info { set; get; }//列表数据
    }
    public class OutZB_Info
    {
        public string ID { set; get; }//指标唯一编号
        public string Name { set; get; }//指标名称
    }
}
