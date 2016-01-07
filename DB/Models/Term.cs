using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls.Expressions;

namespace DB.Models
{
    public class Term
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Content { get; set; }

        public static IQueryable<Term> Get()
        {
            return Terms()
                .AsQueryable();
        }

        public static Term GetByName(string name)
        {
            return Terms().FirstOrDefault(term => name.Equals(term.Name, StringComparison.OrdinalIgnoreCase));
        }

        private static List<Term> Terms()
        {
            return new List<Term>
            {
                new Term
                {
                    Id = 1,
                    Name = "Server",
                    Content = new []{ "In information technology, a server is a computer program that provides services to other computer programs (and their users) in the same or other computers.", "The computer that a server program runs in is also frequently referred to as a server (though it may be used for other purposes as well).", "In the client/server programming model, a server is a program that awaits and fulfills requests from client programs in the same or other computers. A given application in a computer may function as a client with requests for services from other programs and also as a server of requests from other programs.", "Specific to the Web, a Web server is the computer program (housed in a computer) that serves requested HTML pages or files. A Web client is the requesting program associated with the user. The Web browser in your computer is a client that requests HTML files from Web servers." }
                },
                new Term
                {
                    Id = 2,
                    Name = "Server2",
                    Content = new []{"c", "d"}
                }
            };
        }
    }
}