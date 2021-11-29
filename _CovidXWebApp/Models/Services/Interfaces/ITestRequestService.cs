using EFCORE_DATAACCESS.Models;
using EFCORE_DATAACCESS.SQLViews;
using System.Collections.Generic;
using System.Linq;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface ITestRequestService
    {
        /// <summary>
        /// Selects ALL details about a test request(Nurse, Patient, Dependent, Suburb Details)
        /// </summary>
        /// <returns></returns>
        IQueryable<TestRequest> GetAllTestRequestsForPatients();

        /// <summary>
        /// Selects ALll Test Requests for SQLView GetAllTestRequests
        /// </summary>
        /// <returns></returns>
        IQueryable<GetAllTestRequests> GetAllTestRequests();

        /// <summary>
        /// Gets all test requests for the Calender Events Functionality
        /// </summary>
        /// <returns></returns>
        IQueryable<TestRequest> GetAllTestRequestsForEvents();

        /// <summary>
        /// Gets test requests based on one or many favourite suburbs
        /// </summary>
        /// <param name="preferedSuburbsID"></param>
        /// <returns></returns>
        IQueryable<TestRequest> GetFavouriteRequests(List<int> preferedSuburbsID);

        /// <summary>
        ///  Gets test requests based on Nurse's one or many favourite suburbs
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IQueryable<TestRequest> GetMyTestRequests(int nurseID);

        //IQueryable<TestRequest> GetMyFavouriteSuburbs(string userID);

        /// <summary>
        /// Gets test requests based on a specific nurse and where test request status is scheduled
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<TestRequest> GetScheduledTestRequests(string userID);


        /// <summary>
        /// GEts test requests by status
        /// </summary>
        /// <param name="Status"></param>
        /// <returns></returns>

        List<TestRequest> GetTestRequestsByStatus(CovidEnums.TestRequestStatus Status);

        /// <summary>
        /// Gets tests by status whether positive or negative
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        List<Test> GetTestsByStatus(string status);


        /// <summary>
        /// Gets assigned requests for a nurse
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<TestRequest> GetAssignedRequests(string userID);

        /// <summary>
        /// Gets a list of all main members
        /// </summary>
        /// <returns></returns>
        List<Patient> GetMainMembers();
    }
}