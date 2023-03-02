using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet
{
    public class Taxi : TransportePublico
    {
        public Taxi(int id, int pasajeros) : base(id, pasajeros)
        {
        }

        public override void Avanzar()
        {
            Console.WriteLine($"El taxi avanza con {pasajeros} pasajeros.");
        }

        public override void Detenerse()
        {
            Console.WriteLine($"El taxi se detiene con {pasajeros} pasajeros.");
        }
    }
}
