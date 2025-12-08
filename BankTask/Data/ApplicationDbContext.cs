using System.Data.Entity;
using BankTask.Models;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace BankTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("AVERS_DWH_NSO_CLIENT");
            modelBuilder.Entity<Request>().ToTable("AVERS_DWH_NSO_REQUESTS");

            modelBuilder.Entity<Request>()
                .HasRequired(r => r.Client)
                .WithMany()
                .HasForeignKey(r => r.NSO_CLIENT_ID);
        }
    }
}