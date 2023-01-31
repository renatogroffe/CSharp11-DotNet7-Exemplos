namespace ExemploStructs;

public struct Demografia
{
    public string? Pais { get; init; }
    public int Ano { get; set; }
    public int Populacao { get; set; }
    public bool MembroOCDE { get; set; }

    public Demografia()
    {
    }
}