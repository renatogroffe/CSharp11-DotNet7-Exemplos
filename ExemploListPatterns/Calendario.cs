namespace ExemploListPatterns;

public static class Calendario
{
    public static string ObterEstacao(int[] meses)
    => meses switch
    {
        [12, 1, 2, 3] => "Verão",
        [3, .., 6] => "Outono",
        [6, .., 9] => "Inverno",
        [9, .., 12] => "Primavera",
        [_] => "Mês qualquer",
        [1, ..] => "Janeiro/Verão em diante",
        [..] => "Uma sequência de meses"
    };

    public static string AnalisarSequenciaMeses(int[] meses)
    => meses switch
    {
        [_, _] => $"2 Meses: {String.Join(", ", meses)}",
        [1, .. var meses01, _] => $"Meses intermediários após Janeiro: {String.Join(", ", meses01)}",
        [6, .. var meses02, _] => $"Meses intermediários após Junho: {String.Join(", ", meses02)}",
        [.. var todosMeses] => $"Todos os meses: {String.Join(", ", todosMeses)}"
    };
}