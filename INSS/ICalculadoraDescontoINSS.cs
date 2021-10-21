using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public interface ICalculadoraDescontoINSS
    {
        decimal AplicaDescontoSobreSalario(decimal salario);
    }
}
