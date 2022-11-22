using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Financeira
{
    class ContratoPessoaJuridica : Contrato
    {
        public string Contratante { get; set; }
        public int Numero { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
        public int CNPJ { get; set; }
        public int IE { get; set; }

        public ContratoPessoaJuridica()
        {
        }

        public ContratoPessoaJuridica(string contratante, int numero, double valor, int prazo, int cNPJ, int iE)
        {
            Contratante = contratante;
            Numero = numero;
            Valor = valor;
            Prazo = prazo;
            CNPJ = cNPJ;
            IE = iE;
        }

        public override double calcularPrestacao()
        {
            return (Valor / Prazo) + 3;

        }


        public override string ExibirInfo()
        {
            return Numero
                + " | Contratante: "
                + Contratante.ToString(CultureInfo.InvariantCulture)
                + " | Idade: "
                + IE.ToString(CultureInfo.InvariantCulture)
                + " | CPF: "
                + CNPJ.ToString(CultureInfo.InvariantCulture)
                + " | Valor parcelas: R$"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " | Prazo: "
                + Prazo.ToString(CultureInfo.InvariantCulture)
                + " meses"
                + " |  Valor das prestações: R$"
                + calcularPrestacao().ToString(CultureInfo.InvariantCulture);


        }



    }
}
