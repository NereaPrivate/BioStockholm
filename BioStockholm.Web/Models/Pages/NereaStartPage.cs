using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace BioStockholm.Web.Models.Pages
{
    [ContentType(
        GUID = "1148a30e-b8db-446c-a82f-5aca5b7fb64f",
         GroupName = Global.GroupNames.Specialized
    )]
    [SiteImageUrl]
    public class NereaStartPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}