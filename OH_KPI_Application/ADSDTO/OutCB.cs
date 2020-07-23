using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class OutCB
    {
        public List<OutCB_Info> Info { set; get; }
    }
    public class OutCB_Info
    {
        public string ID { set; get; }//部门唯一编号
        public string BMMC { set; get; }//部门名称
        public List<CBR_Info> CBR_Info { set; get; }//列表数据
    }
    public class CBR_Info
    {
        public string ID { set; get; }//承办人唯一编号
        public string CBRMC { set; get; }//承办人名称
    }
}
