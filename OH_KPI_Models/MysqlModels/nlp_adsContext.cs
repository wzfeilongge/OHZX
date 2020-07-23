

using System.Data;

namespace OH_KPI_Models.MysqlModels
{
    public partial class nlp_adsContext 
    {
        public nlp_adsContext()
        {


        }


        public static IDbConnection Db
        {
            get
            {
                //创建单一实例
                MyDapperHelper.GetInstance();
                return MyDapperHelper.OpenCurrentDbConnection();
            }
        }





    }
}
