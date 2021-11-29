using _CovidXWebApp.Models;
using AutoMapper;
using EFCORE_DATAACCESS.Models;

namespace WebApp.AutoMapperProfile
{
    public class CalendarProfile : Profile
    {
        public CalendarProfile()
        {
            CreateMap<CalenderEventModel, CalendarEvent>();
        }
    }
}
