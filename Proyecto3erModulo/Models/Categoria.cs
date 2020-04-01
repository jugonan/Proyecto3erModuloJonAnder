using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto3erModulo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<GustoUsuario> GustoUsuario { get; set; }
        public List<ProductoCategoria> ProductoCategoria { get; set; }
    }
}
