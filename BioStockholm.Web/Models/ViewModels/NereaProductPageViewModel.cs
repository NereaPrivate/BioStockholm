using System;
using System.Collections.Generic;
using BioStockholm.Web.Models.Pages;
using EPiServer.Core;

namespace BioStockholm.Web.Models.ViewModels
{
    public class NereaProductPageViewModel : PageViewModel<NereaProductPage>
    {
        public NereaProductPageViewModel(NereaProductPage currentPage) : base(currentPage)
        {
        }

        public string TrailerUrl { get; set; }

        public ContentReference Image { get; set; }

        public string Heading { get; set; }

        public string DurationTime { get; set; }

        public string Text { get; set; }

        public string Premiere { get; set; }

        public string AgeLimit { get; set; }

        public string OriginalLanguage { get; set; }

        public string Director { get; set; }

        public List<DateTime> CurrentWeek { get; set; }

        public List<TimeSeats> TimeSeats { get; set; }
    }
}