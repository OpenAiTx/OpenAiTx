> [!IMPORTANT]
> เพื่อความยั่งยืนระยะยาวของโครงการนี้ ได้มีการแนะนำค่าบำรุงรักษารายเดือน องค์กรหรือผู้ใช้ใด ๆ ที่สร้างรายได้จากไลบรารีใด ๆ ของโครงการนี้จำเป็นต้องชำระค่าธรรมเนียมดังกล่าว คุณสามารถชำระค่าธรรมเนียมผ่านทาง [GitHub Sponsors](https://github.com/sponsors/gregsdennis)
>
> เพื่อดำเนินการในเรื่องนี้ ได้มีการเพิ่มข้อตกลง EULA สำหรับ binary release ลงใน repo และแพ็คเกจ Nuget ที่ระบุให้ต้องชำระค่าบำรุงรักษานี้
>
> สำหรับข้อมูลเพิ่มเติมเกี่ยวกับผู้ที่ต้องชำระค่าธรรมเนียมและคำถามที่พบบ่อยอื่น ๆ กรุณาดูที่หน้าองค์กร [Open Source Maintenance Fee](https://opensourcemaintenancefee.org/consumers/)

<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` คืออะไร?

ปรัชญาหลักของ `json-everything` คือการทำให้แน่ใจว่าฟังก์ชันการทำงาน JSON ทั่วไปได้รับการสนับสนุนที่ดีในพื้นที่ _System.Text.Json_

ขั้นตอนแรกคือการตรวจสอบว่ามีโปรเจกต์อื่นที่รองรับฟังก์ชันที่ต้องการอยู่แล้วหรือไม่

ถ้าใช่ ความพยายามนั้นอาจจะไม่ถูกทำซ้ำที่นี่ ด้านล่างจะมีรายชื่อโปรเจกต์อื่น ๆ ที่ทำสิ่งเจ๋ง ๆ กับ JSON อยู่

แต่ถ้าไม่มี ก็เปิดให้พิจารณาสำหรับโปรเจกต์นี้

<table>
<thead>
<tr>
<th width="207">สนามทดลอง</th>
<th width="207">เอกสารประกอบ</th>
<th width="207">บล็อก</th>
<th width="207">การเรียนรู้แบบอินเทอร์แอคทีฟ</th>
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
<th width="276">พูดคุย</th>
<th width="276">ถามคำถาม</th>
<th width="276">สร้างด้วย</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-3cfmgde04-o09VBqj6YfpudxTuI3aRhA"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## มีอะไรอยู่ในกล่องบ้าง?

ความจริงแล้วมีกล่องหลายกล่อง ฟังก์ชันการทำงานแต่ละส่วนได้ถูกแยกออกเป็นไลบรารีของตัวเอง เพื่อให้คุณสามารถเลือกใช้เฉพาะส่วนที่ต้องการได้

ไลบรารีทั้งหมดถูกสร้างขึ้นสำหรับ .Net Standard 2.0 และ .Net 8

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
<td>JsonSchema.Net.Api<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Api/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Api.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Api.svg?svg=true"></img></a></td>
<td>การตรวจสอบ JSON Schema สำหรับ ASP.Net APIs</td>
</tr>
<tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>รองรับการสร้าง schema สำหรับ <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>การสร้างข้อมูลตัวอย่างแบบสุ่ม (ขับเคลื่อนโดย <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>คำศัพท์สำหรับการเข้าถึงข้อมูลอินสแตนซ์และข้อมูลภายนอก</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>คำศัพท์สำหรับการขยายการตรวจสอบอาเรย์</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>ส่วนขยายคำศัพท์ <a href="https://www.openapis.org/">OpenApi 3.1</a> (ใช้โดย <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>ส่วนขยายทั่วไปที่ควรจะถูกเพิ่มใน <em>System.Text.Json[.Nodes]</em> แต่ไม่ได้ถูกเพิ่ม</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>การแปลงระหว่างโมเดลเอกสาร YAML ใน <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> และ <code>JsonNode</code> (ทั้งสองทิศทาง)</td>
</tr>
</tbody>
</table>

ไลบรารีทั้งหมดข้างต้นมีการสนับสนุนที่สมบูรณ์สำหรับข้อกำหนดที่เกี่ยวข้อง

การแปลข้อความผิดพลาดสำหรับ _JsonSchema.Net_ มีให้ในภาษา:

- อิตาลี `it`
- นอร์เวย์ `nb-NO`
- โปแลนด์ `pl-PL`
- โปรตุเกส `pt`
- รัสเซีย `ru`
- สเปน `es`
- สวีเดน `sv-SE`
- ตุรกี `tr-TR`

***หมายเหตุ** แต่ละชุดภาษาให้บริการเป็นแพ็คเกจ Nuget ของตัวเอง*

คุณยังสามารถดูผลลัพธ์ JSON Schema Test Suite ได้ที่ [Bowtie](https://bowtie-json-schema.github.io/bowtie) ซึ่งรันชุดทดสอบกับการใช้งานหลายรูปแบบบนแพลตฟอร์มต่าง ๆ

***ข้อจำกัดความรับผิดชอบ** ไลบรารีของฉัน _JsonSchema.Net_ ไม่ได้เกี่ยวข้องหรือมีความสัมพันธ์กับเว็บไซต์ https://jsonschema.net ยกเว้นว่าทั้งสองเป็นเครื่องมือ JSON Schema ที่ยอดเยี่ยม*

### แพ็คเกจที่เลิกใช้งานแล้ว

แพ็คเกจเหล่านี้เคยเป็นส่วนหนึ่งของชุดนี้ แต่ไม่ได้รับการสนับสนุนอีกต่อไป

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>การสร้างโค้ด C# จากสคีมา</td>
<td>เลิกใช้งานแล้วโดยแนะนำให้ใช้ <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> แทน</td>
</tr>
</tbody>
</table>


## การสนับสนุน _System.Text.Json_ โดยโปรเจกต์อื่น

หากคุณไม่พบสิ่งที่ต้องการที่นี่ กรุณาลองโปรเจกต์ยอดเยี่ยมเหล่านี้:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) โดย [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) โดย [@mwadams](https://github.com/mwadams)
  - การตรวจสอบความถูกต้องของ JSON Schema โดยเน้นการสร้างโค้ด C#
- (จะมีเพิ่มเติมในอนาคต)

หากคุณใช้ JSON เพื่อทำสิ่งที่ยังไม่มีไลบรารีในชุดนี้หรือโครงการที่กล่าวถึงข้างต้นรองรับ คุณสามารถ [สร้าง issue ฟีเจอร์](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml) ได้ตามต้องการ

หากคุณดูแลหรือทราบโครงการอื่นที่ขยาย _System.Text.Json_ เพื่อทำสิ่งเจ๋ง ๆ อยากให้รายชื่อไว้ที่นี่ กรุณา [สร้าง issue ทั่วไป](https://github.com/json-everything/json-everything/issues/new) เพื่อแจ้งให้ทราบ

## การมีส่วนร่วม

โปรดดู [จรรยาบรรณ](https://raw.githubusercontent.com/json-everything/json-everything/master/./CODE_OF_CONDUCT.md) และไฟล์ [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/./CONTRIBUTING.md) เพื่อข้อมูลเพิ่มเติม

## การสนับสนุน

หากคุณพบว่าไลบรารีเหล่านี้มีประโยชน์และต้องการสนับสนุนการพัฒนาต่อเนื่อง กรุณา [สนับสนุนผู้ดูแลโครงการ](https://github.com/sponsors/gregsdennis)

## .NET Foundation

โครงการนี้ได้รับการสนับสนุนโดย [.NET Foundation](https://dotnetfoundation.org)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---