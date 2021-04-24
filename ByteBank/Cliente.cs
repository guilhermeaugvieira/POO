namespace ByteBank{
  class Cliente{
    public string nome {get; set;}
    private string _cpf;
    public string profissao {get; set;}

    public Cliente(string nome, string cpf, string profissao)
    {
        this._cpf = cpf;
        this.nome = nome;
        this.profissao = profissao;
    }
    public string CPF
    {
      get { return this._cpf; }
      set { this._cpf = value; }
    }  
  }
}