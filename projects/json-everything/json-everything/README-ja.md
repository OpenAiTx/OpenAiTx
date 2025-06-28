[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` とは？

`json-everything` の主な理念は、一般的な JSON 機能が _System.Text.Json_ の領域で十分にサポートされることを保証することです。

その最初のステップは、特定の機能をサポートしている他のプロジェクトが存在するかどうかを確認することです。

もし存在する場合、その取り組みはここで重複されることはほぼありません。少し下に、JSON でクールなことをしている他のプロジェクトのリストがあります。

そうでなければ、このプロジェクトで検討される可能性があります。

<table>
<thead>
<tr>
<th width="207">プレイグラウンド</th>
<th width="207">ドキュメント</th>
<th width="207">ブログ</th>
<th width="207">インタラクティブラーニング</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="Try it online" title="Try it online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="Documentation" title="Documentation" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="Learn" title="Learn" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">ディスカッション</th>
<th width="276">質問</th>
<th width="276">ビルド環境</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## 同梱内容は？

実際には複数の「箱」があります。各機能は独自のライブラリとして分割されているため、必要なものだけを選んで使用できます。

すべてのライブラリは .Net Standard 2.0 および .Net 8 向けにビルドされています。

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>、ドラフト6以降</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>.Net型からのスキーマ生成</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td><em>System.ComponentModel.DataAnnotations</em> のスキーマ生成サポート。</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>ランダムインスタンスデータ生成（<a href="https://github.com/bchavez/Bogus">Bogus</a> による）</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>インスタンスおよび外部データにアクセスするための語彙</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>配列バリデーション拡張のための語彙</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> 語彙拡張（<a href="https://github.com/gregsdennis/Graeae">Graeae</a> で使用）</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path（<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>）</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch（<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>）</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer（<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>）および Relative JSON Pointer（<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">仕様</a>）</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic（<a href="https://jsonlogic.com">公式サイト</a>）</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e（<a href="https://json-e.js.org/">公式サイト</a>）</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td><em>System.Text.Json[.Nodes]</em> に本来含まれるべきだったが含まれていない一般的な拡張機能</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td><a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> のYAMLドキュメントモデルと <code>JsonNode</code> との相互変換（両方向）。</td>
</tr>
</tbody>
</table>

上記すべてのライブラリは、関連する仕様に対して完全なサポートを提供します。

_JsonSchema.Net_ のエラーメッセージ翻訳は以下の言語で利用可能です：

- イタリア語 `it`
- ノルウェー語 `nb-NO`
- ポーランド語 `pl-PL`
- ロシア語 `ru`
- スペイン語 `es`
- スウェーデン語 `sv-SE`
- トルコ語 `tr-TR`

***注** 各言語パックはそれぞれ独自のNugetパッケージとして提供されます。*

また、[Bowtie](https://bowtie-json-schema.github.io/bowtie) で JSON Schema Test Suite の結果を見ることができます。Bowtieは複数の実装をさまざまなプラットフォームでテストしています。

***免責事項** 私のライブラリ _JsonSchema.Net_ は、https://jsonschema.net というウェブサイトとは関係ありませんが、どちらも優れたJSON Schemaツールです。*

### 非推奨パッケージ

これらのパッケージもこのスイートに含まれていましたが、現在はサポートされていません。

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>スキーマからのC#コード生成</td>
<td><a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> の利用を推奨（非推奨）</td>
</tr>
</tbody>
</table>


## 他プロジェクトによる _System.Text.Json_ サポート

もしここで探しているものが見つからない場合、以下の優れたプロジェクトをぜひご利用ください：

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) （[@danielaparker](https://github.com/danielaparker) による）
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) （[@mwadams](https://github.com/mwadams) による）
  - C#コード生成に重点を置いたJSON Schemaバリデーション
- （今後追加予定）

もし、このスイートや上記プロジェクトでカバーされていないJSONの用途があれば、[機能リクエストissueの作成](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml) をご検討ください。

また、_System.Text.Json_ を拡張する他のプロジェクトを管理、もしくはご存知であれば、ぜひ [一般issueの作成](https://github.com/json-everything/json-everything/issues/new) をしてご連絡ください。ここに掲載したいと考えています。

## コントリビューション

詳細は [行動規範（Code of Conduct）](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) および [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) ファイルをご覧ください。

## スポンサーシップ

これらのライブラリが役立った場合、継続的な開発を支援するために [メンテナースポンサー](https://github.com/sponsors/gregsdennis) をご検討ください。

## .NET Foundation

このプロジェクトは[.NET Foundation](https://dotnetfoundation.org) によってサポートされています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---