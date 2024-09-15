using Microsoft.EntityFrameworkCore;
using StylistPro.Compra.API.Entities;

namespace StylistPro.Compra.API.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {    

        }

        public DbSet<ComprasEntity> Compras { get; set; }
    }
}
