using System.Web.Mvc;

namespace ItPedia.ViewModels
{
    public class HomeIndexModelView
    {
        public class IndexViewModel
        {
            public SelectList IndustryCriterias { get; set; }
            public SelectList EmployeeCriterias { get; set; }
            public SelectList CustomerCriterias { get; set; }
            public SelectList TransactionCriterias { get; set; }
        }

    }
}