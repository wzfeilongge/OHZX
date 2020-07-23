using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.UserDTO
{
    public class LoginModel
    {
        /// <summary>
        /// 用户名 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码 使用用户名拼音
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 法院地址
        /// </summary>
        public string Department { get; set; }
    }
}
