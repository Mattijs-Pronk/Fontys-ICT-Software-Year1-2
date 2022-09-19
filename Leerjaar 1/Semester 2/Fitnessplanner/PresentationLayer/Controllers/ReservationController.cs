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
    public class ReservationController : Controller
    {
        private readonly PresentationLayerContext _context;

        public ReservationController(PresentationLayerContext context)
        {
            _context = context;
        }

        // GET: Reservation
        public async Task<IActionResult> Index()
        {
            var presentationLayerContext = _context.ReservationViewModel.Include(r => r.Program).Include(r => r.Timeslot);
            return View(await presentationLayerContext.ToListAsync());
        }

        // GET: Reservation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservationViewModel = await _context.ReservationViewModel
                .Include(r => r.Program)
                .Include(r => r.Timeslot)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (reservationViewModel == null)
            {
                return NotFound();
            }

            return View(reservationViewModel);
        }

        // GET: Reservation/Create
        public IActionResult Create()
        {
            ViewData["ProgramID"] = new SelectList(_context.Set<Program>(), "ProgramId", "ProgramId");
            ViewData["TimeslotID"] = new SelectList(_context.Set<Timeslot>(), "TimeslotID", "TimeslotID");
            return View();
        }

        // POST: Reservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,UserID,TimeslotID,ProgramID,Currentreservation")] ReservationViewModel reservationViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservationViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgramID"] = new SelectList(_context.Set<Program>(), "ProgramId", "ProgramId", reservationViewModel.ProgramID);
            ViewData["TimeslotID"] = new SelectList(_context.Set<Timeslot>(), "TimeslotID", "TimeslotID", reservationViewModel.TimeslotID);
            return View(reservationViewModel);
        }

        // GET: Reservation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservationViewModel = await _context.ReservationViewModel.FindAsync(id);
            if (reservationViewModel == null)
            {
                return NotFound();
            }
            ViewData["ProgramID"] = new SelectList(_context.Set<Program>(), "ProgramId", "ProgramId", reservationViewModel.ProgramID);
            ViewData["TimeslotID"] = new SelectList(_context.Set<Timeslot>(), "TimeslotID", "TimeslotID", reservationViewModel.TimeslotID);
            return View(reservationViewModel);
        }

        // POST: Reservation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,UserID,TimeslotID,ProgramID,Currentreservation")] ReservationViewModel reservationViewModel)
        {
            if (id != reservationViewModel.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservationViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationViewModelExists(reservationViewModel.BookingID))
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
            ViewData["ProgramID"] = new SelectList(_context.Set<Program>(), "ProgramId", "ProgramId", reservationViewModel.ProgramID);
            ViewData["TimeslotID"] = new SelectList(_context.Set<Timeslot>(), "TimeslotID", "TimeslotID", reservationViewModel.TimeslotID);
            return View(reservationViewModel);
        }

        // GET: Reservation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservationViewModel = await _context.ReservationViewModel
                .Include(r => r.Program)
                .Include(r => r.Timeslot)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (reservationViewModel == null)
            {
                return NotFound();
            }

            return View(reservationViewModel);
        }

        // POST: Reservation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservationViewModel = await _context.ReservationViewModel.FindAsync(id);
            _context.ReservationViewModel.Remove(reservationViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationViewModelExists(int id)
        {
            return _context.ReservationViewModel.Any(e => e.BookingID == id);
        }
    }
}
