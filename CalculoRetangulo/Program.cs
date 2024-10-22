﻿using System.Globalization;

namespace CalculoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseR, altura, area, perimetro, diagonal;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Base do retangulo: ");
            baseR = double.Parse(Console.ReadLine(), CI);

            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = baseR * altura;
            perimetro = 2 * (baseR + altura);
            diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"AREA = {area.ToString("F4", CI)}");
            Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", CI)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", CI)}");
        }
    }
}
