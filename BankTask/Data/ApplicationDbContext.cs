using System.Data.Common;
using System.Data.Entity;
using BankTask.Models;
using Npgsql;

namespace BankTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base(CreateConnection(), true)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        }

        private static DbConnection CreateConnection()
        {
            var conn = new NpgsqlConnection("Host=localhost;Port=5432;Database=BankTaskDb;Username=postgres;Password=123");
            return conn;
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