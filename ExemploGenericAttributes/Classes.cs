using System.Xml.Linq;
using System.Text.Json;

namespace ExemploGenericAttributes.Models;

[Document<JsonDocument>]
public class TransacaoDebito
{
}

[Document<JsonDocument>]
public class TransacaoPix
{
}

[Document<XDocument>]
public class NotaFiscalEletronica
{
}

[Document<XDocument>]
public class NotaFiscalServicos
{
}