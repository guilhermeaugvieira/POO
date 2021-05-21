
using ByteBank_RH.Funcionarios;

namespace ByteBank_RH.Sistemas
{
    class GerenciadorBonificacao
    {
        private double TotalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
        }
        
        public double GetTotalBonificacao()
        {
            return TotalBonificacao;
        }

    }
}