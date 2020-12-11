using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPlan.Models
{
    public class ClienteleReport : IReport
    {
        public string User { get; set; }
        public string Branch { get; set; }

        public string TemplateId { get; set; }
        public DateTime Date { get; set; }

        public string CustomerView { get; set; }

        public string CustomerGroup { get; set; }
    }
}