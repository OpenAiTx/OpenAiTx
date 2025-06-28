[![构建与测试](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![测试结果](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![未关闭问题的百分比](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "未关闭问题的百分比")
[![问题解决的平均时间](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "问题解决的平均时间")
[![许可证](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## 什么是 `json-everything`？

`json-everything` 背后的主要理念是确保在 _System.Text.Json_ 生态中，对常见 JSON 功能提供良好的支持。

第一步是检查是否已经存在支持某项功能的其他项目。

如果有，这里可能不会重复实现该功能。稍后你会看到一个正在用 JSON 做一些很酷事情的其他项目列表。

否则，该功能会被纳入本项目的考虑范围。

<table>
<thead>
<tr>
<th width="207">在线演示</th>
<th width="207">文档</th>
<th width="207">博客</th>
<th width="207">交互式学习</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="在线试用" title="在线试用" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="文档" title="文档" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="博客" title="博客" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="学习" title="学习" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">讨论</th>
<th width="276">提问</th>
<th width="276">技术支持</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="由 Jetbrains Resharper 构建" title="由 Jetbrains Resharper 构建" height="50"></a></td>
</tr>
</tbody>
</table>

## 有哪些内容？

实际上有多个“盒子”。每一项功能都被拆分为独立的库，因此你可以按需选择所需的库。

所有库都基于 .Net Standard 2.0 和 .Net 8 构建。

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>，draft 6 及以上</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>基于 .Net 类型自动生成 Schema</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>支持 <em>System.ComponentModel.DataAnnotations</em> 的 Schema 生成。</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>随机实例数据生成（由 <a href="https://github.com/bchavez/Bogus">Bogus</a> 提供支持）</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>访问实例及外部数据的词汇表</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>扩展数组校验的词汇表</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> 词汇表扩展（被 <a href="https://github.com/gregsdennis/Graeae">Graeae</a> 使用）</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) 及 Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">规范</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">官方网站</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">官方网站</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>通用扩展，本应包含在 <em>System.Text.Json[.Nodes]</em> 中但未被包含</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>在 <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> 的 YAML 文档模型和 <code>JsonNode</code> 之间的转换（双向支持）。</td>
</tr>
</tbody>
</table>

上述所有库均对其相关规范提供完整支持。

_JsonSchema.Net_ 的错误信息翻译支持如下语言：

- 意大利语 `it`
- 挪威语 `nb-NO`
- 波兰语 `pl-PL`
- 俄语 `ru`
- 西班牙语 `es`
- 瑞典语 `sv-SE`
- 土耳其语 `tr-TR`

***注意**：每个语言包都由独立的 Nuget 包提供。*

你还可以在 [Bowtie](https://bowtie-json-schema.github.io/bowtie) 查看 JSON Schema 测试套件的结果，该网站会在不同平台的多种实现上运行测试套件。

***免责声明**：本库 _JsonSchema.Net_ 与网站 https://jsonschema.net 无任何关联，仅同为优秀的 JSON Schema 工具。*

### 已废弃的包

以下包也曾属于本套件，但现已不再维护。

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet 版本" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet 下载量" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>从 Schema 生成 C# 代码</td>
<td>已废弃，推荐使用 <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>

## 其他项目对 _System.Text.Json_ 的支持

如果你没有在这里找到所需的功能，可以尝试以下优秀项目：

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) by [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) by [@mwadams](https://github.com/mwadams)
  - 以 C# 代码生成为重点的 JSON Schema 校验
- （更多项目即将推出）

如果你用 JSON 做了本套件或上述项目未涵盖的事情，欢迎[创建新功能需求](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml)。

如果你维护或了解其他扩展 _System.Text.Json_ 的项目，也欢迎[提交通用 issue](https://github.com/json-everything/json-everything/issues/new) 通知我们，以便将其列出。

## 贡献

请参阅 [行为准则](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) 和 [贡献指南](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) 获取更多信息。

## 赞助

如果你觉得这些库对你有帮助，并希望推动持续开发，请考虑[赞助维护者](https://github.com/sponsors/gregsdennis)。

## .NET 基金会

本项目由 [.NET Foundation](https://dotnetfoundation.org) 支持。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---