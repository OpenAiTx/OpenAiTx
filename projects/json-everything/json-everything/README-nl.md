[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Wat is `json-everything`?

De primaire filosofie achter `json-everything` is om ervoor te zorgen dat gangbare JSON-functionaliteit goede ondersteuning heeft in de _System.Text.Json_ omgeving.

De eerste stap daarbij is controleren of er andere projecten bestaan die een bepaalde functie ondersteunen.

Als dat zo is, zal die inspanning waarschijnlijk hier niet worden gedupliceerd. Iets verderop vind je een lijst met andere projecten die interessante dingen doen met JSON.

Anders komt het in aanmerking voor dit project.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Documentatie</th>
<th width="207">Blog</th>
<th width="207">Interactief leren</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Probeer het online" title="Probeer het online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Documentatie" title="Documentatie" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Leren" title="Leren" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Discussie</th>
<th width="276">Vragen</th>
<th width="276">Gebouwd met</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Gemaakt met Jetbrains Resharper" title="Gemaakt met Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Wat zit er in de doos?

Er zijn eigenlijk meerdere dozen. Elke functionaliteit is opgesplitst in een eigen bibliotheek, zodat je zelf kunt kiezen welke je nodig hebt.

Alle bibliotheken zijn gebouwd voor .Net Standard 2.0 en .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, drafts 6 en hoger</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Genereren van schema's uit .Net types</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Schema genereren met ondersteuning voor <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Willekeurige generatie van instantie-data (mogelijk gemaakt door <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Een vocabulaire voor toegang tot instantie- en externe data</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Een vocabulaire voor het uitbreiden van array-validatie</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> vocabulaire extensie (gebruikt door <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) en Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Specificatie</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Website</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Website</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Algemene uitbreidingen die waarschijnlijk in <em>System.Text.Json[.Nodes]</em> hadden moeten zitten, maar dat niet doen</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Conversies tussen het YAML documentmodel in <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> en <code>JsonNode</code> (beide richtingen).</td>
</tr>
</tbody>
</table>

Alle bovenstaande bibliotheken bieden volledige ondersteuning voor hun bijbehorende specificaties.

Vertalingen van foutmeldingen voor _JsonSchema.Net_ beschikbaar in:

- Italiaans `it`
- Noors `nb-NO`
- Pools `pl-PL`
- Russisch `ru`
- Spaans `es`
- Zweeds `sv-SE`
- Turks `tr-TR`

***LET OP** Elk taalpakket wordt geleverd via zijn eigen Nuget pakket.*

Je kunt ook de resultaten van de JSON Schema Test Suite bekijken op [Bowtie](https://bowtie-json-schema.github.io/bowtie), die de testsuite draait tegen meerdere implementaties op verschillende platformen.

***DISCLAIMER** Mijn bibliotheek, _JsonSchema.Net_, is niet gerelateerd aan of geassocieerd met de website https://jsonschema.net, behalve dat ze allebei uitstekende JSON Schema tools zijn.*

### Verouderde pakketten

Deze pakketten maakten eerder deel uit van deze suite maar worden niet langer ondersteund.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet versie" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet versie" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Genereren van C#-code uit schema's</td>
<td>Verouderd ten gunste van <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## _System.Text.Json_ ondersteuning door andere projecten

Als je hier niet vindt wat je zoekt, probeer dan een van deze uitstekende projecten:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) door [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) door [@mwadams](https://github.com/mwadams)
  - JSON Schema validatie met focus op C# codegeneratie
- (meer volgt)

Als je JSON gebruikt voor iets dat niet wordt gedekt door een bibliotheek in deze suite of in een van bovenstaande projecten, voel je vrij om [een feature-verzoek aan te maken](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Als je een ander project onderhoudt of kent dat _System.Text.Json_ uitbreidt met mooie functionaliteit, dan zet ik die graag hier in de lijst. Maak dan [een algemeen issue aan](https://github.com/json-everything/json-everything/issues/new) om het te melden.

## Bijdragen

Zie het [Code of Conduct](./CODE_OF_CONDUCT.md) en het [CONTRIBUTING](./CONTRIBUTING.md) bestand voor meer informatie.

## Sponsoring

Als je deze bibliotheken nuttig vindt en verdere ontwikkeling wilt stimuleren, overweeg dan om [de ontwikkelaars te sponsoren](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Dit project wordt ondersteund door de [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---