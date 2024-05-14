using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace EMR.Domain
{
	public class ApplicationDbContext:DbContext
	{
		private string _connectionString;
        public ApplicationDbContext(string connectionString)
        {
			_connectionString = connectionString;

		}
        public DbSet<Patient> Patients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public ApplicationDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(_connectionString);
			}
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
