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

        // GET: Booking/Create
        public IActionResult Create()
        {
            List<User> allUsers = _context.Users.ToList();
            var selectAllUsers = allUsers.Select(x => new SelectListItem() { Text = x.FirstName, Value = x.Id, Selected = true });
            // ViewBag.Name = "Cool Title";
            ViewData["users"] = new MultiSelectList(selectAllUsers, "Value", "Text");
            //var todo = new TodoViewModel();
            //todo.UserIds = new List<string>();
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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