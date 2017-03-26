using EPiServer.Core;

namespace BioStockholm.Web.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
