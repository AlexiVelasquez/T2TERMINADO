using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace T2TERMINADO
{
   public class Operaciones
{
    public static void pantallaprincipal(double operaciones)
    {
        // Tu código dentro del método pantallaprincipal
        int n, contadorVeloM100 = 0;
        double[] velocidadMillas, frecuenciaAuto, velocidadKm, VelocidadesM100;
        double conversionKM, frecuenciaOriginal;
        frecuenciaOriginal = 2500;
        conversionKM = 1.60934;

        do
        {
            Console.Write("Repita el numero ingresado por favor: ");
                
        } while (!int.TryParse(Console.ReadLine(), out n));

        velocidadMillas = new double[n];
        frecuenciaAuto = new double[n];
        velocidadKm = new double[n];
        VelocidadesM100 = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nIngrese millas por hora del auto " + (i + 1) + " : ");
            velocidadMillas[i] = double.Parse(Console.ReadLine());
            frecuenciaAuto[i] = velocidadMillas[i] * frecuenciaOriginal / 334.8;
            velocidadKm[i] = velocidadMillas[i] * conversionKM;

            if (velocidadKm[i] > 100)
            {
                VelocidadesM100[contadorVeloM100] = velocidadKm[i];
                contadorVeloM100++;
                continue;
            }
            else
            {
                continue;
            }
        }

        Console.Write("\nVelocidad\t Frecuencia\tVelocidad en\n");
        Console.Write("En Millas\t            \tKilometros\n");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("    " + velocidadMillas[i].ToString("") + "\t\t   " + frecuenciaAuto[i].ToString("N2") + "\t    " + velocidadKm[i].ToString("N2"));
        }
        Console.WriteLine("Velocidad de Kilometros mínima: " + velocidadKm.Min().ToString("N2"));
        Console.WriteLine("Velocidad de kilometros máxima: " + velocidadKm.Max().ToString("N2"));
        Console.WriteLine("Hay " + contadorVeloM100 + " autos que superan los 100km/h y las velocidades son:");

        for (int i = 0; i < contadorVeloM100; i++)
        {
            Console.WriteLine("- " + VelocidadesM100[i].ToString("N2"));
        }
    }
}
}
