using _CovidXWebApp.Models.ViewModels;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface INurseService
    {
        /// <summary>
        /// Add new <see cref="Nurse"/> to the database
        /// </summary>
        /// <param name="model">The data for the patient profile</param>
        /// <returns>True if there was an entity added</returns>
        bool AddNurse(Nurse model);

        /// <summary>
        /// Gets a list of suburbs to load items for a drop-down
        /// </summary>
        /// <returns> <see cref="Suburb.SuburbID"/> as the selected value and <see cref="Suburb.SuburbName"/> as the display value</returns>
        SelectList GetSuburbList();

        /// <summary>
        /// Gets a list of nurses to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetNurseList();

        /// <summary>
        /// Check if Nurse already exists
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        bool NurseExists(string UserID);


        /// <summary>
        /// Add Nurse's favourite suburbs
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddSuburbs(NurseSuburbsModel model);

        /// <summary>
        /// Find nurse by user id
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        Nurse FindNurseByUserID(string UserID);

        Nurse FindNurseByNurseID(int NurseID);



        /// <summary>
        /// Find a nurse's favourite suburbs
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<SuburbsPreffered> GetSuburbsPreffereds(string userID);

        /// <summary>
        /// Update test request based on nurse assignment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AssignNurse(int testRequestID, string userID);


        bool ScheduleRequest(CalenderEventModel model);


        bool AddTestDetails(TestViewModel model);


        IQueryable<TestRequest> GetReportDetails(int NurseId, DateTime StartDate, DateTime EndDate);
        List<TestRequest> GetReportDetail(ManagerViewModel model);

        /// <summary>
        /// Gets number of nurses
        /// </summary>
        /// <returns></returns>
        List<Nurse> GetNurses();

        bool UnAssignTest(int testRequestID, int nurseID);


    }
}
