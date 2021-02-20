using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ch02Quotation.Models
{
    public class PriceQuotation
    {

        [Required(ErrorMessage ="Sub total is required")]
        [Display(Name ="Sub Total")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public float SubTotal { get; set; }
        [Required(ErrorMessage = "Discount Percentage is required")]
        [Display(Name = "Discount Percentage")]
        [Range(1, 100, ErrorMessage = "Please enter a value bigger than {1} and less than {2}")]
        public float DiscountPercent { get; set; }

        public float DiscountAmount { get; set; } = 0;
        public float Total { get; set; } = 0;

    }
}
