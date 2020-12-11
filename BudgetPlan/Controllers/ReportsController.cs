using BudgetPlan.Models;
using BudgetPlan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace BudgetPlan.Controllers
{
    public class ReportsController : Controller
    {
        [HttpPost]
        [ActionName("generateReport")]
        public ActionResult GenerateReport(Report request)
        {

            HostingEnvironment.QueueBackgroundWorkItem(ct => ReportsService.GenerateReport(request));
            //BackgroundJob.Enqueue(() => ReportsService.GenerateReport(request));
            return new HttpStatusCodeResult(HttpStatusCode.OK);

        }

        [HttpPost]
        [ActionName("generatecomparisonreport")]
        public ActionResult GenerateComparisonReport(ComparisonReport request)
        {
            HostingEnvironment.QueueBackgroundWorkItem(ct => ReportsService.GenerateReport(request));
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        [ActionName("generateclientelereport")]
        public ActionResult GenerateClienteleReport(ClienteleReport request)
        {
            HostingEnvironment.QueueBackgroundWorkItem(ct => ReportsService.GenerateReport(request));
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        [ActionName("generateentriesreport")]
        public ActionResult GenerateEntriesReport(EntriesReport request)
        {
            HostingEnvironment.QueueBackgroundWorkItem(ct => ReportsService.GenerateReport(request));
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    
    }
}