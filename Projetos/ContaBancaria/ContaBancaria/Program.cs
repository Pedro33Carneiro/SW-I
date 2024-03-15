using System.Runtime.CompilerServices;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco ETEC MCM!");

            //instalar a classe Conta e criar um objeto dela
            Conta conta = new Conta();
            Console.WriteLine(CONSULTANDO O SALDO);
            conta.consulta_saldo()
            Console.WriteLine(DEPOSITO DE 1000.35);
            conta.depositar(1000.35)
            Console.WriteLine(CONSULTANDO O SALDO);
            conta.consulta_saldo()

            //Console.WriteLine(SAQUE DE 500);
            //conta.sacar(500)
            //Console.WriteLine(CONSULTANDO O SALDO);
            //conta.consulta_saldo()

           

            
        }
    }
}