[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentuale di issue ancora aperte](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentuale di issue ancora aperte")
[![Tempo medio di risoluzione di una issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Tempo medio di risoluzione di una issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Cos'è `json-everything`?

La filosofia principale dietro `json-everything` è garantire che le funzionalità comuni di JSON abbiano un buon supporto nell'ambiente _System.Text.Json_.

Il primo passo è verificare se esistono altri progetti che supportano una determinata funzione.

In tal caso, probabilmente lo sforzo non verrà duplicato qui. Più in basso troverai un elenco di altri progetti che stanno facendo cose interessanti con JSON.

Altrimenti, è aperto alla considerazione per questo progetto.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Documentazione</th>
<th width="207">Blog</th>
<th width="207">Apprendimento Interattivo</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="Provalo online" title="Provalo online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="Documentazione" title="Documentazione" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="Impara" title="Impara" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Discuti</th>
<th width="276">Chiedi</th>
<th width="276">Realizzato con</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Realizzato con Jetbrains Resharper" title="Realizzato con Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Cosa c'è nella scatola?

In realtà ci sono più scatole. Ogni funzionalità è stata suddivisa nella propria libreria, così puoi scegliere quella o quelle di cui hai bisogno.

Tutte le librerie sono costruite per .Net Standard 2.0 e .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, draft 6 e successivi</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Generazione di schemi da tipi .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Supporto alla generazione di schemi per <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Generazione di dati di istanza casuali (basato su <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Un vocabolario per accedere a dati di istanza ed esterni</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Un vocabolario per estendere la validazione degli array</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Estensione di vocabolario <a href="https://www.openapis.org/">OpenApi 3.1</a> (utilizzato da <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) e Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Specifica</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Sito web</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Sito web</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Estensioni di uso generale che probabilmente sarebbero dovute essere incluse in <em>System.Text.Json[.Nodes]</em> ma non lo sono state</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Conversioni tra il modello documento YAML in <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> e <code>JsonNode</code> (in entrambe le direzioni).</td>
</tr>
</tbody>
</table>

Tutte le librerie sopra offrono supporto completo per le relative specifiche.

Le traduzioni dei messaggi di errore per _JsonSchema.Net_ sono disponibili in:

- Italiano `it`
- Norvegese `nb-NO`
- Polacco `pl-PL`
- Russo `ru`
- Spagnolo `es`
- Svedese `sv-SE`
- Turco `tr-TR`

***NOTA** Ogni pacchetto lingua è fornito dal proprio pacchetto Nuget.*

Puoi anche vedere i risultati della JSON Schema Test Suite su [Bowtie](https://bowtie-json-schema.github.io/bowtie), che esegue la suite di test su più implementazioni su diverse piattaforme.

***DISCLAIMER** La mia libreria, _JsonSchema.Net_, non è correlata né associata al sito https://jsonschema.net, se non per il fatto che sono entrambi ottimi strumenti JSON Schema.*

### Pacchetti deprecati

Questi pacchetti hanno fatto parte anche di questa suite ma non sono più supportati.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Generazione di codice C# da schemi</td>
<td>Deprecato a favore di <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Supporto _System.Text.Json_ da altri progetti

Se qui non trovi ciò che cerchi, prova uno di questi eccellenti progetti:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) di [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) di [@mwadams](https://github.com/mwadams)
  - Validazione JSON Schema con focus sulla generazione di codice C#
- (altri in arrivo)

Se usi JSON per qualcosa che non è coperto da una libreria in questa suite o da uno dei progetti sopra, sentiti libero di [creare una feature issue](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Se mantieni o conosci un altro progetto che estende _System.Text.Json_ per fare cose interessanti, mi piacerebbe elencarlo qui, quindi per favore [crea una issue generica](https://github.com/json-everything/json-everything/issues/new) per farmelo sapere.

## Contribuire

Consulta il [Codice di Condotta](./CODE_OF_CONDUCT.md) e il file [CONTRIBUTING](./CONTRIBUTING.md) per maggiori informazioni.

## Sponsorizzazione

Se hai trovato utili queste librerie e desideri promuoverne lo sviluppo continuo, considera di [sponsorizzare i manutentori](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Questo progetto è supportato dalla [.NET Foundation](https://dotnetfoundation.org).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---