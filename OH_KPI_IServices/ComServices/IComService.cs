using OH_KPI_Application.ComDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IServices.ComServices
{
   public interface IComService
    {

        /// <summary>
        /// 质效分析首页指标
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OutMQuery> GetComZbList(InMQuery model);

        /// <summary>
        /// 指标对比接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OutZBCom> GetZbComData(InZBCom model);

        /// <summary>
        /// 历史指标数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OutZBHis> GetZbHisData(InZBHis model);
    }
}
