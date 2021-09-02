﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFMigrations.Models
{
    public class ContextoEmpleados:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public ContextoEmpleados() : base("cadenaempleados") { }




    }
}