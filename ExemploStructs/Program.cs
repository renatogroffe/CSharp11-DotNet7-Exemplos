using System.Runtime.InteropServices;
using System.Text.Json;
using ExemploStructs;

Console.WriteLine("***** Testes com C# 11 | Auto-default structs *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var struct01 = new Demografia();
Console.WriteLine($"{nameof(struct01)} = {JsonSerializer.Serialize(struct01)}");

var struct02 = new Demografia()
{
    Pais = "Canada",
    Ano = 2022,
    Populacao = 38_929_902,
    MembroOCDE = true
};
Console.WriteLine($"{nameof(struct02)} = {JsonSerializer.Serialize(struct02)}");