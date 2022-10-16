using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spacebags.Data;
using Spacebags.Models;

namespace Spacebags.Controllers
{
    public class BagsClassesController : Controller
    {
        private readonly SpacebagsContext _context;

        public BagsClassesController(SpacebagsContext context)
        {
            _context = context;
        }

        // GET: BagsClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.BagsClass.ToListAsync());
        }

        // GET: BagsClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bagsClass = await _context.BagsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bagsClass == null)
            {
                return NotFound();
            }

            return View(bagsClass);
        }

        // GET: BagsClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BagsClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Type,Size,Material,color,review")] BagsClass bagsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bagsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bagsClass);
        }

        // GET: BagsClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bagsClass = await _context.BagsClass.FindAsync(id);
            if (bagsClass == null)
            {
                return NotFound();
            }
            return View(bagsClass);
        }

        // POST: BagsClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Type,Size,Material,color,review")] BagsClass bagsClass)
        {
            if (id != bagsClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bagsClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BagsClassExists(bagsClass.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bagsClass);
        }

        // GET: BagsClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bagsClass = await _context.BagsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bagsClass == null)
            {
                return NotFound();
            }

            return View(bagsClass);
        }

        // POST: BagsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bagsClass = await _context.BagsClass.FindAsync(id);
            _context.BagsClass.Remove(bagsClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BagsClassExists(int id)
        {
            return _context.BagsClass.Any(e => e.Id == id);
        }
    }
}
