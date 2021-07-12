using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatiasFloresEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hallar el perimetro y la superficie de un triangulo";

            double catetoA, catetoB;
            double hipotenusa;
            double superficie, perimetro;

            Console.Write("Ingrese la medida del 1er cateto: ");
            catetoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la medida del 2do cateto: ");
            catetoB = Convert.ToDouble(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            superficie = (catetoA * catetoB) / 2;

            perimetro = catetoA + catetoB + hipotenusa;

            Console.WriteLine($"La superficie del triangulo dado es: {superficie}");
            Console.WriteLine($"El perimetro del triangulo dado es: {perimetro}");

            Console.ReadLine();

        }
    }
}
