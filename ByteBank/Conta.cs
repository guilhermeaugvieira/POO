using System;

namespace ByteBank{
  public class Conta{
    private readonly string _titular;
    private int _numeroAgencia;
    private int _numero;
    private double _saldo;

    public Conta(
      string titular, 
      int numeroAgencia, 
      int numero, 
      double saldo
    ){
      this._titular = titular;
      this._numeroAgencia = numeroAgencia;
      this._numero = numero;
      this._saldo = saldo;
    }

    public void getConta(){
      Console.WriteLine("Titular: " + this._titular);
      Console.WriteLine("Agencia: " + this._numeroAgencia);
      Console.WriteLine("Numero: " + this._numero);
      Console.WriteLine("Saldo: " + this._saldo);
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

    public string getTitular(){
      return this._titular;
    }

    public void setNumeroAgencia(int numeroAgencia){
      this._numeroAgencia = numeroAgencia;
    }

    public void setNumero(int numero){
      this._numero = numero;
    }

    public void alterarSaldo(double valor){
      this._saldo += valor;
    }
  }
}