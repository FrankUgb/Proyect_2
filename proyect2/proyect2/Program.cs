using System;

namespace proyect2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de repetciones");
            double repe = double.Parse(Console.ReadLine());

            for (int i = 1; i <= repe; i++) {

                Console.WriteLine(i);

                Console.WriteLine("Escriba la altura (H) del triangulo");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el lado (A) del triangulo");
                double A = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el lado (Base) del triangulo");
                double B = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el lado (C) del triangulo");
                double C = int.Parse(Console.ReadLine());

                double Area = (B * altura) / 2; 
                double Perimetro = A + B + C;

                Console.Write($"El area del trigulo es de: {Area}cm2 y \n");
                Console.Write($"el perimetro del triangulo es de: {Perimetro}cm2 \n");
                Console.ReadKey();
            }

        }

            
    }
}
