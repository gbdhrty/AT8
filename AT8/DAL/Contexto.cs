using AT8.Models;
using Microsoft.EntityFrameworkCore;

namespace AT8.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> clientes { get; set; }
    }
}
