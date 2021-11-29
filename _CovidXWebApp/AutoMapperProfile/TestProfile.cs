using _CovidXWebApp.Models.ViewModels;
using AutoMapper;
using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.AutoMapperProfile
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<TestViewModel, Test>();
        }
    }
}
