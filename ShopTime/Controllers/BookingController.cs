using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Globalization;
using ShopTime.Data;
using ShopTime.Models;

namespace ShopTime.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcBookingContext _context;
        private readonly UserManager<User> _userManager;
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;

        public BookingController(ILogger<HomeController> logger, MvcBookingContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        // GET: Booking
        public async Task<IActionResult> Index()
        {

            var booking = new Booking();
            _logger.LogInformation(booking.Id.ToString());

            // Test to see if the user is logged in
            if (User.Identity.IsAuthenticated)
            {
                // Get the id of the current loggedin user
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                User currentUser = await _context.User
                    .Include(u => u.Bookings)
                        .ThenInclude(ut => ut.Shop)                    
                    .FirstOrDefaultAsync(u => u.Id == id);

                if (currentUser == null)
                {
                    return NotFound();
                }
                return View(currentUser);
            }
            



            return View();
        }

        // GET: Booking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await _context.Booking
                .Include(t => t.BookingTime)
                   
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }


        public IActionResult Create()
        {
            List<Shop> allShops = _context.Shop.ToList();
            var selectAllShops = allShops.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString(), Selected = true });

            ViewData["shops"] = new MultiSelectList(selectAllShops, "Value", "Text");

            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ShopId,BookingTime,BookingState")] Booking bookingModel) 
        {
            // Make sure that the todo is related to the user on create
            if (ModelState.IsValid)
            {
                // 1. Create a new Todo object
                var booking = new Booking
                {
                    Id = bookingModel.Id,
                    ShopId = bookingModel.ShopId,
                    BookingTime = localDate,
                    BookingState = "Waiting",
                    Owner = _userManager.GetUserAsync(User).Result
                };

                if(booking.Shops != null)
                {
                    _logger.LogInformation("Counting Shops");

                    List<Shop> allShops = _context.Shop.Where(shop => bookingModel.Shops.Contains(shop.Name)).ToList();

                    foreach (Shop shop in allShops)
                    {
                        _logger.LogInformation(shop.Name);

                    }
                }
                else
                {
                    _logger.LogInformation("Not Counting Shops");
                }                            

                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingModel);
        }

        // GET: Booking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Booking/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Booking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Booking.FindAsync(id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}