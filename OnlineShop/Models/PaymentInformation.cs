using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Models
{
    public class PaymentInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [Required]
        [DisplayName("Credit Card Owner")]
        public String CreditCartOwner { get; set; }
        [Required]
        [DisplayName("Credit Card Number")]
        public String CreditCardNumber { get; set; }
        [Required]
        [DisplayName("Expiration Date")]
        public DateTime ExpirationDate { get; set; }
    }
}