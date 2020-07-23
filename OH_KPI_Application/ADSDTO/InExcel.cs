using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class InExcel
    {
        public string Title { set; get; }//标题
        public string UpdateTime { set; get; }//指标近期更新时间
        public List<ZXExcel> Info { set; get; }//列表数据
    }

    public class ZXExcel
    {
        public string Head { set; get; }//表头
        public List<Body> Body { set; get; }//表内容
    }
    public class Body
    {
        public string Val { set; get; }//表内容数据
    }
}
