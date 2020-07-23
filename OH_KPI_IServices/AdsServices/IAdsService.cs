using OH_KPI_Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IServices.AdsServices
{
    public interface IAdsService
    {
        Task<OutZBData> GetZBList(InZBData inZBData);

        Task<string> GetExcel(InExcel model);

        Task<OutZB> GetAllZB();

        Task<OutCB> GetAllCB();

        Task<OutSelect> GetSelectDate(InSelect model);


    }
}
