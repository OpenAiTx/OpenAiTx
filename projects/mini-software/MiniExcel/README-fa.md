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
<p>این پروژه بخشی از <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> است و تحت <a href="https://www.dotnetfoundation.org/code-of-conduct">قوانین رفتار حرفه‌ای</a> آن فعالیت می‌کند. </p>
</div>

---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=zh-TW">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div align="center">
ستاره دادن به <a href="https://github.com/mini-software/MiniExcel">MiniExcel</a> یا <a href="https://miniexcel.github.io">حمایت مالی</a> شما می‌تواند MiniExcel را بهتر کند
</div>

---

### معرفی

MiniExcel یک ابزار ساده و کارآمد برای پردازش اکسل در .NET است که به طور خاص برای کاهش مصرف حافظه طراحی شده است.

در حال حاضر، بیشتر فریم‌ورک‌های محبوب نیاز دارند تمام داده‌های یک سند اکسل را برای انجام عملیات‌ها به طور کامل در حافظه بارگذاری کنند، اما این کار می‌تواند مشکلاتی در مصرف حافظه ایجاد کند. رویکرد MiniExcel متفاوت است: داده‌ها به صورت ردیف به ردیف و به شکل جریانی پردازش می‌شوند، که مصرف اولیه را از صدها مگابایت بالقوه به تنها چند مگابایت کاهش می‌دهد و به طور مؤثری از بروز مشکلات Out-of-memory (OOM) جلوگیری می‌کند.

```mermaid
flowchart LR
    A1(["Excel analysis<br>process"]) --> A2{{"Unzipping<br>XLSX file"}} --> A3{{"Parsing<br>OpenXML"}} --> A4{{"Model<br>conversion"}} --> A5(["Output"])

    B1(["Other Excel<br>Frameworks"]) --> B2{{"Memory"}} --> B3{{"Memory"}} --> B4{{"Workbooks &<br>Worksheets"}} --> B5(["All rows at<br>the same time"])

    C1(["MiniExcel"]) --> C2{{"Stream"}} --> C3{{"Stream"}} --> C4{{"POCO or dynamic"}} --> C5(["Deferred execution<br>row by row"])

    classDef analysis fill:#D0E8FF,stroke:#1E88E5,color:#0D47A1,font-weight:bold;
    classDef others fill:#FCE4EC,stroke:#EC407A,color:#880E4F,font-weight:bold;
    classDef miniexcel fill:#E8F5E9,stroke:#388E3C,color:#1B5E20,font-weight:bold;

    class A1,A2,A3,A4,A5 analysis;
    class B1,B2,B3,B4,B5 others;
    class C1,C2,C3,C4,C5 miniexcel;
```

### ویژگی‌ها

- کمینه‌سازی مصرف حافظه، جلوگیری از خطاهای کمبود حافظه (OOM) و اجتناب از جمع‌آوری کامل زباله‌ها
- امکان انجام عملیات داده‌ای در سطح ردیف به صورت بلادرنگ برای عملکرد بهتر روی داده‌های بزرگ
- پشتیبانی از LINQ با اجرای به تعویق افتاده، امکان صفحه‌بندی سریع و کارآمد از نظر حافظه و پرس‌وجوهای پیچیده
- سبک و کم‌حجم، بدون نیاز به Microsoft Office یا اجزای COM+، و اندازه DLL کمتر از ۵۰۰ کیلوبایت
- رابط برنامه‌نویسی ساده و شهودی برای خواندن/نوشتن/پر کردن اکسل

### نسخه ۲.۰ پیش‌نمایش

ما در حال کار روی نسخه آینده MiniExcel با یک API ماژولار و متمرکز جدید،
بسته‌های جداگانه nuget برای قابلیت‌های Core و Csv، پشتیبانی کامل از پرس‌وجوهای جریانی ناهمگام از طریق `IAsyncEnumerable`
و امکانات بیشتر در آینده هستیم! این بسته‌ها به صورت پیش‌انتشار در دسترس خواهند بود، پس خوشحال می‌شویم که آن‌ها را بررسی کرده و بازخورد خود را ارائه دهید!

اگر این کار را کردید، حتما [مستندات جدید](https://raw.githubusercontent.com/mini-software/MiniExcel/master/README-V2.md) و [یادداشت‌های ارتقاء](https://raw.githubusercontent.com/mini-software/MiniExcel/master/V2-Upgrade-Notes.md) را نیز مشاهده کنید.


### شروع کنید

- [وارد کردن/پرس‌وجوی اکسل](#getstart1)

- [خروجی گرفتن/ایجاد اکسل](#getstart2)

- [قالب اکسل](#getstart3)

- [ویژگی نام/ایندکس/نادیده گرفتن ستون اکسل](#getstart4)

- [نمونه‌ها](#getstart5)


### نصب

شما می‌توانید بسته را [از NuGet](https://www.nuget.org/packages/MiniExcel) نصب کنید

### یادداشت‌های انتشار

لطفاً [یادداشت‌های انتشار](docs) را بررسی کنید

### TODO

لطفاً [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true) را بررسی کنید

### عملکرد

کد مربوط به بنچمارک‌ها را می‌توانید در [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs) پیدا کنید.

فایلی که برای تست عملکرد استفاده شده است [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx) است؛ یک سند ۳۲ مگابایتی شامل ۱,۰۰۰,۰۰۰ ردیف * ۱۰ ستون که سلول‌های آن با رشته "HelloWorld" پر شده‌اند.

برای اجرای تمام بنچمارک‌ها از دستور زیر استفاده کنید:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```
شما می‌توانید نتایج بنچمارک نسخه جدید را [اینجا](benchmarks/results) پیدا کنید.


### پرس‌وجو/وارد کردن اکسل  <a name="getstart1"></a>

#### 1. یک پرس‌وجو اجرا کنید و نتایج را به یک IEnumerable با نوع قوی نگاشت کنید [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

توصیه می‌شود به دلیل کارایی بهتر از Stream.Query استفاده کنید.


```csharp
public class UserAccount
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public DateTime BoD { get; set; }
    public int Age { get; set; }
    public bool VIP { get; set; }
    public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// or

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```
![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. اجرای یک کوئری و نگاشت آن به لیستی از اشیاء داینامیک بدون استفاده از head [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

* کلید داینامیک `A.B.C.D..` است

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |


```csharp

var rows = MiniExcel.Query(path).ToList();

// or
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```
#### 3. اجرای یک پرس و جو با ردیف اول به عنوان هدر [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)

توجه : در صورت وجود نام ستون تکراری، آخرین ستون از سمت راست استفاده می‌شود

ورودی اکسل :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |



```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// or

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```
#### 4. پشتیبانی از کوئری افزونه LINQ مانند First/Take/Skip و غیره

کوئری First

```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// or

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```
عملکرد بین MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### ۵. جستجو بر اساس نام شیت


```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//or
stream.Query(sheetName: "SheetName");
```
#### 6. پرس و جوی تمام نام شیت‌ها و ردیف‌ها


```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```
#### ۷. دریافت ستون‌ها


```csharp
var columns = MiniExcel.GetColumns(path); // e.g result : ["A","B"...]

var cnt = columns.Count;  // get column count
```
#### 8. کوئری داینامیک ردیف را به `IDictionary<string,object>` تبدیل می‌کند


```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// or
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// or Query specified ranges (capitalized)
// A2 represents the second row of column A, C3 represents the third row of column C
// If you don't want to restrict rows, just don't include numbers
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```




#### 9. کوئری اکسل و بازگشت DataTable

توصیه نمی‌شود، زیرا DataTable تمام داده‌ها را به حافظه بارگذاری می‌کند و ویژگی مصرف پایین حافظه MiniExcel را از بین می‌برد.


```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```
![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. مشخص کردن سلولی که خواندن داده از آن آغاز می‌شود


```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```
![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. پر کردن سلول‌های ادغام‌شده

توجه: کارایی نسبت به «استفاده نکردن از پر کردن ادغامی» کندتر است

دلیل: استاندارد OpenXml بخش mergeCells را در انتهای فایل قرار می‌دهد که باعث نیاز به دو بار پیمایش sheetxml می‌شود


```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

پشتیبانی از پر کردن چند سطری و ستونی با طول و عرض متغیر

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### ۱۲. خواندن فایل‌های بزرگ با کش مبتنی بر دیسک (Disk-Base Cache - SharedString)

اگر اندازه SharedStrings از ۵ مگابایت بیشتر شود، MiniExcel به صورت پیش‌فرض از کش دیسک محلی استفاده می‌کند، برای مثال، [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (یک میلیون ردیف داده)، زمانی که کش دیسک غیرفعال باشد، حداکثر مصرف حافظه ۱۹۵ مگابایت است، اما با فعال بودن کش دیسک فقط به ۶۵ مگابایت نیاز دارد. توجه داشته باشید که این بهینه‌سازی هزینه‌هایی در کارایی دارد، بنابراین در این حالت زمان خواندن از ۷.۴ ثانیه به ۲۷.۲ ثانیه افزایش می‌یابد. اگر به این ویژگی نیاز ندارید، می‌توانید کش دیسک را با کد زیر غیرفعال کنید:


```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```
شما می‌توانید از `SharedStringCacheSize` برای تغییر اندازه فایل sharedString فراتر از اندازه مشخص شده برای کش کردن روی دیسک استفاده کنید.

```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)









### ساخت/خروجی گرفتن از اکسل  <a name="getstart2"></a>

1. باید یک نوع غیرانتزاعی با سازنده عمومی بدون پارامتر باشد.

2. MiniExcel از اجرای تاخیری IEnumerable پشتیبانی می‌کند، اگر می‌خواهید کمترین میزان حافظه را مصرف کنید، لطفاً از متدهایی مانند ToList استفاده نکنید.

مثال: استفاده یا عدم استفاده از ToList و مصرف حافظه
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### ۱. ناشناس یا نوع قوی [[امتحان کنید]](https://dotnetfiddle.net/w5WD1J)



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
ایجاد نتیجه فایل :

| ستون1     | ستون2   |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `توصیه می‌شود`، می‌تواند از بارگذاری همه داده‌ها در حافظه جلوگیری کند

```csharp
MiniExcel.SaveAs(path, reader);
```
![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

خروجی گرفتن چندین شیت توسط DataReader (توصیه شده توسط Dapper ExecuteReader)


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

- `توصیه نمی‌شود`، زیرا تمام داده‌ها را به حافظه بارگذاری می‌کند

- دیتاتیبل ابتدا از Caption برای نام ستون استفاده می‌کند، سپس از columname


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
####  5. پرس‌وجوی Dapper

با تشکر از @shaofing #552 ، لطفاً از `CommandDefinition + CommandFlags.NoCache` استفاده کنید.


```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Note: QueryAsync will throw close connection exception
    MiniExcel.SaveAs(path, rows);
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
#### 6. ذخیره به MemoryStream  [[امتحان کنید]](https://dotnetfiddle.net/JOen0e)



```csharp
using (var stream = new MemoryStream()) //support FileStream,MemoryStream ect.
{
    stream.SaveAs(values);
}
```
به عنوان مثال: API برای خروجی گرفتن اکسل


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
#### 7. ایجاد چندین شیت



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


#### ۸. گزینه‌های TableStyles

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


#### 9. فیلتر خودکار (AutoFilter)

از نسخه v0.19.0، با استفاده از `OpenXmlConfiguration.AutoFilter` می‌توان فیلتر خودکار را فعال یا غیرفعال کرد، مقدار پیش‌فرض `true` است، و روش تنظیم AutoFilter به شرح زیر است:


```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```




#### 10. ایجاد تصویر


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



#### 11. خروجی فایل آرایه بایت

از نسخه 1.22.0، زمانی که نوع مقدار `byte[]` باشد، سیستم به طور پیش‌فرض مسیر فایل را در سلول ذخیره می‌کند و هنگام وارد کردن می‌تواند به `byte[]` تبدیل شود. و اگر نمی‌خواهید از این قابلیت استفاده کنید، می‌توانید مقدار `OpenXmlConfiguration.EnableConvertByteArray` را به `false` تنظیم کنید که باعث افزایش کارایی سیستم می‌شود.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

از نسخه 1.22.0، زمانی که نوع مقدار `byte[]` باشد، سیستم به طور پیش‌فرض مسیر فایل را در سلول ذخیره می‌کند و هنگام وارد کردن می‌تواند به `byte[]` تبدیل شود. و اگر نمی‌خواهید از این قابلیت استفاده کنید، می‌توانید مقدار `OpenXmlConfiguration.EnableConvertByteArray` را به `false` تنظیم کنید که باعث افزایش کارایی سیستم می‌شود.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. ادغام سلول‌های مشابه به صورت عمودی

این قابلیت فقط در فرمت `xlsx` پشتیبانی می‌شود و سلول‌ها را به صورت عمودی بین تگ‌های @merge و @endmerge ادغام می‌کند.
شما می‌توانید از @mergelimit برای محدود کردن محدوده ادغام سلول‌ها به صورت عمودی استفاده کنید.


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

#### ۱۳. رد کردن مقادیر تهی

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
     EnableWriteNullValueCell = true // Default value.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```
![تصویر](https://user-images.githubusercontent.com/31481586/241419455-3c0aec8a-4e5f-4d83-b7ec-6572124c165d.png)


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
     EnableWriteNullValueCell = false // Default value is true.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```
![تصویر](https://user-images.githubusercontent.com/31481586/241419441-c4f27e8f-3f87-46db-a10f-08665864c874.png)


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

#### 14. ثابت کردن پنجره‌ها (Freeze Panes)

```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // default is 1
    FreezeColumnCount = 2   // default is 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```
![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### پر کردن داده در قالب اکسل <a name="getstart3"></a>

- اعلان متغیر مشابه قالب Vue با `{{نام متغیر}}` است، یا رندر مجموعه با `{{نام مجموعه.نام فیلد}}`
- رندر مجموعه از انواع IEnumerable/DataTable/DapperRow پشتیبانی می‌کند

#### 1. پر کردن پایه

قالب:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

نتیجه:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

کد:


```csharp
// 1. By POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. By Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```
#### 2. پر کردن داده با IEnumerable

> نکته1: از اولین IEnumerable از همان ستون به عنوان مبنای پر کردن لیست استفاده کنید

قالب:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

نتیجه:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

کد:



```csharp
//1. By POCO
var value = new
{
    employees = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. By Dictionary
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
#### 3. پرکردن داده‌های پیچیده

> توجه: پشتیبانی از چندین شیت و استفاده از متغیر یکسان

قالب:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

نتیجه:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)




```csharp
// 1. By POCO
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

// 2. By Dictionary
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
#### ۴. عملکرد پر کردن داده‌های بزرگ

> توجه: استفاده از اجرای تعلیقی IEnumerable به جای ToList می‌تواند حداکثر صرفه‌جویی در حافظه را در MiniExcel داشته باشد

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### ۵. نگاشت خودکار نوع مقدار سلول

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
#### 6. مثال :  فهرست پروژه‌های گیت‌هاب

قالب

![تصویر](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


نتیجه

![تصویر](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

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
#### 7. پر کردن داده‌های گروه‌بندی‌شده


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
##### 1. با تگ `@group` و با تگ `@header`

قبل

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

بعد

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. با تگ @group و بدون تگ @header

قبل

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

بعد

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. بدون تگ @group

قبل

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

بعد

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. عبارات If/ElseIf/Else داخل سلول

قوانین:
1. از DateTime، Double، Int با عملگرهای ==، !=، >، >=، <، <= پشتیبانی می‌شود.
2. از String با عملگرهای ==، != پشتیبانی می‌شود.
3. هر عبارت باید در یک خط جدید باشد.
4. قبل و بعد از عملگرها باید یک فاصله باشد.
5. نباید خط جدید درون عبارات باشد.
6. سلول باید دقیقاً طبق فرمت زیر باشد.

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

#### ۹. DataTable به عنوان پارامتر


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
#### ۱۰. فرمول‌ها

##### ۱. مثال
فرمول خود را با `$` شروع کنید و از `$enumrowstart` و `$enumrowend` برای علامت‌گذاری ردیف‌های شروع و پایان قابل شمارش استفاده کنید:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

زمانی که قالب رندر می‌شود، پیشوند `$` حذف شده و `$enumrowstart` و `$enumrowend` با شماره ردیف‌های شروع و پایان قابل شمارش جایگزین می‌شوند:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### ۲. سایر مثال‌های فرمول:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| جمع          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| میانگین جایگزین | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| بازه         | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### ۱۱. سایر

##### ۱. بررسی کلید پارامتر قالب

از نسخه V1.24.0 به بعد، به طور پیش‌فرض کلید پارامتر گم‌شده قالب نادیده گرفته شده و با رشته خالی جایگزین می‌شود، `IgnoreTemplateParameterMissing` می‌تواند کنترل کند که استثنا پرتاب شود یا نه.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```
![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### ویژگی نام ستون اکسل/ایندکس/نادیده‌گرفتن ستون <a name="getstart4"></a>



#### ۱. تعیین نام ستون، شماره ستون، یا نادیده‌گرفتن ستون

نمونه اکسل

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

کد


```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
    public string Test1 { get; set; }
    [ExcelColumnName("Column2")]
    public string Test2 { get; set; }
    [ExcelIgnore]
    public string Test3 { get; set; }
    [ExcelColumnIndex("I")] // system will convert "I" to 8 index
    public string Test4 { get; set; }
    public string Test5 { get; } //wihout set will ignore
    public string Test6 { get; private set; } //un-public set will ignore
    [ExcelColumnIndex(3)] // start with 0
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






#### 2. قالب سفارشی (ExcelFormatAttribute)

از نسخه V0.21.0 پشتیبانی از کلاسی که شامل متد `ToString(string content)` باشد، اضافه شده است

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

کوئری از تبدیل فرمت سفارشی پشتیبانی می‌کند

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### ۳. تعیین عرض ستون (ExcelColumnWidthAttribute)


```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```
#### 4. نگاشت چندین نام ستون به یک ویژگی.


```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```




#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

از نسخه 1.24.0، سیستم از System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute پشتیبانی می‌کند.


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
#### ۶. ویژگی ExcelColumnAttribute

از نسخه V1.26.0، چندین ویژگی را می‌توان به صورت زیر ساده‌سازی کرد:

از آن زمان به بعد، استفاده از چندین ویژگی به این صورت امکان‌پذیر است :


```csharp
        public class TestIssueI4ZYUUDto
        {
            [ExcelColumn(Name = "ID",Index =0)]
            public string MyProperty { get; set; }
            [ExcelColumn(Name = "CreateDate", Index = 1,Format ="yyyy-MM",Width =100)]
            public DateTime MyProperty2 { get; set; }
        }
```
#### ۷. ویژگی DynamicColumnAttribute

از نسخه V1.26.0، ما می‌توانیم ویژگی‌های ستون را به صورت پویا تنظیم کنیم



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

#### 8. ویژگی پویا برگه (DynamicSheetAttribute)

از نسخه V1.31.4 می‌توانیم ویژگی‌های برگه را به صورت پویا تنظیم کنیم. می‌توانیم نام برگه و وضعیت (قابلیت مشاهده) را تعیین کنیم.
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
ما همچنین می‌توانیم از ویژگی جدید ExcelSheetAttribute استفاده کنیم:


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

پشتیبانی v1.28.0 از درج داده‌های N ردیف CSV پس از آخرین ردیف


```csharp
// Origin
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Insert 1 rows after last
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Insert N rows after last
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
    };
    MiniExcel.Insert(path, value);
}
```
![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

نسخه 1.37.0 از اکسل پشتیبانی می‌کند که یک شیت جدید را به یک ورک‌بوک موجود اضافه کنید.


```csharp
// Origin excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Insert a new sheet
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```
#### حذف(در انتظار)

#### به‌روزرسانی(در انتظار)



### بررسی خودکار نوع اکسل <a name="getstart5"></a>

- MiniExcel به طور پیش‌فرض بر اساس `پسوند فایل` تشخیص می‌دهد که فایل xlsx است یا csv، اما ممکن است این کار دقیق نباشد، لطفاً نوع فایل را به صورت دستی مشخص کنید.
- از روی جریان داده (Stream) نمی‌توان نوع فایل اکسل را تشخیص داد، لطفاً نوع فایل را به صورت دستی مشخص کنید.




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

- به طور پیش‌فرض نوع بازگشتی `string` است و مقدار به اعداد یا تاریخ تبدیل نمی‌شود، مگر اینکه نوع با تایپ قوی جنریک تعریف شده باشد.



#### جداکننده سفارشی

به طور پیش‌فرض `,` به عنوان جداکننده استفاده می‌شود، می‌توانید خصوصیت `Seperator` را برای سفارشی‌سازی تغییر دهید


```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```
از نسخه V1.30.1 قابلیت پشتیبانی از جداکننده سفارشی اضافه شده است (با تشکر از @hyzx86)


```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```
#### شکست خط سفارشی

پیش‌فرض کاراکتر خط جدید `\r\n` است، شما می‌توانید ویژگی `NewLine` را برای سفارشی‌سازی تغییر دهید




```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```




#### کدنویسی سفارشی

- کدگذاری پیش‌فرض "شناسایی کدگذاری از نشانه‌های ترتیب بایت" است (detectEncodingFromByteOrderMarks: true)
- اگر نیاز به کدگذاری سفارشی دارید، لطفاً ویژگی StreamReaderFunc / StreamWriterFunc را تغییر دهید


```csharp
// Read
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Write
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
از نسخه 1.23.0، شما می‌توانید GetDataReader را دریافت کنید



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




###  غیرهمزمان (Async)

- نسخه v0.17.0 از غیرهمزمان (Async) پشتیبانی می‌کند (با تشکر از isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))


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
-  پشتیبانی v1.25.0 از `cancellationToken`.



### سایر موارد

#### 1. شمارش (Enum)

اطمینان حاصل کنید که نام اکسل و ویژگی یکسان باشد، سیستم به صورت خودکار نگاشت را انجام می‌دهد (بدون حساسیت به حروف بزرگ و کوچک)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

از نسخه V0.18.0 پشتیبانی از توضیحات Enum اضافه شده است


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
![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

از نسخه 1.30.0 پشتیبانی از تبدیل توضیحات اکسل به Enum اضافه شده است، با تشکر از @KaneLeung

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
#### 3. فرهنگ‌اطلاعات (CultureInfo) سفارشی

از نسخه 1.22.0، شما می‌توانید CultureInfo را به صورت زیر سفارشی‌سازی کنید، پیش‌فرض سیستم `CultureInfo.InvariantCulture` است.


```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// or
MiniExcel.Query(path, configuration: config);
```
#### 4. اندازه بافر سفارشی


```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```
#### 5. حالت سریع

سیستم حافظه را کنترل نخواهد کرد، اما می‌توانید سرعت ذخیره‌سازی بالاتری داشته باشید.


```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```
#### 6. افزودن دسته‌ای تصویر (MiniExcel.AddPicture)

لطفاً تصاویر را قبل از تولید دسته‌ای داده‌های ردیف اضافه کنید، در غیر این صورت سیستم هنگام فراخوانی AddPicture از حافظه زیادی استفاده خواهد کرد.


```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // default null is first sheet
        CellAddress = "C3", // required
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // default PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // required
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![تصویر](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### ۷. دریافت ابعاد شیت‌ها

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```
### مثال‌ها:

#### ۱. درج SQL فایل با حجم بزرگ در SQLite و Dapper برای جلوگیری از OOM

توجه: لطفاً پس از Query از متدهای ToList/ToArray استفاده نکنید، این کار باعث بارگذاری تمام داده‌ها در حافظه می‌شود.


```csharp
using (var connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    using (var transaction = connection.BeginTransaction())
    using (var stream = File.OpenRead(path))
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





#### 2. دموی API دانلود/آپلود اکسل Xlsx در ASP.NET Core 3.1 یا MVC 5 [امتحان کنید](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)


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
</body></html{{"
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
            // do your logic etc.
        }

        return Ok("File uploaded successfully");
    }
}
```
####  3. پرس‌وجوی صفحه‌بندی


```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== No.1 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== No.50 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== No.5000 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```
![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. خروجی اکسل WebForm با استفاده از memorystream


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




#### 5. مدیریت پویا i18n چندزبانه و سطح دسترسی نقش‌ها

مانند مثال، یک متد برای مدیریت i18n و سطح دسترسی ایجاد کنید و از `yield return برای بازگرداندن IEnumerable<Dictionary<string, object>>` استفاده کنید تا پردازش پویا و با مصرف حافظه کم حاصل شود.


```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us and Sales role");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
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



### پرسش‌های متداول (FAQ)

#### سوال: اگر عنوان هدر اکسل با نام خصوصیت کلاس برابر نباشد، چگونه نگاشت انجام دهیم؟

پاسخ: لطفاً از ویژگی ExcelColumnName استفاده کنید

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### سوال: چگونه چندین شیت را کوئری یا خروجی بگیریم؟

پاسخ: از متد `GetSheetNames` با پارامتر sheetName در Query استفاده کنید.




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

#### سوال: چگونه اطلاعات مربوط به وضعیت نمایش شیت‌ها را استعلام یا صادر کنیم؟

پاسخ: استفاده از متد `GetSheetInformations`.




```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // next sheet index - numbered from 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // sheet name
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // sheet visibility state - visible / hidden
}
```
#### س. آیا استفاده از Count تمام داده‌ها را به حافظه بارگذاری می‌کند؟

خیر، تست تصویر دارای ۱ میلیون ردیف * ۱۰ ستون داده است، بیشترین استفاده از حافظه کمتر از ۶۰ مگابایت بوده و زمان اجرا ۱۳.۶۵ ثانیه است

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### س. Query چگونه از ایندکس عددی استفاده می‌کند؟

ایندکس پیش‌فرض Query، کلید رشته‌ای است: A,B,C.... اگر می‌خواهید به ایندکس عددی تغییر دهید، لطفاً متد زیر را برای تبدیل ایجاد کنید



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
#### پرسش. چرا زمانی که مقدار خالی باشد، یک فایل اکسل بدون عنوان و خالی هنگام خروجی گرفتن تولید می‌شود؟

زیرا MiniExcel از منطقی مشابه JSON.NET برای به دست آوردن نوع به‌صورت پویا از مقادیر استفاده می‌کند تا عملیات API را ساده کند و بدون داده، نوع قابل تشخیص نیست. برای درک بیشتر می‌توانید به [issue #133](https://github.com/mini-software/MiniExcel/issues/133) مراجعه کنید.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> نوع قوی و DataTable هدرها را تولید می‌کنند، اما Dictionary همچنان اکسل خالی ایجاد می‌کند

#### پرسش. چگونه می‌توان حلقه foreach را هنگام رسیدن به ردیف خالی متوقف کرد؟

MiniExcel را می‌توان با `LINQ TakeWhile` برای متوقف‌کردن حلقه foreach استفاده کرد.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### پرسش. چگونه ردیف‌های خالی را حذف کنیم؟

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




جدول داده (DataTable) :


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




#### س. چگونه از SaveAs(path,value) برای جایگزینی فایل موجود استفاده کنیم بدون اینکه خطای "The file ...xlsx already exists" ایجاد شود


لطفاً از کلاس Stream برای پیاده‌سازی منطق سفارشی ایجاد فایل استفاده کنید، به عنوان مثال:


```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



یا، از نسخه V1.25.0، SaveAs پارامتر overwriteFile را برای فعال/غیرفعال کردن بازنویسی فایل موجود پشتیبانی می‌کند



```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```





### محدودیت‌ها و نکات قابل توجه

- در حال حاضر از فایل‌های xls و فایل‌های رمزگذاری‌شده پشتیبانی نمی‌شود
- xlsm فقط از Query پشتیبانی می‌کند



### منابع

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### تشکر

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

با تشکر از فراهم کردن یک IDE رایگان All product برای این پروژه ([License](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### اشتراک‌گذاری مشارکت و حمایت مالی
لینک https://github.com/orgs/mini-software/discussions/754

### مشارکت‌کنندگان

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---