using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.ResultMessage
{
   public class ResultMessage<T>
    {
        public T Data { set; get; }//数据信息
        public int ErrorCode { set; get; } = 1;//状态（状态正确比如0时，输出Data，否则输出ErrorMsg）
        public string ErrorMsg { set; get; } = "服务器错误";//错误信息
    }
}
