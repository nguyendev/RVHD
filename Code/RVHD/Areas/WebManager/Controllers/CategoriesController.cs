using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RVHD.Data;
using RVHD.Models;

namespace RVHD.Areas.WebManager.Controllers
{
    [Area("WebManager")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: WebManager/Categories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Category.Include(c => c.Author);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WebManager/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Category
                .Include(c => c.Author)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // GET: WebManager/Categories/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: WebManager/Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CategoryName,CategoryDes,Slug,Icon,Color,OrderNo,Auth_status,Notes,Create_DT,Record_Status,Checker_ID,Publish_DT,AuthorId")] Categories categories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categories);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", categories.AuthorId);
            return View(categories);
        }

        // GET: WebManager/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Category.SingleOrDefaultAsync(m => m.ID == id);
            if (categories == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", categories.AuthorId);
            return View(categories);
        }

        // POST: WebManager/Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CategoryName,CategoryDes,Slug,Icon,Color,OrderNo,Auth_status,Notes,Create_DT,Record_Status,Checker_ID,Publish_DT,AuthorId")] Categories categories)
        {
            if (id != categories.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriesExists(categories.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", categories.AuthorId);
            return View(categories);
        }

        // GET: WebManager/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Category
                .Include(c => c.Author)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // POST: WebManager/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categories = await _context.Category.SingleOrDefaultAsync(m => m.ID == id);
            _context.Category.Remove(categories);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CategoriesExists(int id)
        {
            return _context.Category.Any(e => e.ID == id);
        }
    }
}
