using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.DepartDTO
{
    public class OutDepart
    {
        public string UpdateTime { set; get; }//指标近期更新时间
        public string StartTime { set; get; }//开始时间（条件筛选）
        public string EndTime { set; get; }//结束时间（条件筛选）
        public List<OutDepart_Head> Head { set; get; }//头部内容
        public List<OutDepart_Body> Body { set; get; }//列表内容
    }

    public class OutDepart_Head
    {
        public string Name { set; get; }//指标名称
        public string ID { set; get; }//部门表唯一编号

    }
    public class OutDepart_Body
    {
        public List<OutDepart_Row> Row { set; get; }//指标名称
        public string Type { set; get; }//指标类型（0：核心指标  1：调研指标 ）
    }

    public class OutDepart_Row
    {
        public string val { set; get; }//行数据

    }
}
