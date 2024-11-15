using Microsoft.EntityFrameworkCore;
using ProjectWebAPI.Models;

namespace ProjectWebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) {
        
        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
