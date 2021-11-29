using EFCORE_DATAACCESS.Models;
using System.Linq;

namespace _CovidXWebApp.Models.Services.Interfaces
{
    public interface IDependentService
    {
        IQueryable<Dependent> GetAllDependents();
    }
}