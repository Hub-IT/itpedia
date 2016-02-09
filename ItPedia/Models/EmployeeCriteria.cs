using System.Collections.Generic;
using System.Linq;

namespace ItPedia.Models
{
    public class EmployeeCriteria
    {
        public virtual int EmployeeCriteriaId { get; set; }
        public virtual string Size { get; set; }

        public virtual List<CustomerCriteria> CustomerCriterias { get; set; }
//        public virtual List<IndustryCriteria> IndustryCriterias { get; set; }
    }
}