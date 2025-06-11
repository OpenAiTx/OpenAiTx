[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

### الميزات
- صغير الحجم (حجم ملف DLL فقط 20 كيلوبايت) وسهل الاستخدام.
- يدعم .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- بدون أي مكتبات طرف ثالث
- يدعم الأنواع المجهولة، استعلام Dapper الديناميكي، List/Array/Set/Enumrable، DataTable، Dictionary

### التثبيت

يمكنك تثبيت الحزمة [من NuGet](https://www.nuget.org/packages/HtmlTableHelper) باستخدام مدير حزم Visual Studio أو واجهة NuGet:

```cmd
PM> install-package HtmlTableHelper
```

أو باستخدام سطر أوامر `dotnet`:

```cmd
dotnet add package HtmlTableHelper
```

### عرض توضيحي Fiddle:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### بدء الاستخدام

##### مثال على List/Array/Set/Enumrable من نوع غير Key/Value
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
النتيجة:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

##### مثال Dapper
```C#
using (var cn = "Your Connection")
{
	var sourceData = cn.Query(@"select 'ITWeiHan' Name,25 Age,'M' Gender");
	var tablehtml = sourceData.ToHtmlTable();
}
```

##### مثال Dictionary 
```C#
var sourceData = new[] {new Dictionary<string, object> (){{"Name" , "ITWeiHan" },{"Age",25},{"Gender","M"}}};
var tablehtml = sourceData.ToHtmlTable();
```

<!--
**لكن** أنواع Key/Value أخرى يرجى استخدام `ToHtmlTableByDictionary`
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**تخصيص خصائص الجدول/TR/TD/TH (نوع ديناميكي)**

```C#
var data = /*List/Array/Set/Enumrable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //هذا نوع ديناميكي، يدعم جميع الخصائص 
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
النتيجة:
<table class="SomeClass">
	<thead>
		<tr ID="SomeID">
			<th class="dark-theme">..</th>
		</tr>
	</thead>
	<tbody>
		<tr ID="SomeID">
			<td width="120 px">..</td>
		</tr>
	</tbody>
</table>
*/
```

##### توصيف الخصائص

###### 1. Display : 

```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "Column1")] //خاصية MyProperty1 ستظهر في thead-td بالنص الداخلي : "Column1"
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "Column2")] //خاصية MyProperty2 ستظهر في thead-td بالنص الداخلي : "Column2"
    public string MyProperty2 { get; set; }
}
```

###### 2. Skip : 
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //لن تظهر خاصية MyProperty1 في html
    public string MyProperty2 { get; set; }
}
```

##### HTMLTableBuilder

###### HtmlCaption
```C#
var soucreData = new []{ new {MyProperty1="test",MyProperty2=123} };
var html = soucreData.CreateBuilder()
    .SetCaption("This is Caption", new { id = "CaptionId" })
    .ToHtmlTable();
//النتيجة : <table><caption id=\"CaptionId\" >This is Caption</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

ترميز InnerHtml قابل للتعديل (لا ينصح بتعطيله إلا لسبب محدد، بسبب هجمات XSS)
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//الترميز الافتراضي
var encodinghtml = sourceData.ToHtmlTable();
//النتيجة: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//النتيجة: <table>..<b>ITWeiHan</b>..</table>
```

### التوسعة
**ASP.NET Core MVC:**  
أنشئ ملف IHtmlHelperExtension.cs
```C#
using System.Collections.Generic;
using HtmlTableHelper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;

public static class IHtmlHelperExtension
{
    public static HtmlString ToHtmlTable<T>(this IHtmlHelper htmlHelper, IEnumerable<T> enums
        , object tableAttributes = null, object trAttributes = null, object tdAttributes = null
        , HtmlTableSetting HTMLTableSetting = null)
    {
        var html = enums.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
        return new HtmlString(html);
    }

    public static HtmlString ToHtmlTable<T>(this IHtmlHelper htmlHelper, System.Data.DataTable datatable
        , object tableAttributes = null, object trAttributes = null, object tdAttributes = null
        , HtmlTableSetting HTMLTableSetting = null)
    {
        var html = datatable.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
        return new HtmlString(html);
    }
}
```

razor.cshtml 
```C#
@Html.ToHtmlTable(new[] { new { Name = "ITWeiHan", Age = "25", Gender = "M" } })
/*
النتيجة:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
أنشئ ملف HtmlHelperExtension.cs
```C#
using System.Collections.Generic;
using HtmlTableHelper;
using System.Web;
using System.Web.Mvc;

public static class HtmlHelperExtension
{
    public static HtmlString ToHtmlTable<T>(this HtmlHelper htmlHelper, IEnumerable<T> enums
        , object tableAttributes = null, object trAttributes = null, object tdAttributes = null
        , HtmlTableSetting HTMLTableSetting = null)
    {
        var html = enums.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
        return new HtmlString(html);
    }

    public static HtmlString ToHtmlTable<T>(this HtmlHelper htmlHelper, System.Data.DataTable datatable
        , object tableAttributes = null, object trAttributes = null, object tdAttributes = null
```csharp
, HtmlTableSetting HTMLTableSetting = null)
{
    var html = datatable.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
    return new HtmlString(html);
}
}
```

### العرض التجريبي
**عرض تجريبي لـ ASP.NET MVC 5 JQuery DataTable:**  
```csharp
using HtmlTableHelper;
//..
public class HomeController : Controller
{
    public ActionResult Index()
    {
        var datas = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
        ViewBag.Table = datas.ToHtmlTable();
        return View();
    }
}
```

```csharp
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>AspNetMvcDemo</title>
    <link href="//cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css" rel="stylesheet" />
</head>
<body>
    <div>
        @Html.Raw(ViewBag.Table)
    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
    <script>
        $(document).ready(function () {
            $('Table').DataTable();
        });
    </script>
</body>
</html>
```

**عرض تجريبي لـ ASP.NET Core:**
```csharp
public class Startup
{
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        app.Run(async (context) =>
        {
            var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
            var tablehtml = sourceData.ToHtmlTable();
            await context.Response.WriteAsync(tablehtml);
        });
    }
}
```

<!--
#### المهام القادمة:
- [ ] دعم .NET 4.0
- [ ] دعم نموذج EF
- [ ] دعم خاصية استخدام سمة HTML مخصصة

تحديد الأعمدة
```csharp
using HtmlTableHelper;
..
public class Person{
	public string Name { get; set; }
	public int Age { get; set; }
	public string Gender { get; set; }
}
..
var sourceData = new[] { new Person{ Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable(new[]{name});
/*
النتيجة:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->

<!--
اقرأ هذه الصفحة
[security - هل ترميز HTML يمنع جميع أنواع هجمات XSS؟ - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
جدول قابل للتعديل + Ajax
    - مشكلة Route
    - وظائف الإضافة والحذف والتعديل والقراءة
    - يحتاج إلى SID
- [ ] دعم التصفح (Paging)
    باستخدام linq skip و take
    ولكن سيواجه مشاكل مع datatable
    يبدو أنني بحاجة إلى تحويل datatable إلى enumrable
--->
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---