[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

### Funktionen
- Mini (DLL-Größe nur 20KB) und einfach zu verwenden.
- Unterstützt .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- Ohne externe Bibliotheken
- Unterstützt anonyme Typen, Dapper Dynamic Query, List/Array/Set/Enumerable, DataTable, Dictionary

### Installation

Sie können das Paket [von NuGet](https://www.nuget.org/packages/HtmlTableHelper) über den Visual Studio Paket-Manager oder die NuGet-Benutzeroberfläche installieren:

```cmd
PM> install-package HtmlTableHelper
```

oder mit dem `dotnet`-Kommandozeilenbefehl:

```cmd
dotnet add package HtmlTableHelper
```

### Fiddle Demo:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### Erste Schritte

##### List/Array/Set/Enumerable Beispiel für Nicht-Key/Value-Typen
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
Ergebnis:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

##### Dapper Beispiel
```C#
using (var cn = "Your Connection")
{
	var sourceData = cn.Query(@"select 'ITWeiHan' Name,25 Age,'M' Gender");
	var tablehtml = sourceData.ToHtmlTable();
}
```

##### Dictionary Beispiel 
```C#
var sourceData = new[] {new Dictionary<string, object> (){{"Name" , "ITWeiHan" },{"Age",25},{"Gender","M"}}};
var tablehtml = sourceData.ToHtmlTable();
```

<!--
**Aber** für andere Key/Value-Typen bitte `ToHtmlTableByDictionary` verwenden
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**Benutzerdefinierte Table/TR/TD/TH Attribute (Dynamischer Typ)**

```C#
var data = /*List/Array/Set/Enumerable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //dies ist ein dynamischer Typ, unterstützt alle Attribute 
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
Ergebnis:
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

##### Attribut Annotation

###### 1. Display : 

```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "Column1")] //Die Eigenschaft MyProperty1 gibt den thead-td-Inhalt als "Column1" aus
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "Column2")] //Die Eigenschaft MyProperty2 gibt den thead-td-Inhalt als "Column2" aus
    public string MyProperty2 { get; set; }
}
```

###### 2. Skip : 
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //MyProperty1 wird nicht im HTML ausgegeben
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
//Ergebnis : <table><caption id=\"CaptionId\" >This is Caption</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

Konfigurierbares InnerHtml-Encoding (empfohlen dies nicht ohne speziellen Grund zu deaktivieren, da XSS-Angriffe möglich sind)
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//Standard-Encoding
var encodinghtml = sourceData.ToHtmlTable();
//Ergebnis: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//Ergebnis: <table>..<b>ITWeiHan</b>..</table>
```

### Erweiterung
**ASP.NET Core MVC:**  
Erstellen Sie eine Datei IHtmlHelperExtension.cs
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
Ergebnis:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
Erstellen Sie eine Datei HtmlHelperExtension.cs
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

### Demo
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
- [ ] Unterstützung für .NET 4.0
- [ ] Unterstützung für EF Model
- [ ] Unterstützung für benutzerdefinierte HTML-Attribute für Properties 

Bestimmte Spalten angeben
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
Ergebnis:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->


<!--
Lies diese Seite
[security - Wird HTML-Encoding alle Arten von XSS-Angriffen verhindern? - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
editable + ajax Editierbare Tabelle
    - Routing-Problem
    - Funktionen für Hinzufügen/Löschen/Ändern/Abfragen
    - Benötigt SID
- [ ] Unterstützung für Paging
    Verwendung von linq skip und take
    aber es gibt Probleme mit DataTable
    anscheinend muss ich DataTable in Enumerable konvertieren
--->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---