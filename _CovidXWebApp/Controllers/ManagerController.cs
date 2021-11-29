using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Controllers
{
    public class ManagerController:Controller
    {
        private readonly UserManager<CovidXUser> _userManager;
        private readonly INurseService _nurseService;

        public ManagerController(UserManager<CovidXUser> userManager,INurseService nurseService)
        {
            _userManager = userManager;
            _nurseService = nurseService;
        }
        [HttpGet]
        public IActionResult Reports()
        {
            

            return View();
        }


        [HttpPost]
        public IActionResult Reports(ManagerViewModel model)
        {


            if (ModelState.IsValid)
            {
               
                //Get date range inputs
                var range = model.DateInput.Split('-');
                model.StartDate = Convert.ToDateTime(range[0]);
                model.EndDate = Convert.ToDateTime(range[1]);


                _nurseService.GetReportDetails(model.nurseID, model.StartDate, model.EndDate);
                return View(model);
            }
              

            
            return View();
        }



    }
}
