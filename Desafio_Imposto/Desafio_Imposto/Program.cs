using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio_Imposto {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Renda anual com salário: ");
            double rendaAnualSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Renda anual com prestação de serviço: ");
            double rendaAnualServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Renda anual com ganho de capital: ");
            double rendaAnualGanhoCapital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            double rendaMensalSalario = rendaAnualSalario / 12;
            double impostoSalario = 0;

            if (rendaMensalSalario < 3000) {
                impostoSalario = 0;
            }
            else if (rendaMensalSalario >= 3000 && rendaMensalSalario < 5000) {
                impostoSalario = rendaAnualSalario * 0.10;
            }
            else {
                impostoSalario = rendaAnualSalario * 0.20;
            }

            
            double impostoServico = rendaAnualServico * 0.15;

           
            double impostoGanhoCapital = rendaAnualGanhoCapital * 0.20;

           
            double impostoBrutoTotal = impostoSalario + impostoServico + impostoGanhoCapital;

            
            double maximoDedutivel = impostoBrutoTotal * 0.30;
            double gastosDedutiveis = gastosMedicos + gastosEducacionais;
            double abatimento = Math.Min(maximoDedutivel, gastosDedutiveis);

           
            double impostoDevido = impostoBrutoTotal - abatimento;

            
            Console.WriteLine("\nRELATÓRIO DE IMPOSTO DE RENDA");
            Console.WriteLine("CONSOLIDADO DE RENDA:");
            Console.WriteLine($"Imposto sobre salário: {impostoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Imposto sobre serviços: {impostoServico.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Imposto sobre ganho de capital: {impostoGanhoCapital.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");
            Console.WriteLine("DEDUÇÕES:");
            Console.WriteLine($"Máximo dedutível: {maximoDedutivel.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Gastos dedutíveis: {gastosDedutiveis.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");
            Console.WriteLine("RESUMO:");
            Console.WriteLine($"Imposto bruto total: {impostoBrutoTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Abatimento: {abatimento.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Imposto devido: {impostoDevido.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
