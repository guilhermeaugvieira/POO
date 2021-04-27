using System;
using ByteBank_RH.Funcionarios;

namespace ByteBank_RH{
    class Program{
        public static void Main(string[] args){
            Funcionario Guilherme = new Diretor("AAA", "11111111111", 1000);
            Console.WriteLine(Guilherme.GetBonificacao());
        }
    }
}
