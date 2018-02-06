using CSGYoungAdultGroup.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

namespace CSGYoungAdultGroup.DAL
{
	public class YoungAdultContext:DbContext
	{

		public YoungAdultContext() : base("YoungAdultContext")
		{
		}

		public DbSet<Member> Members { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Group> Groups { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}