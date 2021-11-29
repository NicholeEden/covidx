
using _CovidXWebApp.Models;
using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace _CovidXWebApp.Controllers
{
    
    [Authorize]
    public class NurseController : Controller
    {
        private readonly UserManager<CovidXUser> _userManager;
        private readonly INurseService _nurseService;
        public NurseController(UserManager<CovidXUser> userManager, INurseService nurseService)
        {
            _nurseService = nurseService;
            _userManager = userManager;
        }
       
        // GET: Patient
        public IActionResult Index()
        {
            return View();
        }

        // GET: Patient/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Patient/Create
        [HttpGet]
        public IActionResult CreateNurseProfile()
        {
            

            return View(new NurseCreateViewModel());
        }

        //POST: Patient/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNurseProfile(NurseCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //// get user id value...
                ////var user = _userManager.GetUserIdAsync(User.Identity.Name);
                //var user = await _userManager.GetUserAsync(User);
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                // ...add that as a foreign key
                //model.UserID = user.Id;

                //Check if patient already exist
                var nurseExists = _nurseService.NurseExists(user.Id);

                if (nurseExists == true)
                {
                    // reload the registration view with the user's input
                    TempData[WCAlert.Error] = "This nurse already exists in DB!";
                    ModelState.AddModelError("Profile Error", "This nurse already exists in DB. ");
                    return View(model);
                }

                //If patient does not exist..
                //Create new Patient object
                var nurse = new Nurse
                {
                    UserID = user.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Idnumber = model.Idnumber,
                    MobileNumber = model.MobileNumber,
                    SuburbId = model.SuburbId,
                    Rank = model.Rank,
                    YearQualified = model.YearQualified
                };

                var result =  _nurseService.AddNurse(nurse);
                
                if(result)
                {

                    //return View();
                    //Add alert
                    TempData[WCAlert.Success] = "Nurse Profile created successfully!";
                    return RedirectToAction("Dashboard", "Home");
                }

                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            TempData[WCAlert.Success] = "Nurse Profile could not be created!";
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);

        }

        // GET: Patient/Edit/5
        [HttpGet]
        public IActionResult ViewNurseProfile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PickSuburbs(NurseSuburbsModel model)
        {
            // no validation errors
            if (ModelState.IsValid)
            {
                // who is making the test request ?
                var user = await _userManager.GetUserAsync(User);
                var nurse = _nurseService.FindNurseByUserID(user.Id);


              
                  //Loop through the selected suburbs
                if (model.SelectedSuburbsIds?.Length > 0)
                {
                    // create a new suburbs preffered record for the nurse
                    foreach (var nurseID in model.SelectedSuburbsIds)
                    {
                        //Assign NurseID
                        model.NurseId = nurse.NurseId;
                        // Assign suburb ID
                        model.SuburbId = nurseID;
                        // add a favourite suburb for one nurse
                        _nurseService.AddSuburbs(model);
                    }
                }

                return RedirectToAction("ViewNurseProfile");
            }


            return View(model);
        }

        [HttpPost]
        public IActionResult Assign(int testRequestID, string userID)
        {


            // call the database service
           var result =  _nurseService.AssignNurse(testRequestID, userID);

            if(result)
            {
                TempData[WCAlert.Success] = "Test Request has been assigned!";
                return RedirectToAction("Dashboard", "Home");
            }
            TempData[WCAlert.Error] = "Test Request could not be assigned!";
            return RedirectToAction("Dashboard", "Home");
     
        }
        [HttpGet]
        public IActionResult ScheduledRequests()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllScheduledRequests()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PerformTest(TestViewModel model)
        {
            if(ModelState.IsValid)

            {
               _nurseService.AddTestDetails(model);
                TempData[WCAlert.Success] = "Test details captured successfully!";
                
                return RedirectToAction("ScheduledRequests");
            }
            //

         
            TempData[WCAlert.Error] = "Error! Failed to capture test details";
            return View("AllScheduledRequests", model);
        }

        [HttpGet]

        public IActionResult ViewAllRequests()
        {
            return View();
        }

        [HttpGet]

        public IActionResult ViewAssigned()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UnAssignTest(int testRequestID, int nurseID)
        {
            // call the database service
            var result = _nurseService.UnAssignTest(testRequestID, nurseID);

            if (result)
            {
                TempData[WCAlert.Success] = "Test Request has been unassigned!";
                return RedirectToAction("Dashboard", "Home");
            }

            TempData[WCAlert.Error] = "Test Request could not be unassigned!";
            return RedirectToAction("ViewAssigned", "Nurse");
        }




        //


    }
}
