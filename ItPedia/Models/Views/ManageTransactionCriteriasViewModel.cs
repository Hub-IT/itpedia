using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ItPedia.Models.Views
{
    public class ManageTransactionCriteriasViewModel
    {
        public class Edit
        {
            public TransactionCriteria TransactionCriteria { get; set; }
            public ListBox SelectedCustomerCriteriasListBox{ get; set; }
            public IEnumerable<SelectListItem> CustomerCriteriasListBox { get; set; }
        }
    }
}