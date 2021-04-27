namespace ByteBank_RH.Funcionarios{
  class Diretor:Funcionario{
    public Diretor(string Nome, string CPF, double Salario) : base(Nome, CPF, Salario){
      this.Nome = Nome;
      this.CPF = CPF;
      this.Salario = Salario;
    }
    public override double GetBonificacao(){
      return base.GetBonificacao() + this.Salario;
      // Base referencia a classe herdade
    }
  }
}