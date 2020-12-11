using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPlan.Models
{
    public class EntriesReport : IReport
    {
        public string User { get; set; }
        public string Branch { get; set; }
        public string TemplateId { get; set; }
        public string PlanId { get; set; }
    }
}