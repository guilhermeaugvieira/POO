using ByteBank_RH.Funcionarios.Interfaces;

namespace ByteBank_RH.Parceiros{
  class ParceiroComercial : IAutenticavel{

    public string Senha {get; private set;}

    public ParceiroComercial(string senha)
    {
      Senha = senha;
    }

    public bool Autenticar(string senha)
    {
      if(Senha == senha) return true;
      return false;
    }
  }
}