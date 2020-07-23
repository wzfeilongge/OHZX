using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ComDto
{
    public class OutZBCom
    {
        public string UpdateTime { set; get; }//指标近期更新时间

        public List<OutZBCom_Head> Head { set; get; }//头部内容
        public List<OutZBCom_Body> Body { set; get; }//列表内容
    }

    public class OutZBCom_Head
    {
        public string Name { set; get; }//指标名称
    }
    public class OutZBCom_Body
    {
        public List<OutZBCom_Row> Row { set; get; }//行
    }
    public class OutZBCom_Row
    {
        public string val { set; get; }//行数据

    }
}
