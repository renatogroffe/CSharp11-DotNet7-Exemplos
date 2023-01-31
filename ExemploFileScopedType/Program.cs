using System.Runtime.InteropServices;
using ExemploFileScopedType;

Console.WriteLine("***** Testes com C# 11 | File-scoped types *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

ClasseTeste1.Testar();
ClasseTeste2.Testar();