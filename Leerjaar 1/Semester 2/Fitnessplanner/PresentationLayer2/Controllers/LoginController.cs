using BusinessLogicLayer;
using DatabaseLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Controllers
{
    public class LoginController : Controller
    {
        Login login = new Login(new LoginDAL());
        User user = new User();
        UserContainer userContainer = new UserContainer(new UserDAL());
        TimeslotContainer timeslotContainer = new TimeslotContainer(new TimeslotDAL());

        public IActionResult Index()
        {
            HttpContext.Session.Clear();

            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(LoginViewModel loginViewModel)
        {
            Login log = new Login(loginViewModel.Email, loginViewModel.Password);
            if(login.LoginUserExists(log))
            {
                login.LoginUser(log);

                //session Id meegeven.
                HttpContext.Session.SetInt32("UserID", Login.userId);
                HttpContext.Session.SetString("UserType", Login.userusertype);

                return RedirectToAction("Index", "Reservation");
            }
            else
            {
                TempData["UserDontExist"] = "Incorrect email or password!";
                return RedirectToAction("Index", loginViewModel);
            }
        }

        public IActionResult LogoutUser()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }

        public IActionResult MyProfile()
        {
            if (HttpContext.Session.GetInt32("UserID") == null) { Response.Redirect("/Login/Index"); }

            UserViewModel userViewModel = new UserViewModel();

            int userId = (int)HttpContext.Session.GetInt32("UserID");

            UserController usController = new UserController();
            userViewModel = usController.FetchById(userId);

            return View(userViewModel);
        }
    }
}
