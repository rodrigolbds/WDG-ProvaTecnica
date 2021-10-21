using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public sealed class CalculadoraInssFactory : ICalculadoraDescontoInssFactory
    {
        public ICalculadoraDescontoINSS CriarCalculadoraDescontoINSS(int ano)
        {
            if(ano == 2011)
            {
                return new CalculadoraDescontoInss2011();
            }
            else if(ano == 2012)
            {
                return new CalculadoraDescontoInss2012();
            }
            else
            {
                throw new NotImplementedException($"Ainda não está pronta a tabela para esse ano { ano } ");
            }
        }
    }
}
