<div align="center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div align="center">
<p>این پروژه بخشی از <a href="https://www.dotnetfoundation.org/">بنیاد دات‌نت</a> است و تحت <a href="https://www.dotnetfoundation.org/code-of-conduct">منشور رفتار</a> آن فعالیت می‌کند.</p>
</div>

---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div align="center">
<a href="https://github.com/mini-software/MiniExcel">ستاره‌ دادن</a> یا <a href="https://miniexcel.github.io">حمایت مالی</a> شما می‌تواند MiniExcel را بهتر کند
</div>

---

### معرفی

MiniExcel یک ابزار ساده و کارآمد برای پردازش اکسل در .NET است که به طور خاص برای به حداقل رساندن استفاده از حافظه طراحی شده است.

در حال حاضر، بیشتر فریم‌ورک‌های محبوب نیاز دارند تمام داده‌های یک سند اکسل را برای انجام عملیات‌ها به حافظه بارگذاری کنند، اما این موضوع می‌تواند موجب مشکلات مصرف حافظه شود. رویکرد MiniExcel متفاوت است: داده‌ها به صورت ردیف به ردیف و به صورت جریانی (streaming) پردازش می‌شوند و مصرف اصلی را از صدها مگابایت بالقوه به فقط چند مگابایت کاهش می‌دهد و به طور مؤثری از بروز مشکلات کمبود حافظه (OOM) جلوگیری می‌کند.

![Screenshot 2025-06-22 123525](https://github.com/user-attachments/assets/0b99a61e-8061-4604-8957-0b1f3ec74544)


### ویژگی‌ها

- به حداقل رساندن مصرف حافظه و جلوگیری از خطاهای کمبود حافظه (OOM) و جلوگیری از جمع‌آوری کامل زباله‌ها
- امکان عملیات داده‌ای بلادرنگ و سطح ردیف برای عملکرد بهتر در مجموعه داده‌های بزرگ
- پشتیبانی از LINQ با اجرای تعویقی، امکان صفحه‌بندی سریع و کارآمد حافظه و پرس‌وجوهای پیچیده
- سبک، بدون نیاز به Microsoft Office یا اجزای COM+ و اندازه DLL کمتر از 500KB
- رابط برنامه‌نویسی (API) ساده و شهودی برای خواندن/نوشتن/تکمیل اکسل

### شروع کار

- [وارد کردن/پرس‌وجوی اکسل](#getstart1)

- [خروجی گرفتن/ایجاد اکسل](#getstart2)

- [قالب اکسل](#getstart3)

- [نام ستون/اندیس/ویژگی نادیده گرفتن در اکسل](#getstart4)

- [مثال‌ها](#getstart5)



### نصب

شما می‌توانید این بسته را [از NuGet](https://www.nuget.org/packages/MiniExcel) نصب کنید

### یادداشت‌های انتشار

لطفاً [یادداشت‌های انتشار](docs) را بررسی کنید

### TODO

لطفاً [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true) را بررسی کنید

### عملکرد

کد مربوط به بنچمارک‌ها را می‌توانید در [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs) پیدا کنید.

فایلی که برای آزمون عملکرد استفاده شده است [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx) است؛ یک سند 32 مگابایتی شامل 1,000,000 ردیف * 10 ستون که سلول‌های آن با رشته "HelloWorld" پر شده‌اند.

برای اجرای همه بنچمارک‌ها از دستور زیر استفاده کنید:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

می‌توانید نتایج بنچمارک‌های نسخه اخیر را [اینجا](benchmarks/results) مشاهده کنید.


### پرس‌وجو/وارد کردن اکسل  <a name="getstart1"></a>

#### 1. اجرای یک پرس‌وجو و نگاشت نتایج به یک IEnumerable با نوع قوی [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

توصیه می‌شود از Stream.Query به دلیل کارایی بهتر استفاده کنید.

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

// یا

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### ۲. اجرای یک کوئری و نگاشت آن به لیستی از اشیاء داینامیک بدون استفاده از سرستون [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

* کلید داینامیک `A.B.C.D..` است.

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// یا
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### ۳. اجرای کوئری با اولین ردیف به عنوان سرستون [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

توجه: در صورت تکرار نام ستون، آخرین مقدار سمت راست استفاده می‌شود.

ورودی اکسل:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// یا

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### ۴. پشتیبانی کوئری از LINQ Extension مانند First/Take/Skip و غیره

کوئری First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// یا

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

عملکرد بین MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### ۵. کوئری بر اساس نام شیت

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//یا
stream.Query(sheetName: "SheetName");
```

#### ۶. کوئری همه نام شیت‌ها و ردیف‌ها
```
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### ۷. دریافت ستون‌ها

```csharp
var columns = MiniExcel.GetColumns(path); // به عنوان مثال: ["A","B"...]

var cnt = columns.Count;  // دریافت تعداد ستون‌ها
```

#### ۸. کوئری داینامیک تبدیل ردیف به `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// یا
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// یا کوئری محدوده‌های مشخص شده (با حروف بزرگ)
// A2 نمایانگر ردیف دوم ستون A، C3 نمایانگر ردیف سوم ستون C است
// اگر نمی‌خواهید ردیف‌ها را محدود کنید، فقط عدد وارد نکنید
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### ۹. کوئری اکسل با بازگشت DataTable

توصیه نمی‌شود، زیرا DataTable تمام داده‌ها را به حافظه بارگذاری می‌کند و ویژگی مصرف پایین حافظه MiniExcel را از بین می‌برد.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### ۱۰. مشخص کردن سلول شروع برای خواندن داده

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### ۱۱. پر کردن سلول‌های ادغام شده

توجه: کارایی آن نسبت به `عدم استفاده از پر کردن ادغامی` کمتر است

دلیل: طبق استاندارد OpenXml، mergeCells در انتهای فایل قرار دارد و این باعث می‌شود مجبور باشید دوبار روی sheetxml حلقه بزنید

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

پشتیبانی از پرکردن چند ردیف و ستون با طول و عرض متغیر

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### ۱۲. خواندن فایل بزرگ با کش مبتنی بر دیسک (Disk-Base Cache - SharedString)

اگر اندازه SharedStrings بیشتر از ۵ مگابایت شود، MiniExcel به طور پیش‌فرض از کش دیسک محلی استفاده می‌کند، به عنوان مثال، [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (یک میلیون ردیف داده)، هنگام غیرفعال کردن کش دیسک، بیشترین مصرف حافظه ۱۹۵ مگابایت است، اما با فعال بودن کش دیسک فقط به ۶۵ مگابایت نیاز دارد. توجه داشته باشید، این بهینه‌سازی کمی هزینه کارایی دارد، بنابراین در این حالت زمان خواندن از ۷.۴ ثانیه به ۲۷.۲ ثانیه افزایش می‌یابد. اگر به آن نیاز ندارید می‌توانید کش دیسک را با کد زیر غیرفعال کنید:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

می‌توانید از `SharedStringCacheSize` برای تغییر اندازه فایل sharedString جهت کش شدن روی دیسک فراتر از اندازه مشخص شده استفاده کنید.
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)




```
### ایجاد/استخراج اکسل  <a name="getstart2"></a>

1. باید یک نوع غیر انتزاعی با سازنده عمومی بدون پارامتر باشد.

2. MiniExcel از اجرای تأخیری IEnumerable پشتیبانی می‌کند، اگر می‌خواهید کمترین میزان حافظه را مصرف کنید، لطفاً از فراخوانی متدهایی مانند ToList خودداری کنید.

مثال: ToList یا عدم استفاده از حافظه  
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. ناشناس یا نوع قوی [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

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

نتیجه ایجاد فایل:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `توصیه‌شده`، می‌تواند از بارگذاری تمام داده‌ها در حافظه جلوگیری کند
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

خروجی چندین شیت با DataReader (توصیه‌شده توسط Dapper ExecuteReader)

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



#### 4. دیتاتیبل

- `توصیه نمی‌شود`، همه داده‌ها را در حافظه بارگذاری می‌کند

- DataTable ابتدا از Caption برای نام ستون استفاده می‌کند، سپس از columname

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

####  5. کوئری Dapper

با تشکر از @shaofing #552 ، لطفاً از `CommandDefinition + CommandFlags.NoCache` استفاده کنید

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // توجه: QueryAsync استثنای بسته بودن اتصال را پرتاب خواهد کرد
    MiniExcel.SaveAs(path, rows);
```
}
```

کد زیر تمام داده‌ها را به حافظه بارگذاری می‌کند

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. ذخیره در MemoryStream  [[امتحان کنید]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //پشتیبانی از FileStream، MemoryStream و غیره
{
    stream.SaveAs(values);
}
```

مثال: api برای خروجی گرفتن اکسل

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


#### 7. ایجاد چند شیت

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


#### 8. گزینه‌های TableStyles

استایل پیش‌فرض

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

بدون پیکربندی استایل

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. AutoFilter

از نسخه v0.19.0  `OpenXmlConfiguration.AutoFilter` می‌تواند AutoFilter را فعال/غیرفعال کند، مقدار پیش‌فرض `true` است و روش تنظیم AutoFilter به صورت زیر است:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. ایجاد تصویر

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



#### ۱۱. خروجی گرفتن فایل آرایه بایت

از نسخه 1.22.0، زمانی که نوع مقدار `byte[]` باشد، سیستم به طور پیش‌فرض مسیر فایل را در سلول ذخیره می‌کند و هنگام وارد کردن، سیستم می‌تواند آن را به `byte[]` تبدیل کند. و اگر نمی‌خواهید از این ویژگی استفاده کنید، می‌توانید مقدار `OpenXmlConfiguration.EnableConvertByteArray` را روی `false` قرار دهید، که باعث افزایش کارایی سیستم می‌شود.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

از نسخه 1.22.0، زمانی که نوع مقدار `byte[]` باشد، سیستم به طور پیش‌فرض مسیر فایل را در سلول ذخیره می‌کند و هنگام وارد کردن، سیستم می‌تواند آن را به `byte[]` تبدیل کند. و اگر نمی‌خواهید از این ویژگی استفاده کنید، می‌توانید مقدار `OpenXmlConfiguration.EnableConvertByteArray` را روی `false` قرار دهید، که باعث افزایش کارایی سیستم می‌شود.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### ۱۲. ادغام سلول‌های مشابه به صورت عمودی

این قابلیت فقط در فرمت `xlsx` پشتیبانی می‌شود و سلول‌ها را به صورت عمودی بین تگ‌های @merge و @endmerge ادغام می‌کند.
شما می‌توانید با استفاده از @mergelimit، محدوده ادغام سلول‌ها به صورت عمودی را محدود کنید.

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

محتوای فایل قبل و بعد از ادغام:

بدون محدودیت ادغام:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

با محدودیت ادغام:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### ۱۳. صرف‌نظر از مقادیر null

گزینه جدید و صریح برای نوشتن سلول‌های خالی برای مقادیر null:

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
     EnableWriteNullValueCell = true // مقدار پیش‌فرض.
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

رفتار قبلی:
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // مقدار پیش‌فرض true است.
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

برای مقادیر null و DBNull کار می‌کند.

#### 14. قفل کردن سطرها و ستون‌ها (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // مقدار پیش‌فرض 1 است
    FreezeColumnCount = 2   // مقدار پیش‌فرض 0 است
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### وارد کردن داده به قالب اکسل <a name="getstart3"></a>

- اعلان متغیر مشابه قالب Vue به صورت `{{variable name}}` یا رندر مجموعه به صورت `{{collection name.field name}}` است.
- رندر مجموعه از IEnumerable/DataTable/DapperRow پشتیبانی می‌کند.

#### 1. پر کردن پایه‌ای (Basic Fill)

قالب:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

نتیجه:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

کد:
```csharp
// 1. با استفاده از POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. با استفاده از Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. پر کردن داده‌های IEnumerable

> نکته1: برای پر کردن لیست، از اولین IEnumerable با ستون‌های یکسان به عنوان مبنا استفاده کنید.

قالب:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

نتیجه:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

کد:
```csharp
//1. با استفاده از POCO
var value = new
{
    employees = new[] {
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

//2. با استفاده از Dictionary
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



#### 3. پر کردن داده‌های پیچیده

> توجه: پشتیبانی از چند شیت و استفاده از متغیر یکسان

قالب:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

نتیجه:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. با استفاده از POCO
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

// 2. با استفاده از Dictionary
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

#### 4. عملکرد پر کردن داده‌های بزرگ

> توجه: استفاده از IEnumerable با اجرا به تعویق‌افتاده و نه ToList می‌تواند حداکثر صرفه‌جویی در حافظه را در MiniExcel فراهم کند

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. نگاشت خودکار نوع مقدار سلول

قالب

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

نتیجه

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

کلاس

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

کد

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



#### ۶. مثال: فهرست پروژه‌های گیت‌هاب

قالب

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


نتیجه

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

کد

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

#### ۷. پر کردن داده‌های گروه‌بندی شده

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
##### ۱. با تگ `@group` و با تگ `@header`

قبل

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

بعد

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### ۲. با تگ @group و بدون تگ @header

قبل

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

بعد

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### ۳. بدون تگ @group

قبل

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

بعد

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. دستورات If/ElseIf/Else داخل سلول

قوانین:
1. از انواع DateTime، Double، Int با عملگرهای ==، !=، >، >=، <، <= پشتیبانی می‌کند.
2. از نوع String با عملگرهای ==، != پشتیبانی می‌کند.
3. هر دستور باید در یک خط جدید باشد.
4. قبل و بعد از عملگرها باید یک فاصله اضافه شود.
5. نباید خط جدیدی در داخل دستورات باشد.
6. فرمت سلول باید دقیقاً به صورت زیر باشد.

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

#### 9. DataTable به عنوان پارامتر

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
#### 10. فرمول‌ها

##### 1. مثال
فرمول خود را با `$` شروع کنید و از `$enumrowstart` و `$enumrowend` برای علامت‌گذاری ردیف شروع و پایان داده‌های قابل شمارش استفاده کنید:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

زمانی که قالب رندر می‌شود، پیشوند `$` حذف شده و `$enumrowstart` و `$enumrowend` با شماره ردیف شروع و پایان داده‌های قابل شمارش جایگزین می‌شوند:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. سایر مثال‌های فرمول:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| جمع          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| میانگین جایگزین | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| بازه         | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. سایر

##### 1. بررسی کلید پارامتر قالب

از نسخه V1.24.0 ، به طور پیش‌فرض، نبود کلید پارامتر قالب نادیده گرفته می‌شود و با رشته خالی جایگزین می‌شود، گزینه `IgnoreTemplateParameterMissing` می‌تواند کنترل کند که استثنا پرتاب شود یا نه.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### ویژگی نام/اندیس/نادیده‌گیری ستون اکسل <a name="getstart4"></a>



#### 1. تعیین نام ستون، اندیس ستون، نادیده‌گیری ستون

مثال اکسل

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

کد

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
[ExcelColumnIndex("I")] // سیستم "I" را به اندیس 8 تبدیل می‌کند
public string Test4 { get; set; }
public string Test5 { get; } //بدون set نادیده گرفته می‌شود
public string Test6 { get; private set; } //set غیر عمومی نادیده گرفته می‌شود
[ExcelColumnIndex(3)] // از 0 شروع می‌شود
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





#### ۲. فرمت سفارشی (ExcelFormatAttribute)

از نسخه V0.21.0، پشتیبانی از کلاس‌هایی که متد `ToString(string content)` را دارند، اضافه شده است.

کلاس

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

کد

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

نتیجه

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Query از تبدیل فرمت سفارشی پشتیبانی می‌کند

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### ۳. تنظیم عرض ستون (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### ۴. نگاشت چندین نام ستون به یک ویژگی

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### ۵. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

از نسخه 1.24.0، سیستم از نگاشت System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute پشتیبانی می‌کند.

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


#### 6. ویژگی ExcelColumnAttribute

از نسخه V1.26.0، می‌توان چندین ویژگی را به شکل ساده‌شده استفاده کرد:
```csharp
        public class TestIssueI4ZYUUDto
        {
            [ExcelColumn(Name = "ID",Index =0)]
            public string MyProperty { get; set; }
            [ExcelColumn(Name = "CreateDate", Index = 1,Format ="yyyy-MM",Width =100)]
            public DateTime MyProperty2 { get; set; }
        }
```



#### 7. ویژگی DynamicColumnAttribute

از نسخه V1.26.0، می‌توان ویژگی‌های ستون را به صورت داینامیک تنظیم کرد.
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

#### 8. ویژگی DynamicSheetAttribute

از نسخه V1.31.4 می‌توان ویژگی‌های شیت را به صورت داینامیک تنظیم کرد. می‌توان نام و وضعیت (قابل مشاهده بودن) شیت را تنظیم کرد.
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

همچنین می‌توان از ویژگی جدید ExcelSheetAttribute استفاده کرد:

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

### افزودن، حذف، به‌روزرسانی

#### افزودن

از نسخه v1.28.0، درج N ردیف داده پس از آخرین ردیف در فایل CSV پشتیبانی می‌شود.

```csharp
// داده اولیه
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// درج ۱ ردیف پس از آخرین ردیف
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// درج N ردیف پس از آخرین ردیف
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
```
```csharp
};
MiniExcel.Insert(path, value);
}
```

![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

نسخه v1.37.0 پشتیبانی از درج یک شیت جدید در یک ورک‌بوک اکسل موجود

```csharp
// اکسل اولیه
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// درج یک شیت جدید
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### حذف (در انتظار)

#### به‌روزرسانی (در انتظار)



### بررسی خودکار نوع اکسل <a name="getstart5"></a>

- MiniExcel به طور پیش‌فرض بر اساس `پسوند فایل` بررسی می‌کند که xlsx باشد یا csv، اما ممکن است نادقیق باشد، لطفاً به صورت دستی مشخص کنید.
- از روی Stream نوع اکسل قابل تشخیص نیست، لطفاً به صورت دستی مشخص کنید.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//or
stream.SaveAs(excelType:ExcelType.XLSX);
//or
stream.Query(excelType:ExcelType.CSV);
//or
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### نکته

- به طور پیش‌فرض نوع بازگشتی `string` است و مقدار به عدد یا تاریخ تبدیل نخواهد شد، مگر اینکه نوع با استفاده از جنریک قوی تعریف شده باشد.



#### جداکننده سفارشی

جداکننده پیش‌فرض `,` است، می‌توانید ویژگی `Seperator` را برای سفارشی‌سازی تغییر دهید

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

از نسخه V1.30.1 تابعی برای جداکننده سفارشی پشتیبانی می‌شود (با تشکر از @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### سطرشکن سفارشی

پیش‌فرض `\r\n` به عنوان کاراکتر انتهای خط است، می‌توانید ویژگی `NewLine` را برای سفارشی‌سازی تغییر دهید

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### کدگذاری سفارشی
- کدگذاری پیش‌فرض "تشخیص کدگذاری از نشانه‌های ترتیب بایت" است (detectEncodingFromByteOrderMarks: true)
- اگر نیاز به کدگذاری سفارشی دارید، لطفاً ویژگی StreamReaderFunc / StreamWriterFunc را تغییر دهید

```csharp
// خواندن
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// نوشتن
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### خواندن رشته خالی به عنوان null

به طور پیش‌فرض، مقادیر خالی به string.Empty نگاشت می‌شوند. شما می‌توانید این رفتار را تغییر دهید

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
از نسخه 1.23.0، می‌توانید GetDataReader را استفاده کنید

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

- نسخه v0.17.0 از Async پشتیبانی می‌کند (تشکر از isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

- نسخه v1.25.0 از `cancellationToken` پشتیبانی می‌کند.



### سایر موارد

#### 1. Enum

حتماً نام خصوصیت و نام ستون اکسل یکسان باشد، سیستم به صورت خودکار نگاشت انجام می‌دهد (به حروف حساس نیست)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

از نسخه V0.18.0 پشتیبانی از Description برای Enum اضافه شده است

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("کاربر عادی")]
    V1,
    [Description("مدیر عادی")]
    V2,
    [Description("مدیر ارشد")]
    V3
}
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

از نسخه 1.30.0 پشتیبانی از توضیحات اکسل به Enum اضافه شده است، با تشکر از @KaneLeung

#### 2. تبدیل CSV به XLSX یا تبدیل XLSX به CSV

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

#### 3. فرهنگ سفارشی (Custom CultureInfo)

از نسخه 1.22.0، می‌توانید CultureInfo را به شکل زیر سفارشی کنید. مقدار پیش‌فرض سیستم `CultureInfo.InvariantCulture` است.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// یا
MiniExcel.Query(path, configuration: config);
```


#### 4. اندازه بافر سفارشی (Custom Buffer Size)
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

سیستم کنترل حافظه را انجام نمی‌دهد، اما می‌توانید سرعت ذخیره‌سازی را افزایش دهید.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. افزودن دسته‌ای تصویر (MiniExcel.AddPicture)

لطفاً تصاویر را قبل از تولید دسته‌ای داده‌های ردیف اضافه کنید، در غیر این صورت سیستم هنگام فراخوانی AddPicture حافظه زیادی مصرف خواهد کرد.

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // مقدار پیش‌فرض null یعنی اولین شیت
        CellAddress = "C3", // اجباری
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // مقدار پیش‌فرض PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // اجباری
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. دریافت ابعاد شیت‌ها

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### مثال‌ها:

#### 1. SQLite و Dapper `درج فایل‌های حجیم` در SQL به منظور جلوگیری از OOM

نکته: لطفاً پس از Query متدهای ToList/ToArray را صدا نزنید، چون تمام داده‌ها را وارد حافظه می‌کند.

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

عملکرد:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### ۲. نمونه API دانلود/آپلود اکسل Xlsx در ASP.NET Core 3.1 یا MVC 5 [امتحان کنید](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)

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
<p>آپلود اکسل</p>
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
            // منطق خود را اینجا پیاده‌سازی کنید و غیره.
        }

        return Ok("فایل با موفقیت آپلود شد");
    }
}
```

####  3. کوئری صفحه‌بندی شده

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== صفحه شماره 1 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== صفحه شماره 50 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== صفحه شماره 5000 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. خروجی اکسل WebForm با استفاده از MemoryStream

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



#### 5. چندزبانه پویا (i18n) و مدیریت مجوز نقش

مانند مثال زیر، یک متد برای مدیریت i18n و مدیریت دسترسی ایجاد کنید و از `yield return` برای برگرداندن `IEnumerable<Dictionary<string, object>>` استفاده کنید تا پردازش پویا و با مصرف حافظه پایین حاصل شود.

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us و نقش Sales");
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



### سوالات متداول

#### سوال: عنوان سرستون اکسل با نام ویژگی کلاس برابر نیست، چگونه نگاشت انجام دهم؟

پاسخ: لطفاً از ویژگی ExcelColumnName استفاده کنید.

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### سوال: چگونه چند شیت را کوئری یا خروجی بگیرم؟

پاسخ: از متد `GetSheetNames` به همراه پارامتر sheetName در Query استفاده کنید.



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

#### سوال: چگونه اطلاعات مربوط به قابل مشاهده بودن شیت را کوئری یا خروجی بگیرم؟

پاسخ: از متد `GetSheetInformations` استفاده کنید.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // شماره اندیس شیت - از 0 شماره‌گذاری می‌شود
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // نام شیت
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // وضعیت قابل نمایش بودن شیت - visible / hidden
}
```
```

#### سوال: آیا استفاده از Count تمام داده‌ها را در حافظه بارگذاری می‌کند؟

خیر، تست تصویر شامل ۱ میلیون ردیف * ۱۰ ستون داده است، حداکثر استفاده از حافظه کمتر از ۶۰ مگابایت بوده و ۱۳.۶۵ ثانیه طول می‌کشد.

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### سوال: Query چگونه از اندیس عددی استفاده می‌کند؟

اندیس پیش‌فرض Query کلید رشته‌ای است: A,B,C.... اگر می‌خواهید به اندیس عددی تغییر دهید، لطفاً متد زیر را برای تبدیل ایجاد کنید.

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

#### سوال: زمانی که مقدار خالی باشد، اکسل بدون عنوان خالی تولید می‌شود

زیرا MiniExcel از منطقی مشابه JSON.NET برای گرفتن نوع به صورت داینامیک از مقادیر جهت ساده‌سازی عملیات API استفاده می‌کند، بدون داده نمی‌توان نوع را تشخیص داد. برای اطلاعات بیشتر می‌توانید [issue #133](https://github.com/mini-software/MiniExcel/issues/133) را مشاهده کنید.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> نوع قوی و DataTable هدر تولید می‌کنند، اما Dictionary همچنان اکسل خالی خواهد بود

#### سوال: چگونه foreach را هنگام رسیدن به سطر خالی متوقف کنیم؟

می‌توانید از MiniExcel به همراه `LINQ TakeWhile` برای متوقف کردن تکرارگر foreach استفاده کنید.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### سوال: چگونه ردیف‌های خالی را حذف کنیم؟

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



#### سوال. چگونه SaveAs(path,value) را طوری استفاده کنیم که فایل موجود را جایگزین کند و بدون پرتاب خطای "The file ...xlsx already exists error" باشد


لطفاً برای پیاده‌سازی منطق سفارشی ایجاد فایل، از کلاس Stream استفاده کنید، به طور مثال:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



یا، از نسخه V1.25.0، پارامتر overwriteFile به متد SaveAs اضافه شده است تا امکان فعال/غیرفعال کردن بازنویسی فایل موجود را فراهم کند

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### محدودیت‌ها و نکات

- در حال حاضر از xls و فایل رمزگذاری شده پشتیبانی نمی‌شود
- xlsm فقط از Query پشتیبانی می‌کند



### منابع

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### تشکر

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

تشکر بابت ارائه رایگان All product IDE برای این پروژه ([مجوز](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### اشتراک‌گذاری کمک‌های مالی
لینک https://github.com/orgs/mini-software/discussions/754

### مشارکت‌کنندگان

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---