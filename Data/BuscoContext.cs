using Microsoft.EntityFrameworkCore;
using pc3.Models;

namespace pc3.Data
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> Productos{ get; set; }

        public DbSet<categoria> categoria{ get; set; }

        public BuscoContext(DbContextOptions dco) : base(dco){

        }
    }
}
