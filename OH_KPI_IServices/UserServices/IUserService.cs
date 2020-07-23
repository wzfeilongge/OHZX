using OH_KPI_Application.UserDTO;
using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IServices.UserServices
{
    public interface IUserService
    {


        Task<Sysuser1> Login(LoginModel loginModel);






    }
}
