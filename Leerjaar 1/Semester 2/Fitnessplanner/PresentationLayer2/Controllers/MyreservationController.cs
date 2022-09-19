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
    public class MyreservationController : Controller
    {
        ReservationContainer reservationContainer = new ReservationContainer(new ReservationDAL());
        Reservation reservation1 = new Reservation(new ReservationDAL());
        ProgramContainer programContainer = new ProgramContainer(new ProgramDAL());
        MachineContainer machineContainer = new MachineContainer(new MachineDAL());
        ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDAL());



        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MyreservationViewModel myreservationViewmodel = new MyreservationViewModel();
            ListViewModel list = new ListViewModel();

            int userId = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));

            //list van reserveringen vullen
            foreach (Reservation reservation in reservationContainer.GetAllReservationsById(userId))
            {
                reservation.Currentreservations = reservation1.CurrentReservations(reservation.TimeslotID);
                myreservationViewmodel = new MyreservationViewModel(reservation.BookingID, reservation.UserID, reservation.TimeslotID, reservation.Timeslot.Day, reservation.Timeslot.Timeslot, reservation.Currentreservations, reservation.Timeslot.Maxreservations, reservation.Program.Programname);
                list.myreservations.Add(myreservationViewmodel);
            }

            return View(list.myreservations);
        }


        [HttpGet]
        public IActionResult ChangeProgram(int id, string searchPhrase)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MachineViewModel machineViewModel = new MachineViewModel();
            ProgramViewModel programViewModel = new ProgramViewModel();
            MachineAndMyreservationViewModel joined = new MachineAndMyreservationViewModel();           

            joined.myreservation = FetchById(id);

            //viewbag aanmaken
            var programs = new List<string>();
            foreach(BusinessLogicLayer.Program program in programContainer.GetAllPrograms())
            {
                programs.Add(program.ProgramName);
            }
            ViewBag.allprograms = programs;

            //zoekfunctie
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                BusinessLogicLayer.Program program = programContainer.GetOneProgramByName(searchPhrase);

                foreach (ProgramMachine machine in programmachineContainer.GetAllProgramMachinesById(program.ProgramId))
                {
                    machineViewModel = new MachineViewModel(machine.MachineID, machine.Machine.Machinetype, machine.Machine.Machinename, machine.Machine.Machinedescription);
                    joined.machines.Add(machineViewModel);
                }
            }
                return View(joined);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeProgram(int id, MachineAndMyreservationViewModel joinedViewModel)
        {
            BusinessLogicLayer.Program program = programContainer.GetOneProgramByName(joinedViewModel.myreservation.Programname);
            Reservation reser = new Reservation(id, program.ProgramId);

            reservation1.EditOneReservationById(reser);

            TempData["ProgramChanged"] = "Program has been changed to '"+ joinedViewModel.myreservation.Programname+"'";

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Cancel(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            MyreservationViewModel myreservationViewModel = new MyreservationViewModel();
            myreservationViewModel = FetchById(id);
            return View(myreservationViewModel);
        }


        [HttpPost, ActionName("Cancel")]
        [ValidateAntiForgeryToken]
        public IActionResult CancelConfirmed(int id, MyreservationViewModel myreservationViewModel)
        {
            reservationContainer.DeleteOneReservationByBookingId(id);

            TempData["ReservationCancelled"] = "Reservation at '"+myreservationViewModel.Day+ "''" + myreservationViewModel.Timeslot+ "' has been cancelled";

            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public MyreservationViewModel FetchById(int id)
        {
            MyreservationViewModel myreservationViewModel = new MyreservationViewModel();

            Reservation reservation = reservationContainer.GetOneReservationsById(id);
            {
                myreservationViewModel.BookingID = reservation.BookingID;
                myreservationViewModel.TimeslotID = reservation.TimeslotID;
                myreservationViewModel.UserID = reservation.UserID;
                myreservationViewModel.ProgramId = reservation.ProgramID;
                myreservationViewModel.Day = reservation.Timeslot.Day;
                myreservationViewModel.Timeslot = reservation.Timeslot.Timeslot;
                reservation.Currentreservations = reservation1.CurrentReservations(reservation.TimeslotID);
                myreservationViewModel.Currentreservation = reservation.Currentreservations;
                myreservationViewModel.Maxreservations = reservation.Timeslot.Maxreservations;
                myreservationViewModel.Programname = reservation.Program.Programname;
            }

            return myreservationViewModel;
        }
    }
}
