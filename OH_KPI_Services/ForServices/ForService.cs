using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OH_KPI_Application.ForDTO;
using OH_KPI_Common;
using OH_KPI_IRepository.MSBaseRepository;
using OH_KPI_IRepository.MyBaseRepository;
using OH_KPI_IServices.ForServices;
using OH_KPI_Models.MSModels;
using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_Services.ForServices
{
    public class ForService : IForService
    {
        private readonly IAdsSpAj330304Repository adsSpAj330304Repository;

        private readonly IOHZBRepository iOHZBRepository;

        private readonly ILogger<ForService> _logger;

        public ForService(IOHZBRepository iOHZBRepository, IAdsSpAj330304Repository adsSpAj330304Repository, ILogger<ForService> logger)
        {
            this.iOHZBRepository = iOHZBRepository;
            this.adsSpAj330304Repository = adsSpAj330304Repository;
            _logger = logger;
        }

        public async Task<OutCase> GetCaseList(InCase model)
        {
            OutCase outCase = new OutCase
            {
                Info = new List<OutCase_Info>()
            };
            var express_c = string.Empty;
            var data = await iOHZBRepository.QueryFirstOrDefaultAsync<OhZb>("select * from OH_ZB where CID>0 and ID=@Id", new { Id = model.ID });
            if (data != null)
            {
                express_c = data.ExpressC;
            }
            var sql = await adsSpAj330304Repository.GetCaseInfo(DateTime.Parse(model.StartTime).ToString("yyyyMM") + "01", Method.GetDaysByMonth(model.EndTime), express_c);
            var spdata = (await adsSpAj330304Repository.QueryAsync<dynamic>(sql)).ToList();

            _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
            for (int i = 0; i < spdata.Count; i++)
            {
                outCase.Info.Add(new OutCase_Info
                {

                    XH = (1 + i).ToString(),
                    AH = spdata[i].ah,
                    AY = spdata[i].ay,
                    BMMC = spdata[i].bmmc,
                    CBRMC = spdata[i].cbrmc,
                    AJLX = spdata[i].ajlx,
                    SPCX = spdata[i].spcx,
                    SARQ = spdata[i].sarq,
                    JARQ = spdata[i].jarq,
                });
            }
            return outCase;
        }

        public async Task<OutFormula> GetFormulaList(InFormula model)
        {
            OutFormula outFormula = new OutFormula
            {
                Info = new List<OutFormula_Info>()
            };
            var data = await iOHZBRepository.QueryFirstOrDefaultAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0 and ID=@Id", new { Id = model.ID });
            string starttime = model.StartTime;
            string endtime = model.EndTime;
            outFormula.QueryTime = $"{starttime}至 {endtime}";
            outFormula.StartTime = starttime;
            outFormula.EndTime = endtime;
            outFormula.Formula_c = data.FormulaC;
            var array = Method.GetInteger(data.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
            string re, zbmc, id;
            for (int i = 0; i < array.Length; i++)
            {
                id = array[i].ToString();
                re = await iOHZBRepository.GetZBList(starttime, endtime, id);
                data.Formula = data.Formula.Replace("'" + id + "'", re);
                zbmc = await iOHZBRepository.GetZBMC(id);

                outFormula.Info.Add(new OutFormula_Info
                {
                    Col = zbmc,
                    Num = re,
                    ID = id
                });
            }
            DataTable dt = new DataTable();
            string Ret = double.Parse(dt.Compute(data.Formula, "false").ToString()).ToString("0.##");
            outFormula.Info.Add(new OutFormula_Info
            {
                Col = data.Zbmc,
                Num = Ret,
                ID = string.Empty
            });
            return outFormula;
        }
    }
}
