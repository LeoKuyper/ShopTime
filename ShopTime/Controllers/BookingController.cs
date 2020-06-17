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

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,ShopId,BookingTime,BookingState")] Booking booking)
        {
            if (id != booking.Id.ToString())
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }

        // GET: Booking/Edit/5
        public ActionResult UpdateEnterShop(int id)
        {
            return View();
        }

        // POST: Booking/UpdateShop/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEnterShop(int id, [Bind("BookingState")] Booking bookingModel)
        {
            if (id != bookingModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Booking newBooking = new Booking
                    //{
                    //    BookingState = "In Shop",
                    //};
                    _logger.LogInformation(id.ToString() + "ID TEst");
                    //var booking = await _context.Booking
                    //.FirstOrDefaultAsync(m => m.Id == id);

                    var booking = new Booking { Id = 15};
                    booking.BookingState = "In Shop";
                    _context.Entry(booking).Property("BookingState").IsModified = true;
                    _logger.LogInformation(booking.BookingState);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));


                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                //return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
            //return View(bookingModel);
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