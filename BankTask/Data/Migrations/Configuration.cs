using BankTask.Data.Migrations;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
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
            
        }
    }
}