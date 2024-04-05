using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametro
{
    internal class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalc { get; set; }

        public void Escolha(int opcao)
        {
            if (opcao == 1)
            {
               float quadrado = CalcularAreaQuadrado();
                Console.WriteLine("Área do quadradoo é; " + quadrado);
            }
            if (opcao == 2)
            {
               float retangulo = CalcularAreaRetangulo();
                Console.WriteLine("Área do retanguloo é; " + retangulo);
            }
            if (opcao == 3)
            {
               float triangulo = CalcularAreaTriangulo();
                Console.WriteLine("Área do trianguloo é; " + triangulo);
            }
        }

        public float CalcularAreaQuadrado()
        {
            return AreaCalc;
        }
        public float CalcularAreaRetangulo()
        {
            return AreaCalc;
        }
        public float CalcularAreaTriangulo()
        {
            return AreaCalc;
        }
    }
}
