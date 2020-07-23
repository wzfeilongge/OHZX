using Aspose.Cells;
using log4net.Core;
using Newtonsoft.Json;
using OH_KPI_Application;
using OH_KPI_Common;
using OH_KPI_IRepository.MSBaseRepository;
using Microsoft.Extensions.Logging;
using OH_KPI_IServices.AdsServices;
using OH_KPI_Models.MSModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZ.Report.Common;

namespace OH_KPI_Services.AdsServices
{
    public class AdsService : IAdsService
    {
        private readonly IOhSetRepository _ohSetRepository;

        private readonly IOHZBRepository _oHZBRepository;

        private readonly ILogger<AdsService> _logger;

        public AdsService(IOhSetRepository ohSetRepository, IOHZBRepository oHZBRepository, ILogger<AdsService> logger)
        {
            _ohSetRepository = ohSetRepository;
            _oHZBRepository = oHZBRepository;
            _logger = logger;
        }

        public async Task<OutCB> GetAllCB()
        {
            OutCB outCB = new OutCB
            {
                Info = new List<OutCB_Info>()
            };


            var data = await _oHZBRepository.QueryAsync<OhCbxx>("select * from OH_CBXX where IsEnable=1 and CID=0");

            foreach (var item in data)
            {
                var itemdata = await _ohSetRepository.QueryAsync<OhCbxx>("select * from OH_CBXX where IsEnable=1 and CID=@Cid", new
                {
                    Cid = item.Id
                });

                foreach (var items in itemdata)
                {

                    OutCB_Info outCB_Info = new OutCB_Info
                    {
                        CBR_Info = new List<CBR_Info>
                    {
                        new CBR_Info
                        {

                            ID = items.Id.ToString(),
                            CBRMC = items.Name
                        }
                    }
                    };
                    outCB.Info.Add(outCB_Info);
                }
            }
            return outCB;
        }

        public async Task<OutZB> GetAllZB()
        {

            OutZB outZB = new OutZB();
            outZB.Info = new List<OutZB_Info>();

            var data = await _ohSetRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0");

            foreach (var item in data)
            {
                outZB.Info.Add(new OutZB_Info
                {

                    ID = item.Id.ToString(),
                    Name = item.Zbmc.ToString()
                });
            }
            return outZB;
        }

        public async Task<string> GetExcel(InExcel rd)
        {
            string excelurl = Appsettings.app("ExcelUrl");
            //string val = "{\"Title\":\"审判执行质效评估指标数据值\",\"UpdateTime\":\"（更新时间: 2020-5-8 11:35）\",\"Info\":[{\"Head\":\"指标名称\",\"Body\":[{\"Val\":\"同期结案率\"},{\"Val\":\"收案数\"},{\"Val\":\"结案数\"},{\"Val\":\"存案数\"},{\"Val\":\"同期执结率\"},{\"Val\":\"正常审限内结案率\"},{\"Val\":\"执限内执结率\"},{\"Val\":\"民事刑事一审当庭宣判率\"},{\"Val\":\"诉前化解和民事可调撤率\"},{\"Val\":\"民事可调撤率\"},{\"Val\":\"诉前纠纷化解率\"},{\"Val\":\"民事二审可调撤率\"},{\"Val\":\"自动履行率\"},{\"Val\":\"服判息诉率\"},{\"Val\":\"有财产可供执行案件法定期限内实际执结率\"},{\"Val\":\"执行制裁违法率\"},{\"Val\":\"一审民商事案件收案数\"},{\"Val\":\"民事公告送达率\"},{\"Val\":\"民事行政案件上诉率\"},{\"Val\":\"二审改判发回瑕疵率\"},{\"Val\":\"二审改判发回率\"},{\"Val\":\"月均存案工作量\"},{\"Val\":\"12个月以上未结案数\"},{\"Val\":\"执行12个月以上未结案数\"},{\"Val\":\"无财产可供执行案件终本率\"},{\"Val\":\"执行案访比\"},{\"Val\":\"财产保全率\"},{\"Val\":\"拒执案件成案率(合理区间占比≥0.12%)\"},{\"Val\":\"员额法官人均结案数（一线法官人均结案数）\"},{\"Val\":\"人均结案数\"},{\"Val\":\"结案均衡度\"},{\"Val\":\"民事调撤率\"},{\"Val\":\"结案率\"},{\"Val\":\"执结率\"},{\"Val\":\"可能判处三年以上辩护率（合理区间＞99%）\"},{\"Val\":\"简易程序适用率\"},{\"Val\":\"首次执行案件实际执行到位率\"},{\"Val\":\"首次执行案件实际执结率\"},{\"Val\":\"首次执行案件执行完毕率\"},{\"Val\":\"执行信访办结率（合理区间＞90%）\"},{\"Val\":\"执行款发放平均天数\"},{\"Val\":\"实际执行率\"},{\"Val\":\"执行标的到位率\"},{\"Val\":\"平均审理天数\"},{\"Val\":\"申诉率\"},{\"Val\":\"申诉改判发回率\"},{\"Val\":\"庭审记录改革适用率\"},{\"Val\":\"当庭裁判率\"},{\"Val\":\"民事调解自动履行率\"},{\"Val\":\"平均执行天数\"},{\"Val\":\"网上立案率\"},{\"Val\":\"立案调撤率\"},{\"Val\":\"上诉案件平均移送天数\"},{\"Val\":\"一审普通程序陪审率\"},{\"Val\":\"庭审录像率\"},{\"Val\":\"庭审直播率\"}]},{\"Head\":\"全院\n2019-06至2020-06\",\"Body\":[{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"},{\"Val\":\"72.3\"}]}]}";
            //string val = "{\"Title\":\"审判执行质效评估指标数据值\",\"UpdateTime\":\"（更新时间: 2020-5-8 11:35）\",\"Info\":[{\"Head\":\"指标名称\",\"Body\":[{\"Val\":\"同期结案率\"},{\"Val\":\"收案数\"}]},{\"Head\":\"全院\n2019-06至2020-06\",\"Body\":[{\"Val\":\"72.3\"},{\"Val\":\"72.3\"}]}]}";
            //Excel rd = JsonConvert.DeserializeObject<Excel>(val);
            string wjid = Guid.NewGuid().ToString("N");
            string tempurl = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = tempurl + "wwwroot\\Excel\\" + wjid + ".xlsx";
            string filePath_iis = "http://" + excelurl + "/Excel/" + wjid + ".xlsx";

            Workbook book = new Workbook(); //创建工作簿
            Worksheet sheet = book.Worksheets[0]; //创建工作表
            Cells cells = sheet.Cells; //单元格

            Style style = book.CreateStyle();
            style.HorizontalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style.VerticalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style.Font.Name = "宋体"; //字体
            style.Font.IsBold = true; //设置粗体
            style.Font.Size = 10; //设置字体大小
            style.IsTextWrapped = true;

            Style style2 = book.CreateStyle();
            style2.HorizontalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style2.VerticalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style2.Font.Name = "宋体"; //字体
            style2.Font.Size = 10; //设置字体大小


            Style style3 = book.CreateStyle();
            style3.HorizontalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style3.VerticalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
            style3.Font.Name = "宋体"; //字体
            style3.Font.Size = 12; //设置字体大小
            style3.IsTextWrapped = true;



            cells.Merge(0, 0, 1, rd.Info.Count);
            cells[0, 0].PutValue(rd.Title);
            //cells[0, 0].PutValue(rd.Title + "\n" + rd.UpdateTime);
            cells[0, 0].SetStyle(style3);
            cells.SetRowHeight(0, 36); //自定义列宽

            for (int i = 0; i < rd.Info.Count; i++)
            {

                cells[1, i].PutValue(rd.Info[i].Head); //添加表头
                cells[1, i].SetStyle(style); //添加样式
                for (int k = 0; k < rd.Info[i].Body.Count; k++)
                {
                    cells[2 + k, i].PutValue(rd.Info[i].Body[k].Val); //添加数据
                    cells[2 + k, i].SetStyle(style2);
                }
            }
            //cells.SetColumnWidth(1, rd.Info[1].Head.Length * 2); //自定义列宽
            //int rowCount = cells.MaxRow;//获取表页的最大行数
            //sheet.AutoFitColumn(0, 0, rowCount);
            sheet.AutoFitColumns(); //自适应宽
            book.Save(filePath); //保存
            GC.Collect();

            return await Task.FromResult(filePath_iis);
        }

        public async Task<OutSelect> GetSelectDate(InSelect model)
        {

            OutSelect outSelect = new OutSelect
            {
                Info = new List<OutSelect_Info>()
            };
            string table = "";
            switch (model.Type)
            {
                case "lx":
                    table = "OH_AJLX";
                    break;
                case "xz":
                    table = "OH_AJXZ";
                    break;
                case "ay":
                    table = "OH_AY";
                    break;
            }
            var data = await _ohSetRepository.QueryAsync<dynamic>($"select * from {table} where IsEnable==1");

            _logger.LogWarning($"sql 语句返回 dynamic   {JsonConvert.SerializeObject(data)}");

            foreach (var item in data)
            {
                outSelect.Info.Add(new OutSelect_Info
                {

                    ID = item.Id,
                    Name = item.Name
                });
            }
            return outSelect;
        }

        public async Task<OutZBData> GetZBList(InZBData inZBData)
        {

            OutZBData outZBData = new OutZBData
            {
                Info = new List<ZXSearch>()
            };

            string starttime, endtime;
            DateTime time = DateTime.Now;
            if (inZBData.StartTime == null || inZBData.EndTime == null)
            {
                starttime = endtime = time.ToString("yyyy-MM");
            }
            else
            {
                starttime = inZBData.StartTime;
                endtime = inZBData.EndTime;
            }

            var data = await _ohSetRepository.QueryFirstOrDefaultAsync<OhSet>(@"select * from UpdateTime");

            outZBData.UpdateTime = data.UpdateTime.ToString("yyyy - MM - dd HH: mm");

            outZBData.QueryTime = $"全院{starttime}至{endtime}";

            outZBData.StartTime = starttime;

            outZBData.EndTime = endtime;

            string[] array;

            var zbdata = await _oHZBRepository.QueryAsync<OhZb>("select * from OH_ZB where IsEnable=1 and CID=0");

            string re = string.Empty;

            foreach (var item in zbdata)
            {
                ZXSearch search = new ZXSearch
                {
                    Name = item.Zbmc,
                    Type = item.Type.ToString(),
                    ID = item.Id.ToString()
                };
                string formula = item.Formula;
                array = Method.GetInteger(item.Formula).Split(",").GroupBy(p => p).Select(p => p.Key).ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    re = await _oHZBRepository.GetZBList(starttime, endtime, array[j].ToString());
                    formula = formula.Replace("'" + array[j].ToString() + "'", re);
                }
                DataTable dt = new DataTable();
                double Ret = double.Parse(dt.Compute(formula, "false").ToString());
                search.Num = Ret.ToString("0.##");
                outZBData.Info.Add(search);

            }
            return outZBData;
        }
    }
}
