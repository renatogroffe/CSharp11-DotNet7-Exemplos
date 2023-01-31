namespace ExemploFileScopedType;

public static class ClasseTeste1
{
    public static void Testar()
    {
        new Mensagem().Exibir();
    }
}

public class Mensagem
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public void Exibir()
    {
        System.Console.WriteLine("Mensagem gerada em Teste1.cs | " +
            typeof(Mensagem).FullName + " | " +
            $"{nameof(Id)}: {Id}");
    }
}