using BioStockholm.Web.Models.Blocks;
using BioStockholm.Web.Models.Media;
using System.Collections.Generic;

namespace BioStockholm.Web.Models.ViewModels
{
    public class SlideShowViewModel
    {
        public SlideShowBlock CurrentBlock { get; set; }

        public List<ImageFile> Images { get; set; }
    }
}