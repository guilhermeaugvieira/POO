using ByteBank_RH.Funcionarios.Interfaces;

namespace ByteBank_RH.Funcionarios{
  class Diretor : FuncionarioAutenticavel{
    public Diretor(string senha, string nome, string cpf, double salario) : base(senha, nome, cpf, salario)
    {
      Senha = senha;
    }

    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }

    public override double GetBonificacao(){
      return Salario * 0.5;
      // return base.GetBonificacao() + Salario;
      // Base referencia a classe herdada
    }
  }
}