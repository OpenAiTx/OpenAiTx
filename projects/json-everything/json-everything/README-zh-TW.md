[![建置與測試](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![測試結果](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![未解決議題百分比](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "未解決議題百分比")
[![平均議題解決時間](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "平均議題解決時間")
[![授權條款](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## 什麼是 `json-everything`？

`json-everything` 背後的主要理念是確保常見的 JSON 功能在 _System.Text.Json_ 生態中獲得良好支援。

第一步是檢查是否已經有其他專案支援某個功能。

如果有，這裡通常不會重複實作。稍後你會看到一些其他專案的列表，它們對 JSON 做了很酷的事情。

否則，這個專案會考慮納入該功能。

<table>
<thead>
<tr>
<th width="207">線上試玩</th>
<th width="207">文件</th>
<th width="207">部落格</th>
<th width="207">互動學習</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="線上試用" title="線上試用" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="文件" title="文件" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="部落格" title="部落格" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="學習" title="學習" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">討論</th>
<th width="276">提問</th>
<th width="276">技術支援</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="以 Jetbrains Resharper 製作" title="以 Jetbrains Resharper 製作" height="50"></a></td>
</tr>
</tbody>
</table>

## 內容介紹

其實有多個「盒子」。每一項功能都被拆分為獨立的函式庫，你可以按需選擇。

所有函式庫皆支援 .Net Standard 2.0 及 .Net 8。

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>，支援第 6 版及以上</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>從 .Net 類型自動產生 Schema</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>支援 <em>System.ComponentModel.DataAnnotations</em> 的 Schema 產生。</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>隨機資料產生（由 <a href="https://github.com/bchavez/Bogus">Bogus</a> 驅動）</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>用於存取實例與外部資料的詞彙</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>用於擴展陣列驗證的詞彙</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> 詞彙擴充（由 <a href="https://github.com/gregsdennis/Graeae">Graeae</a> 使用）</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) 及 Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">規範</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">官方網站</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">官方網站</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>通用擴充功能，原應包含於 <em>System.Text.Json[.Nodes]</em>，但尚未納入</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td><a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> 的 YAML 文件模型與 <code>JsonNode</code> 之間的轉換（雙向支援）。</td>
</tr>
</tbody>
</table>

以上所有函式庫皆完整支援其相關規範。

_JsonSchema.Net_ 的錯誤訊息支援下列語言：

- 義大利語 `it`
- 挪威語 `nb-NO`
- 波蘭語 `pl-PL`
- 俄語 `ru`
- 西班牙語 `es`
- 瑞典語 `sv-SE`
- 土耳其語 `tr-TR`

***注意**：每個語言包皆以獨立 Nuget 套件提供。*

你也可以在 [Bowtie](https://bowtie-json-schema.github.io/bowtie) 查看 JSON Schema 測試套件結果，該平台會在多個不同平台的實作上運行測試套件。

***免責聲明**：我的函式庫 _JsonSchema.Net_ 與網站 https://jsonschema.net 無任何關聯，僅同為優秀的 JSON Schema 工具。*

### 已棄用套件

以下套件過去也曾屬於本套件組，但現已不再支援。

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet 下載量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>從 Schema 產生 C# 程式碼</td>
<td>已棄用，建議改用 <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## 其他專案的 _System.Text.Json_ 支援

若你在這裡找不到所需功能，請試試下列優秀專案：

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) 作者 [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) 作者 [@mwadams](https://github.com/mwadams)
  - 著重於 C# 程式碼產生的 JSON Schema 驗證
- （更多即將推出）

如果你使用 JSON 完成了這個套件或上述專案未涵蓋的內容，歡迎[建立功能需求議題](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml)。

如果你維護或知道其他能擴展 _System.Text.Json_ 的有趣專案，並希望列在這裡，請[建立一般議題](https://github.com/json-everything/json-everything/issues/new) 告訴我。

## 貢獻

請參閱 [行為準則](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) 以及 [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) 文件以獲取更多資訊。

## 贊助

如果你覺得這些函式庫對你有幫助，並希望支持持續開發，歡迎[贊助維護者](https://github.com/sponsors/gregsdennis)。

## .NET 基金會

本專案由 [.NET Foundation](https://dotnetfoundation.org) 支持。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---