using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OH_KPI_Application.ComDto;
using OH_KPI_Common;
using OH_KPI_IRepository.MSBaseRepository;
using OH_KPI_IServices.ComServices;
using OH_KPI_Models.MSModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_Services.ComServices
{
    public class ComService : IComService
    {
        private readonly IOHZBRepository ohSetRepository;

        private readonly ILogger<ComService> _logger;

        public ComService(IOHZBRepository ohSetRepository, ILogger<ComService> logger)
        {
            this.ohSetRepository = ohSetRepository;
            _logger = logger;
        }


        public async Task<OutMQuery> GetComZBList(InMQuery model)
        {
            OutMQuery outMQuery = new OutMQuery
            {
                Body = new List<OutMQuery_Body>(),
                Head = new List<OutMQuery_Head>()
            };

            var Head = new List<OutMQuery_Head>();
            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");
            outMQuery.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            Head.Add(new OutMQuery_Head
            {
                Name = "指标名称"
            });
            var zb = await ohSetRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0");
            if (model == null)
            {
                string time_n = DateTime.Now.ToString("yyyy-MM");
                Head.Add(new OutMQuery_Head
                {
                    Name = $"全院{time_n}至{time_n}"
                });

                foreach (var item in zb)
                {
                    var Body = new OutMQuery_Body
                    {
                        Row = new List<OutMQuery_Row>()
                    };
                    var type = item.Type;
                    var formula = item.Formula;
                    string[] array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                    DataTable dt = new DataTable();
                    Body.Row.Add(new OutMQuery_Row
                    {
                        val = item.Zbmc
                    });
                    Body.Type = item.Type.ToString();
                    string re = string.Empty;
                    for (int i = 0; i < array.Length; i++)
                    {
                        re = await ohSetRepository.GetZBList(time_n, time_n, array[i].ToString());
                        formula = formula.Replace("'" + array[i].ToString() + "'", re);
                    }
                    var ret = double.Parse(dt.Compute(formula, "false").ToString()).ToString("0.##");

                    Body.Row.Add(new OutMQuery_Row
                    {
                        val = ret
                    });
                    outMQuery.Body.Add(Body);
                }
            }
            else
            {
                var table = string.Empty;
                var type_c = string.Empty;
                foreach (var item in model.Info)
                {

                    switch (item.Type)
                    {
                        case "bm":
                            table = "OH_CBXX";
                            break;
                        case "lx":
                            table = "OH_AJLX";
                            break;
                        case "xz":
                            table = "OH_AJXZ";
                            break;
                        case "ay":
                            table = "OH_AY";
                            break;
                        case "cbr":
                            table = "OH_CBXX";
                            break;
                        case "qt":
                            table = "";
                            break;
                    }


                    if (string.IsNullOrEmpty(table))
                    {
                        Head.Add(new OutMQuery_Head
                        {
                            Name = $"全院{item.StartTime}至{item.EndTime}"
                        });
                    }
                    else
                    {
                        var name = await ohSetRepository.QueryFirstOrDefaultAsync<dynamic>($"select name from {table} where Id=@Id", new
                        {

                            Id = item.Data.ToString()
                        });
                        _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
                        Head.Add(new OutMQuery_Head
                        {
                            Name = $"{name}  {item.StartTime}至{item.EndTime}"
                        });
                    }
                }

                foreach (var item in zb)
                {
                    var Body = new OutMQuery_Body
                    {
                        Row = new List<OutMQuery_Row>()
                    };
                    var type = item.Type;
                    var formula = item.Formula;
                    string[] array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                    DataTable dt = new DataTable();
                    Body.Row.Add(new OutMQuery_Row
                    {
                        val = item.Zbmc
                    });
                    Body.Type = item.Type.ToString();
                    string re = string.Empty;
                    for (int k = 0; k < model.Info.Count; k++)
                    {
                        switch (model.Info[k].Type)
                        {

                            case "bm":
                                type_c = "1";
                                break;
                            case "lx":
                                type_c = "2";
                                break;
                            case "xz":
                                type_c = "3";
                                break;
                            case "ay":
                                type_c = "4";
                                break;
                            case "cbr":
                                type_c = "5";
                                break;
                            case "qt":
                                type_c = "0";
                                break;
                        }
                        for (int h = 0; h < array.Length; h++)
                        {
                            re = await ohSetRepository.GetComList(model.Info[k].StartTime, model.Info[k].EndTime, array[h].ToString(), type_c, model.Info[k].Data);
                            formula = formula.Replace("'" + array[h].ToString() + "'", re);
                        }
                        var Ret = double.Parse(dt.Compute(formula, "false").ToString()).ToString("0.##");
                        Body.Row.Add(new OutMQuery_Row
                        {
                            val = Ret
                        });
                        outMQuery.Body.Add(Body);
                    }
                }
            }

            outMQuery.Head = Head;
            return outMQuery;
        }

        public async Task<OutZBCom> GetZBComData(InZBCom model)
        {
            OutZBCom outZBCom = new OutZBCom
            {
                Head = new List<OutZBCom_Head>(),
                Body = new List<OutZBCom_Body>()
            };

            var Head = new List<OutZBCom_Head>();

            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");

            outZBCom.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");

            Head.Add(new OutZBCom_Head
            {
                Name = "名称"
            });


            if (model.Info == null || model.ZB == null)
            {
                return new OutZBCom();
            }

            foreach (var item in model.ZB)
            {
                Head.Add(new OutZBCom_Head
                {
                    Name = $"{item.Name}  {item.StartTime} 至  {item.EndTime}"
                });
            }

            DataTable dt = new DataTable();
            for (int i = 0; i < model.Info.Count; i++)
            {
                string table = string.Empty;
                string type_c = string.Empty;
                string re_n = string.Empty;
                switch (model.Info[i].Type)
                {
                    case "bm":
                        table = "OH_CBXX";
                        type_c = "1";
                        break;
                    case "lx":
                        table = "OH_AJLX";
                        type_c = "2";
                        break;
                    case "xz":
                        table = "OH_AJXZ";
                        type_c = "3";
                        break;
                    case "ay":
                        table = "OH_AY";
                        type_c = "4";
                        break;
                    case "cbr":
                        table = "OH_CBXX";
                        type_c = "5";
                        break;
                    case "qt":
                        re_n = "全院";
                        table = "";
                        type_c = "0";
                        break;
                }

                if (table != "")
                {
                    var name = await ohSetRepository.QueryFirstOrDefaultAsync<dynamic>($"select name from {table} where Id=@Id", new
                    {
                        Id = model.Info[i].Data.ToString()
                    });
                    _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
                    Head.Add(new OutZBCom_Head
                    {
                        Name = name
                    });
                }
                for (int j = 0; j < model.ZB.Count; j++)
                {

                    var zbdata = await ohSetRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0 and ID=@ID", new
                    {
                        ID = model.ZB[j].ID
                    });

                    foreach (var item in zbdata)
                    {
                        var Body = new OutZBCom_Body
                        {
                            Row = new List<OutZBCom_Row>()
                        };
                        var array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();

                        for (int h = 0; h < array.Length; h++)
                        {
                            var re = await ohSetRepository.GetComList(model.ZB[j].StartTime, model.ZB[j].EndTime, array[h].ToString(), type_c, model.Info[i].Data);
                            item.Formula = item.Formula.Replace("'" + array[h].ToString() + "'", re);
                        }
                        var Ret = double.Parse(dt.Compute(item.Formula, "false").ToString()).ToString("0.##");

                        Body.Row.Add(new OutZBCom_Row
                        {
                            val = Ret
                        });
                        outZBCom.Body.Add(Body);
                    }
                }
            }
            outZBCom.Head = Head;
            return outZBCom;
        }

        public async Task<OutZBHis> GetZBHisData(InZBHis model)
        {
            OutZBHis outZBHis = new OutZBHis
            {
                Body = new List<OutZBHis_Body>(),
                Head = new List<OutZBHis_Head>()
            };
            var Head = new List<OutZBHis_Head>();
            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");
            outZBHis.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            Head.Add(new OutZBHis_Head
            {
                Name = "时间"
            });
            if (model.Info == null)
            {
                return new OutZBHis();
            }

            for (int k = 0; k < model.Info.Count; k++)
            {
              var  re_n = await ohSetRepository.QueryFirstOrDefaultAsync<dynamic>("select name from OH_CBXX where ID=@Id",new {Id= model.Info[k].Data.ToString() });
                Head.Add(new OutZBHis_Head
                {
                    Name = re_n +model.Name
                });

                _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
            }

            DataTable dt = new DataTable();

            var zbdata = await ohSetRepository.QueryFirstOrDefaultAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0 and ID=@Id", new { Id=model.ID});


            var array= Method.GetInteger(zbdata.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();

            string time = Method.GetHisDate();

            HisTime adl = JsonConvert.DeserializeObject<HisTime>(time);

            for (int i = 0; i < adl.Info.Count; i++)
            {
                var Body = new OutZBHis_Body
                {
                    Row = new List<OutZBHis_Row>()
                };
                Body.Row.Add(new OutZBHis_Row
                {
                    val = adl.Info[i].Name
                }) ;

                var type_c = string.Empty;
                for (int k = 0; k < model.Info.Count; k++)
                {
                    switch (model.Info[k].Type)
                    {
                        case "bm":
                            type_c = "1";
                            break;
                        case "cbr":
                            type_c = "5";
                            break;
                    }

                    for (int h = 0; h < array.Length; h++)
                    {
                       var re = await ohSetRepository.GetComList(adl.Info[i].StartTime, adl.Info[i].EndTime, array[h].ToString(), type_c, model.Info[k].Data);
                       zbdata.Formula = zbdata.Formula.Replace("'" + array[h].ToString() + "'", re);
                    }

                   var  Ret = double.Parse(dt.Compute(zbdata.Formula, "false").ToString()).ToString("0.##");
                    Body.Row.Add(new OutZBHis_Row
                    {
                        val = Ret
                    });
                }
                outZBHis.Body.Add(Body);
            }
            outZBHis.Head = Head;
            return outZBHis;
        }
    }
}
