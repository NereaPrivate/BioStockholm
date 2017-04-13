using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BioStockholm.Web.Models.Pages
{
    [ContentType(DisplayName = "BookingPage", GUID = "d24dd606-6409-4199-85de-a595e5a6b3f8", Description = "")]
    public class BookingPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual int NumberOfTickets { get; set; }

        [CultureSpecific]
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 30)]
        public virtual XhtmlString Description { get; set; }
    }
}