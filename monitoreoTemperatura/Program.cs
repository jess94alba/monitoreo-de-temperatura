using System;

namespace MonitoreoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura actual:");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura > 28)
            {
                Console.WriteLine("Alerta: La temperatura ha superado los 28 grados!");
            }
            else
            {
                Console.WriteLine("La temperatura está dentro del rango normal.");
            }
        }
    }
}