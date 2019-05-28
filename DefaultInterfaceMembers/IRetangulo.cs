using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaceMembers
{
    public interface IRetangulo
    {
        float Altura { get; }
        float Largura { get; }

        float Area();
        float Perimetro() => 0f;
    }
}
