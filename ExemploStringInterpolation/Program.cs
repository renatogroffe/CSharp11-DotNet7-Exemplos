using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 11 *****");
Console.WriteLine($"Versão do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment
    .MachineName} - Kernel: {Environment
    .OSVersion
        .VersionString}");