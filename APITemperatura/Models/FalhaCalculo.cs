namespace APITemperatura.Models;

public class FalhaCalculo
{
    public bool Erro => true;
    public string? Mensagem { get; set; }
}