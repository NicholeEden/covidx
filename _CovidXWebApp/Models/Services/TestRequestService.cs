using _CovidXWebApp.Models.Services.Interfaces;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using EFCORE_DATAACCESS.SQLViews;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models.Services
{
    public class TestRequestService : ITestRequestService


    {

        private readonly CovidXSQLDBContext _db;

        public TestRequestService(CovidXSQLDBContext db)
        {
            this._db = db;
        }


        public IQueryable<TestRequest> GetAllTestRequestsForPatients()
        {
            //Get test requests for patient
            var query = _db.TestRequests
                 //Get nurse details for this test request
                 .Include(x => x.Nurse)
                 //Get patient details for this test request
                 .Include(x => x.Patient)
                 //Get dependent details for this test request
                 .Include(x => x.Dependent)
                 //Get Suburb Details for this test request
                 .Include(x => x.Suburb);

            //Equivalent to long SELECT SQL Query 

            return query;
        }

        public IQueryable<GetAllTestRequests> GetAllTestRequests()
        {
            //Get test requests for patient
            var query = _db.AllTestRequests;

            //Equivalent to long SELECT SQL Query 

            return query;
        }


        /// <summary>
        /// Gets all test requests for the Calender Events Functionality
        /// </summary>
        /// <returns></returns>
        public IQueryable<TestRequest> GetAllTestRequestsForEvents()
        {
            //Get test requests for patient
            var query = _db.TestRequests.Include(req => req.CalenderEvent)
                .Include(req => req.Patient)
                .Include(req => req.Suburb)
                .Include(req => req.Nurse); 

            //Equivalent to long SELECT SQL Query 

            return query;
        }


        public IQueryable<TestRequest> GetFavouriteRequests(List<int> preferedSuburbsID)
        {
            // get a select statement [SELECT * FROM TestRequest TR]
            var query = _db.TestRequests
                // left join to suburb table [LEFT JOIN Suburb S ON S.ID = TR.SuburbID]
                .Include(x => x.Suburb)
                // where the suburb id's match one or more of the suburb id's in test request [WHERE TR.SuburbID IN (101, 102. 103, 104)]
                .Where(x => preferedSuburbsID.Contains(x.SuburbId));
              

            return query;
        }

        public IQueryable<TestRequest> GetMyTestRequests(int nurseID)
        {
            //// controller injected context
            //var _context = new CovidXSQLDBContext();

            //// controller injected user manager
            //UserManager<CovidXUser> _userManager;
            //var User = new System.Security.Claims.ClaimsPrincipal();

        

            //// get the nurse id
            //var nurse = _db.Nurses.SingleOrDefault(item => item.UserID == userID)?? null;

            // get all favourite suburbs
            var prefered = _db.SuburbsPreffereds.Where(item => item.NurseId ==nurseID);

            // get id list
            var preferedList = prefered.Select(item => item.SuburbId).ToList();

            // get favourite requests
            var preferedTestRequests = GetFavouriteRequests(preferedList)
                .Where(x=>x.RequestStatus == CovidEnums.TestRequestStatus.New);

            return preferedTestRequests;

        }

        //public IQueryable<Suburb> GetFavouriteSuburbs()
        //{

        //    var query = _db.Suburbs
        //        .Include(x => x.SuburbsPreffereds);
                
             

        //    return query;
        //}

        public List<SuburbsPreffered> GetSuburbsPreffereds(string userID)
        {
            //get the nurse id
            var nurse = _db.Nurses.SingleOrDefault(item => item.UserID == userID);
            // get all favourite suburbs
            var prefered = _db.SuburbsPreffereds.Where(item => item.NurseId ==  nurse.NurseId).ToList();

            return prefered;
        }


        public List<TestRequest> GetScheduledTestRequests(string userID)


        {
            //get the nurse id
            var nurse = _db.Nurses.SingleOrDefault(item => item.UserID == userID);
            return GetAllTestRequestsForPatients()
                 //.Select(x => new { x.TestAddress1, x.TestAddress2})
                 //.GroupBy(x => new { x.TestAddress1, x.TestAddress2})
                 .Where(x => x.NurseId == nurse.NurseId && x.RequestStatus == CovidEnums.TestRequestStatus.Scheduled).ToList();
        }


        public List<TestRequest> GetTestRequestsByStatus(CovidEnums.TestRequestStatus Status)
        {
          
            return GetAllTestRequestsForPatients()
                 //.Select(x => new { x.TestAddress1, x.TestAddress2})
                 //.GroupBy(x => new { x.TestAddress1, x.TestAddress2})
                 .Where(x=> x.RequestStatus == Status).ToList();
        }

        public List<Test> GetTestsByStatus(string status)
        {

            return _db.Tests
                 //.Select(x => new { x.TestAddress1, x.TestAddress2})
                 //.GroupBy(x => new { x.TestAddress1, x.TestAddress2})
                 .Where(x => x.TestResult == status).ToList();
        }

        public List<TestRequest> GetAssignedRequests(string userID)
        {
           return GetAllTestRequestsForEvents()
               .Where(item => item.RequestStatus == TestRequestStatus.Assigned && item.Nurse.UserID == userID)
               .ToList();
        }

        public List<Patient> GetMainMembers()
        {
            return _db.Patients.ToList();
        }
    }
}
