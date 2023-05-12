using FPTBookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Data
{
    public class FPTBookDBContext : DbContext
    {
        public FPTBookDBContext(DbContextOptions<FPTBookDBContext> options) : base(options) { }

        public DbSet<Book> Books => Set<Book>();
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Category> Categories => Set<Category>();
    }
}
