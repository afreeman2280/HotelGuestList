using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningMVC2.Models;
using BusinessLogic;
using BusinessLogic.BusinessLogicObject;

namespace LearningMVC2.Controllers
{
     
    public class UserController : Controller
    {
        UserBusinessLogic UBL = new UserBusinessLogic();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login(UserViewModel userVM)
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Registar()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registar(UserViewModel userVm)
        {
            return View();
        }
    }
}