using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OH_KPI_Common
{
    public class Method
    {
        #region 从字符串中取出'整数',返回数组
        public static string GetInteger(string formula)
        {
            string r = @"(?<=')([0-9]+)(?=')";
            string re = "";
            Regex reg = new Regex(r, RegexOptions.IgnoreCase | RegexOptions.Singleline, TimeSpan.FromSeconds(2));//2秒后超时
            MatchCollection mc = reg.Matches(formula);//传入的字符串
            foreach (Match m in mc)
            {
                re = re + m.Groups[0].Value + ",";
            }
            return re.TrimEnd(',');
        }
        #endregion

        #region 获得同比日期
        public static string GetTB(string s, string e)
        {
            if (s != "" && e != "")
            {
                DateTime starttime = DateTime.Parse(s);
                DateTime endtime = DateTime.Parse(e);

                if (starttime.Year >= 2001)
                {
                    return starttime.AddYears(-1).ToString("yyyy-MM") + "," + endtime.AddYears(-1).ToString("yyyy-MM");
                }
            }
            return "";
        }
        #endregion

        #region 获得环比日期
        public static string GetHB(string s, string e)
        {
            if (s != "" && e != "")
            {
                DateTime starttime = DateTime.Parse(s);
                DateTime endtime = DateTime.Parse(e);
                if (starttime.AddMonths(-1).Year >= 2000)
                {
                    if (s == e)
                    {
                        return starttime.AddMonths(-1).ToString("yyyy-MM") + "," + starttime.AddMonths(-1).ToString("yyyy-MM");
                    }
                    else
                    {
                        int totalmonth = endtime.Year * 12 + endtime.Month - starttime.Year * 12 - starttime.Month;
                        endtime = starttime.AddMonths(-1);
                        starttime = endtime.AddMonths(-totalmonth);

                        if (starttime.Year >= 2000)
                        {
                            return starttime.ToString("yyyy-MM") + "," + endtime.ToString("yyyy-MM");
                        }
                    }
                }
            }
            return "";
        }
        #endregion

        #region 获得日期（历史数据页面）
        public static string GetHisDate()
        {
            DateTime dt = DateTime.Now;
            int y2 = dt.AddYears(-1).Year;
            string y = dt.Year.ToString();
            int i;
            string con = "{\"Info\":[";
            string mame, starttime, endtime;
            for (i = 0; i < dt.Month; i++)
            {
                mame = y + "年01月-" + dt.AddMonths(-i).ToString("MM") + "月";
                starttime = y + "-01";
                endtime = y + "-" + dt.AddMonths(-i).ToString("MM");
                con = con + "{\"Name\":\"" + mame + "\",\"StartTime\":\"" + starttime + "\",\"EndTime\":\"" + endtime + "\"},";
            }
            if (y2 >= 2000)
            {
                for (int j = 0; j < dt.Month; j++)
                {
                    mame = y2.ToString() + "年01月-" + dt.AddMonths(-j).ToString("MM") + "月";
                    starttime = y2.ToString() + "-01";
                    endtime = y2.ToString() + "-" + dt.AddMonths(-j).ToString("MM");
                    con = con + "{\"Name\":\"" + mame + "\",\"StartTime\":\"" + starttime + "\",\"EndTime\":\"" + endtime + "\"},";
                }
            }
            con = con.TrimEnd(',') + "]}";
            return con;
        }
        #endregion


        #region 获得月末日期
        public static string GetDaysByMonth(string e)
        {
            DateTime dt = DateTime.Parse(e);
            DateTime endMonth = dt.AddMonths(1).AddDays(-1);  //本月月末
            return endMonth.ToString("yyyyMMdd");
        }
        #endregion

    }
}
