using FarmerCompanionDBContext.Users;
using FarmerCompanionDBContext.FarmerSurvey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebAPPFarmerCompanion.Models;
using WebAPPFarmerCompanion.Models.Users;

namespace WebAPPFarmerCompanion.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View("~/Views/Users/Login.cshtml",model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                User currentUser = new UserHandler().GetUser(model.LoginId, model.Password);
                if (currentUser != null)
                {
                    Session.Add(WebUtil.CURRENT_USER, currentUser);
                    return RedirectToAction("Index", "Farmer");
                }
            }
            catch (Exception ex)
            {
                TempData.Add("AlertMessage", new AlertModel($"Please Try Correct Email Or Password ! {ex.Message}", AlertModel.AlertType.Error));
            }
            TempData.Add("AlertMessage", new AlertModel($"Please Try Correct Email Or Password !", AlertModel.AlertType.Error));
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(FormCollection fc)
        {
            User user = new User();
            try
            {
                user.UserName = fc["UserName"].ToString().Trim();
                user.Email = fc["Email"].ToString().Trim();
                user.Industry = fc["Industry"].ToString().Trim();
                user.Location = fc["Location"].ToString().Trim();
                user.Password = fc["Password"].ToString();

                new UserHandler().RegisterUser(user);
                TempData.Add("AlertMessage", new AlertModel("Register Successfully !", AlertModel.AlertType.Success));
            }
            catch (Exception ex)
            {
                TempData.Add("AlertMessage", new AlertModel("Error Occurred !", AlertModel.AlertType.Error));
            }
            return RedirectToAction("SignUp");
        }

        [HttpGet]
        public ActionResult RecoverPassword()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserProfile()
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            ViewBag.UserProfile = currentUser;
            return View();
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            ViewBag.UserProfile = currentUser;
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(FormCollection fc)
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            ViewBag.UserProfile = currentUser;
            try
            {

            }
            catch(Exception ex) { }
            return View();
        }
    }
}