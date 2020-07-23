using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class OutMQuery
    {
        public string UpdateTime { set; get; }//指标近期更新时间

        public List<OutMQuery_Head> Head { set; get; }//头部内容
        public List<OutMQuery_Body> Body { set; get; }//列表内容
    }

    public class OutMQuery_Head
    {
        public string Name { set; get; }//指标名称
    }
    public class OutMQuery_Body
    {
        public List<OutMQuery_Row> Row { set; get; }//行
        public string Type { set; get; }//指标类型（0：核心指标  1：调研指标 ）
    }
    public class OutMQuery_Row
    {
        public string val { set; get; }//行数据

    }
}
