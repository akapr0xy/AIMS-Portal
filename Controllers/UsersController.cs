using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIMS_Portal.Data;
using AIMS_Portal.Features;
using AIMS_Portal.Models.Users;
using CryptoHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AIMS_Portal.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(new DetailsViewModel
            {
                Id = user.Id,
                Email = user.Email,
                //Password = user.Password,
                //ConfirmPassword = user.ConfirmPassword,
                Role = user.Role,
                Company = user.Company
            });
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateViewModel user)
        {
            if (ModelState.IsValid)
            {
                //Searches to see if email is already in use in the database.
                var pass = _context.User.SingleOrDefault(m => m.Email.Equals(user.Email));
                if (pass != null)
                {
                    return View(user);
                }
                if (pass == null)
                {
                    var newUser = new User
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Password = Crypto.HashPassword(user.Password),
                        //ConfirmPassword = user.ConfirmPassword,
                        Role = user.Role,
                        Company = user.Company
                    };
                    _context.Add(newUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(new EditViewModel
            {
                Id = user.Id,
                Email = user.Email,
                //Password = user.Password,
                //ConfirmPassword = user.ConfirmPassword,
                Role = user.Role,
                Company = user.Company
            });
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditViewModel user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var newUser = new User()
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Password = Crypto.HashPassword(user.Password),
                        Role = user.Role,
                        Company = user.Company
                    };
                    _context.Update(newUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(new DeleteViewModel
            {
                Id = user.Id,
                Email = user.Email,
                //Password = user.Password,
                //ConfirmPassword = user.ConfirmPassword,
                Role = user.Role,
                Company = user.Company
            });
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.SingleOrDefaultAsync(m => m.Id == id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}