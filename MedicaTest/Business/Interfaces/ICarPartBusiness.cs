
using MedicaTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Business.Interfaces
{
    public interface ICarPartBusiness
    {
        public CarPartVM Create(CarPartVM carPart);
        public bool Update(CarPartVM carPart);
        public bool Delete(int id);
        public IEnumerable<CarPartVM> GetAll();
        public CarPartVM Get(int id);
    }
}
