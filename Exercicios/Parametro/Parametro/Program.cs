namespace Parametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area= new Area();
            Console.WriteLine("Digite a base");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Altura");
            area.Altura = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Escolha: \n1-Quadrado \n2-Retaângulo \n3-Triangulo");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Area.Escolha(opcao);
 

        }
    }
}