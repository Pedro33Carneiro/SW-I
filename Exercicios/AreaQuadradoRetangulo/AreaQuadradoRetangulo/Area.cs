using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalc { get; set;}

        public int Calcular ()
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }

        public string Calcular2()
        {
            string resultado = "";
            AreaCalc = Base * Altura;

            if (Base == Altura)
            {
            resultado = "Quadrado: " + AreaCalc;
            }
            else 
            {
                resultado = "Retângulo : " + AreaCalc
            }
            return resultado;
        }
        public void MostraDetalhes()
        {
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("AreaCaulc: " + AreaCalc);
        }

    }
}
