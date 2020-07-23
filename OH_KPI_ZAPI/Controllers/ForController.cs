using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OH_KPI_Application;
using OH_KPI_Application.ForDTO;
using OH_KPI_IServices.ForServices;

namespace OH_KPI_ZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForController : ControllerBase
    {
        private IForService forService;

        public ForController(IForService forService)
        {
            this.forService = forService;
        }


        /// <summary>
        /// 计算公式接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetFormulaList")]
        public async Task<IActionResult> GetFormulaList([FromForm] InFormula model)
        {
            var data = await forService.GetFormulaList(model);
            return Ok(new ResutModel<OutFormula>
            {

                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }


        /// <summary>
        /// 案件信息接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetCaseList")]
        public async Task<IActionResult> GetCaseList([FromForm] InCase model)
        {
            var data = await forService.GetCaseList(model);
            return Ok(new ResutModel<OutCase>
            {
                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }










    }
}
