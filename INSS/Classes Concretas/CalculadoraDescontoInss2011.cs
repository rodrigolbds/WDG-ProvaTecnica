using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadoraDescontoInss2011 : ICalculadoraDescontoINSS
    {
        //todo arquivo config.
        private const decimal SALARIO_TETO_PRIMEIRA_FAIXA = 1106.90m;
        private const decimal SALARIO_TETO_SEGUNDA_FAIXA = 1844.83m;
        private const decimal SALARIO_TETO_TERCEIRA_FAIXA = 3689.66m;
        private const decimal DESCONTO_TETO = 405.96m;

        private const int ALIQUOTA_PRIMEIRA_FAIXA = 8;
        private const int ALIQUOTA_SEGUNDA_FAIXA = 9;
        private const int ALIQUOTA_TERCEIRA_FAIXA = 11;


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
            else if (salario > SALARIO_TETO_TERCEIRA_FAIXA)
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
