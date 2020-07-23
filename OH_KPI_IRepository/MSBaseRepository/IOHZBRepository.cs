using OH_KPI_Models.MSModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IRepository.MSBaseRepository
{
    public interface IOHZBRepository :IMSBaseRepository<OhZb>
    {


        // 得到下级指标数据
        Task<string> GetZBList(string starttime, string endtime, string id);

        Task<string> GetComList(string starttime, string endtime, string id, string type, string code);

        Task<string> GetDepartList(string starttime, string endtime, string id, string code);

        Task<string> GetZBMC(string ID);

    }

}
