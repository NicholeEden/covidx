using EFCORE_DATAACCESS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCORE_DATAACCESS
{
    public static class QueryHelper
    {

        public static IQueryable<MedicalAidPlan> GetMedicalAidDetail(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme);
        }

        //Return a list of MedicalAidPlans with their linked MedicalAidScheme
        public static List<MedicalAidPlan> GetMedicalAidDetailList(this DbSet<MedicalAidPlan> plans)
        {
            return plans.Include(plan => plan.MedicalAidScheme).ToList();
        }
    }
}
