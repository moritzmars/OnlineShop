using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual List<Product> Products { get; set; }

        public virtual PaymentInformation PaymentInformation { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }

        public virtual BillingAddress BillingAddress { get; set; }
        public decimal Sum { get; set; }

        public decimal ProductsCount { get; set; }

    }

}