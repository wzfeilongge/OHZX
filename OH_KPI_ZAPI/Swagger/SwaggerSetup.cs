﻿using log4net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OH_KPI_ZAPI.Filter;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;

namespace OH_KPI_ZAPI.Swagger
{
    public static class SwaggerSetup
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(GlobalExceptionsFilter));


        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var basePath = AppContext.BaseDirectory;

            var Version = "OHKPIProject";

            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc(Version, new OpenApiInfo
                {
                    Version = Version,
                    Title = "OH_KPIProject 接口文档-NetCore3.1",
                    Description = Version,
                });
                option.OrderActionsBy(x => x.RelativePath);

                try
                {
                    //就是这里
                    var xmlPath = Path.Combine(basePath, "OH_KPI_ZAPI.xml");//这个就是刚刚配置的xml文件名
                    option.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，记得修改

                    var DtoModelPath = Path.Combine(basePath, "OH_KPI_Application.xml");
                    option.IncludeXmlComments(DtoModelPath);
                }
                catch (Exception ex)
                {
                    log.Error($"OH_KPI_ZAPI.xml 丢失，请检查并拷贝。\n" + ex.Message);
                }

                // 开启加权小锁
                option.OperationFilter<AddResponseHeadersFilter>();
                option.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                // 在header中添加token，传递到后台
                option.OperationFilter<SecurityRequirementsOperationFilter>();
                option.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = ParameterLocation.Header,//jwt默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });
            });
        }
    }
}
