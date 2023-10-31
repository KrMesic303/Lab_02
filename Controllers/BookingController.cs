using Microsoft.AspNetCore.Mvc;
using Lab_02.Models;

namespace Lab_02.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> hotelBookings = new();

        public IActionResult Index()
        {
            return View(hotelBookings);
        }

        public IActionResult Create(int id = 0)
        {
            HotelBooking hotelBooking = new();

            return View(hotelBooking);
        }

        public IActionResult CreateBooking(HotelBooking hotelBooking) 
        {
            hotelBooking.Id = hotelBookings.Count > 0 ? (hotelBookings.Max(x => x.Id) + 1) : 1;
            hotelBookings.Add(hotelBooking);

            return RedirectToAction("Create");
        }
    }
}
