using System.Web.Mvc;
using System.Collections.Generic;
using WonderLandAdventures.Models; // Assuming your models are in this namespace

namespace WonderLandAdventures.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutViewModel
            {
                Founder = new Founder
                {
                    Name = "Chaldear Wonder",
                    Bio = "Our beloved founder Chaldear Wonder was a visionary dreamer who believed in the power of joy and imagination...",
                    ImageUrl = "/Content/Images/founder.jpg"
                },
                History = new List<HistoryItem>
                {
                    new HistoryItem { Year = 1985, Title = "The Dream Begins", Description = "Chaldear Wonder opened the gates to WonderLand with just five rides..." },
                    new HistoryItem { Year = 1992, Title = "Dragon's Fury Debut", Description = "Chaldear's masterpiece, Dragon's Fury, opened as the park's first major roller coaster..." },
                    new HistoryItem { Year = 2001, Title = "Jungle Explorer Expansion", Description = "The park doubled in size with the Jungle Explorer zone..." },
                    new HistoryItem { Year = 2012, Title = "A Legacy Continues", Description = "After Chaldear's passing, his daughter Sarah took over as park president..." },
                    new HistoryItem { Year = 2023, Title = "Next Generation of Wonder", Description = "Today, WonderLand Adventures spans over 200 acres..." }
                },
                TeamMembers = new List<TeamMember>
                {
                    new TeamMember { Name = "Sarah Wonder", Position = "Park President", Bio = "Chaldear's daughter who grew up in the park...", ImageUrl = "/Content/Images/sarah.jpg" },
                    new TeamMember { Name = "Michael Chen", Position = "Head Imagineer", Bio = "Started as an intern under Chaldear in 1995...", ImageUrl = "/Content/Images/michael.jpg" },
                    new TeamMember { Name = "Emma Rodriguez", Position = "Character Director", Bio = "Brings Chaldear's original characters to life...", ImageUrl = "/Content/Images/emma.jpg" },
                    new TeamMember { Name = "David Kim", Position = "Chief Safety Officer", Bio = "Ensures all attractions meet Chaldear's exacting standards...", ImageUrl = "/Content/Images/david.jpg" }
                }
            };

            return View(model);
        }

        // GET: Contact
        public ActionResult Contact()
        {
            return View(new ContactForm());
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                // In a real application, you would save the contact form to a database
                // and/or send an email notification
                return RedirectToAction("ContactSuccess");
            }

            return View(model);
        }

        public ActionResult ContactSuccess()
        {
            return View();
        }
    }
}