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
            if (pasajeros < 0 || pasajeros > 4)
                throw new ArgumentException("El número de pasajeros debe estar entre 0 y 4.");
        }

        // agrego el string a Avanzar y Detenerse en por ponerle algo al metodo
        public override string Avanzar()
        {
            return $"El taxi avanza con {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El taxi se detiene con {Pasajeros} pasajeros.";
        }
    }
}
