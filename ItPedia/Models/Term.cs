using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using ItPedia.Models.Contexts;

namespace ItPedia.Models
{
    public class Term
    {
        public virtual int TermId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Source { get; set; }
        public virtual string Content { get; set; }

        public static List<SyndicationItem> GetSyndicationList()
        {
            var db = new ItPediaDbContext();

            var terms = db.Terms;

            var syndicationItems = new List<SyndicationItem>();

            foreach (var term in terms)
            {
                syndicationItems.Add(
                    new SyndicationItem(
                        term.Name,
                        string.Join(" ", term.Content),
                        new Uri(term.Source))
                    );
            }

            return syndicationItems.ToList();
        }
    }
}