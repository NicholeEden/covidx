
using _CovidXWebApp.Models.Services.Interfaces;
using _CovidXWebApp.Models.ViewModels;
using AutoMapper;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models
{
    public class NurseService : INurseService
    {
        private readonly CovidXSQLDBContext _db;
        private readonly IMapper _mapper;

        public NurseService(CovidXSQLDBContext db, IMapper mapper)
        {
            this._db = db;
            this._mapper = mapper;
        }


        public SelectList GetSuburbList()
        {
            // get all the suburs from the database
            var list = _db.Suburbs.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "SuburbId", "SuburbName");

            return output;
        }

        public bool AddNurse(Nurse model)
        {
            //Add patient to DB
            _db.Nurses.Add(model);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;

            // return _context.SaveChanges() > 0;
        }

        public bool NurseExists(string UserID)
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

        public bool AddSuburbs(NurseSuburbsModel model)
        {

            //Map ViewModel info to EF Core Entity
            var entity = new SuburbsPreffered()
            {
                NurseId = model.NurseId,
                SuburbId = model.SuburbId
            };
            //Add Suburbs to DB
            _db.SuburbsPreffereds.Add(entity);

            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public Nurse FindNurseByUserID(string UserID)
        {
            var nurseByUserID = _db.Nurses.FirstOrDefault(x => x.UserID == UserID);

            return nurseByUserID;
        }

        public IQueryable<SuburbsPreffered> GetFavouriteSuburbs()
        {

            var query = _db.SuburbsPreffereds
                .Include(x => x.Suburb);



            return query;
        }

        public List<SuburbsPreffered> GetSuburbsPreffereds(string userID)
        {
            //get the nurse id
            var nurse = _db.Nurses.SingleOrDefault(item => item.UserID == userID);
            // get all favourite suburbs
            var prefered = GetFavouriteSuburbs().Where(item => item.NurseId == nurse.NurseId).ToList();

            return prefered;
        }

        public bool AssignNurse(int testRequestID, string userID)
        {
            //find nurse by user id
            var nurse = _db.Nurses.SingleOrDefault(x => x.UserID == userID);

            //find the test request based on the passed in ID
            var testRequest = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == testRequestID);

            //update nurseid and request status for that found request
            testRequest.NurseId = nurse.NurseId;
            testRequest.RequestStatus = CovidEnums.TestRequestStatus.Assigned;


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

        public bool ScheduleRequest(CalenderEventModel model)
        {



            //find the test request based on the passed in ID
            var testRequest = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == model.ID);

            testRequest.RequestStatus = CovidEnums.TestRequestStatus.Scheduled;
            testRequest.StartTime = model.Start;


            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddTestDetails(TestViewModel model)
        {
            var entity = _mapper.Map<Test>(model);

           //find test request record to update it's status to performed
           var request = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == entity.TestRequestId);
           request.RequestStatus = CovidEnums.TestRequestStatus.Performed;



            entity.TestDate = DateTime.Today;
            entity.TestTime = DateTime.Now;
            
            
            try
            {
                _db.TestRequests.Update(request);
                _db.Tests.Add(entity);
             
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public SelectList GetNurseList()
        {
            // get all the nurses from the database
            var list = _db.Nurses.ToList();

            // create a select list with 'SuburbID' as the selected value and 'SuburbName' as the display value
            var output = new SelectList(list, "NurseId", "FirstName");

            return output;
        }


        public IQueryable<TestRequest> GetReportDetails(int NurseId, DateTime StartDate, DateTime EndDate)
        {


            //find nurse based on user id
            var nurse = _db.Nurses.SingleOrDefault(x => x.NurseId == NurseId);

            return _db.TestRequests
                 .Include(test => test.Test)
                 .Include(pat => pat.Patient)
                 .ThenInclude(med => med.MedicalAidPlan)
                 .ThenInclude(med => med.MedicalAidScheme)
                 .Include(dep => dep.Dependent)
                 .ThenInclude(med => med.MedicalAidPlan)
                  .ThenInclude(med => med.MedicalAidScheme)
                 .Include(nurse => nurse.Nurse).Where(x => x.NurseId == nurse.NurseId && x.StartTime >= Convert.ToDateTime
            (StartDate.ToShortDateString()) && x.EndTime <= Convert.ToDateTime(EndDate.ToShortDateString()));
            //.Include(pat => pat.Patient)
            //.ThenInclude(dep => dep.Dependents)
            //.Include(sub => sub.Suburb);

            //.Include(test => test.TestRequest)
            //.ThenInclude(nurse => nurse.Nurse)
            //.Include(lab => lab.LabUser);


        }

        public List<TestRequest> GetReportDetail(ManagerViewModel model)
        {


            //find tests request based on patient id
            var testRequestList = GetReportDetails(model.nurseID, model.StartDate,model.EndDate).ToList();

            return testRequestList;

        }

        public List<Nurse> GetNurses()
        {


            return _db.Nurses.ToList();

        }

        public bool UnAssignTest(int testRequestID, int nurseID)
        {
            //find nurse by user id
            //var nurse = _db.Patients.SingleOrDefault(x => x.UserID == userID);

            //find the test request based on the passed in testrequestID and nurseID
            var testRequest = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == testRequestID && x.NurseId == nurseID);

            //update request status for that found request that needs to be unassigned
            testRequest.RequestStatus = CovidEnums.TestRequestStatus.New;
            testRequest.NurseId = null;


            //update test request
            _db.TestRequests.Update(testRequest);


            //Save changes to DB
            var rowsAffected = _db.SaveChanges();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public Nurse FindNurseByNurseID(int NurseID)
        {
            //Find Nurse by NurseID
            var nurseByNurseID = _db.Nurses.Find(NurseID);

            return nurseByNurseID;
        }
    }
}
