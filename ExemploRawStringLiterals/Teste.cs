using ExemploRawStringLiterals.Models;
using System.Text.Json;

namespace ExemploRawStringLiterals;

public static class Teste
{
    public static void ExibirConteudo(string dados)
    {
        Console.WriteLine();
        Console.WriteLine(dados);
        var pessoa = JsonSerializer.Deserialize<Pessoa>(dados);
        Console.WriteLine($"Nome = {pessoa!.Nome}");
        Console.WriteLine($"Cidade = {pessoa!.Cidade}");
        Console.WriteLine($"Idade = {pessoa!.Idade}");
    }
}
