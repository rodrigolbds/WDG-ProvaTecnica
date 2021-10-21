using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadoraDescontoInss : ICalculadorInss
    {
        private readonly ICalculadoraDescontoInssFactory calculadoraDesconto;
        public CalculadoraDescontoInss(ICalculadoraDescontoInssFactory _calculadoraDesconto)
        {
            calculadoraDesconto = _calculadoraDesconto;
        }
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
           return calculadoraDesconto.CriarCalculadoraDescontoINSS(data.Year).CalculaDesconto(salario);
        }
    }
}
