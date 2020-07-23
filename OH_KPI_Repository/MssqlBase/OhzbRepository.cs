using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OH_KPI_IRepository.MSBaseRepository;
using OH_KPI_Models.MSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OH_KPI_Repository.MssqlBase
{
    public class OhzbRepository : MsBaseRepository<OhZb>, IOHZBRepository
    {

        public OhzbRepository(ILogger<OhzbRepository> _logger)
        {
            this._logger = _logger;
        }

        private readonly ILogger<OhzbRepository> _logger;

        public async  Task<string> GetComList(string starttime, string endtime, string id, string type, string code)
        {


            DateTime dt_s = DateTime.Parse(starttime);
            DateTime dt_e = DateTime.Parse(endtime); ;
            int y_s = int.Parse(dt_s.ToString("yyyy"));
            string m_s = dt_s.ToString("MM");
            int y_e = int.Parse(dt_e.ToString("yyyy"));
            string m_e = dt_e.ToString("MM");

            StringBuilder strSql = new StringBuilder();

            if (y_s == y_e)
            {
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_s + " where Month  between " + m_s + " and " + m_e + " and ZBID=" + id + " and Type=" + type + " and Code=" + code);
            }
            else
            {
                strSql.Append("select sum(re) as re from(");
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_e + " where Month <=" + m_e + " and ZBID = " + id + " and Type=" + type + " and Code=" + code);
                strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + y_s + " where Month >=" + m_s + " and ZBID = " + id + " and Type=" + type + " and Code=" + code);
                for (int i = 1; i < y_e - y_s; i++)
                {
                    strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + (y_s + i) + " where ZBID = " + id + " and Type=" + type + " and Code=" + code);
                }
                strSql.Append(") c");
            }
      
            var data = (await base.QueryAsync<dynamic>(sql: strSql.ToString())).ToList();

            _logger.LogWarning($"sql 语句返回 dynamic {strSql}  {JsonConvert.SerializeObject(data)}");
            if (data.Count() > 0)
            {

                return data[0].re;
            }
            return string.Empty;
        }

        public  async Task<string> GetDepartList(string starttime, string endtime, string id, string code)
        {

            DateTime dt_s = DateTime.Parse(starttime);
            DateTime dt_e = DateTime.Parse(endtime); ;
            int y_s = int.Parse(dt_s.ToString("yyyy"));
            string m_s = dt_s.ToString("MM");
            int y_e = int.Parse(dt_e.ToString("yyyy"));
            string m_e = dt_e.ToString("MM");

            StringBuilder strSql = new StringBuilder();

            if (y_s == y_e)
            {
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_s + " where Month  between " + m_s + " and " + m_e + " and ZBID=" + id + " and Type=1 and Code=" + code);
            }
            else
            {
                strSql.Append("select sum(re) as re from(");
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_e + " where Month <=" + m_e + " and ZBID = " + id + " and Type=1 and Code=" + code);
                strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + y_s + " where Month >=" + m_s + " and ZBID = " + id + " and Type=1 and Code=" + code);
                for (int i = 1; i < y_e - y_s; i++)
                {
                    strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + (y_s + i) + " where ZBID = " + id + " and Type=1 and Code=" + code);
                }
                strSql.Append(") c");
            }

            var data = (await base.QueryAsync<dynamic>(sql: strSql.ToString())).ToList();

            _logger.LogWarning($"sql 语句返回 dynamic {strSql}  {JsonConvert.SerializeObject(data)}");


            if (data.Count() > 0)
            {

                return data[0].re;
            }
            return string.Empty;






         //   throw new NotImplementedException();
        }

        //得到下级指标数据（首页）
        public async Task<string> GetZBList(string starttime, string endtime, string id)
        {
            DateTime dt_s = DateTime.Parse(starttime);
            DateTime dt_e = DateTime.Parse(endtime); ;
            int y_s = int.Parse(dt_s.ToString("yyyy"));
            string m_s = dt_s.ToString("MM");
            int y_e = int.Parse(dt_e.ToString("yyyy"));
            string m_e = dt_e.ToString("MM");

            StringBuilder strSql = new StringBuilder();

            if (y_s == y_e)
            {
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_s + " where Type=0 and Month  between " + m_s + " and " + m_e + " and ZBID=" + id);
            }
            else
            {
                strSql.Append("select sum(re) as re from(");
                strSql.Append("select sum(Data) as re from OH_ZBJL_" + y_e + " where Type=0 and Month <=" + m_e + " and ZBID = " + id);
                strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + y_s + " where Type=0 and Month >=" + m_s + " and ZBID = " + id);
                for (int i = 1; i < y_e - y_s; i++)
                {
                    strSql.Append(" union all select sum(Data) as re from OH_ZBJL_" + (y_s + i) + " where Type=0 and ZBID = " + id);
                }
                strSql.Append(") c");
            }
            var data = (await base.QueryAsync<dynamic>(sql: strSql.ToString())).ToList();

            _logger.LogWarning($"sql 语句返回 dynamic {strSql}  {JsonConvert.SerializeObject(data)}");
            if (data.Count() > 0)
            {

                return data[0].re;
            }
            return string.Empty;

           
        }

        public  async Task<string> GetZBMC(string ID)
        {

            var data = await base.QueryFirstOrDefaultAsync<OhZb>("Select ZBMC from OH_ZB where ID=@Id",new { Id=ID});

            if (data!=null)
            {
                return data.Zbmc;
            }
            return string.Empty;

         //   throw new NotImplementedException();
        }
    }
}
