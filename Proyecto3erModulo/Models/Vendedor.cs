using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Proyecto3erModulo.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required]
        public string NombreDeEmpresa { get; set; }
        [Required]
        public string TipoDeEmpresa { get; set; }
        [Required]
        public string NumeroRegistro { get; set; }
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public List<ProductoVendedor> ProductoVendedor { get; set; }
    }
}
