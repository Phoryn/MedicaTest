using MedicaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Data.Interfaces
{
    public interface ICarPartRepository
    {
        public CarPart Create(CarPart campaign);
        public bool Update(CarPart id);
        public IEnumerable<CarPart> GetAll();
        public CarPart Get(int id);
        public bool Delete(int id);
    }
}
