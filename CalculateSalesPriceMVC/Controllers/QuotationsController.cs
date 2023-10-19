using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculateSalesPriceMVC.Models;

namespace CalculateSalesPriceMVC.Controllers
{
    public class QuotationsController : Controller
    {
        // Create a Quotation

        //sends the empty form to the browser
        [HttpGet]
        public ActionResult CreateQuotation()
        {
            return View();
        }

        //this action is called when the user clicks the submit button
        //the completed form is sent to the back end
        [HttpPost]
        public ActionResult CreateQuotation(Quotation model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateDiscountAmount();
                model.CalculateTotalPrice();
            }
            return View(model); //return the model with all values calculated
        }
    }
}