namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DE AREA QUADRADO E RETANGULO");
            Area area = new Area();
            Console.WriteLine("digite o valor da base")
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura")
            area.Altura= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("area: " + area.Calcular());
            Console.WriteLine("area: " + area.Calcular2());

            area.MostraDetalhes();
        }
    }
}