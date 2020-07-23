using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OH_KPI_Application;
using OH_KPI_Application.ComDto;
using OH_KPI_IServices.ComServices;

namespace OH_KPI_ZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComController : ControllerBase
    {

        private readonly IComService comService;

        public ComController(IComService comService)
        {
            this.comService = comService;
        }

        /// <summary>
        /// 质效分析首页指标接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetComZBList")]
        public async Task<IActionResult> GetComZBList([FromForm] InMQuery model)
        {
            var data = await comService.GetComZBList(model);
            return Ok(new ResutModel<OutMQuery>
            {

                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }



        /// <summary>
        /// 指标对比接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetZBCom")]
        public async Task<IActionResult> GetZBCom([FromForm] InZBCom model)
        {
            var data = await comService.GetZBComData(model);
            return Ok(new ResutModel<OutZBCom>
            {
                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }



        /// <summary>
        /// 历史指标数据接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetHisZB")]
        public async Task<IActionResult> GetHisZB([FromForm] InZBHis model)
        {
            var data = await comService.GetZBHisData(model);
            return Ok(new ResutModel<OutZBHis>
            {
                data = data,
                errorCode = 0,
                errorMsg = ""
            });
       }















    }

}
