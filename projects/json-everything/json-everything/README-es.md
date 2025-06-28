[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Porcentaje de incidencias aún abiertas](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Porcentaje de incidencias aún abiertas")
[![Tiempo promedio para resolver una incidencia](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Tiempo promedio para resolver una incidencia")
[![Licencia](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## ¿Qué es `json-everything`?

La filosofía principal detrás de `json-everything` es asegurar que las funcionalidades comunes de JSON tengan buen soporte en el entorno de _System.Text.Json_.

El primer paso para ello es verificar si existen otros proyectos que soportan una función determinada.

Si es así, probablemente ese esfuerzo no se duplicará aquí. Un poco más abajo encontrarás una lista de otros proyectos que están haciendo cosas interesantes con JSON.

De lo contrario, está abierto a consideración para este proyecto.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Documentación</th>
<th width="207">Blog</th>
<th width="207">Aprendizaje Interactivo</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Pruébalo en línea" title="Pruébalo en línea" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Documentación" title="Documentación" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Aprende" title="Aprende" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Discute</th>
<th width="276">Pregunta</th>
<th width="276">Hecho con</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Hecho con Jetbrains Resharper" title="Hecho con Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## ¿Qué hay en la caja?

En realidad, hay múltiples cajas. Cada funcionalidad ha sido separada en su propia biblioteca, para que puedas escoger la(s) que necesites.

Todas las bibliotecas están construidas para .Net Standard 2.0 y .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, borradores 6 y superiores</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Generación de esquemas a partir de tipos .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Soporte de generación de esquemas para <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Generación aleatoria de datos de instancia (impulsado por <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Un vocabulario para acceder a datos de instancia y datos externos</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Un vocabulario para extender la validación de arreglos</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Extensión de vocabulario <a href="https://www.openapis.org/">OpenApi 3.1</a> (utilizada por <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) y Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Especificación</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Sitio web</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Sitio web</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Extensiones de uso general que probablemente deberían haber sido incluidas en <em>System.Text.Json[.Nodes]</em> pero no lo fueron</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Conversiones entre el modelo de documento YAML en <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> y <code>JsonNode</code> (en ambas direcciones).</td>
</tr>
</tbody>
</table>

Todas las bibliotecas mencionadas ofrecen soporte completo para sus especificaciones asociadas.

Traducciones de mensajes de error para _JsonSchema.Net_ disponibles en:

- Italiano `it`
- Noruego `nb-NO`
- Polaco `pl-PL`
- Ruso `ru`
- Español `es`
- Sueco `sv-SE`
- Turco `tr-TR`

***NOTA** Cada paquete de idioma se proporciona como su propio paquete Nuget.*

También puedes ver los resultados de la JSON Schema Test Suite en [Bowtie](https://bowtie-json-schema.github.io/bowtie), que ejecuta la suite de pruebas contra múltiples implementaciones en diferentes plataformas.

***AVISO LEGAL** Mi biblioteca, _JsonSchema.Net_, no está relacionada ni asociada con el sitio web https://jsonschema.net, salvo que ambos son excelentes herramientas para JSON Schema.*

### Paquetes obsoletos

Estos paquetes también formaron parte de esta suite pero ya no tienen soporte.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Generación de código C# a partir de esquemas</td>
<td>Obsoleto a favor de <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Soporte de _System.Text.Json_ por otros proyectos

Si no encuentras lo que buscas aquí, por favor prueba uno de estos excelentes proyectos:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) por [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) por [@mwadams](https://github.com/mwadams)
  - Validación de JSON Schema con enfoque en generación de código C#
- (más próximamente)

Si usas JSON para hacer algo que no esté cubierto por alguna biblioteca de esta suite o de los proyectos anteriores, siéntete libre de [crear una incidencia de funcionalidad](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Si mantienes o conoces otro proyecto que extienda _System.Text.Json_ para hacer cosas interesantes, me gustaría incluirlo aquí, así que por favor [crea una incidencia general](https://github.com/json-everything/json-everything/issues/new) para informarme.

## Contribuir

Por favor, consulta el [Código de Conducta](./CODE_OF_CONDUCT.md) y el archivo [CONTRIBUYENDO](./CONTRIBUTING.md) para más información.

## Patrocinio

Si estas bibliotecas te resultaron útiles y te gustaría promover el desarrollo continuo, considera [patrocinar a los mantenedores](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Este proyecto cuenta con el apoyo de la [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---