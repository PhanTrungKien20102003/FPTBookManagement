using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Models
{
	public class FPTBookDBContext:DbContext
	{
		public	FPTBookDBContext(DbContextOptions<FPTBookDBContext> options) : base(options) { }

		public DbSet<Book> Books => Set<Book>();
		public DbSet<Person> Persons => Set<Person>();	

		public DbSet<Cart> Carts => Set<Cart>();
	}
}
