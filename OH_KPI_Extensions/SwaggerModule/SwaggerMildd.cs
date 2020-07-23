using log4net;
using Microsoft.AspNetCore.Builder;
using System;
using System.IO;
using System.Linq;

namespace WZ.Report.Extensions.SwaggerModule
{
   public static class SwaggerMildd
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SwaggerMildd));


        public static void UseSwaggerMildd(this IApplicationBuilder app, Func<Stream> streamHtml)
        {

            if (app == null) throw new ArgumentNullException(nameof(app));


            app.UseSwagger();


            string version = "OHKPIProject";

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $" {version}");

                c.RoutePrefix = ""; //路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，去

            });













        }
















        }
}
