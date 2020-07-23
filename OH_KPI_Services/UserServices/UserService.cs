using OH_KPI_Application.UserDTO;
using OH_KPI_IRepository.MyBaseRepository;
using OH_KPI_IServices.UserServices;
using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WZ.Report.Common;

namespace OH_KPI_Services.UserServices
{
    public class UserService : IUserService
    {

        public IAdsSpAj330304Repository adsSpAj330304Repository;

        public UserService(IAdsSpAj330304Repository adsSpAj330304Repository)
        {
            this.adsSpAj330304Repository = adsSpAj330304Repository;
        }




        public async Task<Sysuser1> Login(LoginModel loginModel)
        {
            loginModel.PassWord = MD5Helper.MD5Encrypt32(loginModel.PassWord);
            var domain = await adsSpAj330304Repository.QueryFirstOrDefaultAsync<Sysuser1>("select * from sysuser where IsDelete=0 AND UserName=@UserName  AND Password=@Password", new
            {
                UserName = loginModel.UserName,
                Password = loginModel.PassWord
            });
            return domain;
        }
    }
}
