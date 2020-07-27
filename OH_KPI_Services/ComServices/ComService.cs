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
        private readonly ILogger<ComService> _logger;
        private readonly IOHZBRepository ohSetRepository;
        public ComService(IOHZBRepository ohSetRepository, ILogger<ComService> logger)
        {
            this.ohSetRepository = ohSetRepository;
            _logger = logger;
        }


        public async Task<OutMQuery> GetComZbList(InMQuery model)
        {
            var outMQuery = new OutMQuery
            {
                Body = new List<OutMQuery_Body>(),
                Head = new List<OutMQuery_Head>()
            };

            var head = new List<OutMQuery_Head>();
            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");
            outMQuery.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            head.Add(new OutMQuery_Head
            {
                Name = "指标名称"
            });
            var zb = await ohSetRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0");
            if (model == null)
            {
                var timeN = DateTime.Now.ToString("yyyy-MM");
                head.Add(new OutMQuery_Head
                {
                    Name = $"全院{timeN}至{timeN}"
                });

                foreach (var item in zb)
                {
                    var Body = new OutMQuery_Body
                    {
                        Row = new List<OutMQuery_Row>()
                    };
                    var type = item.Type;
                    var formula = item.Formula;
                    var array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                    var dt = new DataTable();
                    Body.Row.Add(new OutMQuery_Row
                    {
                        val = item.Zbmc
                    });
                    Body.Type = item.Type.ToString();
                    foreach (var t in array)
                    {
                        var re = await ohSetRepository.GetZBList(timeN, timeN, t.ToString());
                        formula = formula.Replace("'" + t.ToString() + "'", re);
                    }
                    var ret = double.Parse(dt.Compute(formula, "false").ToString() ?? string.Empty).ToString("0.##");

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
                    table = item.Type switch
                    {
                        "bm" => "OH_CBXX",
                        "lx" => "OH_AJLX",
                        "xz" => "OH_AJXZ",
                        "ay" => "OH_AY",
                        "cbr" => "OH_CBXX",
                        "qt" => "",
                        _ => table
                    };

                    if (string.IsNullOrEmpty(table))
                    {
                        head.Add(new OutMQuery_Head
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
                        head.Add(new OutMQuery_Head
                        {
                            Name = $"{name}  {item.StartTime}至{item.EndTime}"
                        });
                    }
                }

                foreach (var item in zb)
                {
                    var body = new OutMQuery_Body
                    {
                        Row = new List<OutMQuery_Row>()
                    };
                    var formula = item.Formula;
                    var array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                    var dt = new DataTable();
                    body.Row.Add(new OutMQuery_Row
                    {
                        val = item.Zbmc
                    });
                    body.Type = item.Type.ToString();
                    foreach (var t in model.Info)
                    {
                        type_c = t.Type switch
                        {
                            "bm" => "1",
                            "lx" => "2",
                            "xz" => "3",
                            "ay" => "4",
                            "cbr" => "5",
                            "qt" => "0",
                            _ => type_c
                        };
                        foreach (var t1 in array)
                        {
                            var re = await ohSetRepository.GetComList(t.StartTime, t.EndTime, t1, type_c, t.Data);
                            formula = formula.Replace("'" + t1 + "'", re);
                        }
                        var ret = double.Parse(dt.Compute(formula, "false").ToString() ?? string.Empty).ToString("0.##");
                        body.Row.Add(new OutMQuery_Row
                        {
                            val = ret
                        });
                        outMQuery.Body.Add(body);
                    }
                }
            }

            outMQuery.Head = head;
            return outMQuery;
        }

        public async Task<OutZBCom> GetZbComData(InZBCom model)
        {
            var outZbCom = new OutZBCom
            {
                Head = new List<OutZBCom_Head>(),
                Body = new List<OutZBCom_Body>()
            };

            var head = new List<OutZBCom_Head>();

            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");

            outZbCom.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");

            head.Add(new OutZBCom_Head
            {
                Name = "名称"
            });


            if (model.Info == null || model.ZB == null)
            {
                return new OutZBCom();
            }

            head.AddRange(model.ZB.Select(item => new OutZBCom_Head { Name = $"{item.Name}  {item.StartTime} 至  {item.EndTime}" }));

            var dt = new DataTable();
            var typeC = string.Empty;
            foreach (var t in model.Info)
            {
                var table = string.Empty;
                switch (t.Type)
                {
                    case "bm":
                        table = "OH_CBXX";
                        typeC = "1";
                        break;
                    case "lx":
                        table = "OH_AJLX";
                        typeC = "2";
                        break;
                    case "xz":
                        table = "OH_AJXZ";
                        typeC = "3";
                        break;
                    case "ay":
                        table = "OH_AY";
                        typeC = "4";
                        break;
                    case "cbr":
                        table = "OH_CBXX";
                        typeC = "5";
                        break;
                    case "qt":
                        table = "";
                        typeC = "0";
                        break;
                }

                if (table != "")
                {
                    var name = await ohSetRepository.QueryFirstOrDefaultAsync<dynamic>($"select name from {table} where Id=@Id", new
                    {
                        Id = t.Data.ToString()
                    });
                    _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
                    head.Add(new OutZBCom_Head
                    {
                        Name = name
                    });
                }
                foreach (var t1 in model.ZB)
                {
                    var databag = await ohSetRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0 and ID=@ID", new
                    {
                        t1.ID
                    });

                    foreach (var item in databag)
                    {
                        var Body = new OutZBCom_Body
                        {
                            Row = new List<OutZBCom_Row>()
                        };
                        var array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();

                        foreach (var t2 in array)
                        {
                            var re = await ohSetRepository.GetComList(t1.StartTime, t1.EndTime, t2.ToString(), typeC, t.Data);
                            item.Formula = item.Formula.Replace("'" + t2.ToString() + "'", re);
                        }
                        var Ret = double.Parse(dt.Compute(item.Formula, "false").ToString() ?? string.Empty).ToString("0.##");

                        Body.Row.Add(new OutZBCom_Row
                        {
                            val = Ret
                        });
                        outZbCom.Body.Add(Body);
                    }
                }
            }
            outZbCom.Head = head;
            return outZbCom;
        }

        public async Task<OutZBHis> GetZbHisData(InZBHis model)
        {
            var outZbHis = new OutZBHis
            {
                Body = new List<OutZBHis_Body>(),
                Head = new List<OutZBHis_Head>()
            };
            var head = new List<OutZBHis_Head>();
            var data = await ohSetRepository.QueryFirstOrDefaultAsync<OhSet>("select * from OH_Set");
            outZbHis.UpdateTime = data.UpdateTime.ToString("yyyy-MM-dd HH:mm");
            head.Add(new OutZBHis_Head
            {
                Name = "时间"
            });
            if (model.Info == null)
            {
                return new OutZBHis();
            }

            foreach (var t in model.Info)
            {
                var reN = await ohSetRepository.QueryFirstOrDefaultAsync<dynamic>("select name from OH_CBXX where ID=@Id", new { Id = t.Data.ToString() });
                head.Add(new OutZBHis_Head
                {
                    Name = reN + model.Name
                });

                _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");
            }

            var dt = new DataTable();

            var databag = await ohSetRepository.QueryFirstOrDefaultAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0 and ID=@Id", new { Id = model.ID });


            var array = Method.GetInteger(databag.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();

            var time = Method.GetHisDate();

            var adl = JsonConvert.DeserializeObject<HisTime>(time);

            foreach (var t in adl.Info)
            {
                var body = new OutZBHis_Body
                {
                    Row = new List<OutZBHis_Row>()
                };
                body.Row.Add(new OutZBHis_Row
                {
                    val = t.Name
                });

                var typeC = string.Empty;
                foreach (var t1 in model.Info)
                {
                    typeC = t1.Type switch
                    {
                        "bm" => "1",
                        "cbr" => "5",
                        _ => typeC
                    };

                    foreach (var t2 in array)
                    {
                        var re = await ohSetRepository.GetComList(t.StartTime, t.EndTime, t2.ToString(), typeC, t1.Data);
                        databag.Formula = databag.Formula.Replace("'" + t2.ToString() + "'", re);
                    }

                    var ret = double.Parse(dt.Compute(databag.Formula, "false").ToString() ?? string.Empty).ToString("0.##");
                    body.Row.Add(new OutZBHis_Row
                    {
                        val = ret
                    });
                }
                outZbHis.Body.Add(body);
            }
            outZbHis.Head = head;
            return outZbHis;
        }
    }
}
