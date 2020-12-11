
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartup(typeof(BudgetPlan.Startup))]

namespace BudgetPlan
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var options = new SQLiteStorageOptions();
            //GlobalConfiguration.Configuration.UseSQLiteStorage("SQLiteConnection", options);

            //var option = new BackgroundJobServerOptions
            //{
            //    WorkerCount = Environment.ProcessorCount * 4
            //};

            //app.UseHangfireServer(option); 
            //app.UseHangfireDashboard();
            //app.UseHangfireServer();

        }
    }
}