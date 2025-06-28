[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## Apa itu `json-everything`?

Filosofi utama di balik `json-everything` adalah memastikan bahwa fungsionalitas JSON umum mendapat dukungan yang baik di ruang _System.Text.Json_.

Langkah pertama untuk itu adalah memeriksa apakah ada proyek lain yang mendukung fungsi tertentu.

Jika ada, upaya tersebut kemungkinan tidak akan diduplikasi di sini. Sedikit lebih jauh ke bawah Anda akan menemukan daftar proyek lain yang melakukan beberapa hal keren dengan JSON.

Jika tidak, maka fungsionalitas tersebut terbuka untuk dipertimbangkan dalam proyek ini.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Dokumentasi</th>
<th width="207">Blog</th>
<th width="207">Pembelajaran Interaktif</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="Coba online" title="Coba online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="Dokumentasi" title="Dokumentasi" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="Belajar" title="Belajar" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Diskusi</th>
<th width="276">Tanya</th>
<th width="276">Dibuat dengan</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Dibuat dengan Jetbrains Resharper" title="Dibuat dengan Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Ada apa saja di dalamnya?

Sebenarnya ada beberapa kotak. Setiap bagian fungsionalitas telah dipisahkan menjadi pustaka sendiri, sehingga Anda dapat memilih yang Anda butuhkan.

Semua pustaka dibangun untuk .Net Standard 2.0 dan .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, draft 6 ke atas</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Pembuatan skema dari tipe .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Dukungan pembuatan skema untuk <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Pembuatan data instance acak (didukung oleh <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Kosakata untuk mengakses data instance dan eksternal</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Kosakata untuk memperluas validasi array</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Ekstensi kosakata <a href="https://www.openapis.org/">OpenApi 3.1</a> (digunakan oleh <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) dan Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Spesifikasi</a>)</td>
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
<td>Ekstensi penggunaan umum yang seharusnya ada di <em>System.Text.Json[.Nodes]</em> tapi tidak ada</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Konversi antara model dokumen YAML di <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> dan <code>JsonNode</code> (dua arah).</td>
</tr>
</tbody>
</table>

Semua pustaka di atas menawarkan dukungan lengkap untuk spesifikasi terkait.

Terjemahan pesan error untuk _JsonSchema.Net_ tersedia dalam:

- Italia `it`
- Norwegia `nb-NO`
- Polandia `pl-PL`
- Rusia `ru`
- Spanyol `es`
- Swedia `sv-SE`
- Turki `tr-TR`

***CATATAN** Setiap paket bahasa disediakan oleh paket Nuget masing-masing.*

Anda juga dapat melihat hasil JSON Schema Test Suite di [Bowtie](https://bowtie-json-schema.github.io/bowtie), yang menjalankan test suite pada berbagai implementasi lintas platform.

***DISKLAIMER** Pustaka saya, _JsonSchema.Net_, tidak terkait atau berafiliasi dengan website https://jsonschema.net, kecuali bahwa keduanya adalah alat JSON Schema yang sangat baik.*

### Paket yang dihentikan

Paket-paket ini juga pernah menjadi bagian dari suite ini namun sekarang sudah tidak didukung lagi.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Pembuatan kode C# dari skema</td>
<td>Dihentikan dan digantikan oleh <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>

## Dukungan _System.Text.Json_ oleh proyek lain

Jika Anda tidak menemukan apa yang Anda cari di sini, silakan coba salah satu proyek hebat berikut:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) oleh [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) oleh [@mwadams](https://github.com/mwadams)
  - Validasi JSON Schema dengan fokus pada pembuatan kode C#
- (akan bertambah)

Jika Anda menggunakan JSON untuk melakukan sesuatu yang belum didukung oleh pustaka dalam suite ini atau salah satu proyek di atas, silakan [buat permintaan fitur](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Jika Anda memelihara atau mengetahui proyek lain yang memperluas _System.Text.Json_ untuk hal keren lainnya, saya ingin mencantumkannya di sini, jadi silakan [buat isu umum](https://github.com/json-everything/json-everything/issues/new) untuk memberi tahu saya.

## Kontribusi

Silakan lihat [Code of Conduct](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) dan file [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) untuk informasi lebih lanjut.

## Sponsor

Jika Anda merasa pustaka ini bermanfaat dan ingin mendukung pengembangan berkelanjutan, silakan [sponsori pengelola](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Proyek ini didukung oleh [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---