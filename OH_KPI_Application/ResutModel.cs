using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application
{
    public class ResutModel<T>
    {
        public T data { get; set; }

        public int errorCode { get; set; } = 0;

        public string errorMsg { get; set; } = null;

    }
}
