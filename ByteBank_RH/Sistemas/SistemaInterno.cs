using System;
using ByteBank_RH.Funcionarios.Interfaces;

namespace ByteBank_RH.Sistemas{
  class SistemaInterno{
    public static bool Logar(IAutenticavel usuario, string senha){
      bool usuarioAutenticado = usuario.Autenticar(senha);

      if(usuarioAutenticado){
        Console.WriteLine("Bem-vindo ao sistema!");
        return true;
      }

      Console.WriteLine("Senha incorreta!");
      return false;
    }
  }
}