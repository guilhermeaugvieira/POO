using ByteBank_RH.Funcionarios.Interfaces;

namespace ByteBank_RH.Funcionarios{
  class Gerente : FuncionarioAutenticavel
  {
    public Gerente(string senha, string nome, string cpf, double salario) : base(senha, nome, cpf, salario)
    {
      Senha = senha;
    }

    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }

    public override double GetBonificacao()
    {
      return Salario * 0.25;
    }
  }
}