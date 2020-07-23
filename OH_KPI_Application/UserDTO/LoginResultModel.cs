using System;
using System.Collections.Generic;
using System.Text;

namespace OH_KPI_Application.UserDTO
{
    public class LoginResultModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public bool IsAdmin { get; set; }
    }
}
