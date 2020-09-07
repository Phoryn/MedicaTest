using AutoMapper;
using MedicaTest.Models;
using MedicaTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Infrastructure
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CarPart, CarPartVM>().ReverseMap();
        }
    }
}
