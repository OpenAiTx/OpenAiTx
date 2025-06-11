[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

### คุณสมบัติ
- ขนาดเล็ก (ขนาด DLL เพียง 20KB) และใช้งานง่าย
- รองรับ .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- ไม่ต้องใช้ไลบรารีของบุคคลที่สามใด ๆ
- รองรับ Anonymous Types, Dapper Dynamic Query, List/Array/Set/Enumerable, DataTable, Dictionary

### การติดตั้ง

คุณสามารถติดตั้งแพ็คเกจ [จาก NuGet](https://www.nuget.org/packages/HtmlTableHelper) โดยใช้ Visual Studio Package Manager หรือ NuGet UI:

```cmd
PM> install-package HtmlTableHelper
```

หรือใช้คำสั่ง `dotnet`:

```cmd
dotnet add package HtmlTableHelper
```

### Fiddle Demo:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### เริ่มต้นใช้งาน

##### ตัวอย่าง List/Array/Set/Enumerable ประเภทที่ไม่ใช่ Key/Value
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
ผลลัพธ์:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

##### ตัวอย่าง Dapper
```C#
using (var cn = "Your Connection")
{
	var sourceData = cn.Query(@"select 'ITWeiHan' Name,25 Age,'M' Gender");
	var tablehtml = sourceData.ToHtmlTable();
}
```

##### ตัวอย่าง Dictionary 
```C#
var sourceData = new[] {new Dictionary<string, object> (){{"Name" , "ITWeiHan" },{"Age",25},{"Gender","M"}}};
var tablehtml = sourceData.ToHtmlTable();
```

<!--
**แต่** สำหรับประเภท Key/Value อื่น ๆ กรุณาใช้ `ToHtmlTableByDictionary`
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**ปรับแต่ง Table/TR/TD/TH Attributes (Dynamic Type)**

```C#
var data = /*List/Array/Set/Enumrable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //นี่คือ dynamic type, รองรับทุก attribute 
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
ผลลัพธ์:
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

##### Attribute Annotation

###### 1. Display : 

```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "Column1")] //Property MyProperty1 จะแสดง thead-td's innertext : "Column1"
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "Column2")] //Property MyProperty2 จะแสดง thead-td's innertext : "Column2"
    public string MyProperty2 { get; set; }
}
```

###### 2. Skip : 
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //MyProperty1 จะไม่ถูก render เป็น html
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
//ผลลัพธ์ : <table><caption id=\"CaptionId\" >This is Caption</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

กำหนดค่า InnerHtml Encoding ได้ (แนะนำไม่ควรปิดการ encode หากไม่มีเหตุผลเฉพาะ เนื่องจากเสี่ยง XSS Attack)
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//การ encode ค่าเริ่มต้น
var encodinghtml = sourceData.ToHtmlTable();
//ผลลัพธ์: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//ผลลัพธ์: <table>..<b>ITWeiHan</b>..</table>
```

### ส่วนขยาย
**ASP.NET Core MVC:**  
สร้างไฟล์ IHtmlHelperExtension.cs
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
ผลลัพธ์:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
สร้างไฟล์ HtmlHelperExtension.cs
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

### สาธิตการใช้งาน
**ASP.NET MVC 5 JQuery DataTable Demo:**  
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

**ASP.NET Core Demo:**
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
#### TODO:
- [ ] รองรับ .NET 4.0
- [ ] รองรับ EF Model
- [ ] รองรับ property ใช้ custom html attribute

ระบุคอลัมน์
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
ผลลัพธ์:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->

<!--
อ่านหน้านี้
[security - Will HTML Encoding prevent all kinds of XSS attacks? - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
editable + ajax ตารางที่แก้ไขได้
    - ปัญหา Route
    - ฟังก์ชันเพิ่มลบแก้ไขค้นหา
    - ต้องการ SID
- [ ] รองรับการแบ่งหน้า (Paging)
    ใช้ linq skip และ take
    แต่จะมีปัญหาใน datatable
    ดูเหมือนว่าต้องแปลง datatable เป็น enumerable
--->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---