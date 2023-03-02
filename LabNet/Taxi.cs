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


        // agrego el string a Avanzar y Detenerse en por ponerle algo al metodo
        public override string Avanzar()
        {
            return $"El taxi avanza con {pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El taxi se detiene con {pasajeros} pasajeros.";
        }
    }
}
