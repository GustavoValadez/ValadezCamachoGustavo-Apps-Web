using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS2Cafeteria.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [Display(Name = "Imagen")]//Data Annotation
        public byte[] Imagen { get; set; }

        [Display(Name = "Café")]//Data Annotation
        [MaxLength(30)]
        public string CoffeeName { get; set; }

        [Display(Name = "Descripción")]//Data Annotation
        [MaxLength(120)]
        public string Description { get; set; }

        [Display(Name = "Precio")]//Data Annotation
        public decimal Price { get; set; }


    }
}