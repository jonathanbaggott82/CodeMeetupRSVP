using CodeMeetupRSVP.Models;
using Microsoft.AspNetCore.Mvc;
namespace CodeMeetupRSVP.Controllers

{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            return View();
        }

    }
}