using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadoraDescontoInss2012 : ICalculadoraDescontoINSS
    {
        //todo arquivo config.
        private const decimal SALARIO_TETO_PRIMEIRA_FAIXA = 1000m;
        private const decimal SALARIO_TETO_SEGUNDA_FAIXA = 1500m;
        private const decimal SALARIO_TETO_TERCEIRA_FAIXA = 3000m;
        private const decimal SALARIO_TETO_QUARTA_FAIXA = 4000m;

        private const int ALIQUOTA_PRIMEIRA_FAIXA = 7;
        private const int ALIQUOTA_SEGUNDA_FAIXA = 8;
        private const int ALIQUOTA_TERCEIRA_FAIXA = 9;
        private const int ALIQUOTA_QUARTA_FAIXA = 11;

        private const decimal DESCONTO_TETO = 500m;

        public decimal CalculaDesconto(decimal salario)
        {
            if (salario <= SALARIO_TETO_PRIMEIRA_FAIXA)
            {
                return (salario / 100) * ALIQUOTA_PRIMEIRA_FAIXA;
            }
            else if (salario > SALARIO_TETO_PRIMEIRA_FAIXA && salario <= SALARIO_TETO_SEGUNDA_FAIXA)
            {
                return (salario / 100) * ALIQUOTA_SEGUNDA_FAIXA;

            }
            else if (salario > SALARIO_TETO_SEGUNDA_FAIXA && salario <= SALARIO_TETO_TERCEIRA_FAIXA)
            {
                return (salario / 100) * ALIQUOTA_TERCEIRA_FAIXA;
            }
            else if (salario > SALARIO_TETO_TERCEIRA_FAIXA && salario <= ALIQUOTA_QUARTA_FAIXA)
            {
                return (salario / 100) * ALIQUOTA_QUARTA_FAIXA;
            }
            else if (salario > SALARIO_TETO_QUARTA_FAIXA)
            {
                return DESCONTO_TETO;
            }
            else
            {
                throw new NotImplementedException("Salário em desacordo com as alíquotas vigentes");
            }
        }

    }
}
