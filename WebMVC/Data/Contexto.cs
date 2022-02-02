using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace WebMVCMysql.Models.Data
{
    public class Contexto: DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
