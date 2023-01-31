using ExemploRequiredMembers.Models;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com C# 11 | Required Members *****");
Console.WriteLine($"Versão do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var func0001 = new Funcionario()
{
    Codigo = "0001",
    Nome = "Joao da Silva",
    Salario = 10000
};
Console.WriteLine($"Dados do Funcionario: {JsonSerializer.Serialize(func0001)}");

func0001.Salario = 11000;
func0001.Observacao = "Aumento de 10%";
Console.WriteLine($"Dados do Funcionario apos reajuste: {JsonSerializer.Serialize(func0001)}");