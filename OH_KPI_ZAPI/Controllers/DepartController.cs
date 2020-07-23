using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OH_KPI_Application;
using OH_KPI_Application.ComDto;
using OH_KPI_Application.DepartDTO;
using OH_KPI_IServices.DepartServices;

namespace OH_KPI_ZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartController : ControllerBase
    {

        private readonly IDepartService departService;

        public DepartController(IDepartService departService)
        {
            this.departService = departService;
        }



        /// <summary>
        /// 部门质效首页指标数据接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetDepartZBList")]
        public async Task<IActionResult> GetDepartZBList([FromForm] InDepart model)
        {
            var data = await departService.GetDepartZBList(model);
            return Ok(new ResutModel<OutDepart>
            {
                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }




        /// <summary>
        /// 详细部门质效指标数据接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetDepartDetail")]
        public async Task<IActionResult> GetDepartDetail([FromForm] InDepartD model)
        {
            var data = await departService.GetDepartDetail(model);
            return Ok(new ResutModel<OutDepartD>
            {
                data = data,
                errorCode = 0,
                errorMsg = ""
            });
        }







    }
}
