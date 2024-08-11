using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
