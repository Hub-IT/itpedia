using System.Collections.Generic;
using System.Linq;

namespace ItPedia.Models
{
    public class EmployeeCriteria
    {
        public virtual int EmployeeCriteriaId { get; set; }
        public virtual string Size { get; set; }
       
        public virtual IndustryCriteria IndustryCriteria { get; set; }
        public virtual int IndustryCriteriaId { get; set; }

//        public static IQueryable<EmployeeCriteria> GetByIndustryCode(string industryCode)
//        {
//            return GetEmployees().Where(employee => industryCode == employee.IndustryId);
//        }
    }
}