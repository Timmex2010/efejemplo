﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.mibd
{
    public class Departamento
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
