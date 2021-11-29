using _CovidXWebApp.Models;
using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _CovidXWebApp.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private readonly UserManager<CovidXUser> _userManager;
        private readonly IPatientService _patientService;

        public PatientController(UserManager<CovidXUser> userManager, IPatientService patientService)
        {
            _patientService = patientService;
            _userManager = userManager;
        }

        // GET: Patient
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewPatientProfile()
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
        public IActionResult CreateProfile()
        {
            return View(new PatientCreateViewModel());
        }

        // POST: Patient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProfile(PatientCreateViewModel model)
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
                var patientExists = _patientService.PatientExists(model.UserID = user.Id);

                if (patientExists == true)
                {
                    // reload the registration view with the user's input
                    TempData[WCAlert.Error] = "This patient already exists in DB!";
                    ModelState.AddModelError("Profile Error", "This patient already exists in DB. ");
                    return View(model);
                }

                //If patient does not exist..
                //Create new Patient object
                var patient = new Patient
                {
                    UserID = user.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Idnumber = model.Idnumber,
                    MobileNumber = model.MobileNumber,
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    Dob = model.Dob,
                    MedicalAidStatus = model.MedicalAidStatus,
                    SuburbId = model.SuburbId,
                    PersonResponsible = model.PersonResponsible
                };

                // create the database entry
                if (model.MedicalAidStatus == true)
                {
                    //If MedicalAid Switch Selected
                    //Changed MedicalAidStatus to true
                    patient.MedicalAidStatus = true;
                    patient.MedicalAidPlanId = model.MedicalAidPlanId;
                    patient.MedicalAidNo = model.MedicalAidNo;
                    patient.DependencyCode = model.DependencyCode;
                    //ADD PATIENT
                    _patientService.AddPatient(patient);

                    //if (success)
                    //{
                    //    // update the Identity user-name
                    //    string username = model.Patient.FirstName + " " + model.Patient.LastName;
                    //    await _userManager.SetUserNameAsync(user, username);
                    //}
                }
                else if (model.MedicalAidStatus == false)
                {
                    //If MedicalAid Switch not selected
                    patient.MedicalAidStatus = false;
                    _patientService.AddPatient(patient);

                    //if (success)
                    //{
                    //    // update the Identity user-name
                    //    string username = model.Patient.FirstName + " " + model.Patient.LastName;
                    //    await _userManager.SetUserNameAsync(user, username);
                    //}
                }

                //return View();
                //Add alert
                TempData[WCAlert.Success] = "Patient Profile created successfully!";
                return RedirectToAction("Dashboard", "Home");
                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            TempData[WCAlert.Success] = "Patient Profile could not be created!";
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
        }




        // GET: Patient/Update
        [HttpGet]
        public IActionResult UpdateProfile(/*int id*/)
        {
            //////Find user by email
            var user1 = _userManager.FindByEmailAsync(User.Identity.Name).Result;

            ////find patient using USerID
            var patient = _patientService.FindPatientByUserID(user1.Id);
            //id = patient.PatientId;

            PatientEditViewModel vm = new()
            {
                PatientId = patient.PatientId,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Idnumber = patient.Idnumber,
                AddressLine1 = patient.AddressLine1,
                AddressLine2 = patient.AddressLine2,
                MobileNumber = patient.MobileNumber,
                Gender = patient.Gender,
                Dob = patient.Dob,
                SuburbId = patient.SuburbId,
                MedicalAidNo = patient.MedicalAidNo,
                MedicalAidStatus = patient.MedicalAidStatus,
                DependencyCode = patient.DependencyCode,
                MedicalAidPlanId = patient.MedicalAidPlanId
            };
            //vm.PatientId = patient.PatientId;
            //Find patient by patient ID
            //var patient = _patientService.FindPatientByPatientID(id);
            return View(vm);
        }

        // POST: Patient/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProfile(PatientEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var patient = _patientService.FindPatientByPatientID(model.PatientId);
                patient.FirstName = model.FirstName;
                patient.LastName = model.LastName;
                patient.Idnumber = model.Idnumber;
                patient.AddressLine1 = model.AddressLine1;
                patient.AddressLine2 = model.AddressLine2;
                patient.MobileNumber = model.MobileNumber;
                patient.Gender = model.Gender;
                patient.Dob = model.Dob;
                patient.SuburbId = model.SuburbId;
                patient.MedicalAidNo = model.MedicalAidNo;
                patient.MedicalAidStatus = model.MedicalAidStatus;
                patient.DependencyCode = model.DependencyCode;
                patient.MedicalAidPlanId = model.MedicalAidPlanId;

                //pass through patient
                _patientService.UpdatePatient(patient);

                //return View();
                //Add alert
                TempData[WCAlert.Success] = "Patient Profile updated successfully!";
                return RedirectToAction("ViewPatientProfile", "Patient");
                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            TempData[WCAlert.Error] = "Patient Profile could not be updated!";
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
        }



        [HttpGet]
        public IActionResult RegisterDependent()
        {

            return View(new DependentCreateViewModel());
        }

        // POST: Patient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterDependent(DependentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                // get user id value...
                //var user = _userManager.GetUserIdAsync(User.Identity.Name);
                //var user = await _userManager.GetUserAsync(User);
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                //Find patient by user ID
                var patient = _patientService.FindPatientByUserID(user.Id);

                //If found  ...add that as a foreign key

                //model.MainMemberId = patient.PatientId;

                //If patient does not exist..
                //Create new Patient object
                var dependent = new Dependent
                {
                    MainMemberId = patient.PatientId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Idnumber = model.Idnumber,
                    MobileNumber = model.MobileNumber,
                    EmailAddress = model.EmailAddress,
                    Dob = model.Dob,
                    MedicalAidStatus = model.MedicalAidStatus,

                    DependentTypeId = model.DependentTypeId,
                    PersonResponsible = model.PersonResponsible
                    
                };

                //If address is same as Main Member,
                //populate those values from Main Member table
                if (model.AddressSameasMainMember == true)
                {
                    dependent.AddressLine1 = patient.AddressLine1;
                    dependent.AddressLine2 = patient.AddressLine2;
                    dependent.SuburbId = patient.SuburbId;
                }
                else if (model.AddressSameasMainMember == false)
                {
                    dependent.AddressLine1 = model.AddressLine1;
                    dependent.AddressLine2 = model.AddressLine2;
                    dependent.SuburbId = model.SuburbId;
                }

                // create the database entry
                if (model.MedicalAidStatus == true)
                {
                    //If MedicalAid Switch Selected
                    //Changed MedicalAidStatus to true
                    dependent.MedicalAidStatus = true;

                    //If MedicalAidSame as Main Member,
                    //get medical aid details from Patient Table
                    if (model.MedicalAidSameasMainMember == true)
                    {
                        dependent.MedicalAidPlanId = patient.MedicalAidPlanId;
                        dependent.MedicalAidNo = patient.MedicalAidNo;
                        dependent.DependencyCode = model.DependencyCode;
                    }
                    else if (model.MedicalAidSameasMainMember == false)
                    {
                        dependent.MedicalAidPlanId = model.MedicalAidPlanId;
                        dependent.MedicalAidNo = model.MedicalAidNo;
                        dependent.DependencyCode = model.DependencyCode;
                    }

                    //Add dependent
                    _patientService.AddDependent(dependent);

                    
                }
                else if (model.MedicalAidStatus == false)
                {
                    //If MedicalAid Switch not selected
                    dependent.MedicalAidStatus = false;
                    //ADD DEPENDENT
                    _patientService.AddDependent(dependent);

                  
                }

                //return View();
                //Add alert
                TempData[WCAlert.Success] = "Dependent added successfully!";
                return RedirectToAction("Dashboard", "Home");
                //return RedirectToAction("ProfileAvatar", "Profile", new { model });
            }

            // reload the page with the user's input
            TempData[WCAlert.Error] = "Dependent could not be added!";
            //ModelState.AddModelError(string.Empty, "Could not create profile. Try again");
            return View(model);
        }



        // GET: Test Request/Create
        [HttpGet]
        public IActionResult RequestTest()
        {
            //////Find user by email
            var user1 = _userManager.FindByEmailAsync(User.Identity.Name).Result;

            ////find patient using USerID
            var patient = _patientService.FindPatientByUserID(user1.Id);
            //patient.PatientId = patient.PatientId;

            TestRequestCreateViewModel vm = new()
            {
                SuburbId = patient.SuburbId
            };


            return View(vm);
         
        }

        // POST: TestRequest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestTest(TestRequestCreateViewModel model)
        {
            // no validation errors
            if (ModelState.IsValid)
            {
                // who is making the test request ?
                var user = await _userManager.GetUserAsync(User);
                var patient = _patientService.FindPatientByUserID(user.Id);


                // Assign PatientID 
                model.PatientId = patient.PatientId;

                // is this request for the patient ?
                if (model.testforMyself)
                {
                    // create a test request for the patient
                    _patientService.AddTestRequest(model);
                }

                // is this request for the dependant ?
                if (model.SelectedDependentIds?.Length > 0)
                {
                    // create a test request for the dependant(s)
                    foreach (var dependantID in model.SelectedDependentIds)
                    {
                        //Assign PatientID

                        // Assign dependentID 
                        model.DependentId = dependantID;
                        // create a test request for one depedant
                        _patientService.AddTestRequest(model);
                    }
                }

                return RedirectToAction("Dashboard", "Home");
            }


            return View(model);
        }
        [HttpPost]
        public IActionResult CancelTest(int testRequestID, string userID)
        {
            // call the database service
           var result = _patientService.CancelTest(testRequestID, userID);

            if(result)
            {
                TempData[WCAlert.Success] = "Test Requests has been cancelled!";
                return RedirectToAction("Dashboard", "Home");
            }

            TempData[WCAlert.Error] = "Test Requests could not be cancelled!";
            return RedirectToAction("Dashboard", "Home");
        }
    }


        //// POST: Patient/Delete/5
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult CancelRequest(TestRequestCreateViewModel model)
        // {
        //     TestRequest entity = new TestRequest();
        //     model.RequestStatus = CovidEnums.TestRequestStatus.Cancelled;
        //     entity.RequestStatus = model.RequestStatus;

        //     var result =  _patientService.CancelRequest(entity);

        //     if (result)
        //     {
        //         //Add alert
        //         TempData[WCAlert.Success] = "Test Request Cancelled successfully!";
        //         return RedirectToAction("Dashboard", "Home");
        //     }
        //     //Add alert
        //     TempData[WCAlert.Error] = "Test Request Cancellation Error";
        //     return RedirectToAction("Dashboard", "Home");
        // }

        // [HttpGet]
        // [ValidateAntiForgeryToken]
        // public IActionResult CancelRequest(int? TestRequestID)
        // {

        //     return RedirectToAction("Dashboard", "Home", TestRequestID);
        // }



















        //// GET: Patient/Edit/5
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Patient/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int id, PatientCreateViewModel model)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //    // GET: Patient/Delete/5
        //    public IActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Patient/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
    
}