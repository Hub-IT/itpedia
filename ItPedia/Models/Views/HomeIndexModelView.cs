using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItPedia.Models.Views
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