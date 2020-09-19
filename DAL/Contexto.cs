using Registro_Tarea1.Models;
using Microsoft.EntityFrameworkCore;

namespace Registro_Tarea1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data/Registro.db");
        }
    }
}