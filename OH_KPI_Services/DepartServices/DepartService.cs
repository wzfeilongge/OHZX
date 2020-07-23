using OH_KPI_Application;
using OH_KPI_Application.DepartDTO;
using OH_KPI_Common;
using OH_KPI_IRepository.MSBaseRepository;
using OH_KPI_IServices.DepartServices;
using OH_KPI_Models.MSModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_Services.DepartServices
{
    public class DepartService : IDepartService
    {

        private readonly IOHZBRepository oHZBRepository;

        public DepartService(IOHZBRepository oHZBRepository)
        {
            this.oHZBRepository = oHZBRepository;
        }



        public async Task<OutDepartD> GetDepartDetail(InDepartD model)
        {
            OutDepartD outDepartD = new OutDepartD
            {
                Info = new List<OutDepartD_List>()
            };
            string formula, re, Ret, formula_t, re_t, Ret_t, formula_h, re_h, Ret_h;
            string starttime = model.StartTime;
            string endtime = model.EndTime;
            string[] array_tb = Method.GetTB(starttime, endtime).Split(",");
            string starttime_t = array_tb[0].ToString();
            string endtime_t = array_tb[1].ToString();

            string[] array_hb = Method.GetHB(starttime, endtime).Split(",");
            string starttime_h = array_hb[0].ToString();
            string endtime_h = array_hb[1].ToString();

            var ohsetdata = await oHZBRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set ");
            outDepartD.UpdateTime = ohsetdata.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            var domain = await oHZBRepository.QueryFirstOrDefaultAsync<OhCbxx>("select * from OH_CBXX where Id=@Id", new { Id = model.ID });
            outDepartD.DepartName = domain.Name;
            outDepartD.StartTime = starttime;
            outDepartD.EndTime = endtime;
            var zbdata = (await oHZBRepository.QueryAsync<OhZb>("select * from OH_ZB  where IsEnable=1 and CID=0")).ToList();

            DataTable dt = new DataTable();
            foreach (var item in zbdata)
            {
                formula_h = formula_t = formula = item.Formula;
                OutDepartD_List info = new OutDepartD_List();
                info.Name = item.Zbmc;
                info.Type = item.Type.ToString();
                var array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    //部门指标数值
                    re = await oHZBRepository.GetDepartList(starttime, endtime, array[j].ToString(), model.ID);
                    formula = formula.Replace("'" + array[j].ToString() + "'", re);


                    //同比
                    if (starttime_t != "")
                    {
                        re_t = await oHZBRepository.GetDepartList(starttime_t, endtime_t, array[j].ToString(), model.ID);
                        formula_t = formula_t.Replace("'" + array[j].ToString() + "'", re_t);
                    }

                    //环比
                    if (starttime_t != "")
                    {
                        re_h = await oHZBRepository.GetDepartList(starttime_h, endtime_h, array[j].ToString(), model.ID);
                        formula_h = formula_h.Replace("'" + array[j].ToString() + "'", re_h);
                    }
                }
                Ret = double.Parse(dt.Compute(formula, "false").ToString()).ToString("0.##");
                Ret_t = formula_t == "" ? "" : double.Parse(dt.Compute(formula_t, "false").ToString()).ToString("0.##");
                Ret_h = formula_h == "" ? "" : double.Parse(dt.Compute(formula_h, "false").ToString()).ToString("0.##");
                Ret_t = (double.Parse(Ret) / double.Parse(Ret_t) - 1).ToString("0.##");
                Ret_h = (double.Parse(Ret) / double.Parse(Ret_h) - 1).ToString("0.##");
                info.Num = Ret;
                info.TB = Ret_t;
                info.HB = Ret_h;
                outDepartD.Info.Add(info);
            }
            return outDepartD;
        }

        public async Task<OutDepart> GetDepartZBList(InDepart model)
        {
            OutDepart outDepart = new OutDepart
            {
                Head = new List<OutDepart_Head>(),
                Body = new List<OutDepart_Body>()
            };
            var Head = new List<OutDepart_Head>();
            string starttime = string.Empty;
            string endtime = string.Empty;
            DateTime time = DateTime.Now;
            if (model.StartTime == null || model.EndTime == null)
            {
                starttime = endtime = time.ToString("yyyy-MM");
            }
            else
            {
                starttime = model.StartTime;
                endtime = model.EndTime;
            }
            var ohsetdata = await oHZBRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set ");
            outDepart.UpdateTime = ohsetdata.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            outDepart.StartTime = starttime;
            outDepart.EndTime = endtime;
            var ohzb = (await oHZBRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0")).ToList();
            Head.Add(new OutDepart_Head()
            {
                ID = "",
                Name = "指标名称"
            });
            DataTable dt = new DataTable();
            for (int i = 0; i < ohzb.Count(); i++)
            {
                var Body = new OutDepart_Body()
                {
                    Row = new List<OutDepart_Row>()
                };
                Body.Type = ohzb[i].Type.ToString();
                Body.Row.Add(new OutDepart_Row
                {
                    val = ohzb[i].Zbmc
                });
                var array = Method.GetInteger(ohzb[i].Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                var bm = await oHZBRepository.QueryAsync<OhCbxx>("select * from OH_CBXX where IsEnable=1 and CID=0");
                foreach (var items in bm)
                {
                    var id = items.Id.ToString();
                    if (i == 0)
                    {
                        Head.Add(new OutDepart_Head()
                        {
                            ID = id,
                            Name = $"{items.Name}+{starttime} 至+{endtime} "
                        });
                    }
                    for (int j = 0; j < array.Length; j++)
                    {
                        var re = await oHZBRepository.GetDepartList(starttime, endtime, array[j].ToString(), id);
                        ohzb[i].Formula = ohzb[i].Formula.Replace("'" + array[j].ToString() + "'", re);
                    }
                    var Ret = double.Parse(dt.Compute(ohzb[i].Formula, "false").ToString()).ToString("0.##");
                    Body.Row.Add(new OutDepart_Row
                    {
                        val = Ret
                    });
                }
                outDepart.Body.Add(Body);
            }
            outDepart.Head = Head;
            return outDepart;
            throw new NotImplementedException();
        }
    }
}
