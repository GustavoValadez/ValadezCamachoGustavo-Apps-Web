using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2Cafeteria.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Cliente")]//Data Annotation
        [MaxLength(30)]
        public string Client { get; set; }


        public int CoffeeId { get; set; }
        [ForeignKey("CoffeeId")]
        public Coffee Coffee { get; set; }

        [Display(Name = "Cantidad")]//Data Annotation
        public int Quantity { get; set; }

        [Display(Name = "Total a pagar")]//Data Annotation
        public decimal Total { get; set; }

        [Display(Name = "Estado")]//Data Annotation
        [MaxLength(14)]
        public string Status { get; set; }


    }
}