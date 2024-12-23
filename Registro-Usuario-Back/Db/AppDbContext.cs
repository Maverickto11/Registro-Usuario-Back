using Microsoft.EntityFrameworkCore;
using Registro_Usuario_Back.Entidad;

namespace Registro_Usuario_Back.Db
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Usuario> Usuarios { get; set; }
        }

}
