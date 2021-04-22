using System;

namespace ByteBank{
  class Conta{
    private int _numeroAgencia;
    private int _numero;
    private double _saldo;
    private Cliente _titular;
    /*Para usar como propriedade, o valor recebido no set é reconhecido como value
      O get não pode usar referência circular (retornar a própria propriedade)
    */

    public Conta( 
      int numeroAgencia, 
      int numero, 
      double saldo,
      ByteBank.Cliente titular //Utilização de namespace
    ){
      this._titular = titular;
      this._numeroAgencia = numeroAgencia;
      this._numero = numero;
      this._saldo = saldo;
    }

    public double getSaldo(){
      return this._saldo;
    }

    public int getNumero(){
      return this._numero;
    }

    public int getNumeroAgencia(){
      return this._numeroAgencia;
    }

    public Cliente getTitular(){
      return this._titular;
    }

    public void setTitular(Cliente titular){
      this._titular = titular;
    }

    public void setNumeroAgencia(int numeroAgencia){
      this._numeroAgencia = numeroAgencia;
    }

    public void setNumero(int numero){
      this._numero = numero;
    }

    public bool alterarSaldo(double valor){
      if((this._saldo + valor)>0){
        this._saldo += valor;
        return true;
      }

      return false;
    }
  }
}