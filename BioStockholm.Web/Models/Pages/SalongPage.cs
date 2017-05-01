using System.ComponentModel.DataAnnotations;
using BioStockholm.Web.Business.CustomProperties.DropdownTime;
using BioStockholm.Web.Business.CustomProperties.DropDownSalong;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace BioStockholm.Web.Models.Pages
{
    [SiteContentType(
    GroupName = Global.GroupNames.Specialized,
    GUID = "829A75F7-815A-4F73-8948-9BF9D8B81E61")]
    public class SalongPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(SalongFactory))]
        public virtual string SalongName { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        //[UIHint("Tider")]
        [SelectOne(SelectionFactoryType = typeof(TimeFactory2))]
        public virtual string Time { get; set; }
    }
}