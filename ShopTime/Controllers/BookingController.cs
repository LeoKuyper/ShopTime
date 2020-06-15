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
using ShopTime.Data;
using ShopTime.Models;

namespace ShopTime.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcBookingContext _context;
        private readonly UserManager<User> _userManager;

        public BookingController(ILogger<HomeController> logger, MvcBookingContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        // GET: Booking
        public async Task<IActionResult> Index()
        {
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

                // Get all notes that belong to this user
                //IEnumerable<Todo> todos = _context.Todo.Where(todo => todo.OwnerId == id).ToList();

                // return the view with the notes passed in
                return View(currentUser);
            }
            //await _context.Todo.ToListAsync()
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

        // GET: Todoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Todoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,Body")] Booking bookingModel) //Change todo to todoModel to make more sense
        //{
        //    // Make sure that the todo is related to the user on create
        //    if (ModelState.IsValid)
        //    {
        //        // 1. Create a new Todo object
        //        var booking = new Booking
        //        {
        //            // 2. Set values from (todoModel) to the new todo keys
        //            Title = todoModel.Title,
        //            Body = todoModel.Body,
        //            // Set the current user to the Owner field of the todo, our DbContext will be responsible for assigning the userID to OwnerID
        //            // Remember to import the userManager class to get access to the current user, use dependency injection for this
        //            Owner = _userManager.GetUserAsync(User).Result
        //        };
        //        _context.Add(booking);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bookingModel);
        //}

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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Booking/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}