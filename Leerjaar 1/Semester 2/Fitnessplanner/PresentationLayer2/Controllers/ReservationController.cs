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
    public class ReservationController : Controller
    {
        Timeslot timeslot = new Timeslot(new TimeslotDAL());
        TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDAL());
        Reservation reservation = new Reservation(new ReservationDAL());
        ReservationContainer reservationContainer = new ReservationContainer(new ReservationDAL());


        public IActionResult Index(string searchPhrase)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            ReservationViewModel reservationViewModel = new ReservationViewModel();
            ListViewModel list = new ListViewModel();

            //viewbag aanmaken
            var alldays = new List<string>();
            foreach (Timeslot userdays in timeslotContainer.GetAllDays())
            {
                alldays.Add(userdays.Day);
            }
            ViewData["alldays"] = alldays.ToList();
            ViewBag.alldays = alldays;

            //zoekfunctie
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                foreach (Timeslot usertimeslot in timeslotContainer.GetTimeslotsByDay(searchPhrase))
                {
                    reservationViewModel = new ReservationViewModel(usertimeslot.TimeslotID, usertimeslot.Day, usertimeslot.Timeslots, usertimeslot.Currentreservations, usertimeslot.Maxreservations);
                    list.availabletimeslots.Add(reservationViewModel);
                }
            }

            return View(list.availabletimeslots);
        }


        public IActionResult Reserve(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            ReservationViewModel reservationViewModel = new ReservationViewModel();
            reservationViewModel = FetchById(id);

            return View(reservationViewModel);
        }


        [HttpPost, ActionName("Reserve")]
        public IActionResult ReserveConfirmed(int id, ReservationViewModel reservationViewModel)
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));

            UserViewModel userViewModel = new UserViewModel();
            UserController userController = new UserController();

            userViewModel = userController.FetchById(userId);
            int ProgramId = 1;

            User user = new User(userId, userViewModel.SubscriptionStart, userViewModel.SubscriptionEnd);
            if(reservationContainer.CanUserReserveTimeslot(user, reservationViewModel.Day, reservationViewModel.Currentreservations, reservationViewModel.Maxreservations, id) == false)
            {
                TempData["NotReserved"] = "possible reasons: timeslot fully booked, you already have a reservation at this timeslot or you dont have a valid subscription";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["Reserved"] = "Chosen timeslot has been reserved";
                Reservation reser1 = new Reservation(userId, id, ProgramId);
                reservationContainer.AddOneReservation(reser1);
            }
            
            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public ReservationViewModel FetchById(int id)
        {
            ReservationViewModel reservationViewModel = new ReservationViewModel();

            Timeslot timeslot = timeslotContainer.GetOneTimeslotById(id);

            reservationViewModel.TimeslotID = timeslot.TimeslotID;
            reservationViewModel.Day = timeslot.Day;
            reservationViewModel.Timeslots = timeslot.Timeslots;
            reservationViewModel.Currentreservations = reservation.CurrentReservations(id);
            reservationViewModel.Maxreservations = timeslot.Maxreservations;

            return reservationViewModel;
        }
    }
}
