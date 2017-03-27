using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace BioStockholm.Web.Models.Pages
{
    [ContentType(DisplayName = "NereaProductListPage", GUID = "d2954341-ee43-47b6-bc1c-4f9dfacbf418", Description = "För att se en sida som listar alla filmer")]
    [SuppressMessage("ReSharper", "Mvc.TemplateNotResolved")]
    public class NereaProductListPage : PageData
    {

        [CultureSpecific]
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 300)]
        public virtual string PageHeading { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 400)]
        [UIHint(UIHint.Textarea)]
        [StringLength(300)]
        public virtual string PagePreamble { get; set; }
    }
}