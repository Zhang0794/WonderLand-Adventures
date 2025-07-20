using System.Net.Sockets;
using System.Web.Mvc;
using WonderLandAdventures.Models;

namespace WonderLandAdventures.Controllers
{
    public class TicketsController : Controller
    {
        public ActionResult Index()
        {
            var tickets = new Ticket[]
            {
                new Ticket {
                    Id = 1,
                    Type = "Adult Ticket",
                    Description = "For guests ages 15-64",
                    Price = 89.99m,
                    ImageUrl = "/Content/Images/ticket_adult.jpg"
                },
                new Ticket {
                    Id = 2,
                    Type = "Child/Senior Ticket",
                    Description = "For guests ages 3-14 and 65+",
                    Price = 69.99m,
                    ImageUrl = "/Content/Images/ticket_child.jpg"
                },
                new Ticket {
                    Id = 3,
                    Type = "VIP Experience",
                    Description = "Includes front-of-line access and reserved show seating",
                    Price = 199.99m,
                    ImageUrl = "/Content/Images/ticket_vip.jpg"
                }
            };

            return View(tickets);
        }

        public ActionResult Purchase(int id)
        {
            // In a real application, we would fetch the ticket details from a database
            var ticket = new Ticket
            {
                Id = id,
                Type = "Sample Ticket",
                Price = 99.99m
            };

            return View(ticket);
        }

        [HttpPost]
        public ActionResult Purchase(TicketPurchase purchase)
        {
            if (ModelState.IsValid)
            {
                // Process the ticket purchase
                return RedirectToAction("Confirmation", new { id = purchase.Id });
            }

            return View(purchase);
        }

        public ActionResult Confirmation(int id)
        {
            // Display purchase confirmation
            return View();
        }
    }
}