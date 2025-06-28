[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Что такое `json-everything`?

Основная философия `json-everything` заключается в обеспечении хорошей поддержки общих функций работы с JSON в пространстве _System.Text.Json_.

Первый шаг к этому — проверить, существуют ли другие проекты, поддерживающие данную функцию.

Если да, то, вероятно, здесь это дублироваться не будет. Ниже вы найдете список других проектов, которые делают интересные вещи с JSON.

В противном случае, возможность реализации рассматривается для этого проекта.

<table>
<thead>
<tr>
<th width="207">Песочница</th>
<th width="207">Документация</th>
<th width="207">Блог</th>
<th width="207">Интерактивное обучение</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Попробовать онлайн" title="Попробовать онлайн" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Документация" title="Документация" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Блог" title="Блог" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Обучение" title="Обучение" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Обсуждение</th>
<th width="276">Вопросы</th>
<th width="276">Сделано с помощью</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Сделано с помощью Jetbrains Resharper" title="Сделано с помощью Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Что входит в комплект?

На самом деле, есть несколько «коробок». Каждый функциональный компонент вынесен в отдельную библиотеку, чтобы вы могли выбрать только те, которые вам нужны.

Все библиотеки построены для .Net Standard 2.0 и .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, драфты 6 и выше</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Генерация схем из типов .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Поддержка генерации схем для <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Генерация случайных экземпляров данных (на базе <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Словарь для доступа к экземплярам и внешним данным</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Словарь для расширения валидации массивов</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Расширение словаря <a href="https://www.openapis.org/">OpenApi 3.1</a> (используется в <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) и Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Спецификация</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Вебсайт</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Вебсайт</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Общие расширения, которые, вероятно, должны были быть включены в <em>System.Text.Json[.Nodes]</em>, но не были</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Преобразование между моделью документа YAML в <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> и <code>JsonNode</code> (в обе стороны).</td>
</tr>
</tbody>
</table>

Все перечисленные выше библиотеки полностью поддерживают свои спецификации.

Переводы сообщений об ошибках для _JsonSchema.Net_ доступны на:

- Итальянский `it`
- Норвежский `nb-NO`
- Польский `pl-PL`
- Русский `ru`
- Испанский `es`
- Шведский `sv-SE`
- Турецкий `tr-TR`

***ПРИМЕЧАНИЕ** Каждый языковой пакет предоставляется отдельным пакетом Nuget.*

Вы также можете просмотреть результаты тестового набора JSON Schema на [Bowtie](https://bowtie-json-schema.github.io/bowtie), который выполняет тесты на различных реализациях и платформах.

***ОГОВОРКА** Моя библиотека, _JsonSchema.Net_, не связана и не ассоциирована с сайтом https://jsonschema.net, кроме того, что оба являются отличными инструментами для работы с JSON Schema.*

### Устаревшие пакеты

Эти пакеты также были частью набора, но больше не поддерживаются.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Генерация C# кода из схем</td>
<td>Устарел в пользу <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Поддержка _System.Text.Json_ в других проектах

Если вы не нашли нужную вам функциональность здесь, попробуйте один из этих отличных проектов:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) от [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) от [@mwadams](https://github.com/mwadams)
  - Валидация JSON Schema с поддержкой генерации C# кода
- (будет пополняться)

Если вы используете JSON для чего-то, что не поддерживается ни одной из библиотек этого набора или вышеуказанных проектов, вы можете [создать запрос на новую функцию](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Если вы поддерживаете или знаете другой проект, расширяющий _System.Text.Json_ для интересных задач, я бы хотел добавить его сюда — пожалуйста, [создайте общий тикет](https://github.com/json-everything/json-everything/issues/new), чтобы сообщить мне об этом.

## Вклад

Пожалуйста, ознакомьтесь с [Кодексом поведения](./CODE_OF_CONDUCT.md) и файлом [CONTRIBUTING](./CONTRIBUTING.md) для получения дополнительной информации.

## Спонсорство

Если эти библиотеки были полезны для вас и вы хотите поддержать дальнейшую разработку, пожалуйста, [поддержите разработчиков](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Этот проект поддерживается [.NET Foundation](https://dotnetfoundation.org).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---