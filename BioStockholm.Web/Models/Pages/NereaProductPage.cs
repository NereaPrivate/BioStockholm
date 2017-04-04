﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace BioStockholm.Web.Models.Pages
{
    [ContentType(DisplayName = "NereaProductPage", GUID = "25fe4701-99ac-4b76-a8e0-ee7a927d5fb1", Description = "")]
    [SuppressMessage("ReSharper", "Mvc.TemplateNotResolved")]
    public class NereaProductPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string TrailerUrl { get; set; }

        //[CultureSpecific]
        //[Display(
        //   GroupName = SystemTabNames.Content,
        //   Order = 12)]
        //public virtual string TrailerImageUrl { get; set; }

        [CultureSpecific]
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 15)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 20)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 25)]
        public virtual string Genre { get; set; }

        [CultureSpecific]
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 30)]
        public virtual string DurationTime { get; set; }

        [CultureSpecific]
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 35)]
        [UIHint(UIHint.Textarea)]
        public virtual string Text { get; set; }

        [CultureSpecific]
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 40)]
        public virtual string Premiere { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 45)]
        public virtual string AgeLimit { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string OrginalLanguage { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 55)]
        public virtual string Director { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            VisibleInMenu = false;
        }
    }
}