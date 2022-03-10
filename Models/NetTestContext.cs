using Microsoft.EntityFrameworkCore;

namespace netTest.Models
{
    public class NetTestContext : DbContext
    {
        public NetTestContext(DbContextOptions<NetTestContext> opciones)
        : base(opciones) //hereda las opciones base a la clase NetTest
        {

        }

        public DbSet<Catalogo> Catalogo{ get; set; } //Catalogo de tipo DbSet
    }
}
