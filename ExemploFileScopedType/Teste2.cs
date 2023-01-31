namespace ExemploFileScopedType;

public static class ClasseTeste2
{
    public static void Testar()
    {
        new Mensagem().Exibir();
    }
}

file class Mensagem
{
    public Guid Codigo { get; init; } = Guid.NewGuid();

    public void Exibir()
    {
        System.Console.WriteLine("Mensagem gerada em Teste2.cs | " +
            typeof(Mensagem).FullName + " | " +
            $"{nameof(Codigo)}: {Codigo}");
    }
}