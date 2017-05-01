using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioStockholm.Web.Business.CustomProperties.DropDownSalong
{

    public class SalongFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                //new SelectItem() {Text = "English", Value = "EN"},
                //new SelectItem() {Text = "Guinean", Value = "GN"}
                new SelectItem { Value = "Salong1", Text = "Salong1" },
                new SelectItem { Value = "Salong2", Text = "Salong2" },
                new SelectItem { Value = "Salong3", Text = "Salong3" },
                new SelectItem { Value = "Salong4", Text = "Salong4" },
                new SelectItem { Value = "Salong5", Text = "Salong5" }
            };
        }
    }
}