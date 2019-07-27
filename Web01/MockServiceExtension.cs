using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MockServiceExtension
    {
        public static void AddMockService(this IServiceCollection services)
        {
            services.AddTransient<IRegisterService, RegisterService>();//用一次就创建一次
            //services.AddScoped<IRegisterService, RegisterService>();//一次Request中只创建一个
            //services.AddSingleton<IRegisterService, RegisterService>();//整个Application只创建一个

        }
    }
}
