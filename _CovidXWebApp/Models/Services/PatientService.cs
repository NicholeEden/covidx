using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using EFCORE_DATAACCESS.SQLViews;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _CovidXWebApp.Models
{
    public class PatientService : IPatientService
    {
        private readonly CovidXSQLDBContext _db;
        private readonly ITestRequestService _testRequest;
        private readonly IDependentService _Dependservice;

        public PatientService(CovidXSQLDBContext db, ITestRequestService testRequest, IDependentService service)
        {
            this._db = db;
            this._testRequest = testRequest;
            this._Dependservice = service;
        }

        public SelectList GetSuburbList()
        {
            // get all the suburs from the database
            var list = _db.Suburbs.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "SuburbId", "SuburbName");

            return output;
        }

        public bool AddPatient(Patient model)
        {
            //Add patient to DB
            _db.Patients.Add(model);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public bool UpdatePatient(Patient model)
        {
            //Update patient to DB
            _db.Patients.Update(model);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public bool PatientExists(string UserID)
        {
            //Add patient to DB
            var patientExists = _db.Patients.FirstOrDefault(x => x.UserID == UserID);

            if (patientExists is not null)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public List<SubtextOption> GetMedicalAidList()
        {
            // get all the medical aid plans from the database
            var medicalAidPlans = _db.MedicalAidPlans.GetMedicalAidDetailList();

            // create a list of SubtextOption objects to return
            var output = new List<SubtextOption>();

            // populate the SubtextOption list with the medical aid plans
            foreach (var plan in medicalAidPlans)
            {
                // set the option properties
                var option = new SubtextOption()
                {
                    DisplayText = plan.Description,
                    DisplaySubtext = plan.MedicalAidScheme.Description,
                    Value = plan.MedicalAidPlanId
                };

                // add the option to the list
                output.Add(option);
            }

            return output;

            //IQueryable<MedicalAidPlan> query = _context.MedicalAidPlans.GetMedicalAidDetail();
            //var getSpecificPlanQuery = query.Where(plan => plan.Name == "this");
            //getSpecificPlanQuery.ToList();

            //List<MedicalAidPlan> list = _context.MedicalAidPlans.GetMedicalAidDetailList();
            //var getSpecificPlan = list.Where(plan => plan.Name == "this");
        }

        public SelectList GetDependentTypeList()
        {
            // get all the suburs from the database
            var list = _db.DependentTypes.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentTypeId", "Description");

            return output;
        }

        public Patient FindPatientByUserID(string UserID)
        {
            //Find Patient by UserID
            var patientByUserID = _db.Patients.FirstOrDefault(x => x.UserID == UserID);

            return patientByUserID;
        }

        public bool AddDependent(Dependent model)
        {
            //Add dependent to DB
            _db.Dependents.Add(model);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public Patient FindPatientByPatientID(int PatientID)
        {
            //Find Patient by PatientID
            var patientByUserID = _db.Patients.Find(PatientID);

            return patientByUserID;
        }

        public SelectList GetDependentByPatientID(int patientID)
        {
            // get list of dependents from the database
            var list = _db.Dependents.Where(x => x.MainMemberId == patientID).ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentId", "FirstName");

            return output;
        }

        public SelectList GetPatientAddress(int patientID)
        {
            // get list of dependents from the database
            var list = _db.Patients.Where(x => x.PatientId == patientID).
                Include(X=>X.Dependents).ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "AddressLine1", "AddressLine1");

            return output;
        }

        public SelectList GetSuburbByPatientList()
        {
            // get all the suburbs from the database
            var list = _db.Suburbs.Include(x => x.Patients).ThenInclude(x => x.SuburbId).ToList();
            //var list = _db.Patients..ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "SuburbId", "SuburbName");

            return output;
        }

        public SelectList GetDependentAddress(int patientID)
        {
            // get list of dependents address from the database
            var list = _db.Dependents.Where(x => x.MainMemberId == patientID).ToList();

            // create a select list with 'DependentD' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentId", "AddressLine1");

            return output;
        }

        public SelectList GetDependentSuburb(int patientID)
        {
            // get list of dependents address from the database
            var list = _db.Dependents.Where(x => x.MainMemberId == patientID).ToList();
           // var list = _db.Suburbs.Include(x => x.Dependents).ThenInclude(x => x.MainMemberId == patientID);
           
            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "DependentId", "SuburbName");

            return output;
        }

       
        public bool AddTestRequest(TestRequestCreateViewModel data)
        {
            //Map ViewModel info to EF Core Entity
            var entity = new TestRequest()
            {
                PatientId = data.PatientId,
                DependentId = data.DependentId,
                RequestDate = DateTime.Now,
                RequestStatus = CovidEnums.TestRequestStatus.New,
                TestAddress1 = data.TestAddress1,
                SuburbId = data.SuburbId
            };

            //Add entity to Db
            _db.TestRequests.Add(entity);

            //Save changes to db
            var rowsAffected = _db.SaveChanges();

            if(rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<TestRequest> GetTestRequests(int PatientID)
        {
           return _testRequest.GetAllTestRequestsForPatients()
                //.Select(x => new { x.TestAddress1, x.TestAddress2})
                //.GroupBy(x => new { x.TestAddress1, x.TestAddress2})
                .Where(x => x.PatientId == PatientID).ToList();
        }

        public List<Dependent> GetDependents(int PatientID)
        {
            return _Dependservice.GetAllDependents().
                Where(x => x.MainMemberId == PatientID).ToList();
        }

        public List<GetAllTestRequests> GetAllTestRequestsByPatientID(int PatientID)
        {
            return _testRequest.GetAllTestRequests().
                Where(x => x.RequesterId == PatientID && x.RequestStatus != CovidEnums.TestRequestStatus.Cancelled && x.RequestStatus != CovidEnums.TestRequestStatus.Closed).ToList();
        }

        public IQueryable<Patient> GetDetails()
        {
            return _db.Patients
               .Include(pat => pat.Suburb)
               .Include(pat => pat.Dependents)
                   .ThenInclude(dep => dep.Suburb)
               .Include(pat => pat.MedicalAidPlan)
               .ThenInclude(pat => pat.MedicalAidScheme);
        }

        public Patient GetPatientDetail(string userID)
        {
            
                // get all the patient details
                return GetDetails()
                    // where the user ID matches
                    .SingleOrDefault(x => x.UserID == userID);
            
        }

        public IQueryable<TestRequest> GetTestDetails()
        {
            return _db.TestRequests
                 .Include(test => test.Test);
                 //.Include(pat => pat.Patient)
                 //.ThenInclude(dep => dep.Dependents)
                 //.Include(sub => sub.Suburb);
                
                 //.Include(test => test.TestRequest)
                 //.ThenInclude(nurse => nurse.Nurse)
                 //.Include(lab => lab.LabUser);


        }

        public List<TestRequest> GetTestDetail(string UserID)
        {

            //find patient based on user id
            var patient = _db.Patients.SingleOrDefault(x => x.UserID == UserID);
            //find tests request based on patient id
           var testRequestList = GetTestDetails().Where(x => x.PatientId == patient.PatientId).ToList();

            return testRequestList;

        }

        public IQueryable<Test> GetTestQuery()
        {
            return _db.Tests
                 .Include(x => x.TestRequest)
                 .ThenInclude(x => x.Patient)
                 .ThenInclude(x => x.Dependents)
                 .Include(x=>x.LabUser);
                    
        }

        public List<Test> GetTestInfo(string UserID)
        {
            //find patient based on user id
            var patient = _db.Patients.SingleOrDefault(x => x.UserID == UserID);
            //find tests request based on patient id
            var testRequestList = GetTestQuery().Where(x => x.TestRequest.Patient.PatientId == patient.PatientId).ToList();

            return testRequestList;
        }

        public bool CancelTest(int testRequestID, string userID)
        {
            //find patient by user id
            var patient = _db.Patients.SingleOrDefault(x => x.UserID == userID);

            //find the test request based on the passed in ID
            var testRequest = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == testRequestID);

            //update request status for that found request that needs to be cancelled
           // testRequest.NurseId = nurse.NurseId;
            testRequest.RequestStatus = CovidEnums.TestRequestStatus.Cancelled;


            //update test request
            _db.TestRequests.Update(testRequest);


            //Map ViewModel info to EF Core Entity

            //Update Test Record 
            //_db.SuburbsPreffereds.Add(entity);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<GetAllTestRequests> GetNewTestRequestsByPatientID(int PatientID)
        {
            return _testRequest.GetAllTestRequests().
                Where(x => x.RequesterId == PatientID && x.RequestStatus == CovidEnums.TestRequestStatus.New).ToList();
        }

        public List<GetAllTestRequests> GetScheduledTestRequestsByPatientID(int PatientID)
        {
            return _testRequest.GetAllTestRequests().
                Where(x => x.RequesterId == PatientID && x.RequestStatus == CovidEnums.TestRequestStatus.Scheduled).ToList();
        }

        public List<GetAllTestRequests> GetCancelledTestRequestsByPatientID(int PatientID)
        {
            return _testRequest.GetAllTestRequests().
                Where(x => x.RequesterId == PatientID && x.RequestStatus == CovidEnums.TestRequestStatus.Cancelled).ToList();

        }

        //public IQueryable<Test> GetTests()
        //{
        //    return _db.Tests.Include(x => x.TestRequest);
        //}



    }
}