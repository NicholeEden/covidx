using _CovidXWebApp.Models.Services.Interfaces;
using AutoMapper;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models.Services
{
    public class CalenderService : ICalenderService
    {
        private readonly CovidXSQLDBContext _db;
        private readonly ITestRequestService _testRequestService;

        private readonly IMapper _mapper;

        public CalenderService(CovidXSQLDBContext db, ITestRequestService TestRequestService, IMapper mapper)
        {
            _db = db;
            _testRequestService = TestRequestService;
            _mapper = mapper;
        }

        public bool AddEvents(CalenderEventModel model)
        {
            model.Start = Convert.ToDateTime(model.StartText.Substring(0, 25));
            model.End = Convert.ToDateTime(model.EndText.Substring(0, 25));


           var entity = _mapper.Map<CalendarEvent>(model);

            //Check for validation to make sure a test request cannotb
            if (model.Start < DateTime.Now)
            {
                return false;
            }

            //find the test request based on the passed in ID
            var testRequest = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == model.ID);

            //update 
            testRequest.RequestStatus = CovidEnums.TestRequestStatus.Scheduled;
            testRequest.StartTime = model.Start;
            testRequest.EndTime = model.End;
           

            //add calender
            _db.CalendarEvents.Add(entity);

            //update test request
            _db.TestRequests.Update(testRequest);

            var result = _db.SaveChanges();

            if (result > 0)
            {
                return true;
            }

            return false;
        }

        public List<CalenderEventModel> GetAssignedRequests(string userID)
        {
            var eventList = new List<CalenderEventModel>();

            // get all the test request information for the current nurse
            var requests = _testRequestService.GetAllTestRequestsForEvents()
                .Where(item => item.RequestStatus == TestRequestStatus.Assigned && item.Nurse.UserID == userID)
                .ToList();

            foreach (var request in requests)
            {
                var calendarEvent = new CalenderEventModel()
                {
                    ID = request.TestRequestId,
                    Title = request.TestAddress1,
                    Description = request.TestAddress1 + " "+ request.Suburb.SuburbName ,
                    AllDay = false
                };

                eventList.Add(calendarEvent);
            }

            return eventList;
        }

        public List<CalenderEventModel> GetEvents()
        {
            // make for database call to get the time slots

            var output = new List<CalenderEventModel>();
            // make for database call to get the time slots

            var events = _db.CalendarEvents.ToList();

            foreach (var eve in events)
            {
                var item = new CalenderEventModel()
                {
                    ID = eve.ID,
                    AllDay = eve.AllDay,
                    Description = eve.Description,
                    Start = eve.Start,
                    End = eve.End,
                    Title = eve.Description
                };

                output.Add(item);
            }

            return output;
        }
    }
}