using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;

namespace BioStockholm.Web.Models.ViewModels
{
    public class NereaProductListPageViewModel
    {
        public string Heading { get; set; }
        public string Preamble { get; set; }

        public NereaProductListPageViewModel(NereaProductListPage currentPage)
        {
            Heading = currentPage.PageHeading;
            Preamble = currentPage.PagePreamble;
        }
    }
       
    }