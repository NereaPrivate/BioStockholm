using EPiServer.Core;
using EPiServer.Web.Routing;

namespace BioStockholm.Web.Business.Extensions
{
    public static class ContentReferenceExtensions
    {
        public static string Url(this ContentReference reference)
        {
            return UrlResolver.Current.GetUrl(reference);
        }
    }
}