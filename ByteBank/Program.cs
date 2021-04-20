using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta guilherme = new Conta("Guilherme Augusto Vieira", 010, 874437, 12000.00);

           guilherme.getConta();
        }
    }
}
