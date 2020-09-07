using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicaTest.Business.Interfaces;
using MedicaTest.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MedicaTest.Controllers
{
    public class CarPartController : Controller
    {
        private readonly ICarPartBusiness _carPartBusiness;

        public CarPartController(ICarPartBusiness carPartBusiness)
        {
            this._carPartBusiness = carPartBusiness;
        }

        [HttpPost]
        [Route("Utwórz")]
        public IActionResult Create(CarPartVM model)
        {
            if (!ModelState.IsValid)
                return View("CarPart", model);

            if (model.Id == null)
            {
                var responsemodel = _carPartBusiness.Create(model);
                if (responsemodel != null)
                {
                    ViewBag.Info = true;
                    return View("CarPart", responsemodel);
                }
                ViewBag.Info = false;
                return View("CarPart", model);
            }
            else
            {

                if (_carPartBusiness.Update(model))
                {
                    ViewBag.Update = true;
                    return View("CarPart", model);
                }
                ViewBag.Update = false;
                return View("CarPart", model);
            }
        }

        [HttpGet]
        [Route("Utwórz")]
        public IActionResult Create()
        {
            return View("CarPart");
        }




        [HttpGet]
        [Route("Wszystkie")]
        public IActionResult GetAll()
        {
            var response = _carPartBusiness.GetAll();
            if (response != null)
            {
                return View("List", response);
            }
            return View("List");
        }

        [HttpGet]
        [Route("Edytuj/{id}")]
        public IActionResult Edit(string id)
        {
            var idTo = Int32.Parse(id);
            if (idTo == null)
            {
                ViewBag.Info = false;
                return View("CarPart");
            }
            var response = _carPartBusiness.Get(idTo);
            if (response != null)
            {
                return View("CarPart", response);
            }
            ViewBag.Info = false;
            return View("CarPart");

        }


        [HttpGet]
        [Route("Usuń/{id}")]
        public IActionResult Delete(string id)
        {
            var idTo = Int32.Parse(id);
            if (idTo == null)
            {
                ViewBag.DeleteError = true;
                GetAll();
                return View("List");
            }
            var response = _carPartBusiness.Delete(idTo);
            if (response)
            {
                GetAll();
                return View("List");
            }
            ViewBag.DeleteError = true;
            return View("List");
        }

    }
}