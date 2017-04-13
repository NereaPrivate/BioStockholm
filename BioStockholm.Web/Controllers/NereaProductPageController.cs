using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BioStockholm.Web.Models;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;

namespace BioStockholm.Web.Controllers
{
    public class NereaProductPageController : PageControllerBase<NereaProductPage>
    {
        public ActionResult Index(NereaProductPage currentPage)
        {
            var model = new NereaProductPageViewModel(currentPage)
            {
                TrailerUrl = CreateTrailerUrl(currentPage),
                CurrentWeek = CreateWeek(currentPage),
                Shows = GetShows(currentPage)
            };

            return View(model);
        }

        private List<SalongPage> GetShows(NereaProductPage currentPage)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var shows = contentRepository.GetChildren<SalongPage>(currentPage.ContentLink).ToList();

            return shows;
        }

        //Lista ut föreställningar
        //private List<Show> GetShows(NereaProductPage currentPage)
        //{
        //    var shows = new List<Show>();
        //    var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            
        //    //Listar ut alla egenskaper
        //    var listOfShows = new List<CategoryList>
        //    {
        //        currentPage.Show1,
        //        currentPage.Show2,
        //        currentPage.Show3,
        //        currentPage.Show4
        //    };

        //    //loopar igenom varje egenskap av lista av egenskaper // för varje categori lista har vi två värden (två id)
        //    foreach (var show in listOfShows)
        //    {
        //        if (show != null)
        //        {
        //            var i = 0;
        //            var tempShow = new Show();
                    
        //            foreach (var currentShow in show)
        //            {
        //                var category = categoryRepository.Get(currentShow);
        //                var description = category.Description;
                        
        //                //Första loopen så plockar jag ut första värdet, tiden
        //                if (i == 0)
        //                {
        //                    tempShow.Time = description;

        //                    i++;
        //                }
        //                else
        //                {
        //                    //Andra loopen så plockar jag ut andra värdet, salongen
        //                    //var salong = new Salong
        //                    //{
        //                    //    Name = description,
        //                    //    Seats = 245
        //                    //};

        //                    tempShow.SalongNamn = description;
        //                    shows.Add(tempShow);
        //                }
        //            }
        //        }
        //    }

        //    return shows;
        //}

        private static List<Show> GetTimeSeatsForShow(CategoryList show, CategoryRepository categoryRepository)
        {
            var timeSeats = new List<Show>();
            foreach (var timeSeatId in show)
            {
                var category = categoryRepository.Get(timeSeatId);
                var theaterName = category.Description;

                var timeSeat = new Show
                {
                    Time = theaterName
                };

                timeSeats.Add(timeSeat);
            }

            return timeSeats;
        }

        private List<DateTime> CreateWeek(NereaProductPage currentPage)
        {
            var week = new List<DateTime>();

            if (currentPage.Premiere > DateTime.Now)
            {
                for (var i = 0; i < 7; i++)
                {
                    var day = currentPage.Premiere.AddDays(i);

                    week.Add(day);
                }
            }
            else
            {
                for (var i = 0; i < 7; i++)
                {
                    var day = DateTime.Now.AddDays(i);

                    week.Add(day);
                }
            }

            return week;
        }

        private string CreateTrailerUrl(NereaProductPage currentPage)
        {
            return @"https://www.youtube.com/embed/" + currentPage.TrailerUrl;
        }
    }
}