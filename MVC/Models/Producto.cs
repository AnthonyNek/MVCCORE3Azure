using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo precio es obligatorio")]
        public string Precio { get; set; }
        [Required(ErrorMessage = "El campo tipo es obligatorio")]
        public string Tipo { get; set; }
    }
}
