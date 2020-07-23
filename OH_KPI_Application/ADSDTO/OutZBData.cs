using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class OutZBData
    {
        public string UpdateTime { set; get; }//指标近期更新时间
        public string QueryTime { set; get; }//时间段(筛选条件)
        public string StartTime { set; get; }//开始时间（条件筛选）
        public string EndTime { set; get; }//结束时间（条件筛选）
        public List<ZXSearch> Info { set; get; }//质效列表信息
    }


    public class ZXSearch
    {
        public string Name { set; get; }//指标名称
        public string Col { set; get; }//列名称
        public string Num { set; get; }//指标数值
        public string Type { set; get; }//指标类型（0：核心指标  1：调研指标 ）
        public string ID { set; get; }//指标唯一编号
    }


}
