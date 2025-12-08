using System.Data.Entity.Migrations;

namespace BankTask.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BankTask.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankTask.Data.ApplicationDbContext context)
        {
            // Добавьте начальные данные, если нужно
        }
    }
}