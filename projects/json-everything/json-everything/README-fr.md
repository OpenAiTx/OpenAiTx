[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Pourcentage de tickets encore ouverts](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Pourcentage de tickets encore ouverts")
[![Temps moyen de résolution d'un ticket](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Temps moyen de résolution d'un ticket")
[![Licence](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Qu'est-ce que `json-everything` ?

La philosophie principale derrière `json-everything` est de garantir que les fonctionnalités courantes de JSON bénéficient d'un bon support dans l'univers _System.Text.Json_.

La première étape consiste à vérifier s'il existe d'autres projets qui prennent en charge une fonctionnalité donnée.

Si c'est le cas, cet effort ne sera probablement pas dupliqué ici. Un peu plus bas, vous trouverez une liste d'autres projets qui réalisent des choses intéressantes avec JSON.

Sinon, la fonctionnalité peut être considérée pour ce projet.

<table>
<thead>
<tr>
<th width="207">Aire de jeux</th>
<th width="207">Documentation</th>
<th width="207">Blog</th>
<th width="207">Apprentissage interactif</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="Essayez en ligne" title="Essayez en ligne" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="Documentation" title="Documentation" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="Apprendre" title="Apprendre" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Discuter</th>
<th width="276">Demander</th>
<th width="276">Construit avec</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Fait avec Jetbrains Resharper" title="Fait avec Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Que trouve-t-on dans la boîte ?

Il y a en réalité plusieurs boîtes. Chaque fonctionnalité a été extraite dans sa propre bibliothèque, vous pouvez donc choisir celle(s) dont vous avez besoin.

Toutes les bibliothèques sont construites pour .Net Standard 2.0 et .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, drafts 6 et supérieurs</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Génération de schémas à partir des types .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Support de génération de schémas pour <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Génération aléatoire de données d’instance (propulsé par <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Un vocabulaire pour accéder aux données de l’instance et externes</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Un vocabulaire pour étendre la validation des tableaux</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Extension de vocabulaire <a href="https://www.openapis.org/">OpenApi 3.1</a> (utilisé par <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) et Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Spécification</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Site web</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Site web</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Extensions d’usage général qui auraient probablement dû être incluses dans <em>System.Text.Json[.Nodes]</em> mais ne l’ont pas été</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Conversions entre le modèle de document YAML dans <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> et <code>JsonNode</code> (dans les deux sens).</td>
</tr>
</tbody>
</table>

Toutes les bibliothèques ci-dessus offrent un support complet pour leurs spécifications associées.

Traductions des messages d’erreur pour _JsonSchema.Net_ disponibles en :

- Italien `it`
- Norvégien `nb-NO`
- Polonais `pl-PL`
- Russe `ru`
- Espagnol `es`
- Suédois `sv-SE`
- Turc `tr-TR`

***REMARQUE** Chaque pack de langue est fourni par son propre package Nuget.*

Vous pouvez également consulter les résultats de la suite de tests JSON Schema sur [Bowtie](https://bowtie-json-schema.github.io/bowtie), qui exécute la suite de tests sur plusieurs implémentations et plateformes différentes.

***AVERTISSEMENT** Ma bibliothèque, _JsonSchema.Net_, n’est pas liée ou associée au site https://jsonschema.net, si ce n’est qu’ils sont tous deux d’excellents outils JSON Schema.*

### Packages obsolètes

Ces packages ont également fait partie de cette suite mais ne sont plus supportés.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="Version NuGet" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="Version NuGet" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Génération de code C# à partir de schémas</td>
<td>Obsolète au profit de <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Support _System.Text.Json_ par d'autres projets

Si vous ne trouvez pas ce que vous cherchez ici, essayez l’un de ces excellents projets :

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) par [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) par [@mwadams](https://github.com/mwadams)
  - Validation JSON Schema avec génération de code C# en focus
- (d’autres à venir)

Si vous utilisez JSON pour faire quelque chose qui n’est pas couvert par une bibliothèque de cette suite ou l’un des projets ci-dessus, n’hésitez pas à [créer une demande de fonctionnalité](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Si vous maintenez ou connaissez un autre projet qui étend _System.Text.Json_ pour faire des choses intéressantes, j’aimerais l’ajouter ici, alors merci de [créer un ticket général](https://github.com/json-everything/json-everything/issues/new) pour m’en informer.

## Contribution

Veuillez consulter le [Code de Conduite](./CODE_OF_CONDUCT.md) et le fichier [CONTRIBUTING](./CONTRIBUTING.md) pour plus d’informations.

## Sponsoring

Si vous avez trouvé ces bibliothèques utiles et souhaitez encourager le développement continu, merci de [sponsoriser les mainteneurs](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Ce projet est soutenu par la [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---