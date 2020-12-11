using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlan.Models
{
    public interface IReport
    {
        string User { get; set; }
        string Branch { get; set; }

        string TemplateId { get; set; }


    }
}
