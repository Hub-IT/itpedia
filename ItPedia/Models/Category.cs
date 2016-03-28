using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItPedia.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public virtual string Name { get; set; }

        public virtual List<Proposal> Proposals { get; set; }
    }
}