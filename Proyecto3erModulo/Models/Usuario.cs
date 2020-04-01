using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Proyecto3erModulo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        public bool Darde { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string FotoPerfil { get; set; }
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public List<Mercado> Mercados { get; set; }
        public List<ProductoCategoria> Categorias { get; set; }
    }
}
