[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

---

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=HtmlTableHelper&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

---

### ویژگی‌ها
- بسیار کوچک (حجم DLL فقط ۲۰ کیلوبایت) و استفاده آسان.
- پشتیبانی از .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- بدون نیاز به هیچ کتابخانه شخص ثالث
- پشتیبانی از انواع ناشناس، Dapper Dynamic Query، لیست/آرایه/Set/Enumerable، DataTable، Dictionary

### نصب

شما می‌توانید این بسته را [از NuGet](https://www.nuget.org/packages/HtmlTableHelper) با استفاده از Visual Studio Package Manager یا رابط کاربری NuGet نصب کنید:

```cmd
PM> install-package HtmlTableHelper
```

یا با استفاده از خط فرمان `dotnet`:

```cmd
dotnet add package HtmlTableHelper
```

### دموی Fiddle:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### شروع کار

##### مثال لیست/آرایه/Set/Enumerable از نوع غیر کلید/مقدار
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
نتیجه:
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
**اما** برای دیگر انواع کلید/مقدار لطفاً از `ToHtmlTableByDictionary` استفاده کنید
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**سفارشی‌سازی ویژگی‌های جدول/TR/TD/TH (نوع داینامیک)**

```C#
var data = /*List/Array/Set/Enumrable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //این یک نوع داینامیک است و از همه ویژگی‌ها پشتیبانی می‌کند
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
نتیجه:
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

##### توضیحات ویژگی‌ها

###### 1. Display : 
```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "ستون1")] //ویژگی MyProperty1 متن داخلی thead-td را به صورت "ستون1" نمایش می‌دهد
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "ستون2")] //ویژگی MyProperty2 متن داخلی thead-td را به صورت "ستون2" نمایش می‌دهد
    public string MyProperty2 { get; set; }
}
```

###### ۲. Skip :
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //MyProperty1 در خروجی HTML نمایش داده نمی‌شود
    public string MyProperty2 { get; set; }
}
```

##### HTMLTableBuilder

###### HtmlCaption
```C#
var soucreData = new []{ new {MyProperty1="test",MyProperty2=123} };
var html = soucreData.CreateBuilder()
    .SetCaption("این یک کپشن است", new { id = "CaptionId" })
    .ToHtmlTable();
//نتیجه : <table><caption id=\"CaptionId\" >این یک کپشن است</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

پیکربندی کدگذاری InnerHtml (توصیه می‌شود بدون دلیل خاصی این کار انجام نشود، به دلیل حملات XSS)
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//کدگذاری پیش‌فرض
var encodinghtml = sourceData.ToHtmlTable();
//نتیجه: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//نتیجه: <table>..<b>ITWeiHan</b>..</table>
```

### Extension
**ASP.NET Core MVC:**  
یک فایل IHtmlHelperExtension.cs بسازید
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
نتیجه:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
یک فایل HtmlHelperExtension.cs بسازید
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
```
```csharp
var html = enums.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
return new HtmlString(html);
}

public static HtmlString ToHtmlTable<T>(this HtmlHelper htmlHelper, System.Data.DataTable datatable
    , object tableAttributes = null, object trAttributes = null, object tdAttributes = null
    , HtmlTableSetting HTMLTableSetting = null)
{
    var html = datatable.ToHtmlTable(tableAttributes, trAttributes, tdAttributes, HTMLTableSetting);
    return new HtmlString(html);
}
}
```

### دموی نمونه
**دموی ASP.NET MVC 5 JQuery DataTable:**  
```C#
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

```C#
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

**دموی ASP.NET Core:**
```C#
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
#### TODO:
- [ ] پشتیبانی از .NET 4.0
- [ ] پشتیبانی از مدل EF
- [ ] پشتیبانی از ویژگی‌های سفارشی HTML برای پراپرتی‌ها

تعیین ستون‌ها
```C#
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
نتیجه:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->

<!--
این صفحه را بخوانید
[امنیت - آیا رمزگذاری HTML از تمام انواع حملات XSS جلوگیری می‌کند؟ - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
editable + ajax جدول قابل ویرایش با ایجکس
    - مشکل Route
    - قابلیت‌های افزودن، حذف، ویرایش، جستجو
    - نیاز به SID
- [ ] پشتیبانی از صفحه‌بندی
    با استفاده از linq skip و take
    اما در دیتاتیبل مشکل ایجاد می‌شود
    به نظر می‌رسد باید دیتاتیبل را به enumrable تبدیل کنم
--->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-30

---