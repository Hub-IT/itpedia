using System;
using System.Collections.Generic;
using System.Linq;

namespace DB.Models
{
    public class Term
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string[] Content { get; set; }

        public static IQueryable<Term> Get()
        {
            return Terms().AsQueryable();
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
                    Content =
                        new[]
                        {
                            "In information technology, a server is a computer program that provides services to other computer programs (and their users) in the same or other computers.",
                            "The computer that a server program runs in is also frequently referred to as a server (though it may be used for other purposes as well).",
                            "In the client/server programming model, a server is a program that awaits and fulfills requests from client programs in the same or other computers. A given application in a computer may function as a client with requests for services from other programs and also as a server of requests from other programs.",
                            "Specific to the Web, a Web server is the computer program (housed in a computer) that serves requested HTML pages or files. A Web client is the requesting program associated with the user. The Web browser in your computer is a client that requests HTML files from Web servers."
                        }
                },
                new Term
                {
                    Id = 2,
                    Name = "Desktop",
                    Content = new[] { "Using an office metaphor, a desktop is a computer display area that represents the kinds of objects one might find on a real desktop: documents, phonebook, telephone, reference sources, writing (and possibly drawing) tools, project folders. A desktop can be contained in a window that is part of the total display area or can be 'full - screen' (the total display area). Conceivably, you can have multiple desktops (for different projects or work environments you may have) and switch among them.<br/> In its Windows product, Microsoft provides what they call an Active Desktop. It includes representations of and access to desktop objects and also dynamic Web content as well, including integrated links to Web sites and information areas that are generated as the result of sites pushing requested information updates to the user.", "Desktop is also an abbreviated form of desktop computer, a personal computer that fits on top of a desk." },
                    Source = "http://searchwindowsserver.techtarget.com/definition/desktop"
                }
            };
        }
    }
}