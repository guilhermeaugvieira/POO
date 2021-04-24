﻿using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente guilherme = new Cliente("Guilherme Augusto Vieira", "13097988696", "Desenvolvedor");
           Conta CcGuilherme = new Conta(3160, 010874437, 12000, guilherme);
           CcGuilherme.titular = guilherme;

           Console.WriteLine(CcGuilherme.titular.CPF);
           Console.WriteLine(Conta.ContasCriadas);
        }
    }
}
