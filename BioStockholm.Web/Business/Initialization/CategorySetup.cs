using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace BioStockholm.Web.Business.Initialization
{

    [InitializableModule]
    public class CategorySetup : IInitializableModule
    {
        
        public void Initialize(InitializationEngine context)
        {
            CreateTimes();   
            CreateGenre();
            CreateSalong();
        }

        private void CreateSalong()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var parent = categoryRepository.GetRoot();
            var salongCategory = new Category(parent, "Salong")
            {
                Description = "Salong"
            };

            //radera om kategorin finns
            if (categoryRepository.Get("Salong") == null)
            {
                //var salongen = categoryRepository.Get("Salong");
                //categoryRepository.Delete(salongen);

                //skapa kategorin
                categoryRepository.Save(salongCategory);

                var parentGenre = categoryRepository.Get("Salong");

                for (var i = 1; i < 6; i++)
                {
                    var salong = new Category(parentGenre, "Salong " + i)
                    {
                        Description = "Salong " + i
                    };

                    categoryRepository.Save(salong);
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }

        private void CreateGenre()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var parent = categoryRepository.GetRoot();
            var genreCategory = new Category(parent, "Genre")
            {
                Description = "Genre"
            };

            //radera om kategorin finns
            if (categoryRepository.Get("Genre") == null)
            {
                //var genre = categoryRepository.Get("Genre");
                //categoryRepository.Delete(genre);

                //skapa kategorin
                categoryRepository.Save(genreCategory);

                var parentGenre = categoryRepository.Get("Genre");

                var genre1 = new Category(parentGenre, "Komedi")
                {
                    Description = "Komedi"
                };

                var genre2 = new Category(parentGenre, "Thriller")
                {
                    Description = "Thriller"
                };

                var genre3 = new Category(parentGenre, "Familj")
                {
                    Description = "Familj"
                };

                var genre4 = new Category(parentGenre, "Skräck")
                {
                    Description = "Skräck"
                };

                var genre5 = new Category(parentGenre, "Action")
                {
                    Description = "Action"
                };

                var genre6 = new Category(parentGenre, "Drama")
                {
                    Description = "Drama"
                };


                var genre7 = new Category(parentGenre, "Romantik")
                {
                    Description = "Romantik"
                };

                var genre8 = new Category(parentGenre, "Fantasy")
                {
                    Description = "Fantasy"
                };

                var genre9 = new Category(parentGenre, "Äventyr")
                {
                    Description = "Äventyr"
                };

                var genre10 = new Category(parentGenre, "Sci-Fi")
                {
                    Description = "Sci-Fi"
                };

                var genre11 = new Category(parentGenre, "Animerat")
                {
                    Description = "Animerat"
                };

                var genre12 = new Category(parentGenre, "Musik")
                {
                    Description = "Musik"
                };

                var genre13 = new Category(parentGenre, "Science-Fiction")
                {
                    Description = "Science-Fiction"
                };

                categoryRepository.Save(genre1);
                categoryRepository.Save(genre2);
                categoryRepository.Save(genre3);
                categoryRepository.Save(genre4);
                categoryRepository.Save(genre5);
                categoryRepository.Save(genre6);
                categoryRepository.Save(genre7);
                categoryRepository.Save(genre8);
                categoryRepository.Save(genre9);
                categoryRepository.Save(genre10);
                categoryRepository.Save(genre11);
                categoryRepository.Save(genre12);
                categoryRepository.Save(genre13);
            }
        }

        private void CreateTimes()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var parent = categoryRepository.GetRoot();
            var timeCategory = new Category(parent, "Tider")
            {
                Description = "Tider"
            };

            //radera om kategorin finns
            if (categoryRepository.Get("Tider") == null)
            {
                //var tider = categoryRepository.Get("Tider");
                //categoryRepository.Delete(tider);
           
                //skapa kategorin
                categoryRepository.Save(timeCategory);

                var parentTime = categoryRepository.Get("Tider");

                for (var i = 12; i < 24; i++)
                {
                    var time = new Category(parentTime, i + ":00")
                    {
                        Description = i + ":00"
                    };

                    categoryRepository.Save(time);
                }
            } 
        }
    }
}