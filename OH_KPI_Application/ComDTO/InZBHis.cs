using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class InZBHis
    {
        public string ID { set; get; }//指标唯一编号
        public string Name { set; get; }//指标名称
        public List<InZBHis_Info> Info { set; get; }//传入的查询条件
    }

    public class InZBHis_Info
    {
        public string Type { set; get; }//类型（bm:部门,cbr：承办人）
        public string Data { set; get; }//数值
    }
}
