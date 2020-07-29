using System.Reflection;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OH_KPI_ZAPI.Filter;
using OH_KPI_ZAPI.Swagger;
using WZ.Report.Common;
using WZ.Report.Extensions.AutoFacModule;
using WZ.Report.Extensions.SwaggerModule;

namespace OH_KPI_ZAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {         
            services.AddSingleton(new Appsettings(Configuration));

            services.AddSingleton<IUser, AspNetUser>();

            services.AddControllers(o =>
            {
                o.Filters.Add(typeof(GlobalExceptionsFilter));

            }).AddNewtonsoftJson(options =>
            {
                //忽略循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //不使用驼峰样式的key
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            }); ;
            services.AddSwaggerSetup();
        }


        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModuleRegister());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDefaultFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerMildd(() => GetType().GetTypeInfo().Assembly.GetManifestResourceStream("WZ.Report.Api.html"));
            // CORS跨域
            app.UseCors("LimitRequests");
            // 使用静态文件
            app.UseStaticFiles();
            // 使用cookie
            app.UseCookiePolicy();
            // 返回错误码
            app.UseStatusCodePages();
            // 路由决策
            app.UseRouting();
            // 先开启认证
            app.UseAuthentication();
            // 然后是授权中间件
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
