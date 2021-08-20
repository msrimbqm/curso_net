using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace codefirst1
{
    public class empleado
    {
        [Key]// declara cable principal
        public int IdEmpleado { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }
        [DataType(DataType.EmailAddress)]// tipo mail para lo siguiente
        public String Email { get; set; }
     }
}








