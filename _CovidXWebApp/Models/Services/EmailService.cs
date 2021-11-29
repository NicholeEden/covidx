using _CovidXWebApp.Models.Services.Interfaces;
using EFCORE_DATAACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Email;

namespace _CovidXWebApp.Models.Services
{
    public class EmailService : IEmailService
    {
        private readonly CovidXSQLDBContext _db;
        private readonly IEmailer _emailer;

        public EmailService(CovidXSQLDBContext db, IEmailer emailer)
        {
            _db = db;
            _emailer = emailer;
        }
        public bool SendPatientNotification(int testrequestID)
        {
            //find the test request using testrequestID
           var request = _db.TestRequests.SingleOrDefault(x => x.TestRequestId == testrequestID);

            if(request is null)
            {
                return false;
            }
            //find patient linked to this test request
            var patient = _db.Patients.SingleOrDefault(x => x.PatientId == request.PatientId);

            if (patient is null)
            {
                return false;
            }

            //find user linked to patientID
           var user = _db.CovidXusers.SingleOrDefault(x => x.Id == patient.UserID);

            if(user is null)
            {
                return false;
            }

            var subject = "Scheduled Test Request ";
            var body = "Good Day, Your test requests have been scheduled for the following date and time slots:" +
                request.StartTime.ToString() + " " + request.EndTime.ToString() + "\n" + "Kind Regards, CovidX Management";

            _emailer.SendEmail(ClientType.Microsoft,
                    user.Email, subject, body);

            return true;


        }
    }
}
