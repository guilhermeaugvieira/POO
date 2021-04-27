namespace ByteBank_RH.Funcionarios{
  class Funcionario
  {
    public string Nome { get; set; }
    public string CPF { get; set; }
    /* Propriedades podem ser sobrecarregadas
       desta forma os valores retornadas em get e set
       podem ser alterados */
    public double Salario{ get; set; }
    public virtual double GetBonificacao() {
      return this.Salario * 0.1;
    }
    public Funcionario(string Nome, string CPF, double Salario){
      this.Nome = Nome;
      this.CPF = CPF;
      this.Salario = Salario;
    }
  }
}