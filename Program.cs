using System;

namespace PercentualDeRepresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal sp = 67836.43m;
            decimal rj = 36678.66m;
            decimal mg = 29229.88m;
            decimal es = 27165.48m;
            decimal outros = 19849.53m;

           
            decimal faturamentoTotal = sp + rj + mg + es + outros;

           
            decimal percentualSP = (sp / faturamentoTotal) * 100;
            decimal percentualRJ = (rj / faturamentoTotal) * 100;
            decimal percentualMG = (mg / faturamentoTotal) * 100;
            decimal percentualES = (es / faturamentoTotal) * 100;
            decimal percentualOutros = (outros / faturamentoTotal) * 100;

           
            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine($"SP: {percentualSP} %");
            Console.WriteLine($"RJ: {percentualRJ} %");
            Console.WriteLine($"MG: {percentualMG} %");
            Console.WriteLine($"ES: {percentualES} %");
            Console.WriteLine($"Outros: {percentualOutros} %");
        }
    }
}

