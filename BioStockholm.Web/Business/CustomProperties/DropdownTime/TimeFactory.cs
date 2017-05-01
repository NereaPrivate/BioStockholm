using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;

namespace BioStockholm.Web.Business.CustomProperties.DropdownTime
{
    public class TimeFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                new SelectItem()
                {
                    Text = "Sterling",
                    Value = "GBP"
                },

                new SelectItem()
                {
                    Text = "Dollars",
                    Value = "USD"
                }
            };
            //    var times = new List<SelectItem>
            //{
            //    new SelectItem { Value = "12:00", Text = "12:00" },
            //    new SelectItem { Value = "14:00", Text = "14:00" },
            //    new SelectItem { Value = "16:00", Text = "16:00" }
            //};

            //    return times;
            //}
        }
    }
}