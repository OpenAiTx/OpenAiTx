[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` คืออะไร?

ปรัชญาหลักเบื้องหลัง `json-everything` คือการรับรองว่าฟังก์ชันการทำงาน JSON ทั่วไปได้รับการสนับสนุนที่ดีในพื้นที่ _System.Text.Json_

ขั้นตอนแรกคือการตรวจสอบว่ามีโปรเจกต์อื่นใดที่สนับสนุนฟังก์ชันที่ต้องการหรือไม่

ถ้ามี ก็อาจจะไม่ทำซ้ำความพยายามนั้นในที่นี้ ด้านล่างนี้คุณจะพบรายการโปรเจกต์อื่น ๆ ที่กำลังทำสิ่งที่น่าสนใจกับ JSON

หากไม่มีก็เปิดโอกาสให้พิจารณาในโปรเจกต์นี้

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Documentation</th>
<th width="207">Blog</th>
<th width="207">Interactive Learning</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Try it online" title="Try it online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Documentation" title="Documentation" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Learn" title="Learn" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Discuss</th>
<th width="276">Ask</th>
<th width="276">Built with</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## มีอะไรอยู่ในกล่องบ้าง?

จริง ๆ แล้วมีกล่องหลายกล่อง ฟังก์ชันการทำงานแต่ละส่วนได้ถูกแยกออกเป็นไลบรารีของตัวเอง คุณจึงสามารถเลือกเฉพาะอันที่คุณต้องการได้

ไลบรารีทั้งหมดสร้างมาสำหรับ .Net Standard 2.0 และ .Net 8

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, drafts 6 ขึ้นไป</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>การสร้าง schema จาก .Net types</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>รองรับการสร้าง schema สำหรับ <em>System.ComponentModel.DataAnnotations</em></td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>การสร้างข้อมูลสุ่ม (ขับเคลื่อนโดย <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>vocabulary สำหรับเข้าถึงข้อมูลอินสแตนซ์และข้อมูลภายนอก</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>vocabulary สำหรับขยายการตรวจสอบความถูกต้องของ array</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> ส่วนขยาย vocabulary (ใช้โดย <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) และ Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Specification</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">เว็บไซต์</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">เว็บไซต์</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>ส่วนขยายการใช้งานทั่วไปที่ควรจะถูกใส่ใน <em>System.Text.Json[.Nodes]</em> แต่ยังไม่ได้ถูกใส่</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>แปลงโมเดลเอกสาร YAML ใน <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> และ <code>JsonNode</code> (ไป-กลับ)</td>
</tr>
</tbody>
</table>

ไลบรารีข้างต้นทั้งหมดรองรับสเปคที่เกี่ยวข้องอย่างสมบูรณ์

มีการแปลข้อความข้อผิดพลาดสำหรับ _JsonSchema.Net_ ใน:

- อิตาเลียน `it`
- นอร์เวย์ `nb-NO`
- โปแลนด์ `pl-PL`
- รัสเซีย `ru`
- สเปน `es`
- สวีเดน `sv-SE`
- ตุรกี `tr-TR`

***หมายเหตุ** แต่ละภาษามี Nuget package ของตัวเอง*

คุณยังสามารถดูผลลัพธ์ของ JSON Schema Test Suite ได้ที่ [Bowtie](https://bowtie-json-schema.github.io/bowtie) ซึ่งรันทดสอบกับหลาย implementation บนแพลตฟอร์มต่าง ๆ

***ข้อสงวนสิทธิ์** ไลบรารีของฉัน _JsonSchema.Net_ ไม่เกี่ยวข้องหรือมีความสัมพันธ์กับเว็บไซต์ https://jsonschema.net ยกเว้นว่าทั้งสองเป็นเครื่องมือ JSON Schema ที่ยอดเยี่ยม*

### แพ็คเกจที่เลิกใช้แล้ว

แพ็คเกจเหล่านี้เคยเป็นส่วนหนึ่งของชุดนี้แต่ไม่ได้รับการสนับสนุนอีกต่อไป

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>การสร้างโค้ด C# จาก schema</td>
<td>เลิกใช้แล้ว ให้ใช้ <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> แทน</td>
</tr>
</tbody>
</table>


## _System.Text.Json_ ที่สนับสนุนโดยโปรเจกต์อื่น

หากคุณไม่พบสิ่งที่ต้องการในที่นี้ โปรดลองโปรเจกต์ที่ยอดเยี่ยมเหล่านี้:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) โดย [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) โดย [@mwadams](https://github.com/mwadams)
  - การตรวจสอบ JSON Schema พร้อมโฟกัสที่การสร้างโค้ด C#
- (จะมีเพิ่มเติม)

หากคุณใช้ JSON เพื่อทำบางสิ่งที่ไม่มีในไลบรารีชุดนี้หรือโปรเจกต์ข้างต้น กรุณา [สร้าง feature issue](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml)

หากคุณดูแลหรือทราบโปรเจกต์อื่นที่ขยาย _System.Text.Json_ เพื่อทำสิ่งที่น่าสนใจ อยากให้แสดงไว้ที่นี่ กรุณา [สร้าง issue ทั่วไป](https://github.com/json-everything/json-everything/issues/new) เพื่อแจ้งให้ทราบ

## การมีส่วนร่วม

โปรดดู [Code of Conduct](./CODE_OF_CONDUCT.md) และไฟล์ [CONTRIBUTING](./CONTRIBUTING.md) สำหรับข้อมูลเพิ่มเติม

## การสนับสนุน

หากคุณพบว่าไลบรารีเหล่านี้มีประโยชน์และต้องการสนับสนุนการพัฒนาต่อ กรุณา [สนับสนุนผู้ดูแล](https://github.com/sponsors/gregsdennis)

## .NET Foundation

โปรเจกต์นี้ได้รับการสนับสนุนโดย [.NET Foundation](https://dotnetfoundation.org)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---