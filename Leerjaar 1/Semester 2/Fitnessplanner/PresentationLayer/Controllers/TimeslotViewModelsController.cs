using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Data;
using PresentationLayer2.Models;

namespace PresentationLayer.Controllers
{
    public class TimeslotViewModelsController : Controller
    {
        private readonly PresentationLayerContext _context;

        public TimeslotViewModelsController(PresentationLayerContext context)
        {
            _context = context;
        }

        // GET: TimeslotViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TimeslotViewModel.ToListAsync());
        }

        // GET: TimeslotViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeslotViewModel = await _context.TimeslotViewModel
                .FirstOrDefaultAsync(m => m.TimeslotID == id);
            if (timeslotViewModel == null)
            {
                return NotFound();
            }

            return View(timeslotViewModel);
        }

        // GET: TimeslotViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeslotViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeslotID,Day,Timeslots,Currentreservations,Maxreservations")] TimeslotViewModel timeslotViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeslotViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeslotViewModel);
        }

        // GET: TimeslotViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeslotViewModel = await _context.TimeslotViewModel.FindAsync(id);
            if (timeslotViewModel == null)
            {
                return NotFound();
            }
            return View(timeslotViewModel);
        }

        // POST: TimeslotViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeslotID,Day,Timeslots,Currentreservations,Maxreservations")] TimeslotViewModel timeslotViewModel)
        {
            if (id != timeslotViewModel.TimeslotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeslotViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeslotViewModelExists(timeslotViewModel.TimeslotID))
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
            return View(timeslotViewModel);
        }

        // GET: TimeslotViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeslotViewModel = await _context.TimeslotViewModel
                .FirstOrDefaultAsync(m => m.TimeslotID == id);
            if (timeslotViewModel == null)
            {
                return NotFound();
            }

            return View(timeslotViewModel);
        }

        // POST: TimeslotViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeslotViewModel = await _context.TimeslotViewModel.FindAsync(id);
            _context.TimeslotViewModel.Remove(timeslotViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeslotViewModelExists(int id)
        {
            return _context.TimeslotViewModel.Any(e => e.TimeslotID == id);
        }
    }
}
