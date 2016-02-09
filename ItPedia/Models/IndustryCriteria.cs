using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace ItPedia.Models
{
    public class IndustryCriteria
    {
        public virtual int IndustryCriteriaId { get; set; }
        public virtual string Name { get; set; }

        public virtual List<EmployeeCriteria>  EmployeeCriterias { get; set; }
    }
}