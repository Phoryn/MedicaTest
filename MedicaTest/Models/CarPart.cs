using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.Models
{
    public class CarPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Added { get; set; }
        public DateTime Modified { get; set; }
    }
}
