<div align="center">
<p><a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/v/MiniWord.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/dt/MiniWord.svg" alt=""></a>
<a href="https://github.com/mini-software/MiniWord" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniWord?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniWord"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=MiniWord&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

---

<div align="center">
 نجمك على <a href="https://github.com/mini-software/MiniWord">GitHub</a> و<a href="https://miniexcel.github.io">تبرعك</a> يمكن أن يجعل MiniWord أفضل
</div>

---

## المقدمة

MiniWord هو مكتبة قوالب Word لـ .NET سهلة وفعالة.

![image](https://user-images.githubusercontent.com/12729184/190835307-6cd87982-b5f3-4a79-9682-bdd1cc02a4ea.png)



## البدء السريع

### التثبيت

- رابط nuget: https://www.nuget.org/packages/MiniWord

### البدء السريع

يعتمد القالب على تصميم "ما تراه هو ما تحصل عليه"، ويتم الاحتفاظ بأنماط علامات القالب بشكل كامل.

```csharp
var value = new Dictionary<string, object>(){["title"] = "Hello MiniWord"};
MiniSoftware.MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

![image](https://user-images.githubusercontent.com/12729184/190875707-6c5639ab-9518-4dc1-85d8-81e20af465e8.png)

### المدخلات والمخرجات

- المدخلات تدعم مسار الملف، byte[]
- المخرجات تدعم مسار الملف، byte[]، stream

```csharp
SaveAsByTemplate(string path, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(string path, byte[] templateBytes, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, byte[] templateBytes, Dictionary<string, object> value)
```



## العلامات

تنسيق سلسلة قوالب MiniWord مشابه لـ Vue, React باستخدام `{{tag}}`، ويكفي أن يتطابق اسم العلامة مع اسم المفتاح في قيمة المعامل ليتم استبدالها تلقائيًا.

### النص

```csharp
{{tag}}
```

##### مثال

```csharp
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["Department"] = "قسم تقنية المعلومات",
    ["Purpose"] = "فرع شنغهاي بحاجة إلى نظام جديد للتحكم في نظام الموارد البشرية.",
    ["StartDate"] = DateTime.Parse("2022-09-07 08:30:00"),
    ["EndDate"] = DateTime.Parse("2022-09-15 15:30:00"),
    ["Approved"] = true,
    ["Total_Amount"] = 123456,
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### القالب

![image](https://user-images.githubusercontent.com/12729184/190834360-39b4b799-d523-4b7e-9331-047a61fd5eb9.png)

##### النتيجة

![image](https://user-images.githubusercontent.com/12729184/190834455-ba065211-0f9d-41d1-9b7a-5d9e96ac2eff.png)

### الصورة

نوع القيمة هو `MiniWordPicture`

##### مثال

```csharp
```csharp
var value = new Dictionary<string, object>()
{
    ["Logo"] = new MiniWordPicture() { Path= PathHelper.GetFile("DemoLogo.png"), Width= 180, Height= 180 }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### القالب

![image](https://user-images.githubusercontent.com/12729184/190647953-6f9da393-e666-4658-a56d-b3a7f13c0ea1.png)

##### النتيجة

![image](https://user-images.githubusercontent.com/12729184/190648179-30258d82-723d-4266-b711-43f132d1842d.png)

### القائمة

قيمة الوسم هي من نوع `string[]` أو `IList<string>`

##### مثال

```csharp
var value = new Dictionary<string, object>()
{
    ["managers"] = new[] { "Jack" ,"Alan"},
    ["employees"] = new[] { "Mike" ,"Henry"},
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

القالب

![image](https://user-images.githubusercontent.com/12729184/190645513-230c54f3-d38f-47af-b844-0c8c1eff2f52.png)

##### النتيجة

![image](https://user-images.githubusercontent.com/12729184/190645704-1f6405e9-71e3-45b9-aa99-2ba52e5e1519.png)

### الجدول

قيمة الوسم هي من نوع `IEmerable<Dictionary<string,object>>`

##### مثال

```csharp
var value = new Dictionary<string, object>()
{
    ["TripHs"] = new List<Dictionary<string, object>>
    {
        new Dictionary<string, object>
        {
            { "sDate",DateTime.Parse("2022-09-08 08:30:00")},
            { "eDate",DateTime.Parse("2022-09-08 15:00:00")},
            { "How","Discussion requirement part1"},
            { "Photo",new MiniWordPicture() { Path = PathHelper.GetFile("DemoExpenseMeeting02.png"), Width = 160, Height = 90 }},
        },
        new Dictionary<string, object>
        {
            { "sDate",DateTime.Parse("2022-09-09 08:30:00")},
            { "eDate",DateTime.Parse("2022-09-09 17:00:00")},
            { "How","Discussion requirement part2 and development"},
            { "Photo",new MiniWordPicture() { Path = PathHelper.GetFile("DemoExpenseMeeting01.png"), Width = 160, Height = 90 }},
        },
    }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### القالب

![image](https://user-images.githubusercontent.com/12729184/190843632-05bb6459-f1c1-4bdc-a79b-54889afdfeea.png)


##### النتيجة

![image](https://user-images.githubusercontent.com/12729184/190843663-c00baf16-21f2-4579-9d08-996a2c8c549b.png)

### قائمة داخل قائمة

قيمة الوسم هي من نوع `IEnumerable<MiniWordForeach>`. من الضروري إضافة وسمي `{{foreach` و `endforeach}}` إلى القالب.

##### مثال

```csharp
var value = new Dictionary<string, object>()
{
    ["TripHs"] = new List<Dictionary<string, object>>
    {
        new Dictionary<string, object>
        {
            { "sDate", DateTime.Parse("2022-09-08 08:30:00") },
            { "eDate", DateTime.Parse("2022-09-08 15:00:00") },
            { "How", "Discussion requirement part1" },
            {
                "Details", new List<MiniWordForeach>()
                {
                    new MiniWordForeach()
                    {
```csharp
                        Value = new Dictionary<string, object>()
                        {
                            {"Text", "هواء"},
                            {"Value", "طائرة"}
                        },
                        Separator = " | "
                    },
                    new MiniWordForeach()
                    {
                        Value = new Dictionary<string, object>()
                        {
                            {"Text", "موقف سيارات"},
                            {"Value", "سيارة"}
                        },
                        Separator = " / "
                    }
                }
            }
        }
    }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### القالب

![before_foreach](https://user-images.githubusercontent.com/38832863/220123955-063c9345-3998-4fd7-982c-8d1e3b48bbf8.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 17 59 37" src="https://github.com/mini-software/MiniWord/assets/38832863/7811bf53-48cf-4fa4-85d7-d98663feb119">

##### النتيجة

![after_foreach](https://user-images.githubusercontent.com/38832863/220123960-913a7140-2fa2-415e-bb3e-456e04167382.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 18 00 15" src="https://github.com/mini-software/MiniWord/assets/38832863/9e1afcf7-64b1-441c-8488-9ea2bd3114a1">

### عبارة if داخل القالب

للفقرات المتعددة، استخدم العلامتين @if و @endif.
لفقرة واحدة وداخل foreach، استخدم العلامتين `{{if` و `endif}}` إذا كان القالب يتطلب ذلك.

##### مثال

```csharp
var value = new Dictionary<string, object>()
{
    ["Name"] = new List<MiniWordHyperLink>(){
        new MiniWordHyperLink(){
            Url = "https://google.com",
            Text = "اختبار رابط 22!!"
        },
        new MiniWordHyperLink(){
            Url = "https://google1.com",
            Text = "اختبار رابط 11!!"
        }
    },
    ["Company_Name"] = "MiniSofteware",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123,
    ["APP"] = "تطبيق تجريبي",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### قالب لفقرات متعددة

![before_if](https://user-images.githubusercontent.com/38832863/220125429-7dd6ce94-35c6-478e-8903-064f9cf9361a.PNG)

##### نتيجة الفقرات المتعددة

![after_if](https://user-images.githubusercontent.com/38832863/220125435-72ea24b4-2412-45de-961a-ad4b2134417b.PNG)

##### قالب لفقرة واحدة

<img width="931" alt="Screenshot 2023-08-08 at 17 55 46" src="https://github.com/mini-software/MiniWord/assets/38832863/2adea468-a9c1-422f-a270-167086bc4ba3">

##### نتيجة الفقرة الواحدة

<img width="536" alt="Screenshot 2023-08-08 at 17 56 47" src="https://github.com/mini-software/MiniWord/assets/38832863/01f71c0f-eee0-4189-8510-abe063126514">

### ColorText

##### مثال

```csharp
var value = new
{
    Company_Name = new MiniWordColorText { Text = "MiniSofteware", FontColor = "#eb70AB", },
    Name = new[] {
        new MiniWordColorText { Text = "Ja", HighlightColor = "#eb70AB" },
        new MiniWordColorText { Text = "ck", HighlightColor = "#a56abe" }
    },
    CreateDate = new MiniWordColorText
    {
        Text = new DateTime(2021, 01, 01).ToString(),
        HighlightColor = "#eb70AB",
        FontColor = "#ffffff",
    },
    VIP = true,
```
```csharp
    Points = 123,
    APP = "Demo APP",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

## أخرى

### معلمة POCO أو dynamic

الإصدار v0.5.0 يدعم معلمة POCO أو dynamic

```csharp
var value = new { title = "Hello MiniWord" };
MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

### لون الخط ولون التظليل
```csharp
var value = new
{
    Company_Name = new MiniWordColorText { Text = "MiniSofteware", FontColor = "#eb70AB" },
    Name = new MiniWordColorText { Text = "Jack", HighlightColor = "#eb70AB" },
    CreateDate = new MiniWordColorText { Text = new DateTime(2021, 01, 01).ToString(), HighlightColor = "#eb70AB", FontColor = "#ffffff" },
    VIP = true,
    Points = 123,
    APP = "Demo APP",
};
```

### الارتباط التشعبي (HyperLink)

إذا كان نوع القيمة هو `MiniWordHyperLink` سيقوم النظام باستبدال سلسلة القالب برابط تشعبي.

* Url: مسار وجهة الرابط التشعبي URI
* Text: الوصف

```csharp
var value = new
{
    ["Name"] = new MiniWordHyperLink(){
        Url = "https://google.com",
        Text = "Test Link!!"
    },
    ["Company_Name"] = "MiniSofteware",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123,
    ["APP"] = "Demo APP",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

## أمثلة

#### تصدير واجهة برمجة تطبيقات ASP.NET Core 3.1

```cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using MiniSoftware;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services) => services.AddMvc();
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=api}/{action=Index}/{id?}");
        });
    }
}

public class ApiController : Controller
{
    public IActionResult Index()
```
```csharp
{
    return new ContentResult
    {
        ContentType = "text/html",
        StatusCode = (int)HttpStatusCode.OK,
        Content = @"<html><body>
<a href='api/DownloadWordFromTemplatePath'>DownloadWordFromTemplatePath</a><br>
<a href='api/DownloadWordFromTemplateBytes'>DownloadWordFromTemplateBytes</a><br>
</body></html>"
    };
}

static Dictionary<string, object> defaultValue = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = new List<Dictionary<string, object>> {
        new Dictionary<string, object>{{"name","Jack"},{ "department", "HR" } },
        new Dictionary<string, object> {{ "name", "Loan"},{ "department", "IT" } }
    },
    ["employees"] = new List<Dictionary<string, object>> {
        new Dictionary<string, object>{{ "name", "Wade" },{ "department", "HR" } },
        new Dictionary<string, object> {{ "name", "Felix" },{ "department", "HR" } },
        new Dictionary<string, object>{{ "name", "Eric" },{ "department", "IT" } },
        new Dictionary<string, object> {{ "name", "Keaton" },{ "department", "IT" } }
    }
};

public IActionResult DownloadWordFromTemplatePath()
{
    string templatePath = "TestTemplateComplex.docx";

    Dictionary<string, object> value = defaultValue;

    MemoryStream memoryStream = new MemoryStream();
    MiniWord.SaveAsByTemplate(memoryStream, templatePath, value);
    memoryStream.Seek(0, SeekOrigin.Begin);
    return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
    {
        FileDownloadName = "demo.docx"
    };
}

private static Dictionary<string, Byte[]> TemplateBytesCache = new Dictionary<string, byte[]>();

static ApiController()
{
    string templatePath = "TestTemplateComplex.docx";
    byte[] bytes = System.IO.File.ReadAllBytes(templatePath);
    TemplateBytesCache.Add(templatePath, bytes);
}

public IActionResult DownloadWordFromTemplateBytes()
{
    byte[] bytes = TemplateBytesCache["TestTemplateComplex.docx"];

    Dictionary<string, object> value = defaultValue;

    MemoryStream memoryStream = new MemoryStream();
    MiniWord.SaveAsByTemplate(memoryStream, bytes, value);
    memoryStream.Seek(0, SeekOrigin.Begin);
    return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
    {
        FileDownloadName = "demo.docx"
    };
}
```

## الدعم : [رابط التبرع](https://miniexcel.github.io/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---