using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DataAccessLayer
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-NGKF6I6;initial catalog=DesignPattern1; integrated security=true;");
		}
		public DbSet<CustomerProcess> CustomerProcesses { get; set; }
	}
}
