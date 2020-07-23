using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OH_KPI_Application;
using OH_KPI_Application.UserDTO;
using OH_KPI_IServices.UserServices;
using OH_KPI_Models.MysqlModels;

namespace OH_KPI_ZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] LoginModel loginModel)
        {
            var data = await userService.Login(loginModel);
            if (data != null)
            {
                return Ok(new ResutModel<Sysuser1>
                {
                    data = data,
                    errorCode = 0,
                    errorMsg = ""
                });
            }
            return Ok(new ResutModel<Sysuser1>
            {

                data = data,
                errorCode = 1,
                errorMsg = "500"
            });

        }
    }
}
