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


            //���·�������������ע��,��ÿ�β�ͬ����ע����ظ�ʹ��
            //services.AddTransient<IRegisterService, RegisterService>();//��һ�ξʹ���һ��
            //services.AddScoped<IRegisterService, RegisterService>();//һ��Request��ֻ����һ��
            //services.AddSingleton<IRegisterService, RegisterService>();//����Applicationֻ����һ��
            //���:����Щ��������һ����չ������
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

            //ʹ��cookie����Ҫ�û�ͬ�⣬���ߣ�ע�͵�app.UseCookiePolicy();
            //app.UseCookiePolicy(new CookiePolicyOptions
            //{ CheckConsentNeeded = x => false});

            //app.UseCookiePolicy();

            app.UseMvc();

           
        }


    }
}
