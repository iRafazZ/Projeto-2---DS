using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Financeira
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato()
        {
        }

        public Contrato(string contratante, int numero, double valor, int prazo)
        {
            Contratante = contratante;
            Numero = numero;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual  double calcularPrestacao()
        {
            return Valor / Prazo;
        }

        public virtual string ExibirInfo()
        {
            return Numero
                + " | Contratante: "
                + Contratante.ToString(CultureInfo.InvariantCulture)
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
