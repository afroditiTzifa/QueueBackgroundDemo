using BudgetPlan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web.Hosting;
using System.Web.Script.Serialization;

namespace BudgetPlan.Services
{
    public static class ReportsService
    {
        public static void GenerateReport(IReport report)
        {
            var path = HostingEnvironment.MapPath("~/Output");
            var fullpath = Path.Combine(path, $"{report.GetType().Name}_{Guid.NewGuid()}.txt"); ;
            File.WriteAllText(fullpath, new JavaScriptSerializer().Serialize(report));

        }
    }
}