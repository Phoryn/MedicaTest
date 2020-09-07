using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicaTest.ViewModel
{
    public class CarPartVM
    {
        public int? Id { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Nazwa jest wymagana!")]
        public string Name { get; set; }
        [DisplayName("Cena")]
        [Required(ErrorMessage = "Cena jest wymagana!")]
        [Range(0, int.MaxValue, ErrorMessage = "Wartość musi być większa niż 0")]
        public decimal Price { get; set; }
        [DisplayName("Dodano")]
        [DisplayFormat(DataFormatString = "{00:dd MMM yyyy}")]
        public DateTime? Added{ get; set; }
        [DisplayFormat(DataFormatString = "{00:dd MMM yyyy}")]
        [DisplayName("Modyfikowano")]
        public DateTime? Modified { get; set; }
    }
}
