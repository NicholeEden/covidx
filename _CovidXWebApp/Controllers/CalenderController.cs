using _CovidXWebApp.Models;
using _CovidXWebApp.Models.Services;
using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Email;

namespace _CovidXWebApp.Controllers
{
    /// <summary>
    /// Controller that contains the methods for scheduling assigned test requests
    /// </summary>
    public class CalenderController:Controller
    {
        private readonly ICalenderService _calendarService;
        private readonly IEmailService _emailer;
       
        public CalenderController(ICalenderService calenderService, IEmailService emailer)
        {
            _calendarService = calenderService;
         
            _emailer = emailer;
        }
        

        public IActionResult Index()
        {
            // model will load the assigned test requests
            return View(new CalenderViewModel());
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            // calendar will call this action to load it's calendar events
            var output = _calendarService.GetEvents();

            return Json(output);
        }

        [HttpPost]
        public IActionResult Update(CalenderEventModel model)
        {


            //Add calender event to test request and update status
            var success = _calendarService.AddEvents(model);
            model.Start = Convert.ToDateTime(model.StartText.Substring(0, 25));
            model.End = Convert.ToDateTime(model.EndText.Substring(0, 25));



            if (success)
            {
                //Send email to patient
                //TODO: User email and Patient Name
                _emailer.SendPatientNotification((int)model.ID);
                //TempData[WCAlert.Success] = "Test request has been successfully scheduled";
                TempData[WCAlert.Success] = "Test request has been successfully scheduled and Email has been sent";
                //Update TestRequest status for a specific test request
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData[WCAlert.Error] = "Cannot schedule a test request in the past. Try again";
                return RedirectToAction(nameof(Index)); ;
            }

            //return View("Index",model);
        }


    }
}
