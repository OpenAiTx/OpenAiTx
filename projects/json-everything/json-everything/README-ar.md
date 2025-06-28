[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## ما هو `json-everything`؟

الفلسفة الأساسية وراء `json-everything` هي ضمان أن الوظائف الشائعة لـ JSON تحظى بدعم جيد في مساحة _System.Text.Json_.

الخطوة الأولى لتحقيق ذلك هي التحقق مما إذا كانت هناك مشاريع أخرى تدعم الوظيفة المطلوبة.

إذا كان الأمر كذلك، فمن المحتمل ألا يتم تكرار هذا الجهد هنا. في الأسفل ستجد قائمة بمشاريع أخرى تقوم بأشياء رائعة مع JSON.

وإلا، فإنه يكون متاحًا للنظر فيه ضمن هذا المشروع.

<table>
<thead>
<tr>
<th width="207">ساحة اللعب</th>
<th width="207">التوثيق</th>
<th width="207">المدونة</th>
<th width="207">التعلم التفاعلي</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="جربه عبر الإنترنت" title="جربه عبر الإنترنت" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="التوثيق" title="التوثيق" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="المدونة" title="المدونة" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="تعلم" title="تعلم" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">النقاش</th>
<th width="276">اسأل</th>
<th width="276">تم البناء بواسطة</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="تم باستخدام Jetbrains Resharper" title="تم باستخدام Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## ماذا يوجد في الصندوق؟

في الواقع هناك عدة صناديق. كل وظيفة تم تقسيمها إلى مكتبتها الخاصة، بحيث يمكنك اختيار ما تحتاجه منها.

جميع المكتبات مبنية على .Net Standard 2.0 و .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">مخطط JSON</a>، المسودات 6 وما فوق</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>توليد المخططات من أنواع .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>دعم توليد المخططات لـ <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>توليد بيانات عشوائية (بدعم من <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>مفردات للوصول إلى بيانات العينة والبيانات الخارجية</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>مفردات لتوسيع تحقق المصفوفات</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>امتداد مفردات <a href="https://www.openapis.org/">OpenApi 3.1</a> (يُستخدم بواسطة <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>مسار JSON (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>تصحيح JSON (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>مؤشر JSON (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) ومؤشر JSON النسبي (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">المواصفة</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">الموقع الإلكتروني</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">الموقع الإلكتروني</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>امتدادات للاستخدام العام كان ينبغي تضمينها في <em>System.Text.Json[.Nodes]</em> ولكن لم تُدرج</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>تحويلات بين نموذج مستند YAML في <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> و <code>JsonNode</code> (في كلا الاتجاهين).</td>
</tr>
</tbody>
</table>

جميع المكتبات المذكورة أعلاه توفر دعمًا كاملاً للمواصفات المرتبطة بها.

ترجمات رسائل الخطأ لـ _JsonSchema.Net_ متوفرة باللغات:

- الإيطالية `it`
- النرويجية `nb-NO`
- البولندية `pl-PL`
- الروسية `ru`
- الإسبانية `es`
- السويدية `sv-SE`
- التركية `tr-TR`

***ملاحظة**: كل حزمة لغة مقدمة كحزمة Nuget منفصلة.*

يمكنك أيضًا عرض نتائج مجموعة اختبارات JSON Schema على [Bowtie](https://bowtie-json-schema.github.io/bowtie)، والتي تشغل مجموعة الاختبار ضد عدة تطبيقات عبر منصات مختلفة.

***إخلاء المسؤولية**: مكتبتي، _JsonSchema.Net_، ليست مرتبطة أو تابعة لموقع https://jsonschema.net، باستثناء أنهما كلاهما أدوات ممتازة لـ JSON Schema.*

### الحزم المهملة

هذه الحزم كانت جزءًا من هذه المجموعة ولكن لم يعد يتم دعمها.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>توليد كود C# من المخططات</td>
<td>تم إهماله لصالح <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## دعم _System.Text.Json_ بواسطة مشاريع أخرى

إذا لم تجد ما تبحث عنه هنا، يرجى تجربة أحد هذه المشاريع الممتازة:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) بواسطة [@danielaparker](https://github.com/danielaparker)
  - مؤشر JSON
  - تصحيح JSON
  - تصحيح دمج JSON
  - مسار JSON
  - مسار JMES
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) بواسطة [@mwadams](https://github.com/mwadams)
  - تحقق من مخطط JSON مع التركيز على توليد كود C#
- (المزيد قادم)

إذا كنت تستخدم JSON للقيام بشيء غير مغطى بمكتبة في هذه المجموعة أو أحد المشاريع أعلاه، لا تتردد في [إنشاء طلب ميزة](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

إذا كنت تدير أو تعرف مشروعًا آخر يوسع _System.Text.Json_ للقيام بأشياء رائعة، أود أن أدرجه هنا، لذا يرجى [إنشاء طلب عام](https://github.com/json-everything/json-everything/issues/new) لإعلامي بذلك.

## المساهمة

يرجى الاطلاع على [مدونة قواعد السلوك](./CODE_OF_CONDUCT.md) وملف [CONTRIBUTING](./CONTRIBUTING.md) لمزيد من المعلومات.

## الرعاية

إذا وجدت هذه المكتبات مفيدة وترغب في دعم استمرار تطويرها، يرجى النظر في [رعاية القائمين عليها](https://github.com/sponsors/gregsdennis).

## مؤسسة .NET

هذا المشروع مدعوم من قبل [مؤسسة .NET](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---