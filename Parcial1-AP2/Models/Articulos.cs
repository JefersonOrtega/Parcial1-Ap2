using Parcial1_AP2.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2.Models
{
    public class Articulos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Debe ingresar la descripción del artículo")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Debe ingresar la existencia del articulo")]
        public int Existencia { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Costo del artículo")]
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

    }
}
