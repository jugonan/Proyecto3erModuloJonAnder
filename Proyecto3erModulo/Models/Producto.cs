using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto3erModulo.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaValidez { get; set; }
        [Required]
        public string ImagenProducto { get; set; }
        [Required]
        public double Precio { get; set; }
        public List<Mercado> Mercados { get; set; }
        public List<ProductoCategoria> ProductoCategoria { get; set; }
        public List<ProductoVendedor> ProductoVendedor { get; set; }
    }
}
