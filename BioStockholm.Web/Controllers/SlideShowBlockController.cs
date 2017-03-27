using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BioStockholm.Web.Models.Blocks;
using BioStockholm.Web.Models.Media;
using BioStockholm.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

namespace BioStockholm.Web.Controllers
{
    public class SlideShowBlockController : BlockController<SlideShowBlock>
    {
        public override ActionResult Index(SlideShowBlock currentBlock)
        {
            var model = new SlideShowViewModel();
            model.CurrentBlock = currentBlock;

            if (!ContentReference.IsNullOrEmpty(currentBlock.ImageFolder))
            {
                var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
                var images = contentLoader.GetChildren<ImageFile>(currentBlock.ImageFolder).ToList();
                model.Images = images;
            }

            //var editingHints = ViewData.GetEditHints<SlideShowViewModel, SlideShowBlock>();
            //editingHints.AddFullRefreshFor(m => m.ImageFolder);

            return PartialView(model);
        }
    }
}
