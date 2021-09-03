namespace EFMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EFMigrations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFMigrations.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFMigrations.Models.ContextoEmpleados context)
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

            CreateTable(
               "dbo.Empleado",
               c => new
               {
                   IdEmpleado = c.Int(nullable: false, identity: true),
                   Nombre = c.String(),
                   Apellido = c.String(),
                   Direccion = c.String(),
                   Email = c.String(),
               })
               .PrimaryKey(t => t.IdEmpleado);

        }



    }

            



        }
    }
}
