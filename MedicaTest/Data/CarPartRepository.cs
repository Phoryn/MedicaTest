using MedicaTest.Data.Interfaces;
using MedicaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Data
{
    public class CarPartRepository : ICarPartRepository
    {
        private readonly MedicaContext _context;

        public CarPartRepository(MedicaContext context)
        {
            this._context = context;
        }
        public CarPart Create(CarPart carPart)
        {
            var enntity =_context.CarParts.Add(carPart).Entity;
            _context.SaveChanges();
            return enntity;
        }

        public CarPart Get(int id)
        {
            return _context.CarParts.Where(r => r.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<CarPart> GetAll()
        {
            return _context.CarParts.ToList();
        }

        public bool Update(CarPart carPart)
        {
            _context.CarParts.Update(carPart);
            
            if (_context.SaveChanges() == 0)
                return false;

            return true;
        }
        public bool Delete(int id)
        {
            var carPart = _context.CarParts.Where(r => r.Id.Equals(id)).FirstOrDefault();

            if (carPart == null)
                return false;

            _context.CarParts.Remove(carPart);
            _context.SaveChanges();

            return true;
        }

    }
}
