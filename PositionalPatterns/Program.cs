using System;

namespace PositionalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InformacaoRetangulo(new Retangulo(5, 2)));
            Console.WriteLine(InformacaoRetangulo(new Retangulo(1, 6)));
            Console.WriteLine(InformacaoRetangulo(new Retangulo(9, 9)));
            Console.WriteLine(InformacaoRetangulo(null));
        }

        static string InformacaoRetangulo(Retangulo ret) => ret switch
        {
            var (altura, largura) when altura > largura => "O retângulo possui altura maior que largura.",
            var (altura, largura) when altura < largura => "O retângulo possui largura maior que altura.",
            var (altura, largura) when altura == largura => "O retângulo é um quadrado.",
            _ => "Forma desconhecida"
        };
    }

    public class Retangulo
    {
        public float Altura { get; private set; }
        public float Largura { get; private set; }

        public Retangulo(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public void Deconstruct(out float altura, out float largura) =>
            (altura, largura) = (Altura, Largura);
    }
}
