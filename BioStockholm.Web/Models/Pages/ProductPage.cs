using System.ComponentModel.DataAnnotations;
using BioStockholm.Web.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using BioStockholm.Web.Models.Properties;

namespace BioStockholm.Web.Models.Pages
{
    /// <summary>
    /// Used to present a single product
    /// </summary>
    [SiteContentType(
        GUID = "17583DCD-3C11-49DD-A66D-0DEF0DD601FC",
        GroupName = Global.GroupNames.Products)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [AvailableContentTypes( 
        Availability = Availability.Specific,
        IncludeOn = new[]
        {
            typeof(StartPage),
            typeof(SalongPage)
        })]
    public class ProductPage : StandardPage, IHasRelatedContent
    {
        [Required]
        [BackingType(typeof(PropertyStringList))]
        [Display(Order = 305)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] UniqueSellingPoints { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 330)]
        [CultureSpecific]
        [AllowedTypes(new[] { typeof(IContentData) },new[] { typeof(JumbotronBlock) })]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}
