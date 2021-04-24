using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente guilherme = new Cliente("Guilherme", "11111111111", "Desenvolvedor");
           Conta CcGuilherme = new Conta(0001, 111111111, 1.99, guilherme);
           CcGuilherme.titular = guilherme;

           Console.WriteLine(CcGuilherme.titular.CPF);
           Console.WriteLine(Conta.ContasCriadas);
        }
    }
}
