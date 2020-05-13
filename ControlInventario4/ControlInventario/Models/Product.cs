using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Código")]//Data Annotation
        public int ProductCode { get; set; }
        [Display(Name = "Nombre")]//Data Annotation
        public string ProductName { get; set; }
        [Display(Name = "Descripción")]//Data Annotation
        public string Description { get; set; }
        [Display(Name = "Cantidad")]//Data Annotation
        public int Quantity { get; set; }
        [Display(Name = "Precio")]//Data Annotation
        public int Price { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
      
    }
}