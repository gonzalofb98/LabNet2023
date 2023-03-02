using LabNet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNetProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();
            var pasajerosDeColectivo = new Random();
            var pasajerosDeTaxi = new Random();

            for (int i = 5; i > 0; i--)
            {
                Omnibus omnibus = new Omnibus(i, pasajerosDeColectivo.Next(1, 100));
                transportes.Add(omnibus);

                Taxi taxi = new Taxi(i, pasajerosDeTaxi.Next(1, 4));
                transportes.Add(taxi);
            }

            foreach (var transporte in transportes.OrderBy(tipo => tipo.GetType().Name).ThenBy(x => x.Id))
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.Id}: {transporte.Pasajeros} pasajeros");
            }

            Console.ReadKey();
        }
    }
}
