using _CovidXWebApp.Models.Services.Interfaces;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.Services
{
    public class DependentService : IDependentService
    {

        private readonly CovidXSQLDBContext _db;

        public DependentService(CovidXSQLDBContext db)
        {
            this._db = db;
        }

        public IQueryable<Dependent> GetAllDependents()
        {
            //Get test requests for patient
            var query = _db.Dependents
                .Include(x => x.DependentType)
                .Include(x => x.MainMember)
                .Include(x => x.MedicalAidPlan)
                .ThenInclude(x=>x.MedicalAidScheme)
                .Include(x => x.Suburb);


            //Equivalent to long SELECT SQL Query 

            return query;
        }
    }
}
