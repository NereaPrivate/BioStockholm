using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;

namespace BioStockholm.Web.Models.ViewModels
{
    public class NereaProductListPageViewModel : PageViewModel<NereaProductListPage>
    {
        //public string Heading { get; set; }
        //public string Preamble { get; set; }

        //public NereaProductListPageViewModel(NereaProductListPage currentPage)
        //{
        //    Heading = currentPage.PageHeading;
        //    Preamble = currentPage.PagePreamble;
        //}

        public NereaProductListPageViewModel(NereaProductListPage currentPage) : base(currentPage)
        {
        }

        public IEnumerable<NereaProductPage> Products { get; set; }
    }
       
    }