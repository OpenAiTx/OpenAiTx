[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Czym jest `json-everything`?

Główną filozofią stojącą za `json-everything` jest zapewnienie, że popularne funkcjonalności JSON mają dobre wsparcie w przestrzeni _System.Text.Json_.

Pierwszym krokiem do tego jest sprawdzenie, czy istnieją inne projekty, które wspierają daną funkcjonalność.

Jeśli tak, prawdopodobnie nie będzie ona tutaj duplikowana. Nieco niżej znajdziesz listę innych projektów, które robią ciekawe rzeczy z JSON-em.

W przeciwnym razie jest to otwarte na rozważenie w tym projekcie.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Dokumentacja</th>
<th width="207">Blog</th>
<th width="207">Nauka interaktywna</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Wypróbuj online" title="Wypróbuj online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Dokumentacja" title="Dokumentacja" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Nauka" title="Nauka" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Dyskusja</th>
<th width="276">Pytania</th>
<th width="276">Zbudowane z</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Stworzone z Jetbrains Resharper" title="Stworzone z Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Co znajduje się w "pudełku"?

W rzeczywistości jest kilka "pudełek". Każda funkcjonalność została wydzielona do osobnej biblioteki, więc możesz wybrać tylko te, których potrzebujesz.

Wszystkie biblioteki są zbudowane dla .Net Standard 2.0 oraz .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, drafty 6 i wyższe</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Generowanie schematów z typów .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Wsparcie generowania schematów dla <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Generowanie losowych danych instancji (napędzane przez <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Słownik do dostępu do danych instancji i zewnętrznych</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Słownik rozszerzający walidację tablic</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Rozszerzenie słownika <a href="https://www.openapis.org/">OpenApi 3.1</a> (używane przez <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) oraz Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Specyfikacja</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Strona</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Strona</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Rozszerzenia ogólnego zastosowania, które prawdopodobnie powinny być częścią <em>System.Text.Json[.Nodes]</em>, ale nie są</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Konwersje między modelem dokumentu YAML w <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> a <code>JsonNode</code> (w obie strony).</td>
</tr>
</tbody>
</table>

Wszystkie powyższe biblioteki oferują pełne wsparcie dla powiązanych specyfikacji.

Tłumaczenia komunikatów błędów dla _JsonSchema.Net_ są dostępne w:

- włoski `it`
- norweski `nb-NO`
- polski `pl-PL`
- rosyjski `ru`
- hiszpański `es`
- szwedzki `sv-SE`
- turecki `tr-TR`

***UWAGA** Każda paczka językowa jest dostarczana jako osobna paczka Nuget.*

Możesz także zobaczyć wyniki Test Suite JSON Schema na [Bowtie](https://bowtie-json-schema.github.io/bowtie), która uruchamia testy na wielu implementacjach na różnych platformach.

***ZASTRZEŻENIE** Moja biblioteka, _JsonSchema.Net_, nie jest powiązana ani związana ze stroną https://jsonschema.net, poza tym, że obie są doskonałymi narzędziami JSON Schema.*

### Przestarzałe paczki

Te paczki także były częścią tego zestawu, ale nie są już wspierane.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Generowanie kodu C# ze schematów</td>
<td>Wycofane na rzecz <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Wsparcie _System.Text.Json_ przez inne projekty

Jeśli nie znajdziesz tutaj tego, czego szukasz, spróbuj któregoś z tych świetnych projektów:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) autorstwa [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) autorstwa [@mwadams](https://github.com/mwadams)
  - Walidacja JSON Schema ze skupieniem na generowaniu kodu C#
- (więcej wkrótce)

Jeśli używasz JSON-a do czegoś, co nie jest objęte biblioteką z tego zestawu lub jednym z powyższych projektów, śmiało [zgłoś propozycję funkcji](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Jeśli utrzymujesz lub znasz inny projekt, który rozszerza _System.Text.Json_ o ciekawe funkcje, chętnie go tu wymienię, więc proszę [zgłoś ogólne zgłoszenie](https://github.com/json-everything/json-everything/issues/new), aby mi o nim powiedzieć.

## Współpraca

Zobacz [Kodeks Postępowania](./CODE_OF_CONDUCT.md) oraz plik [CONTRIBUTING](./CONTRIBUTING.md) po więcej informacji.

## Sponsorowanie

Jeśli te biblioteki okazały się pomocne i chciałbyś wesprzeć dalszy rozwój, rozważ [sponsorowanie autorów](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Ten projekt jest wspierany przez [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---