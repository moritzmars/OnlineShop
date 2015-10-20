using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Log
    {
             [Key]
            [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required]
            [Display(Name = "Date")]
            public DateTime Date { get; set; }

            [Required]
            [Display(Name = "Thread")]
            public string Thread { get; set; }

            [Required]
            [Display(Name = "Level")]
            public string Level { get; set; }

            [Required]
            [Display(Name = "Logger")]
            public string Logger { get; set; }

            [Required]
            [Display(Name = "Message")]
            public string Message { get; set; }

            [Required]
            [Display(Name = "Exception")]
            public string Exception { get; set; }
    }
}