using System.Data.Entity.Migrations;

namespace DevIO.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DevIO.Infra.Data.Context.MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
