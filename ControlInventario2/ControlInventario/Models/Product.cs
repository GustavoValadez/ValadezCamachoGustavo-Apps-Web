using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public int ProductName { get; set; }
        public int Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
      
    }
}