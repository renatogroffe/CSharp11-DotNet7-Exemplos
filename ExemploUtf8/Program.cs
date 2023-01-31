using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 11 | UTF-8 String Literals *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var parte1 = "Exemplo utilizando Utf-8 no C# 11 "u8;
ReadOnlySpan<byte> parte2 = "| Segunda parte do conteúdo "u8;

using var fs = new FileStream($"exemplo-utf8-{DateTime.Now:MMdd-HHmmss}.txt",
    FileMode.CreateNew);
fs.Write(parte1);
fs.Write(parte2);
fs.Close();
Console.WriteLine($"Arquivo '{fs.Name}' gerado com sucesso!");