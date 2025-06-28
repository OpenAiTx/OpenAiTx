[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## json-everything چیست؟

فلسفه اصلی پشت `json-everything` این است که اطمینان حاصل شود قابلیت‌های رایج JSON در فضای _System.Text.Json_ به خوبی پشتیبانی می‌شوند.

اولین گام در این راه، بررسی این است که آیا پروژه‌های دیگری وجود دارند که عملکرد مورد نظر را پشتیبانی می‌کنند یا خیر.

در صورتی که چنین باشد، احتمالاً آن تلاش در اینجا تکرار نخواهد شد. کمی پایین‌تر فهرستی از پروژه‌های دیگری که کارهای جالبی با JSON انجام می‌دهند خواهید یافت.

در غیر این صورت، این قابلیت برای این پروژه مورد بررسی قرار خواهد گرفت.

<table>
<thead>
<tr>
<th width="207">محیط آزمایشی</th>
<th width="207">مستندات</th>
<th width="207">وبلاگ</th>
<th width="207">یادگیری تعاملی</th>
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
<th width="276">بحث</th>
<th width="276">پرسش</th>
<th width="276">ساخته شده با</th>
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

## چه چیزی داخل جعبه است؟

در واقع چندین جعبه وجود دارد. هر بخش از قابلیت‌ها به صورت یک کتابخانه مجزا ارائه شده تا بتوانید هر کدام را که نیاز دارید انتخاب و استفاده کنید.

همه کتابخانه‌ها برای .Net Standard 2.0 و .Net 8 ساخته شده‌اند.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>، پیش‌نویس ۶ و بالاتر</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>تولید اسکیمای JSON از انواع .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>پشتیبانی از تولید اسکیمای JSON برای <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>تولید داده نمونه تصادفی (با قدرت گرفته از <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>واژگان برای دسترسی به داده نمونه و داده خارجی</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>واژگان برای گسترش اعتبارسنجی آرایه‌ها</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>افزونه واژگان <a href="https://www.openapis.org/">OpenApi 3.1</a> (استفاده شده در <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
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
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) و Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Specification</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">وب‌سایت</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">وب‌سایت</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>افزونه‌های عمومی که احتمالاً باید در <em>System.Text.Json[.Nodes]</em> قرار می‌گرفتند اما قرار نگرفتند</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>تبدیل بین مدل سند YAML در <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> و <code>JsonNode</code> (در هر دو جهت).</td>
</tr>
</tbody>
</table>

تمام کتابخانه‌های فوق پشتیبانی کامل از استانداردهای مربوطه خود را ارائه می‌دهند.

ترجمه پیام‌های خطا برای _JsonSchema.Net_ موجود است به زبان‌های:

- ایتالیایی `it`
- نروژی `nb-NO`
- لهستانی `pl-PL`
- روسی `ru`
- اسپانیایی `es`
- سوئدی `sv-SE`
- ترکی `tr-TR`

***توجه:** هر بسته زبانی به صورت یک بسته جداگانه در Nuget ارائه شده است.*

همچنین می‌توانید نتایج تست مجموعه آزمون JSON Schema را در [Bowtie](https://bowtie-json-schema.github.io/bowtie) مشاهده کنید که این آزمون را روی چندین پیاده‌سازی در پلتفرم‌های مختلف اجرا می‌کند.

***سلب مسئولیت:** کتابخانه من، _JsonSchema.Net_، هیچ ارتباطی با سایت https://jsonschema.net ندارد، جز اینکه هر دو ابزارهای عالی برای JSON Schema هستند.*

### بسته‌های منسوخ شده

این بسته‌ها نیز قبلاً بخشی از این مجموعه بوده‌اند اما دیگر پشتیبانی نمی‌شوند.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>تولید کد #C از روی اسکیمای JSON</td>
<td>در حال حاضر منسوخ و جایگزین <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> شده است</td>
</tr>
</tbody>
</table>


## پشتیبانی _System.Text.Json_ توسط پروژه‌های دیگر

اگر آنچه را که نیاز دارید اینجا پیدا نکردید، لطفاً یکی از این پروژه‌های عالی را امتحان کنید:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) توسط [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) توسط [@mwadams](https://github.com/mwadams)
  - اعتبارسنجی JSON Schema با تمرکز بر تولید کد #C
- (موارد بیشتر به زودی)

اگر از JSON برای کاری استفاده می‌کنید که هیچ کتابخانه‌ای در این مجموعه یا پروژه‌های فوق آن را پوشش نمی‌دهد، می‌توانید [یک issue ویژگی ایجاد کنید](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

اگر پروژه دیگری را می‌شناسید یا نگهداری می‌کنید که _System.Text.Json_ را گسترش می‌دهد و کارهای جالبی انجام می‌دهد، خوشحال می‌شوم که آن را اینجا فهرست کنم. لطفاً [یک issue عمومی ایجاد کنید](https://github.com/json-everything/json-everything/issues/new) و مرا مطلع کنید.

## مشارکت

لطفاً برای اطلاعات بیشتر به [قوانین رفتاری](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) و [راهنمای مشارکت](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) مراجعه کنید.

## حمایت مالی

اگر این کتابخانه‌ها برای شما مفید بوده‌اند و مایل به حمایت از توسعه مداوم آن‌ها هستید، لطفاً [از نگهدارندگان پروژه حمایت مالی کنید](https://github.com/sponsors/gregsdennis).

## بنیاد .NET

این پروژه توسط [بنیاد .NET](https://dotnetfoundation.org) پشتیبانی می‌شود.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---