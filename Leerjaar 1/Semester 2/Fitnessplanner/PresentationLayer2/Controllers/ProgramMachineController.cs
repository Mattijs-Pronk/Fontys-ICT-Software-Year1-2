using System;
using System.Collections.Generic;
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
    public class ProgramMachineController : Controller
    {
        ProgramMachine programMachine = new ProgramMachine(new ProgramMachineDAL());
        ProgramMachineContainer programMachineContainer = new ProgramMachineContainer(new ProgramMachineDAL());
        BusinessLogicLayer.Program program = new BusinessLogicLayer.Program(new ProgramDAL());
        ProgramContainer programContainer = new ProgramContainer(new ProgramDAL());
        MachineContainer machineContainer = new MachineContainer(new MachineDAL());


        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            ProgramMachineViewModel programMachineViewModel = new ProgramMachineViewModel();
            ListViewModel list = new ListViewModel();

            //list van programmas vullen
            foreach(BusinessLogicLayer.Program program in programContainer.GetAllPrograms())
            {
                programMachineViewModel = new ProgramMachineViewModel(program.ProgramId, program.ProgramName, program.ProgramDescription);
                list.allprograms.Add(programMachineViewModel);
            }

            return View(list.allprograms);
        }


        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MachineViewModel machineViewModel = new MachineViewModel();
            ProgramAndMachineViewModel joined = new ProgramAndMachineViewModel();

            joined.program = FetchById(id);

            //list van alle machines die bij programma horen vullen
            foreach (ProgramMachine programMachine in programMachineContainer.GetAllProgramMachinesById(id))
            {
                machineViewModel = new MachineViewModel(programMachine.MachineID, programMachine.Machine.Machinetype, programMachine.Machine.Machinename, programMachine.Machine.Machinedescription);
                joined.machines.Add(machineViewModel);
            }

            return View(joined);
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            ProgramMachineViewModel programMachineViewModel = new ProgramMachineViewModel();

            return View(programMachineViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProgramMachineViewModel programMachineViewModel)
        {
            BusinessLogicLayer.Program program = new BusinessLogicLayer.Program(programMachineViewModel.Programname, programMachineViewModel.Programdescription);
            programContainer.AddOneProgram(program);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MachineViewModel machineViewModel = new MachineViewModel();
            ProgramAndMachineViewModel joined = new ProgramAndMachineViewModel();

            joined.program = FetchById(id);

            //viewbag aanmaken
            var machines = new List<string>();
            foreach (Machine machine in machineContainer.GetAllMachines())
            {
                machines.Add(machine.Machinename);
            }
            ViewBag.machines = machines;

            joined.program = FetchById(id);

            //list van alle machines die bij programma horen vullen
            foreach (ProgramMachine programMachine in programMachineContainer.GetAllProgramMachinesById(id))
            {
                machineViewModel = new MachineViewModel(programMachine.MachineID, programMachine.Machine.Machinetype, programMachine.Machine.Machinename, programMachine.Machine.Machinedescription);
                joined.machines.Add(machineViewModel);
            }

            return View(joined);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, string button, ProgramAndMachineViewModel joined)
        {
            Machine machine = machineContainer.GetOneMachineByMachineName(joined.machine.Machinename);
            ProgramMachine prmachine = new ProgramMachine(id, machine.MachineId);

            //checken op welke knop er is gedrukt
            if (button == "Add")
            {
                programMachineContainer.AddMachineToProgramById(prmachine);

                TempData["MachineAdded"] = "Machine '"+joined.machine.Machinename+"' has been added to current program!";

                return RedirectToAction("Edit");
            }
            else
            {
                ProgramMachine programMachine = programMachineContainer.GetOneProgramMachines(prmachine);

                programMachineContainer.DeleteOneProgramMachineByProgramMachineId(programMachine.ProgramMachineID);

                TempData["MachineRemoved"] = "Machine '" + joined.machine.Machinename + "' has been removed from current program!";

                return RedirectToAction("Edit");
            }
            
        }


        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            ProgramMachineViewModel programMachineViewModel = new ProgramMachineViewModel();
            programMachineViewModel = FetchById(id);

            return View(programMachineViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            programMachineContainer.DeleteOneProgramMachineByProgramId(id);
            programContainer.DeleteOneProgramById(id);

            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public ProgramMachineViewModel FetchById(int id)
        {
            ProgramMachineViewModel programMachineViewModel = new ProgramMachineViewModel();

            BusinessLogicLayer.Program program = programContainer.GetOneProgramById(id);
            {
                programMachineViewModel.ProgramID = program.ProgramId;
                programMachineViewModel.Programname = program.ProgramName;
                programMachineViewModel.Programdescription = program.ProgramDescription;
            }

            return programMachineViewModel;
        }
    }
}
