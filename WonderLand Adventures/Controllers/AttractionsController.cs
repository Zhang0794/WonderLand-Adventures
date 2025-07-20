using System.Web.Mvc;
using WonderLandAdventures.Models;

namespace WonderLandAdventures.Controllers
{
    public class AttractionsController : Controller
    {
        public ActionResult Index()
        {
            var attractions = new Attraction[]
            {
                new Attraction {
                    Id = 1,
                    Name = "Dragon's Fury Coaster",
                    Description = "Our newest and most thrilling roller coaster with 5 inversions and speeds up to 80mph!",
                    ImageUrl = "/Content/Images/coaster.jpg",
                    MinHeight = "54\"",
                    Intensity = "Extreme"
                },
                new Attraction {
                    Id = 2,
                    Name = "Splash Mountain Adventure",
                    Description = "Cool off with this exciting water ride through mysterious caves and down a 50-foot waterfall drop!",
                    ImageUrl = "/Content/Images/water_ride.jpg",
                    MinHeight = "42\"",
                    Intensity = "High"
                },
                new Attraction {
                    Id = 3,
                    Name = "Fairy Tale Village",
                    Description = "A magical land designed especially for our younger guests with gentle rides.",
                    ImageUrl = "/Content/Images/kids_area.jpg",
                    MinHeight = "None",
                    Intensity = "Low"
                },
                new Attraction {
                    Id = 4,
                    Name = "Haunted Mansion",
                    Description = "Journey through a spooky haunted house with ghostly surprises around every corner.",
                    ImageUrl = "/Content/Images/haunted.jpg",
                    MinHeight = "48\"",
                    Intensity = "Medium"
                },
                new Attraction {
                    Id = 5,
                    Name = "Pirate's Cove",
                    Description = "Interactive pirate adventure with water cannons and treasure hunts for the whole family.",
                    ImageUrl = "/Content/Images/pirates.jpg",
                    MinHeight = "36\"",
                    Intensity = "Medium"
                }
            };

            return View(attractions);
        }
    }
}