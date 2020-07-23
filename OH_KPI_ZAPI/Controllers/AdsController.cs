using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OH_KPI_Application;
using OH_KPI_Application.ResultMessage;
using OH_KPI_IServices.AdsServices;

namespace OH_KPI_ZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly IAdsService _adsService;


        public AdsController(IAdsService adsService)
        {
            _adsService = adsService;
        }


        /// <summary>
        /// 首页全院指标数据接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetZBList")]
        public async Task<IActionResult> GetZBList([FromForm] InZBData model)
        {
            var data = await _adsService.GetZBList(model);

            return Ok(new ResultMessage<string>
            {

                Data = JsonSerializer.Serialize(data),
                ErrorCode = 0,
                ErrorMsg = ""
            });
        }

        /// <summary>
        /// excel导出接口（公共接口）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetExcel")]
        public async Task<IActionResult> GetExcel([FromForm] InExcel model)
        {
            var data = await _adsService.GetExcel(model);
            return Ok(new ResultMessage<string>
            {
                Data = data,
                ErrorCode = string.IsNullOrWhiteSpace(data) ? 3 : 0,
                ErrorMsg = string.IsNullOrWhiteSpace(data) ? "提示:Excel文件生成失败,请联系管理员！" : ""
            });
        }

        /// <summary>
        /// 获取所有指标接口（公共接口）
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetZB")]
        public async Task<IActionResult> GetZB()
        {
            var data = await _adsService.GetAllZB();
            return Ok(new ResultMessage<OutZB>
            {
                Data = data,
                ErrorCode = data == null ? 4 : 0,
                ErrorMsg = (data) == null ? "提示:获取指标数据失败,请联系管理员！" : ""
            });
        }



        /// <summary>
        /// 获取承办信息接口（公共接口）
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetCBInfo")]
        public async Task<IActionResult> GetCBInfo()
        {

            var data = await _adsService.GetAllCB();
            return Ok(new ResultMessage<OutCB>
            {
                Data = data,
                ErrorMsg = "",
                ErrorCode = 0
            });
        }


        /// <summary>
        /// 条件筛选数据接口（公共接口）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("GetSelect")]
        public async Task<IActionResult> GetSelect([FromForm] InSelect model)
        {
            var data = await _adsService.GetSelectDate(model);
            return Ok(new ResultMessage<OutSelect>
            {
                Data = data,
                ErrorMsg = "",
                ErrorCode = 0
            });
        }
    }
}
