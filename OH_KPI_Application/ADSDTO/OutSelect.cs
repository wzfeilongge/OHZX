using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class OutSelect
    {
        public List<OutSelect_Info> Info { set; get; }
    }
    public class OutSelect_Info
    {
        public string ID { set; get; }//部门唯一编号
        public string Name { set; get; }//部门名称
    }
}
