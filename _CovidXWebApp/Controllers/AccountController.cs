using _CovidXWebApp.Models;
using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _CovidXWebApp.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Implementation to facilitate login/out and registration
        /// </summary>
        private readonly UserManager<CovidXUser> _userManager;

        /// <summary>
        /// Implementation to facilitate the sign in and sign out
        /// </summary>
        private readonly SignInManager<CovidXUser> _signInManager;

       
        private readonly RoleManager<IdentityRole> _roleManager;

        // private readonly CovidXSQLDBContext _context;

        public AccountController(UserManager<CovidXUser> userManager, SignInManager<CovidXUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           
            _roleManager = roleManager;
            // _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            // did they provide a valid email and password?
            if (ModelState.IsValid)
            {
                // attempt to find the user based on the Email
                var user = await _userManager.FindByEmailAsync(model.Email);
                var validPassword = await _userManager.CheckPasswordAsync(user, model.Password);
                // if the user was not found
                if (user is null)
                {
                    // reload the page with the user's input
                    return View(model);
                }

                // attempt to sign the user in
                if (validPassword == true)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, password: model.Password, isPersistent: false, lockoutOnFailure: false);
                    // was the sign in successful
                    if (result.Succeeded)
                    {
                        //// send the user to the dashboard page
                        //TempData[WCAlert.Success] = "User logged in!";
                        return RedirectToAction("Dashboard", "Home");

                        
                    }
                }
            }
            // reload the page with the user's input
            //Add alert
            TempData[WCAlert.Error] = "Login was unsuccessful";
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            // sign the user out
            await _signInManager.SignOutAsync();

            // redirect to the sign in page
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
           
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model) // create patient
        {
            

            // verify that the model properties passed validation
            if (ModelState.IsValid)
            {
                // verify if email is already registered
                var existingUser = await _userManager.FindByEmailAsync(model.Email); // create a state machine and wait for the result

                /* var existingUser = _userManager.FindByEmailAsync(model.Email); => create a state machine and proceed with the next line of code */

                if (existingUser is not null)
                {
                    // reload the registration view with the user's input
                    TempData[WCAlert.Error] = "This email is already in use. Please try to login or use a different email!";
                    ModelState.AddModelError("Email Error", "This email is already in use. Please try to login or use a different email.");
                    return View(model);
                }

                // create a user object and specify the details
                var newUser = new CovidXUser { Email = model.Email, UserName = model.Email, IsActive = true,UserType="P" };

                // create the user on the database
                var result = await _userManager.CreateAsync(newUser, model.Password);

                // was the user create successfully
                if (result.Succeeded)
                {
                    

                    //Add a patient role
                    bool patientRoleExists = await _roleManager.RoleExistsAsync("Patient");
                    if (!patientRoleExists)
                    {
                        var roleResult = await _roleManager.CreateAsync(new IdentityRole() { Name = "Patient", NormalizedName = "Patient".ToUpper() });
                    }

                    // Select the user, and then add the patient role to the user
                    //newUser = await _userManager.FindByNameAsync(model.Email);
                    if (!await _userManager.IsInRoleAsync(newUser, "Patient"))
                    {
                        //_logger.LogInformation("Adding sysadmin to Admin role");
                        var userResult = await _userManager.AddToRoleAsync(newUser, "Patient");

                        //Sign user in

                        //if (userResult.Succeeded)
                        //{
                        //    await _signInManager.SignInAsync(newUser, isPersistent: false);
                        //}
                    }



                    // sign the user in if register


                    //// is the string empty ?
                    //bool isEmpty = string.IsNullOrWhiteSpace(returnUrl);

                    //// is the string not empty?
                    //bool urlProvided = (isEmpty == false);

                    //// is the URL valid
                    //bool isValidUrl = Url.IsLocalUrl(returnUrl);

                    //// return the user to the previous page
                    //if (urlProvided && isValidUrl)
                    //{
                    //    // redirect the user to the previous page
                    //    return Redirect(returnUrl);
                    //}

                    //Add alert
                    TempData[WCAlert.Success] = "User created successfully";
                    // redirect the user to a page
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

           
            // reload the registration view with the user's input
            TempData[WCAlert.Error] = "Registration Attempt Unsuccessful";
            //ModelState.AddModelError(string.Empty, "Registration Attempt Unsuccessful");
            return View(model);
        }



        [HttpGet]
        public IActionResult RegisterNurse()
        {

            return View();
        }



        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterNurse(RegisterModel model) // create patient
        {


            // verify that the model properties passed validation
            if (ModelState.IsValid)
            {
                // verify if email is already registered
                var existingUser = await _userManager.FindByEmailAsync(model.Email); // create a state machine and wait for the result

                /* var existingUser = _userManager.FindByEmailAsync(model.Email); => create a state machine and proceed with the next line of code */

                if (existingUser is not null)
                {
                    // reload the registration view with the user's input
                    TempData[WCAlert.Error] = "This email is already in use. Please try to login or use a different email!";
                    ModelState.AddModelError("Email Error", "This email is already in use. Please try to login or use a different email.");
                    return View(model);
                }

                // create a user object and specify the details
                var newUser = new CovidXUser { Email = model.Email, UserName = model.Email, IsActive = true, UserType = "N" };

                // create the user on the database
                var result = await _userManager.CreateAsync(newUser, model.Password);

                // was the user create successfully
                if (result.Succeeded)
                {


                    //Add a patient role
                    bool patientRoleExists = await _roleManager.RoleExistsAsync("Nurse");
                    if (!patientRoleExists)
                    {
                        var roleResult = await _roleManager.CreateAsync(new IdentityRole() { Name = "Nurse", NormalizedName = "Nurse".ToUpper() });
                    }

                    // Select the user, and then add the patient role to the user
                    //newUser = await _userManager.FindByNameAsync(model.Email);
                    if (!await _userManager.IsInRoleAsync(newUser, "Nurse"))
                    {
                        //_logger.LogInformation("Adding sysadmin to Admin role");
                        var userResult = await _userManager.AddToRoleAsync(newUser, "Nurse");

                        
                    }



                    

                    //Add alert
                    TempData[WCAlert.Success] = "User created successfully";
                    // redirect the user to a page
                    return RedirectToAction("Dashboard", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }


            // reload the registration view with the user's input
            TempData[WCAlert.Error] = "Registration Attempt Unsuccessful";
            //ModelState.AddModelError(string.Empty, "Registration Attempt Unsuccessful");
            return View(model);
        }
    }

}