namespace ByteBank{
  class Cliente{
    private string _nome;
    private string _cpf;
    private string _profissao;

    public Cliente(string nome, string cpf, string profissao)
    {
        this._cpf = cpf;
        this._nome = nome;
        this._profissao = profissao;
    }

    public string getNome(){
      return this._nome;
    }

    public string getCPF(){
      return this._cpf;
    }

    public string getProfissao(){
      return this._profissao;
    }

    public void setNome(string nome){
      this._nome = nome;
    }

    public void setCPF(string cpf){
      this._cpf = cpf;
    }

    public void setProfissao(string profissao){
      this._profissao = profissao;
    }
  }
}