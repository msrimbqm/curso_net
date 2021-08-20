using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace codefirst1.Models
{
    public class ContextoEmpleados:DbContext
    {
        public DbSet<empleado> Empleados { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public ContextoEmpleados() : base("CadenaEmpleados") { }
        
        

    }
}