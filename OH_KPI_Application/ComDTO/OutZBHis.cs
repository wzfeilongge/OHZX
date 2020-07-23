using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class OutZBHis
    {
        public string UpdateTime { set; get; }//指标近期更新时间

        public List<OutZBHis_Head> Head { set; get; }//头部内容
        public List<OutZBHis_Body> Body { set; get; }//列表内容
    }

    public class OutZBHis_Head
    {
        public string Name { set; get; }//指标名称
    }
    public class OutZBHis_Body
    {
        public List<OutZBHis_Row> Row { set; get; }//行
    }
    public class OutZBHis_Row
    {
        public string val { set; get; }//行数据

    }
}
