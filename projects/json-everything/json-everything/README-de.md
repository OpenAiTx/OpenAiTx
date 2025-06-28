[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Testergebnisse](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Prozentsatz offener Issues](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Prozentsatz offener Issues")
[![Durchschnittliche Lösungszeit für ein Issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Durchschnittliche Lösungszeit für ein Issue")
[![Lizenz](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Was ist `json-everything`?

Die Hauptphilosophie hinter `json-everything` ist, sicherzustellen, dass gängige JSON-Funktionalitäten im _System.Text.Json_-Umfeld gut unterstützt werden.

Der erste Schritt dazu ist die Überprüfung, ob es bereits andere Projekte gibt, die eine bestimmte Funktion unterstützen.

Falls ja, wird dieser Aufwand hier wahrscheinlich nicht dupliziert. Etwas weiter unten findest du eine Liste anderer Projekte, die einige coole Dinge mit JSON machen.

Andernfalls wird die Funktionalität für dieses Projekt in Erwägung gezogen.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Dokumentation</th>
<th width="207">Blog</th>
<th width="207">Interaktives Lernen</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="Online ausprobieren" title="Online ausprobieren" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="Dokumentation" title="Dokumentation" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="Lernen" title="Lernen" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Diskussion</th>
<th width="276">Fragen</th>
<th width="276">Erstellt mit</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Erstellt mit Jetbrains Resharper" title="Erstellt mit Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Was ist im Paket enthalten?

Tatsächlich gibt es mehrere Pakete. Jede Funktionalität wurde in eine eigene Bibliothek ausgelagert, sodass du diejenige(n) auswählen kannst, die du benötigst.

Alle Bibliotheken sind für .Net Standard 2.0 und .Net 8 gebaut.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, Entwürfe 6 und höher</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Generierung von Schemata aus .Net-Typen</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Schema-Generierungsunterstützung für <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Zufällige Instanzdatenerzeugung (bereitgestellt durch <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Ein Vokabular zum Zugriff auf Instanz- und externe Daten</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Ein Vokabular zur Erweiterung der Array-Validierung</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> Vokabular-Erweiterung (verwendet von <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) und Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Spezifikation</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Website</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Website</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Allgemeine Erweiterungen, die vermutlich in <em>System.Text.Json[.Nodes]</em> hätten enthalten sein sollen, es aber nicht sind</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Konvertierungen zwischen dem YAML-Dokumentmodell in <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> und <code>JsonNode</code> (beide Richtungen).</td>
</tr>
</tbody>
</table>

Alle oben genannten Bibliotheken bieten vollständige Unterstützung für ihre zugehörigen Spezifikationen.

Fehlermeldungsübersetzungen für _JsonSchema.Net_ sind verfügbar in:

- Italienisch `it`
- Norwegisch `nb-NO`
- Polnisch `pl-PL`
- Russisch `ru`
- Spanisch `es`
- Schwedisch `sv-SE`
- Türkisch `tr-TR`

***HINWEIS**: Jedes Sprachpaket wird durch ein eigenes Nuget-Paket bereitgestellt.*

Du kannst auch die Ergebnisse der JSON Schema Test Suite auf [Bowtie](https://bowtie-json-schema.github.io/bowtie) ansehen, das die Test Suite gegen mehrere Implementierungen auf verschiedenen Plattformen ausführt.

***HAFTUNGSAUSSCHLUSS**: Meine Bibliothek, _JsonSchema.Net_, ist nicht mit der Website https://jsonschema.net verbunden oder assoziiert, abgesehen davon, dass beide ausgezeichnete JSON Schema-Tools sind.*

### Veraltete Pakete

Diese Pakete waren ebenfalls Teil dieser Suite, werden aber nicht mehr unterstützt.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Generierung von C#-Code aus Schemata</td>
<td>Veraltet zugunsten von <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>

## _System.Text.Json_-Unterstützung durch andere Projekte

Wenn du hier nicht findest, was du suchst, probiere eines dieser großartigen Projekte:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) von [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) von [@mwadams](https://github.com/mwadams)
  - JSON Schema-Validierung mit Fokus auf C# Code-Generierung
- (mehr folgt)

Wenn du JSON für etwas verwendest, das nicht durch eine Bibliothek in dieser Suite oder eines der oben genannten Projekte abgedeckt ist, kannst du gerne [ein Feature-Issue erstellen](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Wenn du ein anderes Projekt pflegst oder kennst, das _System.Text.Json_ um coole Funktionen erweitert, würde ich es gerne hier auflisten. Bitte [erstelle ein allgemeines Issue](https://github.com/json-everything/json-everything/issues/new), um mich darüber zu informieren.

## Mitwirken

Bitte sieh dir den [Verhaltenskodex](./CODE_OF_CONDUCT.md) und die [CONTRIBUTING](./CONTRIBUTING.md)-Datei für weitere Informationen an.

## Sponsoring

Wenn dir diese Bibliotheken geholfen haben und du die Weiterentwicklung fördern möchtest, erwäge bitte, [die Maintainer zu sponsern](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Dieses Projekt wird von der [.NET Foundation](https://dotnetfoundation.org) unterstützt.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---