using System;

namespace Poupanca
{
    class ContaPoupanca
    {
        private decimal saldoPoupanca;
        private static double taxaDeJurosAnual;

        private const int MESES = 12;

        // Questão Criando Classe ContaPoupanca
        // Cria uma nova conta poupança
        public ContaPoupanca()
        {
            saldoPoupanca = 0.0M;
            taxaDeJurosAnual = 0.0;
        }

        public ContaPoupanca(decimal saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            taxaDeJurosAnual = 0.0;
        }

        public decimal Saldo
        {
            get { return saldoPoupanca; }
            set { saldoPoupanca = value; }
        }
        public static double TaxaJuros
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }

        public decimal CalcularJurosMensal()
        {
            decimal jurosMensal = (saldoPoupanca * (decimal)taxaDeJurosAnual) / MESES;
            return jurosMensal + saldoPoupanca;
        }

        /// <param name="taxaDeJuros">Novo valor double para taxa de Juros</param>
        public static void AlterarTaxaDeJuros(double taxaDeJuros)
        {
            taxaDeJurosAnual = taxaDeJuros;
        }

    } // Fim da classe ContaPoupanca

} // Fim do namespace Poupanca
