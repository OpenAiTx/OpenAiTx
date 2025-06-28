[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` nedir?

`json-everything`'in arkasındaki temel felsefe, yaygın JSON işlevselliğinin _System.Text.Json_ ortamında iyi bir desteğe sahip olmasını sağlamaktır.

Bunun ilk adımı, belirli bir işlevi destekleyen başka projelerin olup olmadığını kontrol etmektir.

Eğer varsa, bu çaba muhtemelen burada yinelenmez. Aşağıda JSON ile ilgili bazı harika şeyler yapan diğer projelerin bir listesini bulacaksınız.

Aksi takdirde, bu proje için değerlendirmeye açıktır.

<table>
<thead>
<tr>
<th width="207">Oyun Alanı</th>
<th width="207">Dokümantasyon</th>
<th width="207">Blog</th>
<th width="207">Etkileşimli Öğrenme</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Çevrimiçi deneyin" title="Çevrimiçi deneyin" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Dokümantasyon" title="Dokümantasyon" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Öğren" title="Öğren" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Tartış</th>
<th width="276">Sor</th>
<th width="276">İle inşa edildi</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Jetbrains Resharper ile yapıldı" title="Jetbrains Resharper ile yapıldı" height="50"></a></td>
</tr>
</tbody>
</table>

## Kutunun içinde ne var?

Aslında birden fazla kutu var. Her işlevsellik kendi kütüphanesine ayrılmıştır, böylece ihtiyacınız olan(ları) seçebilirsiniz.

Tüm kütüphaneler .Net Standard 2.0 ve .Net 8 için derlenmiştir.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, 6 ve üzeri taslaklar</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>.Net türlerinden şema üretimi</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td><em>System.ComponentModel.DataAnnotations</em> için şema üretim desteği.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Rastgele örnek veri üretimi (<a href="https://github.com/bchavez/Bogus">Bogus</a> tarafından desteklenmektedir)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Örnek ve harici verilere erişim için bir kelime dağarcığı</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Dizi doğrulamasını genişletmek için bir kelime dağarcığı</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> kelime dağarcığı uzantısı (<a href="https://github.com/gregsdennis/Graeae">Graeae</a> tarafından kullanılır)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) ve Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Spesifikasyon</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Web sitesi</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Web sitesi</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td><em>System.Text.Json[.Nodes]</em> içinde olması gereken ancak olmayan genel kullanım uzantıları</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td><a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a>'teki YAML belge modeli ile <code>JsonNode</code> arasında (iki yönlü) dönüşümler.</td>
</tr>
</tbody>
</table>

Yukarıdaki tüm kütüphaneler, ilişkili oldukları standartların tam desteğini sunar.

_JsonSchema.Net_ için hata mesajı çevirileri şu dillerde mevcuttur:

- İtalyanca `it`
- Norveççe `nb-NO`
- Lehçe `pl-PL`
- Rusça `ru`
- İspanyolca `es`
- İsveççe `sv-SE`
- Türkçe `tr-TR`

***NOT** Her dil paketi kendi Nuget paketiyle sağlanır.*

Ayrıca, JSON Schema Test Suite sonuçlarını [Bowtie](https://bowtie-json-schema.github.io/bowtie) üzerinden görüntüleyebilirsiniz; bu platform, test paketini farklı platformlarda birden çok uygulamada çalıştırır.

***UYARI** Benim kütüphanem _JsonSchema.Net_, https://jsonschema.net web sitesiyle ilişkili veya bağlantılı değildir; sadece ikisi de harika JSON Schema araçlarıdır.*

### Kullanımdan kaldırılmış paketler

Bu paketler de bu paketin bir parçasıydı ancak artık desteklenmiyor.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Şemalardan C# kodu üretimi</td>
<td><a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> lehine kullanımdan kaldırıldı</td>
</tr>
</tbody>
</table>


## Diğer projeler tarafından _System.Text.Json_ desteği

Aradığınız şeyi burada bulamazsanız, lütfen şu harika projelerden birini deneyin:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) ([danielaparker](https://github.com/danielaparker) tarafından)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) ([mwadams](https://github.com/mwadams) tarafından)
  - C# kod üretimine odaklanan JSON Schema doğrulama
- (daha fazlası eklenecek)

Eğer JSON'u bu paketteki veya yukarıdaki projelerdeki bir kütüphanede yer almayan bir şey için kullanıyorsanız, [özellik isteği oluşturabilirsiniz](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Eğer _System.Text.Json_'u genişleten başka bir proje biliyor ya da sürdürüyor ve burada yer almasını istiyorsanız, lütfen [genel bir konu oluşturun](https://github.com/json-everything/json-everything/issues/new) ve bana bildirin.

## Katkıda Bulunma

Daha fazla bilgi için lütfen [Davranış Kuralları](./CODE_OF_CONDUCT.md) ve [KATKI](./CONTRIBUTING.md) dosyasına bakın.

## Sponsorluk

Eğer bu kütüphaneleri faydalı bulduysanız ve geliştirilmesinin devam etmesini istiyorsanız, lütfen [geliştiricileri sponsor olarak desteklemeyi](https://github.com/sponsors/gregsdennis) düşünün.

## .NET Foundation

Bu proje [.NET Foundation](https://dotnetfoundation.org) tarafından desteklenmektedir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---