using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BioStockholm.Web.Models;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
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
                TimeSeats = GetTimeSeats(currentPage)
            };

            return View(model);
        }

        //Lista av timeseat som bara skriver ut tiden
        private List<TimeSeats> GetTimeSeats(NereaProductPage currentPage)
        {
            var timeSeats = new List<TimeSeats>();
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();

            if (currentPage.Show1 != null)
            {
                foreach (var timeSeatId in currentPage.Show1)
                {
                    var category = categoryRepository.Get(timeSeatId);
                    var theaterName = category.Description;

                    var timeSeat = new TimeSeats
                    {
                        Time = theaterName
                    };

                    timeSeats.Add(timeSeat);
                }
            }

            if (currentPage.Show2 != null)
            {
                foreach (var timeSeatId in currentPage.Show2)
                {
                    var category = categoryRepository.Get(timeSeatId);
                    var theaterName = category.Description;

                    var timeSeat = new TimeSeats
                    {
                        Time = theaterName
                    };

                    timeSeats.Add(timeSeat);
                }
            }

            if (currentPage.Show3 != null)
            {
                foreach (var timeSeatId in currentPage.Show3)
                {
                    var category = categoryRepository.Get(timeSeatId);
                    var theaterName = category.Description;

                    var timeSeat = new TimeSeats
                    {
                        Time = theaterName
                    };

                    timeSeats.Add(timeSeat);
                }
            }

            if (currentPage.Show4 != null)
            {
                var showTimeSeats = GetTimeSeatsForShow(currentPage.Show4, categoryRepository);

                timeSeats.AddRange(showTimeSeats);
            }

            return timeSeats;
        }

        private static List<TimeSeats> GetTimeSeatsForShow(CategoryList show, CategoryRepository categoryRepository)
        {
            var timeSeats = new List<TimeSeats>();
            foreach (var timeSeatId in show)
            {
                var category = categoryRepository.Get(timeSeatId);
                var theaterName = category.Description;

                var timeSeat = new TimeSeats
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