using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ForDTO
{
    public class OutCase
    {
        public List<OutCase_Info> Info { set; get; }
    }

    public class OutCase_Info
    {
        public string XH { set; get; }//序号
        public string AH { set; get; }//案号
        public string AY { set; get; }//案由
        public string BMMC { set; get; }//部门名称
        public string CBRMC { set; get; }//承办人名称
        public string AJLX { set; get; }//案件类型
        public string SPCX { set; get; }//审判程序
        public string SARQ { set; get; }//收案日期
        public string JARQ { set; get; }//结案日期
    }
}
