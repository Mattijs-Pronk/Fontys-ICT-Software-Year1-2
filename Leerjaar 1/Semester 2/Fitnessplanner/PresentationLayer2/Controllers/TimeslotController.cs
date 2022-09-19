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
    public class TimeslotController : Controller
    {
        Timeslot timeslot = new Timeslot(new TimeslotDAL());
        TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDAL());
        Reservation reservation = new Reservation(new ReservationDAL());
        ReservationContainer reservationContainer = new ReservationContainer(new ReservationDAL());


        public IActionResult Index(string searchPhrase)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            TimeslotViewModel timeslotViewmodel = new TimeslotViewModel();
            ListViewModel list = new ListViewModel();

            //list vullen met alle tijdsloten
            foreach (Timeslot timeslot in timeslotContainer.GetAllTimeslots())
            {
                timeslotViewmodel = new TimeslotViewModel(timeslot.TimeslotID, timeslot.Day, timeslot.Timeslots, timeslot.Currentreservations, timeslot.Maxreservations);
                list.alltimeslots.Add(timeslotViewmodel);
            }

            //zoekfunctie
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                list.alltimeslots.Clear();
                foreach (Timeslot timeslot in timeslotContainer.GetTimeslotsByDay(searchPhrase))
                {
                    timeslotViewmodel = new TimeslotViewModel(timeslot.TimeslotID, timeslot.Day, timeslot.Timeslots, timeslot.Currentreservations, timeslot.Maxreservations);
                    list.alltimeslots.Add(timeslotViewmodel);
                }
                if (list.alltimeslots.Count < 1)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(list.alltimeslots);
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            //viewbag aanmaken
            var list = new List<string>()
            {
                "08:00 - 09:00",
                "09:00 - 10:00",
                "10:00 - 11:00",
                "11:00 - 12:00",
                "12:00 - 13:00",
                "13:00 - 14:00",
                "14:00 - 15:00",
                "16:00 - 17:00",
                "18:00 - 19:00",
                "19:00 - 20:00",
                "20:00 - 21:00",
                "21:00 - 22:00",
                "22:00 - 23:00"
            };
            ViewBag.list = list;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TimeslotViewModel timeslotViewModel)
        {
            TempData["TimeslotCreated"] = "Succesfully created Timeslot: '" + timeslotViewModel.Day + "' at '" + timeslotViewModel.Timeslots + "'";
            Timeslot time = new Timeslot(timeslotViewModel.Day, timeslotViewModel.Timeslots, timeslotViewModel.Maxreservations);
            timeslotContainer.AddOneTimeslot(time);
            return RedirectToAction(nameof(Index));
        }

        // GET: Timeslot/Edit/5
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            //viewbag aanmaken
            var list = new List<string>()
            {
                "08:00 - 09:00",
                "09:00 - 10:00",
                "10:00 - 11:00",
                "11:00 - 12:00",
                "12:00 - 13:00",
                "13:00 - 14:00",
                "14:00 - 15:00",
                "16:00 - 17:00",
                "18:00 - 19:00",
                "19:00 - 20:00",
                "20:00 - 21:00",
                "21:00 - 22:00",
                "22:00 - 23:00"
            };
            ViewBag.list = list;

            TimeslotViewModel timeslotViewModel = new TimeslotViewModel();
            timeslotViewModel = FetchById(id);
            return View(timeslotViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TimeslotViewModel timeslotViewModel)
        {
            TempData["TimeslotEdited"] = "Succesfully edited Timeslot with new: '" + timeslotViewModel.Day + "' at '" + timeslotViewModel.Timeslots + "'";

            Timeslot time = new Timeslot(timeslotViewModel.TimeslotID, timeslotViewModel.Day, timeslotViewModel.Timeslots, timeslotViewModel.Maxreservations);
            timeslot.EditOneTimeslotById(time);

            return RedirectToAction(nameof(Index));
        }

        // GET: Timeslot/Delete/5
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            TimeslotViewModel timeslotViewModel = new TimeslotViewModel();
            timeslotViewModel = FetchById(id);

            return View(timeslotViewModel);
        }

        // POST: Timeslot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, TimeslotViewModel timeslotViewModel)
        {
            TempData["TimeslotDeleted"] = "Succesfully deleted Timeslot with: '" + timeslotViewModel.Day + "' at '" + timeslotViewModel.Timeslots + "'";

            reservationContainer.DeleteAllReservationsByTimeslotId(id);
            timeslotContainer.DeleteOneTimeslotById(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("CreateNewDay")]
        public IActionResult CreateNewWeek()
        {
            foreach (Timeslot timeslot in timeslotContainer.GetTimeslotsByDay(DateTime.Now.ToString("dd-MM-yyyy")))
            {
                timeslotContainer.DeleteOneTimeslotById(timeslot.TimeslotID);
            }

            timeslotContainer.NewDay();

            TempData["NewDayadded"] = "New day added, current day removed";

            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public TimeslotViewModel FetchById(int id)
        {
            TimeslotViewModel timeslotViewModel = new TimeslotViewModel();

            Timeslot timeslot = timeslotContainer.GetOneTimeslotById(id);

            timeslotViewModel.TimeslotID = timeslot.TimeslotID;
            timeslotViewModel.Day = timeslot.Day;
            timeslotViewModel.Timeslots = timeslot.Timeslots;
            timeslotViewModel.Currentreservations = reservation.CurrentReservations(id);
            timeslotViewModel.Maxreservations = timeslot.Maxreservations;

            return timeslotViewModel;
        }
    }
}
