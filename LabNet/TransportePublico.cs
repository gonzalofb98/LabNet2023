using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet
{
    public abstract class TransportePublico
    {
        protected int id;

        public int Id
        {
            get { return id; }
        }

        protected int pasajeros;

        public int Pasajeros
        {
            get { return pasajeros; }
        }

        public TransportePublico(int id, int pasajeros)
        {
            this.id = id;
            this.pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
