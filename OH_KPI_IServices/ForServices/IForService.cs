using OH_KPI_Application.ForDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IServices.ForServices
{
    public interface IForService
    {


        /// <summary>
        /// 计算公式接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OutFormula> GetFormulaList(InFormula model);


        /// <summary>
        /// 案件信息接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OutCase> GetCaseList(InCase model);








    }
}
