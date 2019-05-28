using System;

namespace ReadonlyMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = new Retangulo(5,5);
            Console.WriteLine(ret.MensagemArea());
        }
    }

    public struct Retangulo
    {
        public float Altura { get; private set; }
        public float Largura { get; private set; }
        public readonly float Area => Altura * Largura;

        public Retangulo(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public readonly string MensagemArea() =>
            $"A área do retângulo é: {Area}";
    }
}
