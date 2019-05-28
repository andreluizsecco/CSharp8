using System;

namespace DisposableRefStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ret = new Retangulo(3, 2))
                Console.WriteLine($"O valor da área do retângulo é: {ret.Area()}");

            Console.WriteLine("Fim da execução.");
        }
    }

    // ref struct é um recurso do C# 7.2
    public ref struct Retangulo
    {
        public float Altura { get; private set; }
        public float Largura { get; private set; }

        public Retangulo(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public float Area() => Altura * Largura;

        // Disposable em ref struct é um recurso do C# 8
        public void Dispose()
        {
            //Implementação
        }
    }

    public class ClasseExemplo
    {
        // Não permitido em ref struct pois ficaria alocada na heap, sujeita a GC
        public Retangulo MyProperty { get; set; }

        // Permitido pois não precisa ficar alocado na heap
        public Retangulo ObterRetangulo(float altura, float largura)
        {
            return new Retangulo(altura, largura);
        }

        // Permitido pois não precisa ficar alocado na heap
        public float CalcularArea(Retangulo ret)
        {
            return ret.Area();
        }


    }
}
