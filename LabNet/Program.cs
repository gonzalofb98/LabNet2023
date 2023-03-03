using LabNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LabNetProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();

            Console.WriteLine("Se pedira ingresar el omnibus 'i' y el taxi 'i' en ese orden:");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                int pasajero;
                bool esNumero;
                do
                {
                    Console.Write($"Ingrese el número de pasajeros del Omnibus {i}: ");
                     esNumero = int.TryParse(Console.ReadLine(), out pasajero);

                    if (!esNumero)
                    {
                        Console.WriteLine("El valor ingresado no es válido.");
                    }
                    else
                    {
                        try
                        {
                            TransportePublico omnibus = new Omnibus(i, pasajero);
                            transportes.Add(omnibus);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            esNumero = false;
                        }
                    }
                } while (!esNumero);

            Console.WriteLine();

                do
                {
                    Console.Write($"Ingrese la cantidad de pasajeros del Taxi {i}: ");
                    esNumero = int.TryParse(Console.ReadLine(), out pasajero);

                    if (!esNumero)
                    {
                        Console.WriteLine("El valor ingresado no es válido.");
                    }
                    else
                    {
                        try
                        {
                            TransportePublico taxi = new Taxi(i, pasajero);
                            transportes.Add(taxi);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            esNumero = false;
                        }
                    }
                } while (!esNumero);
            Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("         Vehiculos       ");
            Console.WriteLine();

            foreach (var transporte in transportes.OrderBy(tipo => tipo.GetType().Name).ThenBy(x => x.Id))
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.Id}: {transporte.Pasajeros} pasajeros");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("         Vehiculos: Metodo Avanzar       ");
            Console.WriteLine();

            foreach (var transporte in transportes.OrderBy(tipo => tipo.GetType().Name).ThenBy(x => x.Id))
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.Id}: {transporte.Avanzar()}");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("         Vehiculos: Metodo Avanzar       ");
            Console.WriteLine();

            foreach (var transporte in transportes.OrderBy(tipo => tipo.GetType().Name).ThenBy(x => x.Id))
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.Id}: {transporte.Detenerse()}");
            }
            Console.ReadKey();
        }
    }
}
