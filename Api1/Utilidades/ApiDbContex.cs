using Api1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Api1.Utilidades
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> dbContextOptions)
            : base(dbContextOptions)
        { 
                
        }

        public DbSet<Productos> Productos { get; set; }
    }
}
