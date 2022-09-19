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
    public class MachineController : Controller
    {
        private readonly PresentationLayerContext _context;

        public MachineController(PresentationLayerContext context)
        {
            _context = context;
        }

        // GET: Machine
        public async Task<IActionResult> Index()
        {
            return View(await _context.MachineViewModel.ToListAsync());
        }

        // GET: Machine/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineViewModel = await _context.MachineViewModel
                .FirstOrDefaultAsync(m => m.MachineId == id);
            if (machineViewModel == null)
            {
                return NotFound();
            }

            return View(machineViewModel);
        }

        // GET: Machine/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Machine/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MachineId,Machinetype,Machinename,Machinedescription")] MachineViewModel machineViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(machineViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(machineViewModel);
        }

        // GET: Machine/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineViewModel = await _context.MachineViewModel.FindAsync(id);
            if (machineViewModel == null)
            {
                return NotFound();
            }
            return View(machineViewModel);
        }

        // POST: Machine/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MachineId,Machinetype,Machinename,Machinedescription")] MachineViewModel machineViewModel)
        {
            if (id != machineViewModel.MachineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(machineViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MachineViewModelExists(machineViewModel.MachineId))
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
            return View(machineViewModel);
        }

        // GET: Machine/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machineViewModel = await _context.MachineViewModel
                .FirstOrDefaultAsync(m => m.MachineId == id);
            if (machineViewModel == null)
            {
                return NotFound();
            }

            return View(machineViewModel);
        }

        // POST: Machine/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var machineViewModel = await _context.MachineViewModel.FindAsync(id);
            _context.MachineViewModel.Remove(machineViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MachineViewModelExists(int id)
        {
            return _context.MachineViewModel.Any(e => e.MachineId == id);
        }
    }
}
