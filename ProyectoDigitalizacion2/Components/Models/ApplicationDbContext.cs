using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDigitalizacion2.Components.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

       
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
