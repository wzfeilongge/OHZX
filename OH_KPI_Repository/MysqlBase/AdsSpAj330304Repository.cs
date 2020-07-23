using OH_KPI_IRepository.MyBaseRepository;
using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_Repository.MysqlBase
{
    public class AdsSpAj330304Repository : MyBaseRepository<AdsSpAj330304>, IAdsSpAj330304Repository
    {
        public async Task<string> GetCaseInfo(string starttime, string endtime, string sql)
        {
            return  await  Task.FromResult(sql.Replace("@starttime", starttime).Replace("@endtime", endtime).Replace("@more", " order by jarq desc,sarq desc limit 20"));

        }
    }
}
