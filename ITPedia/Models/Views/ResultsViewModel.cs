using System.Collections.Generic;

namespace ITPedia.Models.Views
{
    public class ResultsViewModel
    {
        public Dictionary<Term, string> HardwareSolutions { get; set; }
        public Dictionary<Term, string> SoftwareSolutions { get; set; }
        public Dictionary<Term, string> AppSolutions { get; set; }
        public Dictionary<Term, string> NetSolutions { get; set; }
        public Dictionary<Term, string> StorageSolutions { get; set; }
        public Dictionary<Term, string> FixedCosts { get; set; }
        public Dictionary<Term, string> RecurringCosts { get; set; }
    }
}