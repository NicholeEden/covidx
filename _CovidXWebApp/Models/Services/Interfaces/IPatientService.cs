using _CovidXWebApp.Models.ViewModels;
using _CovidXWebApp.Utility;
using EFCORE_DATAACCESS.Models;
using EFCORE_DATAACCESS.SQLViews;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface IPatientService
    {
        public bool AddTestRequest(TestRequestCreateViewModel data);

        /// <summary>
        /// Add new <see cref="Patient"/> to the database
        /// </summary>
        /// <param name="model">The data for the patient profile</param>
        /// <returns>True if there was an entity added</returns>
        bool AddPatient(Patient model);


        /// <summary>
        /// Update <see cref="Patient"/> to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdatePatient(Patient model);


        /// <summary>
        /// Gets a list of suburbs to load items for a drop-down
        /// </summary>
        /// <returns> <see cref="Suburb.SuburbID"/> as the selected value and <see cref="Suburb.SuburbName"/> as the display value</returns>
        SelectList GetSuburbList();


        /// <summary>
        /// Gets a list of suburbs based on patient to load items for a drop-down
        /// </summary>
        /// <returns> <see cref="Suburb.SuburbID"/> as the selected value and <see cref="Suburb.SuburbName"/> as the display value</returns>
        SelectList GetSuburbByPatientList();

        /// <summary>
        /// Gets a list of dependents to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentTypeList();

        /// <summary>
        /// Gets a list of dependents based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentByPatientID(int patientID);


        /// <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetPatientAddress(int patientID);


        /// <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentAddress(int patientID);


        // <summary>
        /// Gets a list of addresses based on a patientID to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        SelectList GetDependentSuburb(int patientID);


        /// <summary>
        /// Gets a list of medical aid plan to load items for a drop-down
        /// </summary>
        /// <returns></returns>
        List<SubtextOption> GetMedicalAidList();
        /// <summary>
        /// Checks if patient already exists in DB
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        bool PatientExists(string UserID);

        /// <summary>
        /// Find Patient by it's UserID
        /// </summary>
        /// <param name="UserID"></param>
       Patient FindPatientByUserID(string UserID);

        /// <summary>
        /// Find patient by patient ID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        Patient FindPatientByPatientID(int PatientID);

        /// <summary>
        /// Add <see cref="Dependent"/> to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddDependent(Dependent model);


        /// <summary>
        /// Get All Tests Requests 
        /// </summary>
        /// <returns></returns>
        List<TestRequest> GetTestRequests(int PatientID);

        /// <summary>
        /// Get All Dependents
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<Dependent> GetDependents(int PatientID);


        /// <summary>
        /// Gets ALL TestRequets by PatientID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<GetAllTestRequests> GetAllTestRequestsByPatientID(int PatientID);


        /// <summary>
        /// Gets ALL NEW TestRequets by PatientID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<GetAllTestRequests> GetNewTestRequestsByPatientID(int PatientID);

        /// <summary>
        ///  Gets ALL SCHEDULED TestRequets by PatientID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<GetAllTestRequests> GetScheduledTestRequestsByPatientID(int PatientID);

        /// <summary>
        /// Gets ALL Cancelled TestRequets by PatientID
        /// </summary>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        List<GetAllTestRequests> GetCancelledTestRequestsByPatientID(int PatientID);


        /// <summary>
        /// Returns a query with patient details
        /// </summary>
        /// <returns></returns>
        IQueryable<Patient> GetDetails();

        /// <summary>
        /// Returns a query with test details
        /// </summary>
        /// <returns></returns>
        IQueryable<TestRequest> GetTestDetails();

        /// <summary>
        /// Returns Patient details based on UserID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Patient GetPatientDetail(string userID);

        /// <summary>
        /// Gets tests requests and it's test results details based on UserID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<TestRequest> GetTestDetail(string UserID);


        /// <summary>
        /// Get test details for patient
        /// </summary>
        /// <returns></returns>
        IQueryable<Test> GetTestQuery();

        /// <summary>
        /// Gets a list of test results based on a user id
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        List<Test> GetTestInfo(string UserID);

        /// <summary>
        /// Cancels a test request
        /// </summary>
        /// <param name="testRequestID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool CancelTest(int testRequestID, string userID);






    }
}
