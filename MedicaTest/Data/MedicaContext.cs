using MedicaTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicaTest.ViewModel;

namespace MedicaTest.Data
{
    public class MedicaContext : DbContext
    {
        public MedicaContext(DbContextOptions<MedicaContext> options)
            : base(options)
        {
        }

        public DbSet<CarPart> CarParts { get; set; }

        public DbSet<MedicaTest.ViewModel.CarPartVM> CarPartVM { get; set; }

    }
}
