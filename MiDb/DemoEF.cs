using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.MiDb
{
    public class DemoEF : Dbcontext
    {
        DbSet<Empleado> Empleados { get; set; }
        //DbSet<Autos> Empleados { get; set; }
    }
}
