using System.Web.Mvc;
using WonderLandAdventures.Models;

namespace WonderLandAdventures.Controllers
{
    public class HotelsController : Controller
    {
        public ActionResult Index()
        {
            var hotels = new Hotel[]
            {
                new Hotel {
                    Id = 1,
                    Name = "WonderLand Grand Hotel",
                    Description = "Luxury accommodations steps from the park entrance",
                    ImageUrl = "/Content/Images/hotel1.jpg",
                    PricePerNight = 299.99m,
                    Rating = 5
                },
                new Hotel {
                    Id = 2,
                    Name = "Adventure Suites",
                    Description = "Family-friendly suites with themed rooms",
                    ImageUrl = "/Content/Images/hotel2.jpg",
                    PricePerNight = 199.99m,
                    Rating = 4
                },
                new Hotel {
                    Id = 3,
                    Name = "Enchanted Garden Resort",
                    Description = "Beautiful gardens and relaxing spa facilities",
                    ImageUrl = "/Content/Images/hotel3.jpg",
                    PricePerNight = 249.99m,
                    Rating = 4
                },
                new Hotel {
                    Id = 4,
                    Name = "Magic Castle Inn",
                    Description = "Budget-friendly option with free shuttle to park",
                    ImageUrl = "/Content/Images/hotel4.jpg",
                    PricePerNight = 149.99m,
                    Rating = 3
                }
            };

            return View(hotels);
        }

        public ActionResult Book(int id)
        {
            // In a real application, we would fetch the hotel details from a database
            var hotel = new Hotel
            {
                Id = id,
                Name = "Sample Hotel",
                PricePerNight = 199.99m
            };

            return View(hotel);
        }

        [HttpPost]
        public ActionResult Book(Booking booking)
        {
            if (ModelState.IsValid)
            {
                // Process the booking
                return RedirectToAction("Confirmation", new { id = booking.Id });
            }

            return View(booking);
        }

        public ActionResult Confirmation(int id)
        {
            // Display booking confirmation
            return View();
        }
    }
}