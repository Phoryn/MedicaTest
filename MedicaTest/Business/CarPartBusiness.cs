using AutoMapper;
using MedicaTest.Business.Interfaces;
using MedicaTest.Data.Interfaces;
using MedicaTest.Models;
using MedicaTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Business
{
    public class CarPartBusiness : ICarPartBusiness
    {
        private readonly IMapper _mapper;

        private readonly ICarPartRepository _carPartRepository;
        public CarPartBusiness(ICarPartRepository carPartRepository,
                                    IMapper mapper)
        {
            _carPartRepository = carPartRepository;
            this._mapper = mapper;
        }



        public CarPartVM Create(CarPartVM carPart)
        {
            carPart.Added = DateTime.Now;
            return _mapper.Map<CarPartVM>(_carPartRepository.Create(_mapper.Map<CarPart>(carPart)));
        }

        public IEnumerable<CarPartVM> GetAll()
        {
            return _mapper.Map<IEnumerable<CarPartVM>>(_carPartRepository.GetAll());

        }

        public CarPartVM Get(int id)
        {
            return _mapper.Map<CarPartVM>(_carPartRepository.Get(id));
        }

        public bool Update(CarPartVM carPart)
        {
            carPart.Modified = DateTime.Now;
            return _carPartRepository.Update(_mapper.Map<CarPart>(carPart));
        }

        public bool Delete(int id)
        {
            return _carPartRepository.Delete(id);
        }

    }
}
