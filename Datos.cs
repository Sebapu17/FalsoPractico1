using System.Collections;
using System.Collections.Generic;

namespace EjemplosWin
{
    public static class Datos
    {

        public static IList<Empleado> Productos = new List<Empleado>
        {
          new Empleado { Id = 1, Nombre = "Sergio",Apellido = "Rochet", Puesto = "Arquero", EmpresaID = 1, Sueldo = 100 },
          new Empleado { Id = 2, Nombre = "Sebastian", Apellido = "Puppo", Puesto = "Delantero", EmpresaID = 1, Sueldo = 35000 },
          new Empleado { Id = 3, Nombre = "Luis", Apellido = "Suarez", Puesto = "Delantero", EmpresaID = 1, Sueldo = 3600 },
          new Empleado { Id = 4, Nombre = "Felipe", Apellido = "Carballo", Puesto = "Medio", EmpresaID = 1, Sueldo = 4500 },
          new Empleado { Id = 5, Nombre = "Diego", Apellido = "Polenta", Puesto = "Defensa", EmpresaID = 1, Sueldo = 1200 },
          new Empleado { Id = 6, Nombre = "Lionel", Apellido = "Messi", Puesto = "Delantero", EmpresaID = 2, Sueldo = 47800 },
          new Empleado { Id = 1, Nombre = "Sergio", Apellido = "Aguero", Puesto = "Delantero", EmpresaID = 3, Sueldo = 2500 },
          new Empleado { Id = 6, Nombre = "Ngolo", Apellido = "Kante", Puesto = "Medio", EmpresaID = 3, Sueldo = 1700 }
        };
    }
}
