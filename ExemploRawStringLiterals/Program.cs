using ExemploRawStringLiterals;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 11 | Raw String Literals *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var pessoa1 = "{ \"Nome\": \"Renato Groffe\", \"Cidade\": \"Sao Paulo\", \"Idade\": 40 }";
Teste.ExibirConteudo(pessoa1);

var pessoa2 = """{ "Nome": "Joao Oliveira", "Cidade": "Rio de Janeiro", "Idade": 20 }""";
Teste.ExibirConteudo(pessoa2);

var nome3 = "Pedro Moreira";
var cidade3 = "Salvador";
var idade3 = 45;
var pessoa3 = $$"""{ "Nome": "{{nome3}}", "Cidade": "{{cidade3}}", "Idade": {{idade3}} }""";
Teste.ExibirConteudo(pessoa3);

var pessoa4 =
    """
       {
         "Nome": "Maria da Silva",
         "Cidade": "Belo Horizonte",
         "Idade": 32
       }
    """;
Teste.ExibirConteudo(pessoa4);