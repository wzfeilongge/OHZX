using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IRepository.MyBaseRepository
{
    public interface IAdsSpAj330304Repository :IMyBaseRepository<AdsSpAj330304>
    {

        /// <summary>
        /// 生成sql 语句
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        Task<string> GetCaseInfo(string starttime, string endtime, string sql);


    }
}
