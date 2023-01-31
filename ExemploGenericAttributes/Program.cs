using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Linq;
using ExemploGenericAttributes;
using ExemploGenericAttributes.Models;


Console.WriteLine("***** Testes com C# 11 | Generic Attributes *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

var types = new Type[]
{
    typeof(NotaFiscalEletronica),
    typeof(TransacaoPix),
    typeof(TransacaoDebito),
    typeof(NotaFiscalServicos)
};
foreach (var type in types)
{
    var attributes = type.GetCustomAttributes();
    foreach (var attribute in attributes)
    {
        if (attribute is DocumentAttribute<JsonDocument>)
            Console.WriteLine(
                $"{type.FullName} | Utilizando JSON | {((DocumentAttribute<JsonDocument>)attribute).Document.FullName}");
        else if (attribute is DocumentAttribute<XDocument>)
            Console.WriteLine(
                $"{type.FullName} | Usando agora XML | {((DocumentAttribute<XDocument>)attribute).Document.FullName}");
    }
}