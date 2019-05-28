namespace DefaultInterfaceMembers
{
    public class RetanguloV2 : IRetangulo
    {
        public float Altura { get; private set; }

        public float Largura { get; private set; }

        public RetanguloV2(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public float Area() =>
            Altura * Largura;

        public float Perimetro() =>
            (Altura * 2) + (Largura * 2);
    }
}
