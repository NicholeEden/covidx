using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface IEmailService
    {
        /// <summary>
        /// Sends an email notification to a patient on a success scheduling event
        /// </summary>
        /// <param name="testrequestID"></param>
        /// <returns></returns>
        bool SendPatientNotification(int testrequestID);
    }
}
