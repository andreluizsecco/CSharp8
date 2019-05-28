namespace DefaultInterfaceMembers
{
    public class RetanguloV1 : IRetangulo
    {
        public float Altura { get; private set; }

        public float Largura { get; private set; }

        public RetanguloV1(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public float Area() =>
            Altura * Largura;
    }
}
