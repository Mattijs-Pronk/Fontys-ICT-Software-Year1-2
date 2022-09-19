using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DatabaseLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PresentationLayer2.Data;
using PresentationLayer2.Models;

namespace PresentationLayer2.Controllers
{
    public class MachineController : Controller
    {
        Machine machine = new Machine(new MachineDAL());
        MachineContainer machineContainer = new MachineContainer(new MachineDAL());


        public IActionResult Index(string searchPhrase)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MachineViewModel machineViewmodel = new MachineViewModel();
            ListViewModel list = new ListViewModel();

            //list met machines vullen.
            foreach (Machine machine in machineContainer.GetAllMachines())
            {
                machineViewmodel = new MachineViewModel(machine.MachineId, machine.Machinetype, machine.Machinename, machine.Machinedescription);
                list.allmachines.Add(machineViewmodel);
            }

            //zoekfunctie 
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                list.allmachines.Clear();
                foreach (Machine machine in machineContainer.GetAllMachinesByMachineType(searchPhrase))
                {
                    machineViewmodel = new MachineViewModel(machine.MachineId, machine.Machinetype, machine.Machinename, machine.Machinedescription);
                    list.allmachines.Add(machineViewmodel);
                }
            }

            //viewbag aanmaken
            var machinetype = new List<string>()
            {
                "Bicep",
                "Tricep",
                "Back",
                "Chest",
                "Shoulders",
                "Legs"
            };
            ViewBag.machinetype = machinetype;

            return View(list.allmachines);
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            //viewbag aanmaken
            var machinetype = new List<string>()
            {
                "Bicep",
                "Tricep",
                "Back",
                "Shoulders",
                "Chest",
                "Legs"
            };
            ViewBag.machinetype = machinetype;

            MachineViewModel machineViewModel = new MachineViewModel();
            return View(machineViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MachineViewModel machineViewModel)
        {
            TempData["MachineCreated"] = "Succesfully created Machine!";

            Machine mach = new Machine(machineViewModel.Machinetype, machineViewModel.Machinename, machineViewModel.Machinedescription);
            machineContainer.AddOneMachine(mach);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            //viewbag aanmaken
            var machinetype = new List<string>()
            {
                "Bicep",
                "Tricep",
                "Back",
                "Shoulders",
                "Chest",
                "Legs"
            };
            ViewBag.machinetype = machinetype;

            MachineViewModel machineViewModel = new MachineViewModel();
            machineViewModel = FetchById(id);
            return View(machineViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, MachineViewModel machineViewModel)
        {
            if (ModelState.IsValid)
            {
                TempData["MachineEdited"] = "Succesfully edited Machine with: '" + machineViewModel.Machinename + "'!";
                Machine mach = new Machine(id, machineViewModel.Machinetype, machineViewModel.Machinename, machineViewModel.Machinedescription);
                machine.EditOneMachineById(mach);
                return RedirectToAction(nameof(Index));
            }
            return View(machineViewModel);
        }


        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MachineViewModel machineViewModel = new MachineViewModel();

            machineViewModel = FetchById(id);

            return View(machineViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, MachineViewModel machineViewModel)
        {
            TempData["MachineDeleted"] = "Succesfully deleted Machine with: '" + machineViewModel.Machinename + "'!";

            machineContainer.DeleteOneMachineById(id);

            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public MachineViewModel FetchById(int id)
        {
            MachineViewModel machineViewModel = new MachineViewModel();

            Machine machine = machineContainer.GetOneMachineById(id);

            machineViewModel.Machinetype = machine.Machinetype;
            machineViewModel.Machinename = machine.Machinename;
            machineViewModel.Machinedescription = machine.Machinedescription;

            return machineViewModel;
        }
    }
}
