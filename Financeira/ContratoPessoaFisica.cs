using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Financeira
{
    class ContratoPessoaFisica : Contrato
    {
        public string Contratante { get; set; }
        public int Numero { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
        public int Cpf { get; set; }
        public int Idade { get; set; }

        public ContratoPessoaFisica()
        {
        }

        public ContratoPessoaFisica(string contratante, int numero, double valor, int prazo, int cpf, int idade)
        {
            Contratante = contratante;
            Numero = numero;
            Valor = valor;
            Prazo = prazo;
            Cpf = cpf;
            Idade = idade;
        }

        public override double calcularPrestacao()
        {
            if (Idade <= 30) { return (Valor / Prazo) + 1; }
            else if (Idade <= 40) { return (Valor / Prazo) + 2; }
            else if (Idade <= 50) { return (Valor / Prazo) + 3; }
            else { return (Valor / Prazo) + 2; }

        }

        public override string ExibirInfo()
        {
            return Numero
                + " | Contratante: "
                + Contratante.ToString(CultureInfo.InvariantCulture)
                + " | Idade: "
                + Idade.ToString(CultureInfo.InvariantCulture)
                + " | CPF: "
                + Cpf.ToString(CultureInfo.InvariantCulture)
                + " | Valor parcelas: R$"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " | Prazo: "
                + Prazo.ToString( CultureInfo.InvariantCulture)
                + " meses"
                + " |  Valor das prestações: R$"
                + calcularPrestacao().ToString(CultureInfo.InvariantCulture);


        }

    }





}
