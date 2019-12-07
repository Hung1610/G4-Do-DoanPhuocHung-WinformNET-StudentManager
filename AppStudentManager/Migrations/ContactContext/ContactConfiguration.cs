namespace AppG2.Migrations.ContactContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ContactConfiguration : DbMigrationsConfiguration<AppG2.Model.DbContext>
    {
        public ContactConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ContactContext";
        }

        protected override void Seed(AppG2.Model.DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
