﻿using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace TS1._5_VS2015RTM
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) { }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
    }
}
