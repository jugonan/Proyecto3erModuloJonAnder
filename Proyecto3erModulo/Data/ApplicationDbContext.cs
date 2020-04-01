using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto3erModulo.Models;

namespace Proyecto3erModulo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Proyecto3erModulo.Models.Categoria> Categoria { get; set; }
        public DbSet<Proyecto3erModulo.Models.GustoUsuario> GustoUsuario { get; set; }
        public DbSet<Proyecto3erModulo.Models.Mercado> Mercado { get; set; }
        public DbSet<Proyecto3erModulo.Models.Producto> Producto { get; set; }
        public DbSet<Proyecto3erModulo.Models.ProductoCategoria> ProductoCategoria { get; set; }
        public DbSet<Proyecto3erModulo.Models.ProductoVendedor> ProductoVendedor { get; set; }
        public DbSet<Proyecto3erModulo.Models.Ubicacion> Ubicacion { get; set; }
        public DbSet<Proyecto3erModulo.Models.Usuario> Usuario { get; set; }
        public DbSet<Proyecto3erModulo.Models.Vendedor> Vendedor { get; set; }
    }
}
