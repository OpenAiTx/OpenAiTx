<div style="text-align: center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div style="text-align: center">
<p>هذا المشروع جزء من <a href="https://www.dotnetfoundation.org/">مؤسسة .NET</a> ويعمل تحت <a href="https://www.dotnetfoundation.org/code-of-conduct">مدونة السلوك الخاصة بهم</a>. </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div style="text-align: center">
 نجماتك على <a href="https://github.com/mini-software/MiniExcel">GitHub</a> أو <a href="https://miniexcel.github.io">تبرعاتك</a> يمكن أن تجعل MiniExcel أفضل
</div>

---

### المقدمة

MiniExcel هو أداة بسيطة وفعّالة لمعالجة ملفات إكسل لـ .NET، تم تصميمها خصيصاً لتقليل استهلاك الذاكرة.

حالياً، تحتاج معظم الأطر الشائعة إلى تحميل جميع البيانات من مستند Excel إلى الذاكرة لتسهيل العمليات، لكن هذا قد يؤدي إلى مشاكل في استهلاك الذاكرة. نهج MiniExcel مختلف: تتم معالجة البيانات صفاً صفاً بطريقة تدفقية، مما يقلل الاستهلاك الأصلي من مئات الميغابايتات إلى عدة ميغابايتات فقط، ويمنع بشكل فعّال مشاكل نفاد الذاكرة (OOM).

![Screenshot 2025-06-22 123525](https://github.com/user-attachments/assets/0b99a61e-8061-4604-8957-0b1f3ec74544)


### الميزات

- يقلل استهلاك الذاكرة، ويمنع أخطاء نفاد الذاكرة (OOM) ويتجنب جمع القمامة الكامل
- يمكّن من العمليات الفورية على مستوى الصف لتحقيق أداء أفضل مع مجموعات البيانات الكبيرة
- يدعم LINQ بتنفيذ مؤجل، مما يسمح بتقسيم الصفحات السريع والاستعلامات المعقدة بكفاءة عالية في استخدام الذاكرة
- خفيف الوزن، لا يحتاج إلى Microsoft Office أو مكونات COM+، وحجم ملف DLL أقل من 500 كيلوبايت
- واجهة برمجة تطبيقات بسيطة وبديهية لقراءة/كتابة/تعبئة ملفات Excel

### البدء السريع

- [استيراد/استعلام Excel](#getstart1)

- [تصدير/إنشاء Excel](#getstart2)

- [قالب Excel](#getstart3)

- [اسم العمود/الفهرس/تجاهل السمة في Excel](#getstart4)

- [أمثلة](#getstart5)



### التثبيت

يمكنك تثبيت الحزمة [من NuGet](https://www.nuget.org/packages/MiniExcel)

### ملاحظات الإصدارات

يرجى مراجعة [ملاحظات الإصدارات](docs)

### المهام القادمة

يرجى مراجعة  [المهام القادمة](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### الأداء

يمكنك العثور على كود اختبارات الأداء في [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs).

الملف المستخدم لاختبار الأداء هو [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx)، وهو مستند بحجم 32 ميغابايت يحتوي على 1,000,000 صف × 10 أعمدة تم ملء خلاياه بسلسلة "HelloWorld".

لتشغيل جميع اختبارات الأداء استخدم:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

يمكنك العثور على نتائج اختبارات الأداء للإصدار الأخير [هنا](benchmarks/results).


### استعلام/استيراد Excel  <a name="getstart1"></a>

#### 1. تنفيذ استعلام وربط النتائج بنوع بيانات قوي باستخدام IEnumerable [[جرّب الآن]](https://dotnetfiddle.net/w5WD1J)

يُنصح باستخدام Stream.Query لأنه أكثر كفاءة.

```csharp
public class UserAccount
{
```csharp
public Guid ID { get; set; }
public string Name { get; set; }
public DateTime BoD { get; set; }
public int Age { get; set; }
public bool VIP { get; set; }
public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// أو

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. تنفيذ استعلام وربطه بقائمة من الكائنات الديناميكية بدون استخدام رأس [[جرب ذلك]](https://dotnetfiddle.net/w5WD1J)

* المفتاح الديناميكي هو `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// أو
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. تنفيذ استعلام مع صف رأس أول [[جرب ذلك]](https://dotnetfiddle.net/w5WD1J)

ملاحظة: إذا كان هناك اسم عمود مكرر يتم استخدام الأخير من اليمين

إدخال Excel :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// أو

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. دعم الاستعلام عبر LINQ Extension First/Take/Skip ...إلخ

استعلام أول عنصر
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// أو

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

الأداء بين MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. الاستعلام حسب اسم الورقة

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//أو
stream.Query(sheetName: "SheetName");
```

#### 6. الاستعلام عن جميع أسماء الأوراق والصفوف
```
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. الحصول على الأعمدة

```csharp
var columns = MiniExcel.GetColumns(path); // مثال على النتيجة : ["A","B"...]

var cnt = columns.Count;  // الحصول على عدد الأعمدة
```

#### 8. الاستعلام الديناميكي بتحويل الصف إلى `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// أو
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// أو الاستعلام عن نطاقات محددة (بحروف كبيرة)
// A2 تمثل الصف الثاني من العمود A، وC3 تمثل الصف الثالث من العمود C
// إذا كنت لا ترغب في تقييد الصفوف، فقط لا تدرج الأرقام
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. استعلام Excel وإرجاع DataTable

غير مستحسن، لأن DataTable سيقوم بتحميل جميع البيانات في الذاكرة ويفقد ميزة استهلاك MiniExcel المنخفض للذاكرة.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. تحديد الخلية لبدء قراءة البيانات منها

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. تعبئة الخلايا المدمجة

ملاحظة: الكفاءة أبطأ مقارنةً بـ `عدم استخدام تعبئة الدمج`

السبب: معيار OpenXml يضع mergeCells في أسفل الملف، مما يؤدي إلى الحاجة لتكرار المرور على sheetxml مرتين

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

يدعم الطول والعرض المتغير وتعبئة الصفوف والأعمدة المتعددة

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. قراءة ملف كبير باستخدام التخزين المؤقت على القرص (Disk-Base Cache - SharedString)

إذا تجاوز حجم SharedStrings 5 ميجابايت، فإن MiniExcel بشكل افتراضي سيستخدم التخزين المؤقت على القرص المحلي، مثال، [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (بيانات مليون صف)، عند تعطيل التخزين المؤقت على القرص يكون الحد الأقصى لاستهلاك الذاكرة 195 ميجابايت، ولكن عند تفعيل التخزين المؤقت يحتاج فقط إلى 65 ميجابايت. ملاحظة، هذا التحسين يحتاج إلى بعض تكلفة الكفاءة، ففي هذه الحالة سيزيد وقت القراءة من 7.4 ثانية إلى 27.2 ثانية، إذا لم تكن بحاجة إليه يمكنك تعطيل التخزين المؤقت على القرص باستخدام الكود التالي:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

يمكنك استخدام `SharedStringCacheSize` لتغيير حجم ملف sharedString الذي يتجاوز الحجم المحدد للتخزين المؤقت على القرص
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)
```
### إنشاء/تصدير Excel  <a name="getstart2"></a>

1. يجب أن يكون نوعًا غير مجرد مع مُنشئ عام بدون معلمات.

2. يدعم MiniExcel تنفيذ IEnumerable المؤجل، إذا كنت تريد استخدام أقل قدر من الذاكرة، يُرجى عدم استدعاء طرق مثل ToList

مثال: ToList أو عدم استخدام الذاكرة
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. النوع المجهول أو النوع القوي [[جربها]](https://dotnetfiddle.net/w5WD1J)

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
MiniExcel.SaveAs(path, new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
});
```

#### 2. `IEnumerable<IDictionary<string, object>>`

```csharp
var values = new List<Dictionary<string, object>>()
{
    new Dictionary<string,object>{{ "Column1", "MiniExcel" }, { "Column2", 1 } },
    new Dictionary<string,object>{{ "Column1", "Github" }, { "Column2", 2 } }
};
MiniExcel.SaveAs(path, values);
```

نتيجة إنشاء الملف:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `موصى به`، يمكنه تجنب تحميل جميع البيانات في الذاكرة
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

تصدير DataReader لعدة أوراق (موصى به بواسطة Dapper ExecuteReader)

```csharp
using (var cnn = Connection)
{
    cnn.Open();
    var sheets = new Dictionary<string,object>();
    sheets.Add("sheet1", cnn.ExecuteReader("select 1 id"));
    sheets.Add("sheet2", cnn.ExecuteReader("select 2 id"));
    MiniExcel.SaveAs("Demo.xlsx", sheets);
}
```



#### 4. DataTable

- `غير موصى به`، سيقوم بتحميل جميع البيانات في الذاكرة

- يستخدم DataTable السمة Caption لاسم العمود أولاً، ثم يستخدم اسم العمود

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
var table = new DataTable();
{
    table.Columns.Add("Column1", typeof(string));
    table.Columns.Add("Column2", typeof(decimal));
    table.Rows.Add("MiniExcel", 1);
    table.Rows.Add("Github", 2);
}

MiniExcel.SaveAs(path, table);
```

####  5. استعلام Dapper

شكرًا لـ @shaofing #552 ، يرجى استخدام `CommandDefinition + CommandFlags.NoCache`

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // ملاحظة: QueryAsync سيلقي استثناء إغلاق الاتصال
    MiniExcel.SaveAs(path, rows);
```
}
```

الكود أدناه سيقوم بتحميل جميع البيانات في الذاكرة

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. الحفظ في MemoryStream  [[جرّبه]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //يدعم FileStream, MemoryStream إلخ.
{
    stream.SaveAs(values);
}
```

مثال : واجهة برمجة تطبيقات لتصدير ملف إكسل

```csharp
public IActionResult DownloadExcel()
{
    var values = new[] {
        new { Column1 = "MiniExcel", Column2 = 1 },
        new { Column1 = "Github", Column2 = 2}
    };

    var memoryStream = new MemoryStream();
    memoryStream.SaveAs(values);
    memoryStream.Seek(0, SeekOrigin.Begin);
    return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
    {
        FileDownloadName = "demo.xlsx"
    };
}
```


#### 7. إنشاء أوراق متعددة

```csharp
// 1. Dictionary<string,object>
var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
var sheets = new Dictionary<string, object>
{
    ["users"] = users,
    ["department"] = department
};
MiniExcel.SaveAs(path, sheets);

// 2. DataSet
var sheets = new DataSet();
sheets.Add(UsersDataTable);
sheets.Add(DepartmentDataTable);
//..
MiniExcel.SaveAs(path, sheets);
```

![image](https://user-images.githubusercontent.com/12729184/118130875-6e7c4580-b430-11eb-9b82-22f02716bd63.png)


#### 8. خيارات TableStyles

النمط الافتراضي

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

بدون تكوين النمط

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. عامل التصفية التلقائي (AutoFilter)

منذ الإصدار v0.19.0 يمكن لـ `OpenXmlConfiguration.AutoFilter` تفعيل/إلغاء تفعيل عامل التصفية التلقائي، القيمة الافتراضية هي `true`، وطريقة تعيين عامل التصفية التلقائي:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. إنشاء صورة

```csharp
```csharp
var value = new[] {
    new { Name="github",Image=File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png"))},
    new { Name="google",Image=File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png"))},
    new { Name="microsoft",Image=File.ReadAllBytes(PathHelper.GetFile("images/microsoft_logo.png"))},
    new { Name="reddit",Image=File.ReadAllBytes(PathHelper.GetFile("images/reddit_logo.png"))},
    new { Name="statck_overflow",Image=File.ReadAllBytes(PathHelper.GetFile("images/statck_overflow_logo.png"))},
};
MiniExcel.SaveAs(path, value);
```

![image](https://user-images.githubusercontent.com/12729184/150462383-ad9931b3-ed8d-4221-a1d6-66f799743433.png)



#### 11. تصدير ملف كمصفوفة بايت

بدءًا من الإصدار 1.22.0، عند كون نوع القيمة هو `byte[]` يقوم النظام افتراضيًا بحفظ مسار الملف في الخلية، وعند الاستيراد يمكن تحويله إلى `byte[]`. وإذا كنت لا ترغب في استخدام هذه الخاصية، يمكنك تعيين `OpenXmlConfiguration.EnableConvertByteArray` إلى `false`، مما قد يحسّن من كفاءة النظام.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

بدءًا من الإصدار 1.22.0، عند كون نوع القيمة هو `byte[]` يقوم النظام افتراضيًا بحفظ مسار الملف في الخلية، وعند الاستيراد يمكن تحويله إلى `byte[]`. وإذا كنت لا ترغب في استخدام هذه الخاصية، يمكنك تعيين `OpenXmlConfiguration.EnableConvertByteArray` إلى `false`، مما قد يحسّن من كفاءة النظام.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. دمج الخلايا المتشابهة عموديًا

هذه الخاصية مدعومة فقط في صيغة `xlsx` وتقوم بدمج الخلايا عموديًا بين الوسمين @merge و@endmerge.
يمكنك استخدام @mergelimit لتحديد حدود دمج الخلايا عموديًا.

```csharp
var mergedFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid().ToString()}.xlsx");

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

MiniExcel.MergeSameCells(mergedFilePath, path);
```

```csharp
var memoryStream = new MemoryStream();

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

memoryStream.MergeSameCells(path);
```

محتوى الملف قبل وبعد الدمج:

بدون حد للدمج:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

مع حد للدمج:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. تخطي القيم الفارغة (null)

خيار جديد صريح لكتابة خلايا فارغة للقيم الفارغة (null):

```csharp
DataTable dt = new DataTable();

/* ... */

DataRow dr = dt.NewRow();

dr["Name1"] = "Somebody once";
dr["Name2"] = null;
dr["Name3"] = "told me.";

dt.Rows.Add(dr);

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = true // القيمة الافتراضية.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419455-3c0aec8a-4e5f-4d83-b7ec-6572124c165d.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" s="2"></x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

السلوك السابق:
```
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // القيمة الافتراضية هي true.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419441-c4f27e8f-3f87-46db-a10f-08665864c874.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" t ="str" s="2">
        <x:v></x:v>
    </x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

يعمل مع القيم null و DBNull.

#### 14. تجميد الأجزاء (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // الافتراضي هو 1
    FreezeColumnCount = 2   // الافتراضي هو 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### تعبئة البيانات في قالب Excel <a name="getstart3"></a>

- الإعلان مشابه لقالب Vue `{{اسم المتغير}}`، أو عرض مجموعة `{{اسم المجموعة.اسم الحقل}}`
- دعم عرض المجموعات IEnumerable/DataTable/DapperRow

#### 1. تعبئة أساسية

القالب:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

النتيجة:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

الكود:
```csharp
// 1. بواسطة POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. بواسطة Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. تعبئة بيانات IEnumerable

> ملاحظة1: استخدم أول IEnumerable من نفس العمود كأساس لتعبئة القائمة

القالب:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

النتيجة:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

الكود:
```csharp
//1. بواسطة POCO
var value = new
{
    employees = new[] {
```
```csharp
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. باستخدام Dictionary
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 3. تعبئة بيانات معقدة

> ملاحظة: يدعم أوراق متعددة واستخدام نفس المتغير

القالب:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

النتيجة:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. باستخدام POCO
var value = new
{
    title = "FooCompany",
    managers = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    employees = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

// 2. باستخدام Dictionary
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    ["employees"] = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 4. أداء تعبئة البيانات الكبيرة

> ملاحظة: استخدام IEnumerable مع التنفيذ المؤجل وليس ToList يمكن أن يوفر أقصى استخدام للذاكرة في MiniExcel

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. نوع تعيين قيمة الخلية تلقائياً

القالب

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

النتيجة

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

الصنف

```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
```
```csharp
public decimal? @decimal { get; set; }
public double? @double { get; set; }
public DateTime? datetime { get; set; }
public bool? @bool { get; set; }
public Guid? Guid { get; set; }
}
```

كود

```csharp
var poco = new TestIEnumerableTypePoco { @string = "string", @int = 123, @decimal = decimal.Parse("123.45"), @double = (double)123.33, @datetime = new DateTime(2021, 4, 1), @bool = true, @Guid = Guid.NewGuid() };
var value = new
{
    Ts = new[] {
        poco,
        new TestIEnumerableTypePoco{},
        null,
        poco
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 6. مثال :  قائمة مشاريع Github

القالب

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


النتيجة

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

كود

```csharp
var projects = new[]
{
    new {Name = "MiniExcel",Link="https://github.com/mini-software/MiniExcel",Star=146, CreateTime=new DateTime(2021,03,01)},
    new {Name = "HtmlTableHelper",Link="https://github.com/mini-software/HtmlTableHelper",Star=16, CreateTime=new DateTime(2020,02,01)},
    new {Name = "PocoClassGenerator",Link="https://github.com/mini-software/PocoClassGenerator",Star=16, CreateTime=new DateTime(2019,03,17)}
};
var value = new
{
    User = "ITWeiHan",
    Projects = projects,
    TotalStar = projects.Sum(s => s.Star)
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 7. تعبئة بيانات مجمعة

```csharp
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Jack",department="HR"},
        new {name="John",department="HR"},
        new {name="John",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
await MiniExcel.SaveAsByTemplateAsync(path, templatePath, value);
```
##### 1. مع وسم `@group` ومع وسم `@header`

قبل

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

بعد

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. مع وسم @group وبدون وسم @header

قبل

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

بعد

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. بدون وسم @group

قبل

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

بعد

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)
```
#### 8. عبارات If/ElseIf/Else داخل الخلية

القواعد:
1. يدعم DateTime و Double و Int مع العمليات ==، !=، >، >=، <، <=.
2. يدعم String مع العمليات ==، !=.
3. يجب أن تكون كل عبارة في سطر جديد.
4. يجب إضافة مسافة واحدة قبل وبعد العمليات.
5. لا يجب أن يكون هناك سطر جديد داخل العبارات.
6. يجب أن تكون الخلية بنفس التنسيق التالي بالضبط.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

قبل

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

بعد

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable كمعامل

```csharp
var managers = new DataTable();
{
    managers.Columns.Add("name");
    managers.Columns.Add("department");
    managers.Rows.Add("Jack", "HR");
    managers.Rows.Add("Loan", "IT");
}
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = managers,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```
#### 10. الصيغ الحسابية

##### 1. مثال
قم بوضع بادئة `$` لصيغتك واستخدم `$enumrowstart` و `$enumrowend` لتحديد بداية ونهاية الصفوف المرجعية:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

عند عرض القالب، ستتم إزالة بادئة `$` وسيتم استبدال `$enumrowstart` و `$enumrowend` بأرقام الصفوف الفعلية للبداية والنهاية:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. أمثلة أخرى للصيغ:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| المجموع      | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| المتوسط البديل| `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| المدى        | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. أخرى

##### 1. التحقق من مفتاح معامل القالب

منذ الإصدار V1.24.0 ، يتم بشكل افتراضي تجاهل المعاملات المفقودة في القالب واستبدالها بسلسلة فارغة، ويمكن لـ `IgnoreTemplateParameterMissing` التحكم في رمي الاستثناء أو لا.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### خاصية اسم/فهرس/تجاهل عمود الإكسل <a name="getstart4"></a>



#### 1. تحديد اسم العمود، فهرس العمود، تجاهل العمود

مثال إكسل

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

كود

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
```csharp
public string Test1 { get; set; }
[ExcelColumnName("Column2")]
public string Test2 { get; set; }
[ExcelIgnore]
public string Test3 { get; set; }
[ExcelColumnIndex("I")] // سيقوم النظام بتحويل "I" إلى الفهرس 8
public string Test4 { get; set; }
public string Test5 { get; } // بدون set سيتم التجاهل
public string Test6 { get; private set; } // set غير عامة سيتم التجاهل
[ExcelColumnIndex(3)] // يبدأ من 0
public string Test7 { get; set; }
}

var rows = MiniExcel.Query<ExcelAttributeDemo>(path).ToList();
Assert.Equal("Column1", rows[0].Test1);
Assert.Equal("Column2", rows[0].Test2);
Assert.Null(rows[0].Test3);
Assert.Equal("Test7", rows[0].Test4);
Assert.Null(rows[0].Test5);
Assert.Null(rows[0].Test6);
Assert.Equal("Test4", rows[0].Test7);
```





#### 2. تنسيق مخصص (ExcelFormatAttribute)

منذ الإصدار V0.21.0 تم دعم الفئة التي تحتوي على طريقة `ToString(string content)` للتنسيق

الفئة

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

الكود

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

النتيجة

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

الاستعلام يدعم تحويل التنسيق المخصص

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. تعيين عرض العمود (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. ربط عدة أسماء أعمدة بنفس الخاصية.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

منذ الإصدار 1.24.0، يدعم النظام System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

```C#
public class TestIssueI4TXGTDto
{
    public int ID { get; set; }
    public string Name { get; set; }
    [DisplayName("Specification")]
    public string Spc { get; set; }
    [DisplayName("Unit Price")]
    public decimal Up { get; set; }
}
```
```

#### 6. خاصية ExcelColumnAttribute

منذ الإصدار V1.26.0، يمكن تبسيط استخدام عدة سمات كما يلي:
```csharp
        public class TestIssueI4ZYUUDto
        {
            [ExcelColumn(Name = "ID",Index =0)]
            public string MyProperty { get; set; }
            [ExcelColumn(Name = "CreateDate", Index = 1,Format ="yyyy-MM",Width =100)]
            public DateTime MyProperty2 { get; set; }
        }
```

#### 7. خاصية DynamicColumnAttribute

منذ الإصدار V1.26.0، يمكننا تعيين خصائص الأعمدة ديناميكياً
```csharp
            var config = new OpenXmlConfiguration
            {
                DynamicColumns = new DynamicExcelColumn[] {
                    new DynamicExcelColumn("id"){Ignore=true},
                    new DynamicExcelColumn("name"){Index=1,Width=10},
                    new DynamicExcelColumn("createdate"){Index=0,Format="yyyy-MM-dd",Width=15},
                    new DynamicExcelColumn("point"){Index=2,Name="Account Point"},
                }
            };
            var path = PathHelper.GetTempPath();
            var value = new[] { new { id = 1, name = "Jack", createdate = new DateTime(2022, 04, 12) ,point = 123.456} };
            MiniExcel.SaveAs(path, value, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/164510353-5aecbc4e-c3ce-41e8-b6cf-afd55eb23b68.png)

#### 8. خاصية DynamicSheetAttribute

منذ الإصدار V1.31.4 يمكننا تعيين خصائص الورقة (Sheet) ديناميكياً. يمكننا تعيين اسم الورقة وحالتها (ظهور/إخفاء).
```csharp
            var configuration = new OpenXmlConfiguration
            {
                DynamicSheets = new DynamicExcelSheet[] {
                    new DynamicExcelSheet("usersSheet") { Name = "Users", State = SheetState.Visible },
                    new DynamicExcelSheet("departmentSheet") { Name = "Departments", State = SheetState.Hidden }
                }
            };

            var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
            var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
            var sheets = new Dictionary<string, object>
            {
                ["usersSheet"] = users,
                ["departmentSheet"] = department
            };

            var path = PathHelper.GetTempPath();
            MiniExcel.SaveAs(path, sheets, configuration: configuration);
```

يمكننا أيضاً استخدام السمة الجديدة ExcelSheetAttribute:

```C#
   [ExcelSheet(Name = "Departments", State = SheetState.Hidden)]
   private class DepartmentDto
   {
      [ExcelColumn(Name = "ID",Index = 0)]
      public string ID { get; set; }
      [ExcelColumn(Name = "Name",Index = 1)]
      public string Name { get; set; }
   }
```

### إضافة، حذف، تحديث

#### الإضافة

يدعم الإصدار v1.28.0 إدراج بيانات CSV بعدد N من الصفوف بعد آخر صف

```csharp
// الأصل
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// إدراج صف واحد بعد الأخير
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// إدراج N صفوف بعد الأخير
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
```
};
    MiniExcel.Insert(path, value);
}
```

![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

الإصدار v1.37.0 يدعم إدراج ورقة جديدة في ملف إكسل موجود مسبقًا

```csharp
// ملف الإكسل الأصلي
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// إدراج ورقة جديدة
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### حذف (بانتظار)

#### تحديث (بانتظار)



### فحص نوع إكسل تلقائياً <a name="getstart5"></a>

- يقوم MiniExcel بفحص ما إذا كان الملف xlsx أو csv بناءً على `امتداد الملف` افتراضيًا، ولكن قد يكون هناك عدم دقة، يرجى تحديده يدويًا.
- لا يمكن معرفة نوع الإكسل من الـ Stream، يرجى تحديده يدويًا.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//أو
stream.SaveAs(excelType:ExcelType.XLSX);
//أو
stream.Query(excelType:ExcelType.CSV);
//أو
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### ملاحظة

- الإرجاع الافتراضي هو نوع `string`، ولن يتم تحويل القيم إلى أرقام أو تواريخ، ما لم يكن النوع معرفًا باستخدام النوع القوي (strong typing generic).



#### فاصل مخصص

الفاصل الافتراضي هو `,`، يمكنك تعديل خاصية `Seperator` للتخصيص

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

منذ الإصدار V1.30.1 تم دعم وظيفة تحديد الفاصل المخصص (شكرًا لـ @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### فاصل أسطر مخصص

الفاصل الافتراضي هو `\r\n` كرمز للسطر الجديد، يمكنك تعديل خاصية `NewLine` للتخصيص

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### ترميز مخصص
- الترميز الافتراضي هو "الكشف عن الترميز من علامات ترتيب البايتات"  (detectEncodingFromByteOrderMarks: true)
- إذا كان لديك متطلبات ترميز مخصصة، يرجى تعديل خاصية StreamReaderFunc / StreamWriterFunc

```csharp
// قراءة
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// كتابة
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### قراءة السلسلة الفارغة كقيمة null

بشكل افتراضي، يتم تعيين القيم الفارغة إلى string.Empty. يمكنك تعديل هذا السلوك

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
منذ الإصدار 1.23.0، يمكنك استخدام GetDataReader

```csharp
    using (var reader = MiniExcel.GetReader(path,true))
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var value = reader.GetValue(i);
            }
        }
    }
```



###  Async

- الإصدار v0.17.0 يدعم Async (شكرًا لـ isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

```csharp
public static Task SaveAsAsync(string path, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.UNKNOWN, IConfiguration configuration = null)
public static Task SaveAsAsync(this Stream stream, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.XLSX, IConfiguration configuration = null)
public static Task<IEnumerable<dynamic>> QueryAsync(string path, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task<IEnumerable<T>> QueryAsync<T>(this Stream stream, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<T>> QueryAsync<T>(string path, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<IDictionary<string, object>>> QueryAsync(this Stream stream, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task SaveAsByTemplateAsync(this Stream stream, string templatePath, object value)
public static Task SaveAsByTemplateAsync(this Stream stream, byte[] templateBytes, object value)
public static Task SaveAsByTemplateAsync(string path, string templatePath, object value)
public static Task SaveAsByTemplateAsync(string path, byte[] templateBytes, object value)
public static Task<DataTable> QueryAsDataTableAsync(string path, bool useHeaderRow = true, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
```

-  الإصدار v1.25.0 يدعم `cancellationToken`.



### أخرى

#### 1. Enum

تأكد أن اسم الخاصية في الإكسل يطابق اسم الخاصية في الكود، سيقوم النظام بالربط تلقائيًا (غير حساس لحالة الأحرف)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

منذ الإصدار V0.18.0 تم دعم خاصية Enum Description

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("General User")]
    V1,
    [Description("General Administrator")]
    V2,
    [Description("Super Administrator")]
    V3
}
```
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

منذ الإصدار 1.30.0 تم دعم الوصف في Excel إلى Enum، شكرًا لـ @KaneLeung

#### 2. تحويل CSV إلى XLSX أو تحويل XLSX إلى CSV

```csharp
MiniExcel.ConvertXlsxToCsv(xlsxPath, csvPath);
MiniExcel.ConvertXlsxToCsv(xlsxStream, csvStream);
MiniExcel.ConvertCsvToXlsx(csvPath, xlsxPath);
MiniExcel.ConvertCsvToXlsx(csvStream, xlsxStream);
```
```csharp
using (var excelStream = new FileStream(path: filePath, FileMode.Open, FileAccess.Read))
using (var csvStream = new MemoryStream())
{
   MiniExcel.ConvertXlsxToCsv(excelStream, csvStream);
}
```

#### 3. تخصيص CultureInfo

منذ الإصدار 1.22.0، يمكنك تخصيص CultureInfo كما يلي، الافتراضي في النظام هو `CultureInfo.InvariantCulture`.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// أو
MiniExcel.Query(path, configuration: config);
```


#### 4. تخصيص حجم المخزن المؤقت (Buffer Size)
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. وضع السرعة (FastMode)

لن يقوم النظام بالتحكم في الذاكرة، لكن يمكنك الحصول على سرعة حفظ أعلى.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. إضافة صور دفعة واحدة (MiniExcel.AddPicture)

يرجى إضافة الصور قبل توليد بيانات الصفوف دفعة واحدة، وإلا سيستخدم النظام ذاكرة كبيرة عند استدعاء AddPicture.

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // الافتراضي null هو أول ورقة
        CellAddress = "C3", // مطلوب
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // الافتراضي PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // مطلوب
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. الحصول على أبعاد الورقة (Get Sheets Dimension)

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### أمثلة:

#### 1. SQLite & Dapper إدخال بيانات ملف كبير في SQL لتجنب نفاد الذاكرة (OOM)

ملاحظة: يرجى عدم استدعاء طرق ToList/ToArray بعد Query، لأنها ستقوم بتحميل كل البيانات في الذاكرة

```csharp
using (var connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    using (var transaction = connection.BeginTransaction())
    using (var stream = File.OpenRead(path))
```
```csharp
{
   var rows = stream.Query();
   foreach (var row in rows)
         connection.Execute("insert into T (A,B) values (@A,@B)", new { row.A, row.B }, transaction: transaction);
   transaction.Commit();
}
}
```

الأداء:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 أو MVC 5 مثال API لتحميل/رفع ملفات Excel Xlsx [جربه](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)

```csharp
public class ApiController : Controller
{
    public IActionResult Index()
    {
        return new ContentResult
        {
            ContentType = "text/html",
            StatusCode = (int)HttpStatusCode.OK,
            Content = @"<html><body>
<a href='api/DownloadExcel'>DownloadExcel</a><br>
<a href='api/DownloadExcelFromTemplatePath'>DownloadExcelFromTemplatePath</a><br>
<a href='api/DownloadExcelFromTemplateBytes'>DownloadExcelFromTemplateBytes</a><br>
<p>Upload Excel</p>
<form method='post' enctype='multipart/form-data' action='/api/uploadexcel'>
    <input type='file' name='excel'> <br>
    <input type='submit' >
</form>
</body></html>"
        };
    }

    public IActionResult DownloadExcel()
    {
        var values = new[] {
            new { Column1 = "MiniExcel", Column2 = 1 },
            new { Column1 = "Github", Column2 = 2}
        };
        var memoryStream = new MemoryStream();
        memoryStream.SaveAs(values);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult DownloadExcelFromTemplatePath()
    {
        string templatePath = "TestTemplateComplex.xlsx";

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(templatePath, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    private static Dictionary<string, Byte[]> TemplateBytesCache = new Dictionary<string, byte[]>();

    static ApiController()
    {
        string templatePath = "TestTemplateComplex.xlsx";
        byte[] bytes = System.IO.File.ReadAllBytes(templatePath);
        TemplateBytesCache.Add(templatePath, bytes);
    }

    public IActionResult DownloadExcelFromTemplateBytes()
    {
        byte[] bytes = TemplateBytesCache["TestTemplateComplex.xlsx"];

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
```
```csharp
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(bytes, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult UploadExcel(IFormFile excel)
    {
        var stream = new MemoryStream();
        excel.CopyTo(stream);

        foreach (var item in stream.Query(true))
        {
            // نفذ منطقك هنا وما إلى ذلك.
        }

        return Ok("تم رفع الملف بنجاح");
    }
}
```

####  3. استعلام التصفح (Paging Query)

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== الصفحة رقم 1 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== الصفحة رقم 50 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== الصفحة رقم 5000 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. تصدير إكسل في WebForm باستخدام memorystream

```csharp
var fileName = "Demo.xlsx";
var sheetName = "Sheet1";
HttpResponse response = HttpContext.Current.Response;
response.Clear();
response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
response.AddHeader("Content-Disposition", $"attachment;filename=\"{fileName}\"");
var values = new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
};
var memoryStream = new MemoryStream();
memoryStream.SaveAs(values, sheetName: sheetName);
memoryStream.Seek(0, SeekOrigin.Begin);
memoryStream.CopyTo(Response.OutputStream);
response.End();
```



#### 5. إدارة الديناميكية للغات متعددة (i18n) وصلاحيات الدور

كما في المثال، أنشئ طريقة للتعامل مع i18n وإدارة الصلاحيات، واستخدم `yield return` لإرجاع IEnumerable<Dictionary<string, object>> لتحقيق معالجة ديناميكية وفعالة في الذاكرة.

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us ودور Sales");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
```
```csharp
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN and PMC role");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "zh-CN";
        var role = "PMC";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }
}

private IEnumerable<Dictionary<string, object>> GetOrders(string lang, string role, Order[] orders)
{
    foreach (var order in orders)
    {
        var newOrder = new Dictionary<string, object>();

        if (lang == "zh-CN")
        {
            newOrder.Add("客户编号", order.CustomerID);
            newOrder.Add("订单编号", order.OrderNo);
            newOrder.Add("产品编号", order.ProductID);
            newOrder.Add("数量", order.Qty);
            if (role == "Sales")
                newOrder.Add("价格", order.Amt);
            yield return newOrder;
        }
        else if (lang == "en-US")
        {
            newOrder.Add("Customer ID", order.CustomerID);
            newOrder.Add("Order No", order.OrderNo);
            newOrder.Add("Product ID", order.ProductID);
            newOrder.Add("Quantity", order.Qty);
            if (role == "Sales")
                newOrder.Add("Amount", order.Amt);
            yield return newOrder;
        }
        else
        {
            throw new InvalidDataException($"lang {lang} wrong");
        }
    }
}

public class Order
{
    public string OrderNo { get; set; }
    public string CustomerID { get; set; }
    public decimal Qty { get; set; }
    public string ProductID { get; set; }
    public decimal Amt { get; set; }
}
```

![image](https://user-images.githubusercontent.com/12729184/118939964-d24bc480-b982-11eb-88dd-f06655f6121a.png)



### الأسئلة المتكررة

#### س: عنوان رأس Excel لا يساوي اسم خاصية الكلاس، كيف يمكن التعيين؟

ج. يرجى استخدام خاصية ExcelColumnName

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### س. كيف يمكن الاستعلام أو تصدير أوراق متعددة؟

ج. استخدم طريقة `GetSheetNames` مع وسيط  sheetName في  Query.



```csharp
var sheets = MiniExcel.GetSheetNames(path);
foreach (var sheet in sheets)
{
    Console.WriteLine($"sheet name : {sheet} ");
    var rows = MiniExcel.Query(path,useHeaderRow:true,sheetName:sheet);
    Console.WriteLine(rows);
}
```

![image](https://user-images.githubusercontent.com/12729184/116199841-2a1f5300-a76a-11eb-90a3-6710561cf6db.png)

#### س. كيف يمكن الاستعلام أو تصدير معلومات عن رؤية الورقة؟

ج. استخدم طريقة `GetSheetInformations`.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // رقم فهرس الورقة - يبدأ من 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // اسم الورقة
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // حالة رؤية الورقة - مرئية / مخفية
}
```
```

#### س. هل استخدام Count سيحمّل جميع البيانات إلى الذاكرة؟

لا، اختبار الصورة يحتوي على مليون صف * 10 أعمدة من البيانات، وأقصى استخدام للذاكرة أقل من 60 ميجابايت، ويستغرق 13.65 ثانية.

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### س. كيف يستخدم الاستعلام (Query) الفهارس الرقمية؟

الفهرس الافتراضي في Query هو مفتاح نصي: A,B,C... إذا كنت ترغب في التغيير إلى فهرس رقمي، يرجى إنشاء الطريقة التالية للتحويل

```csharp
void Main()
{
    var path = @"D:\git\MiniExcel\samples\xlsx\TestTypeMapping.xlsx";
    var rows = MiniExcel.Query(path,true);
    foreach (var r in ConvertToIntIndexRows(rows))
    {
        Console.Write($"column 0 : {r[0]} ,column 1 : {r[1]}");
        Console.WriteLine();
    }
}

private IEnumerable<Dictionary<int, object>> ConvertToIntIndexRows(IEnumerable<object> rows)
{
    ICollection<string> keys = null;
    var isFirst = true;
    foreach (IDictionary<string,object> r in rows)
    {
        if(isFirst)
        {
            keys = r.Keys;
            isFirst = false;
        }

        var dic = new Dictionary<int, object>();
        var index = 0;
        foreach (var key in keys)
            dic[index++] = r[key];
        yield return dic;
    }
}
```

#### س. لماذا يتم توليد ملف إكسل فارغ العنوان عندما تكون القيمة فارغة عند التصدير؟

لأن MiniExcel يستخدم منطقاً مشابهاً لـ JSON.NET للحصول على النوع ديناميكياً من القيم لتبسيط عمليات الـ API، ولا يمكن معرفة النوع بدون بيانات. يمكنك مراجعة [issue #133](https://github.com/mini-software/MiniExcel/issues/133) للمزيد من الفهم.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> الأنواع القوية & DataTable ستولد رؤوس الأعمدة، لكن Dictionary ستبقى إكسل فارغ

#### س. كيف أوقف foreach عند صف فارغ؟

يمكن استخدام MiniExcel مع `LINQ TakeWhile` لإيقاف تكرار foreach.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### س. كيف أحذف الصفوف الفارغة؟

![image](https://user-images.githubusercontent.com/12729184/137873865-7107d8f5-eb59-42db-903a-44e80589f1b2.png)

IEnumerable :

```csharp
public static IEnumerable<dynamic> QueryWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string,object> row in rows)
    {
        if(row.Keys.Any(key=>row[key]!=null))
            yield return row;
    }
}
```

DataTable :

```csharp
public static DataTable QueryAsDataTableWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    if (sheetName == null && excelType != ExcelType.CSV) /*Issue #279*/
        sheetName = stream.GetSheetNames().First();

    var dt = new DataTable(sheetName);
    var first = true;
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string, object> row in rows)
    {
        if (first)
        {

            foreach (var key in row.Keys)
            {
                var column = new DataColumn(key, typeof(object)) { Caption = key };
```
```csharp
                dt.Columns.Add(column);
            }

            dt.BeginLoadData();
            first = false;
        }

        var newRow = dt.NewRow();
        var isNull=true;
        foreach (var key in row.Keys)
        {
            var _v = row[key];
            if(_v!=null)
                isNull = false;
            newRow[key] = _v;
        }

        if(!isNull)
            dt.Rows.Add(newRow);
    }

    dt.EndLoadData();
    return dt;
}
```



#### س. كيف يمكن استخدام SaveAs(path,value) لاستبدال ملف موجود دون رمي خطأ "الملف ...xlsx موجود بالفعل"؟


يرجى استخدام فئة Stream لإنشاء منطق مخصص لإنشاء الملف، على سبيل المثال:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



أو، منذ الإصدار V1.25.0، تدعم SaveAs معلمة overwriteFile لتمكين/تعطيل استبدال الملف الموجود

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### القيود والتحذيرات

- لا يدعم ملفات xls والملفات المشفرة حالياً
- xlsm يدعم فقط الاستعلام



### المراجع

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### الشكر

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

شكرًا لتوفير رخصة مجانية لجميع منتجات IDE لهذا المشروع ([الترخيص](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### مشاركة التبرع بالمساهمة
الرابط https://github.com/orgs/mini-software/discussions/754

### المساهمون

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---