using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Código Proveedor")]//Data Annotation
        public int SupplierCode { get; set; }
        [Display(Name = "Proveedor")]//Data Annotation
        public string SupplierName { get; set; }
        [Display(Name = "Correo")]//Data Annotation
        public string Email { get; set; }
        [Display(Name = "Teléfono")]//Data Annotation
        public string Phone { get; set; }
        [Display(Name = "Dirección")]//Data Annotation
        public string Address { get; set; }


    }
}