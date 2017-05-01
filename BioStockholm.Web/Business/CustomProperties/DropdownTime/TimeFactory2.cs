using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioStockholm.Web.Business.CustomProperties.DropdownTime
{


    public class TimeFactory2 : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                //new SelectItem() {Text = "English", Value = "EN"},
                //new SelectItem() {Text = "Guinean", Value = "GN"}
                new SelectItem { Value = "12:00", Text = "12:00" },
                new SelectItem { Value = "14:00", Text = "14:00" },
                new SelectItem { Value = "16:00", Text = "16:00" },
                new SelectItem { Value = "18:00", Text = "18:00" },
                new SelectItem { Value = "20:00", Text = "20:00" },
                new SelectItem { Value = "22:00", Text = "22:00" }
            };
        }
    }
}