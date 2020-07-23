using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.DepartDTO
{
    public class OutDepartD
    {
        public string UpdateTime { set; get; }//指标近期更新时间
        public string StartTime { set; get; }//开始时间（条件筛选）
        public string EndTime { set; get; }//结束时间（条件筛选）
        public string DepartName { set; get; }//部门名称
        public List<OutDepartD_List> Info { set; get; }//质效列表信息
    }

    public class OutDepartD_List
    {
        public string Name { set; get; }//指标名称
        public string Num { set; get; }//指标数值
        public string TB { set; get; }//同比数值
        public string HB { set; get; }//环比数值
        public string Type { set; get; }//指标类型（0：核心指标  1：调研指标 ）

    }
}
