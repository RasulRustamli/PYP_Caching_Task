using Microsoft.EntityFrameworkCore;
using PYP_Caching_Task.Models;

namespace PYP_Caching_Task.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
