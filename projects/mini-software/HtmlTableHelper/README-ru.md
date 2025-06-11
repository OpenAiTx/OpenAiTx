[![NuGet](https://img.shields.io/nuget/v/HtmlTableHelper.svg)](https://www.nuget.org/packages/HtmlTableHelper)
![](https://img.shields.io/nuget/dt/HtmlTableHelper.svg)

### Возможности
- Миниатюрная (размер DLL всего 20KB) и простая в использовании.
- Поддержка .NET Standard 2.0/.NET 4.6/.NET 4.5/.NET 4.0
- Без сторонних библиотек
- Поддержка анонимных типов, динамических запросов Dapper, List/Array/Set/Enumerable, DataTable, Dictionary

### Установка

Вы можете установить пакет [с NuGet](https://www.nuget.org/packages/HtmlTableHelper) с помощью диспетчера пакетов Visual Studio или интерфейса NuGet:

```cmd
PM> install-package HtmlTableHelper
```

или с помощью командной строки `dotnet`:

```cmd
dotnet add package HtmlTableHelper
```

### Fiddle Demo:
- [HtmlTableHelper ConsoleDemo](https://dotnetfiddle.net/DzddCl)
- [HtmlTableHelper ASP.NET MVC Demo (JQuery DataTable)](https://dotnetfiddle.net/u9Ia6M)

### Начало работы

##### Пример для List/Array/Set/Enumerable не Key/Value типа
```C#
using HtmlTableHelper;
..
var sourceData = new[] { new { Name = "ITWeiHan", Age = "25",Gender = "M" } };
var tablehtml = sourceData.ToHtmlTable();
/*
Результат:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

##### Пример Dapper
```C#
using (var cn = "Your Connection")
{
	var sourceData = cn.Query(@"select 'ITWeiHan' Name,25 Age,'M' Gender");
	var tablehtml = sourceData.ToHtmlTable();
}
```

##### Пример Dictionary
```C#
var sourceData = new[] {new Dictionary<string, object> (){{"Name" , "ITWeiHan" },{"Age",25},{"Gender","M"}}};
var tablehtml = sourceData.ToHtmlTable();
```

<!--
**Но** для другого Key/Value типа используйте `ToHtmlTableByDictionary`
```C#
var sourceData = new[] {
    new Dictionary<SomeKeyType, SomeValueType> (){...}
};
var tablehtml = sourceData.ToHtmlTableByDictionary();
```
--->

**Пользовательские атрибуты Table/TR/TD/TH (Dynamic Type)**

```C#
var data = /*List/Array/Set/Enumrable..*/;
var html = data.ToHtmlTable( tableAttributes: new { @class = "SomeClass"} //это dynamic type, поддерживает все атрибуты 
    ,trAttributes: new { ID = "SomeID" },tdAttributes: new { width = "120 px" },thAttributes: new { @class = "dark-theme" }
);
/*
Результат:
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

##### Аннотация атрибутов

###### 1. Display : 

```C#
public class ModelClassWithDisplayAttr
{
    [TableColumn(DisplayName = "Column1")] //Свойство MyProperty1 отобразится в thead-td с текстом: "Column1"
    public string MyProperty1 { get; set; }
    [TableColumn(DisplayName = "Column2")] //Свойство MyProperty2 отобразится в thead-td с текстом: "Column2"
    public string MyProperty2 { get; set; }
}
```

###### 2. Skip : 
```C#
public class ModelClassWithSkipAttr
{
    [TableColumn( Skip = true)]
    public string MyProperty1 { get; set; } //MyProperty1 не будет отображаться в html
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
//Результат : <table><caption id=\"CaptionId\" >This is Caption</caption><thead><tr><th>MyProperty1</th><th>MyProperty2</th></tr></thead><tbody><tr><td>test</td><td>123</td></tr></tbody></table>
```

##### HTMLTableSetting

Настраиваемое кодирование InnerHtml (Не рекомендуется отключать без особой необходимости, из-за угрозы XSS)
```C#
var sourceData = new[] { new { Name = "<b>ITWeiHan</b>" } };

//Кодирование по умолчанию
var encodinghtml = sourceData.ToHtmlTable();
//Результат: <table>..&lt;b&gt;ITWeiHan&lt;/b&gt;..</table>

var htmltablesetting = new HTMLTableSetting()
{
    IsHtmlEncodeMode = false
};
var notEncodinghtml = sourceData.ToHtmlTable(HTMLTableSetting: htmltablesetting);
//Результат: <table>..<b>ITWeiHan</b>..</table>
```

### Расширение
**ASP.NET Core MVC:**  
Создайте файл IHtmlHelperExtension.cs
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
Результат:<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```

**ASP.NET MVC 5:**   
Создайте файл HtmlHelperExtension.cs
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

### Демонстрация
**Демонстрация ASP.NET MVC 5 JQuery DataTable:**  
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

**Демонстрация ASP.NET Core:**
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
- [ ] Поддержка .NET 4.0
- [ ] Поддержка EF Model
- [ ] Поддержка пользовательских html-атрибутов для свойств

Указание столбцов
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
Результат:
<table><thead><tr><th>Name</th><th>Age</th><th>Gender</th></tr></thead><tbody><tr><td>ITWeiHan</td><td>25</td><td>M</td></tr></tbody></table>
*/
```
-->

<!--
Прочитайте эту страницу
[security - Will HTML Encoding prevent all kinds of XSS attacks? - Stack Overflow]
(https://stackoverflow.com/questions/53728/will-html-encoding-prevent-all-kinds-of-xss-attacks)
-->

<!---
editable + ajax Редактируемая таблица
    - Проблема маршрутизации
    - Функционал добавления, удаления, изменения, просмотра
    - Необходим SID
- [ ] Поддержка пагинации
    используя linq skip и take
    но могут возникнуть проблемы с datatable
    похоже, нужно конвертировать datatable в enumrable
--->
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---