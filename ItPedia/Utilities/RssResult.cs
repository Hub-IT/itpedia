using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;

namespace ITPedia.Utilities
{
    public class RssResult : ActionResult
    {
        public SyndicationFeed Feed { get; set; }

        public RssResult() { }

        public RssResult(SyndicationFeed feed)
        {
            Feed = feed;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.ContentType = "application/rss+xml";

            var formatter = new Rss20FeedFormatter(this.Feed);

            using (var writer = XmlWriter.Create(context.HttpContext.Response.Output))
            {
                formatter.WriteTo(writer);
            }
        }
    }
}