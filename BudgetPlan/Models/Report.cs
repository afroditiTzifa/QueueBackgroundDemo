using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPlan.Models
{
    public class Report : IReport
    {
        public string User { get; set; }
        public string Branch { get; set; }
        public string TemplateId { get; set; }
        public DateTime CheckDate { get; set; }
    }
}