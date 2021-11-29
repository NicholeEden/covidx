using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface ICalenderService
    {
        /// <summary>
        /// Gets the list of scheduled test requests
        /// </summary>
        /// <returns></returns>
        List<CalenderEventModel> GetEvents();

        /// <summary>
        /// Gets all the test request for the logged in nurse
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<CalenderEventModel> GetAssignedRequests(string userID);


        /// <summary>
        /// Adding Calender Events to CalenderEvent Table
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddEvents(CalenderEventModel model);

    }
}
