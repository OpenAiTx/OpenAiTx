[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

### 功能特色
- 精巧（DLL 僅 20KB）且易於使用。
- 支援 .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- 無需任何第三方函式庫
- 支援匿名型別、Dapper 動態查詢、List/Array/Set/Enumrable、DataTable、Dictionary

### 安裝方式

你可以透過 [NuGet 下載套件](https://www.nuget.org/packages/HtmlTableHelper)，使用 Visual Studio 套件管理器或 NuGet UI 安裝：

```cmd
PM> install-package HtmlTableHelper
```

或使用 `dotnet` 命令列：

```cmd
dotnet add package HtmlTableHelper
```

### 線上範例:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### 快速開始

##### List/Array/Set/Enumrable 非 Key/Value 型別範例
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
結果:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

##### Dapper 範例
```C#
using (var cn = "Your Connection")
{
	var sourceData = cn.Query(@"select 'ITWeiHan' Name,25 Age,'M' Gender");
	var tablehtml = sourceData.ToHtmlTable();
}
```

##### Dictionary 範例 
```C#
var sourceData = new[] {new Dictionary<string, object> (){{"Name" , "ITWeiHan" },{"Age",25},{"Gender","M"}}};
var tablehtml = sourceData.ToHtmlTable();
```

<!--
**但** 其他 Key/Value 型別請使用 `ToHtmlTableByDictionary`
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**自訂 Table/TR/TD/TH 屬性（動態型別）**

```C#
var data = /*List/Array/Set/Enumrable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //這是動態型別，支援所有屬性
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
結果:
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

##### 屬性註解

###### 1. Display : 

```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "Column1")] //MyProperty1 屬性會渲染 thead-td 的 innertext 為 "Column1"
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "Column2")] //MyProperty2 屬性會渲染 thead-td 的 innertext 為 "Column2"
    public string MyProperty2 { get; set; }
}
```

###### 2. Skip : 
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //MyProperty1 不會渲染到 HTML
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
//結果 : <table><caption id=\"CaptionId\" >This is Caption</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

可設定內部 Html 編碼（不建議無特殊需求時關閉，避免 XSS 攻擊）
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//預設啟用編碼
var encodinghtml = sourceData.ToHtmlTable();
//結果: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//結果: <table>..<b>ITWeiHan</b>..</table>
```

### 擴充功能
**ASP.NET Core MVC:**  
建立 IHtmlHelperExtension.cs
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
結果:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
建立 HtmlHelperExtension.cs
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

### 範例
**ASP.NET MVC 5 JQuery DataTable 範例:**  
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

**ASP.NET Core 範例:**
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
- [ ] 支援 .NET 4.0
- [ ] 支援 EF Model
- [ ] 支援屬性自訂 html 屬性

指定欄位
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
結果:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->

<!--
閱讀本頁
[security - Will HTML Encoding prevent all kinds of XSS attacks? - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
editable + ajax 可編輯的表格
    - Route問題
    - 增刪改查功能
    - 需要SID
- [ ] 支援分頁
    使用 linq skip 和 take
    但這在 datatable 會有問題
    看來我必須將 datatable 轉為 enumrable
--->
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---