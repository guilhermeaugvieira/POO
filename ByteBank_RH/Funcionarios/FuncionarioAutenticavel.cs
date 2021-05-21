using ByteBank_RH.Funcionarios.Interfaces;

namespace ByteBank_RH.Funcionarios{
  abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
  {
    public string Senha {get; protected set;}
    protected FuncionarioAutenticavel(string senha, string nome, string cpf, double salario) : base(nome, cpf, salario)
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