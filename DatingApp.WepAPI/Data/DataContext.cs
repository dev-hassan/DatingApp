using DatingApp.WepAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WepAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}