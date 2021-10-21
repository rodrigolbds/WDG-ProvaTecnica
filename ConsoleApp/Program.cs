using INSS;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadoraDescontoInssFactory calculadoINSSfabrica = new CalculadoraInssFactory();
            var calculadora = new CalculadoraDescontoInss(calculadoINSSfabrica);

            var data = new DateTime(2011, 1, 1);

            Console.WriteLine("Digite seu salario");
            var salarioDigitado = Console.ReadLine();

            decimal salario;
            if (!decimal.TryParse(salarioDigitado, out salario))
            {
                Console.WriteLine("Salário inválido");
                return;
            }

            Console.WriteLine("Calculando Faixa para o ano de 2011");
            var descontoInns2011 = calculadora.CalcularDesconto(data, salario);

            Console.WriteLine($"Com um salário de { salario } no ano de { data.Year } você receberá um desconto mensal no seu salário de {descontoInns2011}");
           
            data = new DateTime(2012, 1, 1);
            Console.WriteLine("Calculando Faixa para o ano de 2012");
            var descontoInns2012 = calculadora.CalcularDesconto(data, Convert.ToDecimal(salario));

            Console.WriteLine($"Com um salário de { salario } no ano de { data.Year } você receberá um desconto mensal no seu salário de {descontoInns2012}");

        }
    }
}
