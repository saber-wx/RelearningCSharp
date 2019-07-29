using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SRV;

namespace Web01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var autoMapconfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, DTOArticle>();
                //cfg.CreateMap<Bar, BarDto>();
            });
            // only during development, validate your mappings; remove it before release
            autoMapconfig.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            var mapper = autoMapconfig.CreateMapper();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //以下方法用来做依赖注入,若每次不同的类注入会重复使用
            //services.AddTransient<IRegisterService, RegisterService>();//用一次就创建一次
            //services.AddScoped<IRegisterService, RegisterService>();//一次Request中只创建一个
            //services.AddSingleton<IRegisterService, RegisterService>();//整个Application只创建一个
            //因此:将这些方法放入一个扩展方法中
            //services.AddMockService();
            services.AddScoped<DbContext, SQLContext>();

            services.AddService();
            services.AddRepository();
            services.AddHttpContextAccessor();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //使用cookie不需要用户同意，或者，注释掉app.UseCookiePolicy();
            //app.UseCookiePolicy(new CookiePolicyOptions
            //{ CheckConsentNeeded = x => false});

            //app.UseCookiePolicy();

            app.UseMvc();

           
        }


    }
}
