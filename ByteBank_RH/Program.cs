using System;
using ByteBank_RH.Funcionarios;
using ByteBank_RH.Parceiros;
using ByteBank_RH.Sistemas;

namespace ByteBank_RH
{
  class Program{
    public static void Main(string[] args)
    {
      GerenciadorBonificacao empresa = new GerenciadorBonificacao();

      Diretor Guilherme = new Diretor("12345", "AAA", "11111111111", 1000);
      Gerente Dino = new Gerente("12345", "BBB", "22222222222", 1000);
      ParceiroComercial Fulano = new ParceiroComercial("12345");

      empresa.Registrar(Guilherme);
      empresa.Registrar(Dino);

      Console.WriteLine(
        SistemaInterno.Logar(Fulano, "12345")
      );
    }
  }
}
