namespace NBABlackBone.MigrationsSQLite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;

    internal sealed class ConfigurationSqlite : DbMigrationsConfiguration<NBABlackBone.SQLite.StandingsDbContext>
    {
        public ConfigurationSqlite()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigrationsSQLite";
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        internal sealed class DBMigrationsConfig : DbMigrationsConfiguration<NBABlackBone.SQLite.StandingsDbContext>
        {
            private readonly bool pendingMigrations;

            public DBMigrationsConfig()
            {
                AutomaticMigrationsEnabled = true;
                AutomaticMigrationDataLossAllowed = true;

                var migrator = new DbMigrator(this);
                this.pendingMigrations = migrator.GetPendingMigrations().Any();

                if(pendingMigrations)
                {
                    migrator.Update();
                    Seed(new NBABlackBone.SQLite.StandingsDbContext());
                }
            }
        }

        protected override void Seed(NBABlackBone.SQLite.StandingsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
