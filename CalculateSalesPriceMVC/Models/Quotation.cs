using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculateSalesPriceMVC.Models
{
    public class Quotation
    {
        [Required]
        [Display(Name = "Sale Price")]
        public double SalePrice { get; set; }

        [Required]
        [Display(Name = "Discount Percent")]
        public double Discount { get; set; }

        [Required]
        [Display(Name = "Discount Amount")]
        public double DiscountAmount { get; set; }

        [Required]
        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }



        //this method will calculate discount amount
        public void CalculateDiscountAmount()
        {
            DiscountAmount = Discount * SalePrice / 100;
        }

        //this method will calculate final price after discount
        public void CalculateTotalPrice()
        {
            TotalPrice = SalePrice - DiscountAmount;
        }
    }
}