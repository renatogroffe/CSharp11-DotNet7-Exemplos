using System.Runtime.InteropServices;
using ExemploListPatterns;

Console.WriteLine("***** Testes com C# 11 | List Patterns *****");
Console.WriteLine($"Versão do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var conjuntoMeses = new List<int[]>();
conjuntoMeses.Add(new int[] { 3, 5, 6 });
conjuntoMeses.Add(new int[] { 1 });
conjuntoMeses.Add(new int[] { 6, 9 });
conjuntoMeses.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 });
conjuntoMeses.Add(new int[] { 2, 4, 6, 8, 10 });
conjuntoMeses.Add(new int[] { 12, 1, 2, 3 });
conjuntoMeses.Add(new int[] { 6, 7, 8, 9 });
conjuntoMeses.Add(new int[] { 9, 10, 12 });

foreach (var meses in conjuntoMeses)
{
    Console.WriteLine();
    Console.WriteLine($"Meses: [ {String.Join(", ", meses)} ]");
    Console.WriteLine($"Estação do ano: {Calendario.ObterEstacao(meses)}");
    Console.WriteLine($"{Calendario.AnalisarSequenciaMeses(meses)}");
}