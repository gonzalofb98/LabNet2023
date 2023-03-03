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
            if (pasajeros < 0 || pasajeros > 100)
                throw new ArgumentException("El número de pasajeros debe estar entre 0 y 100.");
        }

        public override string Avanzar()
        {
            return $"El ómnibus avanza con {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El ómnibus se detiene con {Pasajeros} pasajeros.";
        }
    }
}
