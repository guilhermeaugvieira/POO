namespace ByteBank_RH.Funcionarios{
  abstract class Funcionario
  {
    public string Nome { get; set; }
    
    public string CPF { get; protected set; }
    /* Propriedades podem ser sobrecarregadas
       desta forma os valores retornadas em get e set
       podem ser alterados */
    
    public double Salario{ get; set; }

    public static int TotalFuncionarios {get; private set;}
    
    public abstract double GetBonificacao();

    public abstract void AumentarSalario();
    
    public Funcionario(string nome, string cpf, double salario){
      Nome = nome;
      CPF = cpf;
      Salario = salario;
      Funcionario.TotalFuncionarios += 1;
    }

  }
}