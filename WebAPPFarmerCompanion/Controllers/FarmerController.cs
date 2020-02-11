using WebAPPFarmerCompanion.Models;
using FarmerCompanionDBContext.FarmerSurvey;
using FarmerCompanionDBContext.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPPFarmerCompanion.Controllers
{
    public class FarmerController : Controller
    {
        // GET: Farmer
        [HttpGet]
        public ActionResult Index()
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            return View();
        }
        
        [HttpGet]
        public ActionResult FarmerSurvey()
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            return View();
        }

        [HttpPost]
        public ActionResult FarmerSurvey(FormCollection fc)
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            FarmerSurveys obj = new FarmerSurveys();
            try
            {
                obj.UserId = currentUser.Id;
                obj.Users = new User { Id= currentUser.Id, UserName = currentUser.UserName , Email= currentUser.Email, Industry= currentUser.Industry, Location= currentUser.Location, Password = currentUser.Password };
                obj.AnswerQA = fc["AnswerQA"].ToString();
                obj.AnswerQB = fc["AnswerQB"].ToString();
                obj.AnswerQC = fc["AnswerQC"].ToString();
                obj.SurveyDate = DateTime.Now;

                new FarmerHandler().SaveSurvey(obj);
                TempData.Add("AlertMessage", new AlertModel("Form Saved Successfully !", AlertModel.AlertType.Success));
            }
            catch (Exception ex)
            {
                TempData.Add("AlertMessage", new AlertModel("Error Occurred !", AlertModel.AlertType.Error));
            }
            return View();
        }

        [HttpGet]
        public ActionResult RecommendedSteps()
        {
            User currentUser = Session[WebUtil.CURRENT_USER] as User;
            ViewBag.UserName = currentUser.UserName.ToUpper();
            //ViewBag.SurveyList = new FarmerHandler().GetSurveyListByUserId(currentUser.Id);

            return View(new FarmerHandler().GetSurveyListByUserId(currentUser.Id).ToFarmerSurveyModelList());
        }
    }
}