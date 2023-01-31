namespace ExemploRequiredMembers.Models;

public class Funcionario
{
    public required string Codigo { get; set; }
    public required string Nome { get; set; }
    public required double Salario { get; set; }
    public string? Observacao { get; set; }
}