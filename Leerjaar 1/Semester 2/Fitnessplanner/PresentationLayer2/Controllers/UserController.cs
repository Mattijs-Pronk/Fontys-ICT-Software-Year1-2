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
    public class UserController : Controller
    {
        User user = new User(new UserDAL());
        UserContainer userContainer = new UserContainer(new UserDAL());
        ReservationContainer reservationContainer = new ReservationContainer(new ReservationDAL());


        public IActionResult Index(string searchPhrase)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            UserViewModel userViewmodel = new UserViewModel();
            ListViewModel list = new ListViewModel();

            //list vullen met alle users
            foreach (User user in userContainer.GetAllUsers())
            {
                userViewmodel = new UserViewModel(user.Id, user.Firstname, user.Lastname, user.Adress, user.Email, user.Password, user.Usertype, user.SubscriptionStart, user.SubscriptionEnd);
                list.allusers.Add(userViewmodel);
            }

            //zoekfunctie
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                if (userContainer.UserExists(searchPhrase))
                {
                    User user = userContainer.GetOneUserByEmail(searchPhrase);
                    userViewmodel = new UserViewModel(user.Id, user.Firstname, user.Lastname, user.Adress, user.Email, user.Password, user.Usertype, user.SubscriptionStart, user.SubscriptionEnd);
                    list.allusers.Clear();
                    list.allusers.Add(userViewmodel);
                }
                else
                {
                    ViewBag.EmailNotFound = "Email not found!";
                }
            }

            return View(list.allusers);
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            //viewbag aanmaken
            var list = new List<string>()
            {
                "User",
                "Admin"
            };
            ViewBag.list = list;

            UserViewModel userViewModel = new UserViewModel();
            return View(userViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserViewModel userViewModel)
        {
            if (userContainer.UserExists(userViewModel.Email))
            {
                //message die word laten zien(zie verder in Vieuws/User/Create)
                TempData["UserNotCreated"] = "User with this email already exists (user not created)!";
                var list = new List<string>()
                    {
                        "User",
                        "Admin"
                    };
                ViewBag.list = list;

                //blijf op dezelfde pagina
                return View("Create");
            }
            else
            {
                TempData["UserCreated"] = "Succesfully created user with email: '" + userViewModel.Email + "'";
                User us1 = new User(userViewModel.Firstname, userViewModel.Lastname, userViewModel.Adress, userViewModel.Email, userViewModel.Password, userViewModel.Usertype, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.AddDays(1).ToString("dd-MM-yyyy"));
                userContainer.AddOneUser(us1);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: User/Edit/5
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            UserViewModel userViewModel = new UserViewModel();
            userViewModel = FetchById(id);

            //viewbag aanmaken
            var usertype = new List<string>()
            {
                "User",
                "Admin"
            };
            ViewBag.usertype = usertype;

            //viewbag aanmaken
            var Currentdate = DateTime.Now;
            var subscription = new List<string>()
                {
                userViewModel.SubscriptionEnd,
                Currentdate.AddMonths(1).ToString("dd-MM-yyyy"),
                Currentdate.AddMonths(3).ToString("dd-MM-yyyy"),
                Currentdate.AddMonths(6).ToString("dd-MM-yyyy"),
                Currentdate.AddMonths(9).ToString("dd-MM-yyyy"),
                Currentdate.AddMonths(12).ToString("dd-MM-yyyy")
                };
            ViewBag.subscription = subscription;

            return View(userViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UserViewModel userViewModel)
        {
            if (userContainer.CheckForPermisson(id) == false)
            {
                TempData["UserNotEdited"] = "Selected user is an admin (insufficient permissions)";

                //blijft op dezelfde pagina
                return RedirectToAction("Edit");
            }
            else
            {
                TempData["UserEdited"] = "Succesfully edited user (new email: '" + userViewModel.Email + "')";

                User us1 = new User(userViewModel.Id, userViewModel.Firstname, userViewModel.Lastname, userViewModel.Adress, userViewModel.Email, userViewModel.Password, userViewModel.Usertype, DateTime.Now.ToString("dd-MM-yyyy"), userViewModel.SubscriptionEnd);
                user.EditOneUserById(us1);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: User/Delete/5
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            UserViewModel userViewModel = new UserViewModel();
            userViewModel = FetchById(id);

            return View(userViewModel);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(UserViewModel userViewModel)
        {
            if (userContainer.CheckForPermisson(userViewModel.Id) == false)
            {
                TempData["UserNotDeleted"] = "Selected user with email: '" + userViewModel.Email + "' is an admin (insufficient permissions)";
            }
            else
            {
                reservationContainer.DeleteAllReservationsByUserId(userViewModel.Id);
                userContainer.DeleteOneUserById(userViewModel.Id);

                TempData["UserDeleted"] = "Succesfully deleted user with email: '" + userViewModel.Email + "'";
            }

            return RedirectToAction(nameof(Index));
        }


        [NonAction]
        public UserViewModel FetchById(int id)
        {
            UserViewModel userViewModel = new UserViewModel();

            User user = userContainer.GetOneUserById(id);
            {
                userViewModel.Id = user.Id;
                userViewModel.Firstname = user.Firstname;
                userViewModel.Lastname = user.Lastname;
                userViewModel.Adress = user.Adress;
                userViewModel.Email = user.Email;
                userViewModel.Password = user.Password;
                userViewModel.Usertype = user.Usertype;
                userViewModel.SubscriptionStart = user.SubscriptionStart;
                userViewModel.SubscriptionEnd = user.SubscriptionEnd;
            }

            return userViewModel;
        }
    }
}
