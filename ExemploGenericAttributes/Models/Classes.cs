using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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