using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BioStockholm.Web.Models.Blocks
{
    [ContentType(DisplayName = "SlideShowBlock", GUID = "88cdc7de-2e8b-4a44-9a50-3be9127ab5de", Description = "")]
    public class SlideShowBlock : BlockData
    {
        [Display(Name = "Image Folder",
                Description = "Select folder with images to use in slide show.")]
        //[AllowedTypes(typeof(ContentFolder))]
        public virtual ContentReference ImageFolder { get; set; }


        public virtual bool HideCaption { get; set; }
    }
}