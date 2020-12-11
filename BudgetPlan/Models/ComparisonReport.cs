using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPlan.Models
{
    public class ComparisonReport : IReport
    {
        public string User { get; set; }
        public string Branch { get; set; }
        public string TemplateId { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string CustomerView { get; set; }

        public string CustomerGroup { get; set; }

    }
}