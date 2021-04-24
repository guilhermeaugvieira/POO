using System;

namespace ByteBank{
  class Conta{
    public int numeroAgencia {get; set;}
    public int numero {get; set;}
    private double _saldo;
    private Cliente _titular;
    public Cliente titular { 
      get{
        return this._titular;
      } 
      set{
        this._titular = value;
      } 
    }
    /*Para usar como propriedade, o valor recebido no set é reconhecido como value
      O get não pode usar referência circular (retornar a própria propriedade),
        por conta disse, utiliza-se a convenção de nome para atribuir valor a 
        propriedade privada
      Propriedade não pode ser usada como referência
    */

    public static int ContasCriadas { get; private set; }

    public Conta( 
      int numeroAgencia, 
      int numero, 
      double saldo,
      ByteBank.Cliente titular //Utilização de namespace
    ){
      this._titular = titular;
      this.numeroAgencia = numeroAgencia;
      this.numero = numero;
      this._saldo = saldo;
      Conta.ContasCriadas ++;
    }

    public double GetSaldo(){
      return this._saldo;
    }

    public bool AlterarSaldo(double valor){      
      if((this._saldo + valor)>0){
        this._saldo += valor;
        return true;
      }

      return false;
    }
  }
}