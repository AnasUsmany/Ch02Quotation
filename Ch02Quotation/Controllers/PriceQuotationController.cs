using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch02Quotation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ch02Quotation.Controllers
{
    public class PriceQuotationController : Controller
    {
        

        public IActionResult Calculate()
        {
            PriceQuotation model = new PriceQuotation();
            model.DiscountAmount = 0;
            model.Total = 0;
            ModelState.Clear();
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(PriceQuotation model)
        {
            if (ModelState.IsValid)
            {
                model.DiscountAmount = model.SubTotal * (model.DiscountPercent / 100);
                model.Total = model.SubTotal - model.DiscountAmount;
                return View("Calculate", model);
            }
            else
            {
                return View();
            }
        }

        
    }
}