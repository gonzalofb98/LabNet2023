using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int id, int pasajeros) : base(id,pasajeros)
        {
        }

        public override void Avanzar()
        {
            Console.WriteLine($"El ómnibus avanza con {pasajeros} pasajeros.");
        }

        public override void Detenerse()
        {
            Console.WriteLine($"El ómnibus se detiene con {pasajeros} pasajeros.");
        }
    }
}
