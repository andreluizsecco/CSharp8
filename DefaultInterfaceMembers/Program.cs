using System;

namespace DefaultInterfaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            IRetangulo ret1 = new RetanguloV1(3, 5);
            Console.WriteLine("Implementação - Versão 1");
            Console.WriteLine($"Área do retângulo: {ret1.Area()}");
            Console.WriteLine($"Perímetro do retângulo: {ret1.Perimetro()}");

            Console.WriteLine("----------------------------------------");

            IRetangulo ret2 = new RetanguloV2(3, 5);
            Console.WriteLine("Implementação - Versão 2");
            Console.WriteLine($"Área do retângulo: {ret2.Area()}");
            Console.WriteLine($"Perímetro do retângulo: {ret2.Perimetro()}");
        }
    }
}
